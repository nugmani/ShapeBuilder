using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShapeBuilderClasses;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ShapeBuilder
{
    public partial class MainForm : Form
    {
        //============================Свойства=============================//
        Bitmap bmp;
        double[,] zbuff;
        TMVertex camera = new TMVertex(0, 0, 1, 1); // Расположение камеры (наблюдателя)
        TMVertex lightSource = new TMVertex(0, 0, 1, 1); // Расположение источника света
        TMVertex[,] vertices; // Массив всех вершин 
        List<TMPolygon> polygons; // Список всех полигонов
        //List<TMPixel> pixels; // Список всех пикселей        
        //List<TMPixel> zbuff; // Список тех пикселей, которые будут выведены на экран
        int old_x, old_y, old_z; // Углы поворота в градусах на последнем шаге
        TMMatrix result = TMMatrix.E(); // Матрица всех поворотов
        TMMatrix old_result = TMMatrix.E(); // Матрица поворотов на последнем шаге
        Color internalColor, externalColor; // Внутренний и внешний цвет поверхности
        Color directColor, ambientColor; // Цвет точечного и рассеянного источника света
        bool clicked; // Флаг нажатия на кнопку мыши (нажата = true, иначе false)
        int lastX, lastY; // Углы поворота в градусах на последнем шаге для обработки событий мыши
        double ka, kd, ks; // коэффициенты фонового, диффузного и отраженного освещеий
        int n; // степень сфокусированности бликов
        //=================================================================//

      
        /* Конструктор главной формы:
         * cтроим поверхность фигуры;
         * сохраняем начальные значения поворотов как старые значения;
         * назначаем цвета внешней и внутренней сторон;
         * связываем контролы между собой.
         * */
        public MainForm()
        {
            InitializeComponent();
            buildShape();
            SetOldValues();
            SetColors();
            SetLightSource();
            BindControls();
        }


        //================Методы построения поверхности====================//
        /* Строит Поверхность фигуры.
         * Вычисляет координаты всех вершин поверхности,
         * а затем группирует их в полигоны.
         * */
        private void buildShape()
        {
            int cout_U = Convert.ToInt32(trackBarDU.Value);
            int cout_V = Convert.ToInt32(trackBarDV.Value);
            double max_U = Convert.ToInt32(trackBarU.Value);
            double max_V = Convert.ToInt32(trackBarV.Value);
            double a = Convert.ToInt32(trackBarA.Value);

            TMShapeGenerator.generateShape(out vertices, cout_U, cout_V, 0, 0, (max_U / 180) * Math.PI, (max_V / 180) * Math.PI, a);
            TMShapeGenerator.generatePolygons(out polygons, ref vertices);
            Parallel.ForEach(polygons, p => p.сalculateNormale());
            //Parallel.For(0, vertices.GetLength(0), i =>
            //{
            //    for (int j = 0; j < vertices.GetLength(1); j++)
            //    {
            //        vertices[i, j].evaluateNormal();
            //    }
            //});
        }

        /* Вычисляет координаты всех вершин поверхности в соответствии с матрицей поворота.
         * Каждая вершина поверхности умножается на матрицу поворота, затем список
         * полигонов формируется снова в соответствии с новыми координатами вершин.
         * */
        private void calculateShapeRotation(TMMatrix matrix)
        {
            //for (int i = 0; i < vertices.GetLength(0); i++)
            //{
            //    for (int j = 0; j < vertices.GetLength(1); j++)
            //    {
            //        vertices[i, j] = vertices[i, j] * matrix;
            //    }
            //}
            Parallel.For(0, vertices.GetLength(0), i =>
            {
                for (int j = 0; j < vertices.GetLength(1); j++)
                {
                    vertices[i, j].copyParamFrom(vertices[i, j] * matrix);
                    vertices[i, j].Normal = vertices[i, j].Normal * matrix;
                }
            });
            Parallel.ForEach(polygons, p => p.n = p.n * matrix );
            //while (polygons.Count != 0) polygons.RemoveAt(0);
            //TMShapeGenerator.generatePolygons(out polygons, ref vertices);           
            //Parallel.ForEach(polygons, p => p.сalculateNormale());
            //Parallel.For(0, vertices.GetLength(0), i =>
            //{
            //    for (int j = 0; j < vertices.GetLength(1); j++)
            //    {
            //        vertices[i, j].evaluateNormal();
            //    }
            //});
        }

        /* Высчитывает матрицу всех поворотов. 
         * Умножает матрицу предыдущих поворотов на матрицу новых поворотов,
         * а матрицу новых поворотов сохраняет как как матрицу старых поворотов.
         * */
        private void calculateMatrix(double dx, double dy, double dz)
        {
            double radian = Math.PI / 180;
            old_result = TMMatrix.RotateX(dx * radian) * TMMatrix.RotateY(dy * radian) * TMMatrix.RotateZ(dz * radian);
            result *= old_result;
        }



        /* Вычисляет цвет в данном полигоне или в данной точке,
         * взависемоти от метода закраски, с учетом фонового, 
         * рассеиваемого и отражаемого света.
         * */
        private Color CalcColor(TMVertex normal)
        {
            Color color;
            // определяем внешняя или внутренняя сторона
            bool external = (TMVertex.getCos(normal, camera) >= 0);
            // косинус угла м/у источником света и нормалью
            double cosTheta = TMVertex.getCos(normal, lightSource);

            if (external)
                color = externalColor;
            else
                color = internalColor;

            if (((external) && (cosTheta < 0)) || ((!external) && (cosTheta > 0)))
                cosTheta = 0;
            cosTheta = Math.Abs(cosTheta);
            
            // Вычисляем направление отраженного луча для зеркальной состовляющей света
            TMVertex reflectedLight = new TMVertex(0, 0, 0, 1);
            double sqrNormaLength = normal.x * normal.x + normal.y * normal.y + normal.z * normal.z;//normal.getLength() * normal.getLength();
            double vecmul = normal * lightSource;
            reflectedLight.x = 2 * normal.x * (vecmul) / sqrNormaLength - lightSource.x;
            reflectedLight.y = 2 * normal.y * (vecmul) / sqrNormaLength - lightSource.y;
            reflectedLight.z = 2 * normal.z * (vecmul) / sqrNormaLength - lightSource.z;


            double cosAlpha = TMVertex.getCos(camera, reflectedLight);
            if (cosAlpha < 0) cosAlpha = 0;

            // Вычисляем все составляющие света: 
            // фоновый, рассеиваемый, отражаемый свет соответственно            
            TMVertex Ia = new TMVertex(
                            ka * Math.Min(ambientColor.R, color.R),
                            ka * Math.Min(ambientColor.G, color.G),
                            ka * Math.Min(ambientColor.B, color.B), 1);
            TMVertex Id = new TMVertex(
                            kd * cosTheta * Math.Min(directColor.R, color.R),
                            kd * cosTheta * Math.Min(directColor.G, color.G),
                            kd * cosTheta * Math.Min(directColor.B, color.B), 1);
            TMVertex Is = new TMVertex(
                            ks * directColor.R * Math.Pow(cosAlpha, n),
                            ks * directColor.G * Math.Pow(cosAlpha, n),
                            ks * directColor.B * Math.Pow(cosAlpha, n), 1);

            // Результирующий цвет в данном полигоне или точке
            // взависемости от метода закраски
            TMVertex resColor = Ia + Id + Is;
            if (Double.IsNaN(resColor.x)) resColor.x = 0;
            if (Double.IsNaN(resColor.y)) resColor.y = 0;
            if (Double.IsNaN(resColor.z)) resColor.z = 0;
            if (resColor.x > 255) resColor.x = 255;
            else if (resColor.x < 0) resColor.x = 0;
            if (resColor.y > 255) resColor.y = 255;
            else if (resColor.y < 0) resColor.y = 0;
            if (resColor.z > 255) resColor.z = 255;
            else if (resColor.z < 0) resColor.z = 0;
            

            // Формируем цвет по системе RGB
            return Color.FromArgb((int)resColor.x, (int)resColor.y, (int)resColor.z);
        }

        /* Определяет тип цвета (внешний или внутренний)
         * надо использовать для закраски полигона 
         * */
        private bool isExternalColor(TMVertex normal)
        {
            // определяем внешняя или внутренняя сторона
            return TMVertex.getCos(normal, camera) >= 0;
        }
        /* Вычисляет цвет в данной точке полигона,
         * взависемоти от метода закраски, с учетом фонового, 
         * рассеиваемого и отражаемого света. Передаем вектор 
         * оценки нормали вершины и тип цвета (внешний или внутренний)
         * */
        private Color CalcColorForVertex(TMVertex normal, bool isExtColor)
        {
            Color color;
            // косинус угла м/у источником света и нормалью
            double cosTheta = TMVertex.getCos(normal, lightSource);

            if (isExtColor)
                color = externalColor;
            else
                color = internalColor;

            if (((isExtColor) && (cosTheta < 0)) || ((!isExtColor) && (cosTheta > 0)))
                cosTheta = 0;
            cosTheta = Math.Abs(cosTheta);

            // Вычисляем направление отраженного луча для зеркальной состовляющей света
            TMVertex reflectedLight = new TMVertex(0, 0, 0, 1);
            double sqrNormaLength = normal.x * normal.x + normal.y * normal.y + normal.z * normal.z;//normal.getLength() * normal.getLength();
            double vecmul = normal * lightSource;
            reflectedLight.x = 2 * normal.x * (vecmul) / sqrNormaLength - lightSource.x;
            reflectedLight.y = 2 * normal.y * (vecmul) / sqrNormaLength - lightSource.y;
            reflectedLight.z = 2 * normal.z * (vecmul) / sqrNormaLength - lightSource.z;

            double cosAlpha = TMVertex.getCos(camera, reflectedLight);
            if (cosAlpha < 0) cosAlpha = 0;

            // Вычисляем все составляющие света: 
            // фоновый, рассеиваемый, отражаемый свет соответственно
            TMVertex Ia = new TMVertex(
                            ka * Math.Min(ambientColor.R, color.R),
                            ka * Math.Min(ambientColor.G, color.G),
                            ka * Math.Min(ambientColor.B, color.B), 1);
            TMVertex Id = new TMVertex(
                            kd * cosTheta * Math.Min(directColor.R, color.R),
                            kd * cosTheta * Math.Min(directColor.G, color.G),
                            kd * cosTheta * Math.Min(directColor.B, color.B), 1);
            TMVertex Is = new TMVertex(
                            ks * directColor.R * Math.Pow(cosAlpha, n),
                            ks * directColor.G * Math.Pow(cosAlpha, n),
                            ks * directColor.B * Math.Pow(cosAlpha, n), 1);

            // Результирующий цвет в данном полигоне или точке
            // взависемости от метода закраски
            TMVertex resColor = Ia + Id + Is;
            if (Double.IsNaN(resColor.x)) resColor.x = 0;
            if (Double.IsNaN(resColor.y)) resColor.y = 0;
            if (Double.IsNaN(resColor.z)) resColor.z = 0;
            if (resColor.x > 255) resColor.x = 255;
            else if (resColor.x < 0) resColor.x = 0;
            if (resColor.y > 255) resColor.y = 255;
            else if (resColor.y < 0) resColor.y = 0;
            if (resColor.z > 255) resColor.z = 255;
            else if (resColor.z < 0) resColor.z = 0;


            // Формируем цвет по системе RGB
            return Color.FromArgb((int)resColor.x, (int)resColor.y, (int)resColor.z);
        }
        //=================================================================//


        //=================Управление контролами формы=====================//
        /* Связываем контролы между собой.
         * Привязывает значение всех лейблов с текущими, минимальными, 
         * максимальными значениями трэкбаров.
         * */
        private void BindControls()
        {
            checkBoxPolyZSort.DataBindings.Add("Enabled", radioButtonFlatFrame, "Checked");

            labelValX.DataBindings.Add("Text", trackBarX, "Value");
            labelValY.DataBindings.Add("Text", trackBarY, "Value");
            labelValZ.DataBindings.Add("Text", trackBarZ, "Value");

            labelMinX.DataBindings.Add("Text", trackBarX, "Minimum");
            labelMinY.DataBindings.Add("Text", trackBarY, "Minimum");
            labelMinZ.DataBindings.Add("Text", trackBarZ, "Minimum");
            labelMaxX.DataBindings.Add("Text", trackBarX, "Maximum");
            labelMaxY.DataBindings.Add("Text", trackBarY, "Maximum");
            labelMaxZ.DataBindings.Add("Text", trackBarZ, "Maximum");

            labelValXLight.DataBindings.Add("Text", trackBarXLight, "Value");
            labelValYLight.DataBindings.Add("Text", trackBarYLight, "Value");
            labelValZLight.DataBindings.Add("Text", trackBarZLight, "Value");

            labelMinXLight.DataBindings.Add("Text", trackBarXLight, "Minimum");
            labelMinYLight.DataBindings.Add("Text", trackBarYLight, "Minimum");
            labelMinZLight.DataBindings.Add("Text", trackBarZLight, "Minimum");
            labelMaxXLight.DataBindings.Add("Text", trackBarXLight, "Maximum");
            labelMaxYLight.DataBindings.Add("Text", trackBarYLight, "Maximum");
            labelMaxZLight.DataBindings.Add("Text", trackBarZLight, "Maximum");

            labelValU.DataBindings.Add("Text", trackBarU, "Value");
            labelValV.DataBindings.Add("Text", trackBarV, "Value");
            labelValA.DataBindings.Add("Text", trackBarA, "Value");
            labelValDU.DataBindings.Add("Text", trackBarDU, "Value");
            labelValDV.DataBindings.Add("Text", trackBarDV, "Value");

            labelMinU.DataBindings.Add("Text", trackBarU, "Minimum");
            labelMinV.DataBindings.Add("Text", trackBarV, "Minimum");
            labelMinA.DataBindings.Add("Text", trackBarA, "Minimum");
            labelMaxU.DataBindings.Add("Text", trackBarU, "Maximum");
            labelMaxV.DataBindings.Add("Text", trackBarV, "Maximum");
            labelMaxA.DataBindings.Add("Text", trackBarA, "Maximum");
            labelMinDU.DataBindings.Add("Text", trackBarDU, "Minimum");
            labelMinDV.DataBindings.Add("Text", trackBarDV, "Minimum");
            labelMaxDU.DataBindings.Add("Text", trackBarDU, "Maximum");
            labelMaxDV.DataBindings.Add("Text", trackBarDV, "Maximum");

            labelMaxR1.DataBindings.Add("Text", trackBarR1, "Maximum");
            labelMaxG1.DataBindings.Add("Text", trackBarG1, "Maximum");
            labelMaxB1.DataBindings.Add("Text", trackBarB1, "Maximum");
            labelMaxR2.DataBindings.Add("Text", trackBarR2, "Maximum");
            labelMaxG2.DataBindings.Add("Text", trackBarG2, "Maximum");
            labelMaxB2.DataBindings.Add("Text", trackBarB2, "Maximum");
            labelMaxR3.DataBindings.Add("Text", trackBarR3, "Maximum");
            labelMaxG3.DataBindings.Add("Text", trackBarG3, "Maximum");
            labelMaxB3.DataBindings.Add("Text", trackBarB3, "Maximum");
            labelMaxR4.DataBindings.Add("Text", trackBarR4, "Maximum");
            labelMaxG4.DataBindings.Add("Text", trackBarG4, "Maximum");
            labelMaxB4.DataBindings.Add("Text", trackBarB4, "Maximum");            

            labelValR1.DataBindings.Add("Text", trackBarR2, "Value");
            labelValG1.DataBindings.Add("Text", trackBarG2, "Value");
            labelValB1.DataBindings.Add("Text", trackBarB2, "Value");
            labelValR2.DataBindings.Add("Text", trackBarR1, "Value");
            labelValG2.DataBindings.Add("Text", trackBarG1, "Value");
            labelValB2.DataBindings.Add("Text", trackBarB1, "Value");
            labelValR3.DataBindings.Add("Text", trackBarR3, "Value");
            labelValG3.DataBindings.Add("Text", trackBarG3, "Value");
            labelValB3.DataBindings.Add("Text", trackBarB3, "Value");
            labelValR4.DataBindings.Add("Text", trackBarR4, "Value");
            labelValG4.DataBindings.Add("Text", trackBarG4, "Value");
            labelValB4.DataBindings.Add("Text", trackBarB4, "Value");
            
            Binding bind = new Binding("Text", trackBarAmbientLight, "Value");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelValAmbientLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarDiffuseLight, "Value");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelValDiffuseLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarSpecularLight, "Value");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelValSpecularLight.DataBindings.Add(bind);
            labelValPower.DataBindings.Add("Text", trackBarPower, "Value");

            bind = new Binding("Text", trackBarAmbientLight, "Minimum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMinAmbientLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarDiffuseLight, "Minimum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMinDiffuseLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarSpecularLight, "Minimum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMinSpecularLight.DataBindings.Add(bind);
            labelMinPower.DataBindings.Add("Text", trackBarPower, "Minimum");

            bind = new Binding("Text", trackBarAmbientLight, "Maximum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMaxAmbientLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarDiffuseLight, "Maximum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMaxDiffuseLight.DataBindings.Add(bind);
            bind = new Binding("Text", trackBarSpecularLight, "Maximum");
            bind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            labelMaxSpecularLight.DataBindings.Add(bind);
            labelMaxPower.DataBindings.Add("Text", trackBarPower, "Maximum");
        }
        /* Обработчик события Format при осуществлении привязки 
         * Label.Text к TrackBar.Value. значение ползунка приводится
         * к дробному формату и делится на 100 (т.к. значение параметров 
         * изменяется от 0 до 1, а TrackBar допускает только целые числа)
         * */
        private void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            double value = (double)(Int32)cevent.Value;
            cevent.Value = (value / 10).ToString("0.0");
        }        

        /* Задаёт последние значения поворотов в градусах вокрух осей координат.
         * */
        private void SetOldValues()
        {
            old_x = trackBarX.Value;
            old_y = trackBarY.Value;
            old_z = trackBarZ.Value;
        }

        /* Задаёт внеший и внутренний цвета и цвета точечного и рассеянного источника света 
         * в соответствии со значениями трэкбаров, определяющих эти значения в системе RGB
         * */
        private void SetColors()
        {
            externalColor = Color.FromArgb(trackBarR1.Value, trackBarG1.Value, trackBarB1.Value);
            internalColor = Color.FromArgb(trackBarR2.Value, trackBarG2.Value, trackBarB2.Value);
            directColor   = Color.FromArgb(trackBarR3.Value, trackBarG3.Value, trackBarB3.Value);
            ambientColor  = Color.FromArgb(trackBarR4.Value, trackBarG4.Value, trackBarB4.Value);

            pictureBoxExtern.BackColor = internalColor;
            pictureBoxIntern.BackColor  = externalColor;
            pictureBoxDirect.BackColor  = directColor;
            pictureBoxAmbient.BackColor = ambientColor;
        }

        /* Задаёт положение источника света
         * */
        private void SetLightSource()
        {
            lightSource = new TMVertex(trackBarXLight.Value, trackBarYLight.Value, trackBarZLight.Value, 1);
        }

        /* Задаёт последнии значения поворотов в градусах 
         * вокрух осей координат для обработки событий мыши.
         * */
        private void SetLastCoordinates(MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
        }        
        //=================================================================//



        //==================Методы визуализации поверхности================//
        /* Рисует каркас поверхности.
         * При этом осуществляет смещение точек полигонов в центр экрана.
         * */
        private void drawWireFrame(int cx, int cy, Graphics g)
        {
            // Рисуем только каркас
            foreach (TMPolygon t in polygons)
            {
                Point[] points = new Point[3];
                points[0] = new Point(cx + (int)t.v1.x, cy - (int)t.v1.y);
                points[1] = new Point(cx + (int)t.v2.x, cy - (int)t.v2.y);
                points[2] = new Point(cx + (int)t.v3.x, cy - (int)t.v3.y);

                // Задаём перо и рисуем полигон
                Pen pen = new Pen(externalColor);
                g.DrawPolygon(pen, points);
            }
        }

        /* Рисует поверхность, заливая полигоны методом Flat закраски.
         * Цвет, которым заливается полигон зависит от его расположения 
         * относительно расположения источника света.
         * */
        private void drawFlatFrame(int cx, int cy, Graphics g)
        {
            // Залиаем полигон целиком (Flat-закраска)
            foreach (TMPolygon t in polygons)
            {
                Point[] points = new Point[3];
                points[0] = new Point(cx + (int)t.v1.x, cy - (int)t.v1.y);
                points[1] = new Point(cx + (int)t.v2.x, cy - (int)t.v2.y);
                points[2] = new Point(cx + (int)t.v3.x, cy - (int)t.v3.y);

                // Задаём кисть и рисуем полигон
                Color color = CalcColor(t.n); //= Color.FromArgb(red, green, blue);
                
                SolidBrush brush = new SolidBrush(color);
                g.FillPolygon(brush, points);
            }
        }


        private void prepairZBuff()
        {
            for (int i = 0; i < bmp.Size.Width; i++)
            {
                for (int j = 0; j < bmp.Size.Height; j++)
                {
                    zbuff[i, j] = int.MinValue;
                }
            }            
        }

        private static void Swap(ref TMVertex v1, ref TMVertex v2)
        {
            TMVertex tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        private static void Sort_By_Y(ref TMVertex a, ref TMVertex b, ref TMVertex c)
        {
            if (a.y > b.y)
                Swap(ref a, ref b);
            if (a.y > c.y)
                Swap(ref a, ref c);
            if (b.y > c.y)
                Swap(ref b, ref c);
        }

        /* Рисует поверхность, заливая полигоны методом Flat закраски с УНЛП.
         * Цвет, которым заливается полигон зависит от его расположения 
         * относительно расположения источника света. Выполняется растеризация
         * затем Z-буффеизация, затем пиксели выводятся на экран.
         * */
        private void drawFlatFrameWithHSR(int cx, int cy, Graphics g)
        {
            // HSR - hidden-surface removal или
            // УНЛП - удаление невидемых линий поверхности
            // Залиаем полигон целиком (Flat-закраска с УНЛП)
            double eps = 0.000001;
            Parallel.ForEach(polygons, p => 
            {
                try
                {                    
                    TMVertex a, b, c;
                    a = p.v1; b = p.v2; c = p.v3;
                    Sort_By_Y(ref a, ref b, ref c);

                    double tmp;
                    double xa, xb; // левый и правый края растеризуемой линии полигона (треугольника) по x
                    double za, zb; // левый и правый края растеризуемой линии полигона (треугольника) по z
                    // Формируем разтеризуемые линии полигона (треугольника)
                    // и рисуем на битмапе только те точки, значенние z которых
                    // больше чем значение z точек, которая уже нарисована на
                    // битмапе в (sx,sy) - задаём цвет каждого пикселя (sx,sy) на битмапе
                    for (double sy = a.y; sy <= c.y; sy += 0.5f)
                    {
                        if (Math.Abs(c.y - a.y) < eps)
                        {
                            xa = a.x;
                            za = a.z;
                        }
                        else
                        {
                            xa = a.x + (sy - a.y) * (c.x - a.x) / (c.y - a.y);
                            za = a.z + (sy - a.y) * (c.z - a.z) / (c.y - a.y);
                        }

                        if (sy < b.y)
                        {
                            xb = a.x + (sy - a.y) * (b.x - a.x) / (b.y - a.y);
                            zb = a.z + (sy - a.y) * (b.z - a.z) / (b.y - a.y);
                        }
                        else
                        {
                            if (Math.Abs(c.y - b.y) < eps)
                            {
                                xb = b.x;
                                zb = b.z;
                            }
                            else
                            {
                                xb = b.x + (sy - b.y) * (c.x - b.x) / (c.y - b.y);
                                zb = b.z + (sy - b.y) * (c.z - b.z) / (c.y - b.y);
                            }
                        }

                        if (xa > xb)
                        {
                            tmp = xa; xa = xb; xb = tmp;
                            tmp = za; za = zb; zb = tmp;
                        }

                        // z нам нужен для zbufferization
                        double sz;
                        // Добавляем горизонтальную линию(sy, xa, xb) в список пикселей;
                        for (double sx = xa; sx <= xb; sx += 1)
                        {
                            sz = za + (zb - za) * (sx - xa) / (xb - xa);
                            // Проецируем точку на экран - в нашем случае смещаем в центр экрана
                            // т.к. камера у нас находится на оси Oz
                            int indexI = cx + (int)sx;
                            int indexJ = cy - (int)sy;
                            // Проверяем попала ли точка в экран
                            if (indexI >= 0 && indexI < cx * 2 && indexJ >= 0 && indexJ < cy * 2)
                                // Если да, то проверяем ближе ли она находится к камере
                                // по оси Oz чем та точка, которая уже выведена на эеран
                                lock (bmp)
                                {
                                    if (sz > zbuff[indexI, indexJ])
                                    {   // Если да, то заносим zbuff её значение z как
                                        // наиболее близкое к камере
                                        this.zbuff[indexI, indexJ] = sz;
                                        // и рисуем точку на битмапе - задаём цвет пикселя (sx,sy) на битмапе
                                        Color color = CalcColor(p.n);
                                        this.bmp.SetPixel(indexI, indexJ, color);
                                    }
                                }
                        }
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Exception: " + e.Message);
                }
            });

            // Рисуем изображение на битмапе
            g.DrawImage(bmp, 0, 0);
        }


        /* Рисует поверхность, заливая полигоны методом закраски Фонга.
         * Цвет, которым заливается каждая точка каждой грани определяется 
         * относительно расположения источника света. Выполняется растеризация
         * затем Z-буффеизация, затем пиксели выводятся на экран.
         * */        
        private void drawPhongShading(int cx, int cy, Graphics g)
        {
            // Залиаем полигон целиком (метод Фонга)                        
            double eps = 0.000001;
            Parallel.ForEach(polygons, p =>
            {
                try
                {
                    // Na,Nb  - интерпалированные оценки нормалей на концах горизонтального отрезка
                    TMVertex Na, Nb;
                    TMVertex a, b, c;
                    a = p.v1; b = p.v2; c = p.v3;
                    Sort_By_Y(ref a, ref b, ref c);
                    TMVertex NvA = new TMVertex(a.Normal); // Оценка нормали в вершине А
                    TMVertex NvB = new TMVertex(b.Normal); // Оценка нормали в вершине B
                    TMVertex NvC = new TMVertex(c.Normal); // Оценка нормали в вершине C

                    bool isExtColor = isExternalColor(p.n);
                    double tmp;
                    double xa, xb; // левый и правый края растеризуемой линии полигона (треугольника) по x
                    double za, zb; // левый и правый края растеризуемой линии полигона (треугольника) по z
                    // Формируем разтеризуемые линии полигона (треугольника)
                    // и рисуем на битмапе только те точки, значенние z которых
                    // больше чем значение z точек, которая уже нарисована на
                    // битмапе в (sx,sy) - задаём цвет каждого пикселя (sx,sy) на битмапе
                    for (double sy = a.y; sy <= c.y; sy += 0.5f)
                    {
                        if (Math.Abs(c.y - a.y) < eps)
                        {
                            xa = a.x;
                            za = a.z;

                            Na = new TMVertex(NvA);
                        }
                        else
                        {
                            xa = a.x + (sy - a.y) * (c.x - a.x) / (c.y - a.y);
                            za = a.z + (sy - a.y) * (c.z - a.z) / (c.y - a.y);

                            Na = new TMVertex(
                                (NvA.x * (c.y - sy) / (c.y - a.y) + NvC.x * (sy - a.y) / (c.y - a.y)),
                                (NvA.y * (c.y - sy) / (c.y - a.y) + NvC.y * (sy - a.y) / (c.y - a.y)),
                                (NvA.z * (c.y - sy) / (c.y - a.y) + NvC.z * (sy - a.y) / (c.y - a.y)),
                                0);
                        }

                        if (sy < b.y)
                        {
                            xb = a.x + (sy - a.y) * (b.x - a.x) / (b.y - a.y);
                            zb = a.z + (sy - a.y) * (b.z - a.z) / (b.y - a.y);

                            Nb = new TMVertex(
                                 NvA.x * (b.y - sy) / (b.y - a.y) + NvB.x * (sy - a.y) / (b.y - a.y),
                                 NvA.y * (b.y - sy) / (b.y - a.y) + NvB.y * (sy - a.y) / (b.y - a.y),
                                 NvA.z * (b.y - sy) / (b.y - a.y) + NvB.z * (sy - a.y) / (b.y - a.y),
                                 0);
                        }
                        else
                        {
                            if (Math.Abs(c.y - b.y) < eps)
                            {
                                xb = b.x;
                                zb = b.z;

                                Nb = new TMVertex(NvB);
                            }
                            else
                            {
                                xb = b.x + (sy - b.y) * (c.x - b.x) / (c.y - b.y);
                                zb = b.z + (sy - b.y) * (c.z - b.z) / (c.y - b.y);

                                Nb = new TMVertex(
                                    NvB.x * (c.y - sy) / (c.y - b.y) + NvC.x * (sy - b.y) / (c.y - b.y),
                                    NvB.y * (c.y - sy) / (c.y - b.y) + NvC.y * (sy - b.y) / (c.y - b.y),
                                    NvB.z * (c.y - sy) / (c.y - b.y) + NvC.z * (sy - b.y) / (c.y - b.y),
                                    0);
                            }
                        }

                        if (xa > xb)
                        {
                            tmp = xa; xa = xb; xb = tmp;
                            tmp = za; za = zb; zb = tmp;
                            TMVertex tmpV = new TMVertex(Na);
                            Na = new TMVertex(Nb);
                            Nb = new TMVertex(tmpV);
                        }

                        // z нам нужен для zbufferization
                        double sz;
                        // Добавляем горизонтальную линию(sy, xa, xb) в список пикселей;
                        for (double sx = xa; sx <= xb; sx += 1)
                        {
                            sz = za + (zb - za) * (sx - xa) / (xb - xa);
                            // Проецируем точку на экран - в нашем случае смещаем в центр экрана
                            // т.к. камера у нас находится на оси Oz
                            int indexI = cx + (int)sx;
                            int indexJ = cy - (int)sy;
                            // Проверяем попала ли точка в экран
                            if (indexI >= 0 && indexI < cx * 2 && indexJ >= 0 && indexJ < cy * 2)
                                // Если да, то проверяем ближе ли она находится к камере
                                // по оси Oz чем та точка, которая уже выведена на эеран
                                lock (bmp)
                                {
                                    if (sz > zbuff[indexI, indexJ])
                                    {   // Если да, то заносим zbuff её значение z как
                                        // наиболее близкое к камере
                                        this.zbuff[indexI, indexJ] = sz;
                                        // и рисуем точку на битмапе - задаём цвет пикселя (sx,sy) на битмапе
                                        TMVertex normal = new TMVertex(
                                            Na.x + (sx - xa) * (Nb.x - Na.x) / (xb - xa),
                                            Na.y + (sx - xa) * (Nb.y - Na.y) / (xb - xa),
                                            Na.z + (sx - xa) * (Nb.z - Na.z) / (xb - xa),
                                            0);
                                        Color color = CalcColorForVertex(normal, isExtColor);
                                        this.bmp.SetPixel(indexI, indexJ, color);
                                    }
                                }
                        }
                    }
                }
                catch (Exception e) {
                    //MessageBox.Show("Exception: " + e.Message);
                }
            });

            // Рисуем изображение на битмапе
            g.DrawImage(bmp, 0, 0);
        }

        /* Рисует поверхность, заливая полигоны методом закраски Гуро.
         * Цвет, которым заливается каждая точка каждой грани определяется 
         * относительно расположения источника света. Выполняется растеризация
         * затем Z-буффеизация, затем пиксели выводятся на экран.
         * */        
        private void drawGouraudShading(int cx, int cy, Graphics g)
        {
            // Залиаем полигон целиком (метод Гуро)
            double eps = 0.000001;
            Parallel.ForEach(polygons, p =>
            {
                try
                {
                    // color - интерполированная интенсивность в точке (sx,sy)
                    // Ia,Ib  - интерпалированные интенсивности на концах горизонтального отрезка
                    Color color, Ia, Ib;
                    TMVertex a, b, c;
                    a = p.v1; b = p.v2; c = p.v3;
                    Sort_By_Y(ref a, ref b, ref c);

                    bool isExtColor = isExternalColor(p.n);
                    Color IvA = CalcColorForVertex(a.Normal, isExtColor); // Интенсивность в вершине А
                    Color IvB = CalcColorForVertex(b.Normal, isExtColor); // Интенсивность в вершине B
                    Color IvC = CalcColorForVertex(c.Normal, isExtColor); // Интенсивность в вершине C


                    double tmp;
                    double xa, xb; // левый и правый края растеризуемой линии полигона (треугольника) по x
                    double za, zb; // левый и правый края растеризуемой линии полигона (треугольника) по z
                    // Формируем разтеризуемые линии полигона (треугольника)
                    // и рисуем на битмапе только те точки, значенние z которых
                    // больше чем значение z точек, которая уже нарисована на
                    // битмапе в (sx,sy) - задаём цвет каждого пикселя (sx,sy) на битмапе
                    for (double sy = a.y; sy <= c.y; sy += 0.5f)
                    {
                        if (Math.Abs(c.y - a.y) < eps)
                        {
                            xa = a.x;
                            za = a.z;

                            Ia = IvA;
                        }
                        else
                        {
                            xa = a.x + (sy - a.y) * (c.x - a.x) / (c.y - a.y);
                            za = a.z + (sy - a.y) * (c.z - a.z) / (c.y - a.y);

                            Ia = Color.FromArgb(
                                (int)(IvA.R * (c.y - sy) / (c.y - a.y) + IvC.R * (sy - a.y) / (c.y - a.y)),
                                (int)(IvA.G * (c.y - sy) / (c.y - a.y) + IvC.G * (sy - a.y) / (c.y - a.y)),
                                (int)(IvA.B * (c.y - sy) / (c.y - a.y) + IvC.B * (sy - a.y) / (c.y - a.y)));
                        }

                        if (sy < b.y)
                        {
                            xb = a.x + (sy - a.y) * (b.x - a.x) / (b.y - a.y);
                            zb = a.z + (sy - a.y) * (b.z - a.z) / (b.y - a.y);

                            Ib = Color.FromArgb(
                                (int)(IvA.R * (b.y - sy) / (b.y - a.y) + IvB.R * (sy - a.y) / (b.y - a.y)),
                                (int)(IvA.G * (b.y - sy) / (b.y - a.y) + IvB.G * (sy - a.y) / (b.y - a.y)),
                                (int)(IvA.B * (b.y - sy) / (b.y - a.y) + IvB.B * (sy - a.y) / (b.y - a.y)));
                        }
                        else
                        {
                            if (Math.Abs(c.y - b.y) < eps)
                            {
                                xb = b.x;
                                zb = b.z;

                                Ib = IvB;
                            }
                            else
                            {
                                xb = b.x + (sy - b.y) * (c.x - b.x) / (c.y - b.y);
                                zb = b.z + (sy - b.y) * (c.z - b.z) / (c.y - b.y);

                                Ib = Color.FromArgb(
                                    (int)(IvB.R * (c.y - sy) / (c.y - b.y) + IvC.R * (sy - b.y) / (c.y - b.y)),
                                    (int)(IvB.G * (c.y - sy) / (c.y - b.y) + IvC.G * (sy - b.y) / (c.y - b.y)),
                                    (int)(IvB.B * (c.y - sy) / (c.y - b.y) + IvC.B * (sy - b.y) / (c.y - b.y)));
                            }
                        }

                        if (xa > xb)
                        {
                            tmp = xa; xa = xb; xb = tmp;
                            tmp = za; za = zb; zb = tmp;
                            Color tmpColor = Ia; Ia = Ib; Ib = tmpColor;
                        }

                        // z нам нужен для zbufferization
                        double sz;
                        // Добавляем горизонтальную линию(sy, xa, xb) в список пикселей;
                        for (double sx = xa; sx <= xb; sx += 1)
                        {
                            sz = za + (zb - za) * (sx - xa) / (xb - xa);

                            // Проецируем точку на экран - в нашем случае смещаем в центр экрана
                            // т.к. камера у нас находится на оси Oz
                            int indexI = cx + (int)sx;
                            int indexJ = cy - (int)sy;
                            // Проверяем попала ли точка в экран
                            if (indexI >= 0 && indexI < cx * 2 && indexJ >= 0 && indexJ < cy * 2)
                                // Если да, то проверяем ближе ли она находится к камере
                                // по оси Oz чем та точка, которая уже выведена на эеран
                                lock (bmp)
                                {
                                    if (sz > zbuff[indexI, indexJ])
                                    {   // Если да, то заносим zbuff её значение z как
                                        // наиболее близкое к камере
                                        this.zbuff[indexI, indexJ] = sz;
                                        // и рисуем точку на битмапе - задаём цвет пикселя (sx,sy) на битмапе
                                        color = Color.FromArgb(
                                            (int)(Ia.R + (sx - xa) * (Ib.R - Ia.R) / (xb - xa)),
                                            (int)(Ia.G + (sx - xa) * (Ib.G - Ia.G) / (xb - xa)),
                                            (int)(Ia.B + (sx - xa) * (Ib.B - Ia.B) / (xb - xa)));
                                        this.bmp.SetPixel(indexI, indexJ, color);
                                    }
                                }
                        }
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Exception: " + e.Message);
                }
            });

            // Рисуем изображение на битмапе
            g.DrawImage(bmp, 0, 0);
        }
        //=================================================================//


        //======================Обработчики событий========================//
        /* При отображении поверхности на экран
         * все верщины смещаются в центр экрана
         * и выводятся на форму в соответствии с
         * параметрами закраски.
         * */
        private void onShapeDraw(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int center_x = pb.Width / 2;
            int center_y = pb.Height / 2;
            Graphics g = e.Graphics;

            ka = (double)trackBarAmbientLight.Value / 10;
            kd = (double)trackBarDiffuseLight.Value / 10;
            ks = (double)trackBarSpecularLight.Value / 10;
            n = trackBarPower.Value;
            
            if (radioButtonWireframe.Checked)
            {   // Рисуем только каркас
                g.Clear(pictureBoxDraw.BackColor);
                drawWireFrame(center_x, center_y, g);
            }
            else if (radioButtonFlatFrame.Checked)
            {
                /* В случае Z-буфферизации сортируем полигоны по значению 
                 * координаты Z, тогда полигоны будут выводится в порядке 
                 * возрастания координаты Z и полигоны, которые находятся
                 * ближе к наюлюдателю не будут перекрываться теми, которых
                 * не должно быть видно
                 * */
                //foreach (TMPolygon p in polygons)
                //    p.сalculateNormale();

                if (checkBoxPolyZSort.Checked) polygons.Sort(TMPolygon.compareByZ);
                // Залиаем полигон целиком (Flat-закраска)
                g.Clear(pictureBoxDraw.BackColor);
                drawFlatFrame(center_x, center_y, g);
            }
            else if (radioButtonFlatHLSRFrame.Checked)
            {
                // Залиаем полигон целиком (Flat-закраска)
                // с удалением невидимых линий и поверхностей
                bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                zbuff = new double[bmp.Width, bmp.Height];
                prepairZBuff();

                drawFlatFrameWithHSR(center_x, center_y, g);
            }
            else if (radioButtonPhongShading.Checked)
            {
                // Залиаем полигон целиком (закраска Фонга)
                // с удалением невидимых линий и поверхностей
                bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                zbuff = new double[bmp.Width, bmp.Height];
                prepairZBuff();

                drawPhongShading(center_x, center_y, g);
            }
            else if (radioButtonGouraudShading.Checked)
            {
                // Залиаем полигон целиком (закраска Гуро)
                // с удалением невидимых линий и поверхностей
                bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                zbuff = new double[bmp.Width, bmp.Height];
                prepairZBuff();

                drawGouraudShading(center_x, center_y, g);
            }
        }

        /* При вращении поверхности
         * высчитываем матрицу поворота и в соответствии с ней
         * вычисляем координаты всех вершин поверхности, запоминаем 
         * вычисленные углы поворота, как последние значения, для 
         * вычисления будующей матрицы поворота, и обновляем 
         * изображение поверхности.
         * */
        private void onRotation(object sender, EventArgs e)
        {
            calculateMatrix(trackBarX.Value - old_x, trackBarY.Value - old_y, trackBarZ.Value - old_z);
            calculateShapeRotation(old_result);
            SetOldValues();
            pictureBoxDraw.Refresh();
        }

        /* При изменении параметров поверхности или включении/выключении Z-буфферизации
         * перестраиваем поверхность фигуры и вычисляем координаты всех вершин 
         * поверхности в соответствии с матрицей поворота, затем обнавляем
         * изображение поверхности.
         * */
        private void onShapeParameterChanged(object sender, EventArgs e)
        {
            buildShape();
            calculateShapeRotation(result);
            pictureBoxDraw.Refresh();
        }

        /* При изменении цвета поверхности
         * обнавляется изображение поверхности
         * */
        private void onColorChanged(object sender, EventArgs e)
        {
            SetColors();
            pictureBoxDraw.Refresh();
        }

        /* При изменении положения источника света
         * обнавляется изображение поверхности
         * */
        private void onLightSourceChanged(object sender, EventArgs e)
        {
            SetLightSource();
            pictureBoxDraw.Refresh();
        }

        /* При изменении изображения поверхности
         * в случае изменения размера контрола или изменения метода 
         * рисования, или в любых других случаях, когда поверхность 
         * должна быть перерисована.
         * */
        private void onDrawChanged(object sender, EventArgs e)
        {
            pictureBoxDraw.Refresh();
        }

        /* При нажатии кнопки мыши на поверхность рисования
         * флаг нажатия на кнопку мыши устанавливается в true,
         * запоминаются заданные значения поворотов.
         * */
        private void pictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            SetLastCoordinates(e);
        }

        /* При отпускании кнопки мыши на поверхность рисования
         * флаг нажатия на кнопку мыши устанавливается в false.
         * */
        private void pictureBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        /* При перемещении мыши на поверхности рисования, 
         * если кнопка мыши нажата, то высчитываем матрицу поворота 
         * и в соответствии с ней вычисляем координаты всех вершин 
         * поверхности, запоминаем вычисленные углы поворота, как 
         * последние значения, для вычисления будующей матрицы 
         * поворота, и обновляем изображение поверхности.
         * */
        private void pictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                calculateMatrix(lastY - e.Y, e.X - lastX, 0);
                calculateShapeRotation(old_result);
                SetLastCoordinates(e);
                pictureBoxDraw.Refresh();
            }
        }

        /* При вызове справки
         * */
       

        /* При закрывании формы
         * */
        private void onFormClose(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }
        //=================================================================//
    }
}
