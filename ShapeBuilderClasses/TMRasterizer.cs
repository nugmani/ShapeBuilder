using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    static public class TMRasterizer
    {
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


        public static void DoRasterization(TMPolygon p, out List<TMPixel> pixels)
        {
            double eps = 0.000001;

            pixels = new List<TMPixel>();
            
            TMVertex a, b, c;
            a = p.v1; b = p.v2; c = p.v3;
            Sort_By_Y(ref a, ref b, ref c);
            
            double tmp;
            double xa, xb; // левый и правый края растеризуемой линии полигона (треугольника) по x
            double za, zb; // левый и правый края растеризуемой линии полигона (треугольника) по z
            // Формируем разтеризуемые линии полигона (треугольника)
            for (double sy = a.y; sy <= c.y; sy = sy + 0.5f)
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
                for (double sx = xa; sx <= xb; sx = sx + 0.5f)
                {
                    sz = za + (zb - za) * (sx - xa) / (xb - xa);
                    pixels.Add(new TMPixel((float)sx, (float)sy, (float)sz));
                }
            }
        }

        public static void DoZBufferization(ref List<TMPixel> zbuff, ref List<TMPixel> pixels)
        {
            double eps = 0.000001;

            TMPixel pixel;
            for (int i = 0; i < pixels.Count; i++)
            {
                pixel = pixels[i];

                for (int j = 1; j < pixels.Count; j++)
                {
                    // Рассматриваем пиксели только в в позиции [i,j]
                    if (Math.Abs(pixel.X - pixels[j].X) < eps && 
                        Math.Abs(pixel.Y - pixels[j].Y) < eps)
                    {
                        // Запоминаем тот, который ближе находится
                        // к какмере, а все остальные удаляем
                        if (pixel.Z > pixels[j].Z)
                        {
                            pixels.RemoveAt(j--);
                            if (i > j) i--;
                        }
                        else
                        {
                            pixel = pixels[j];
                            pixels.RemoveAt(i--);
                            if (j > i) j--;
                        }
                    }
                }

                // Заносим пикскль [i,j], который находится ближе других к камере
                zbuff.Add(new TMPixel(pixel));
                // и удаляем его из списка пикселей
                pixels.Remove(pixel);
            }
        }

        /*public static void DoRasterization(TMPolygon p, out List<TMPixel> pixels)
        {
            pixels = new List<TMPixel>();
            TMVertex a, b, c;
            a = p.v1; b = p.v2; c = p.v3;
            Sort_By_Y(ref a, ref b, ref c);

            int x1, x2; // левый и правый края растеризуемой линии полигона (треугольника)
            // Формируем разтеризуемые линии полигона (треугольника)
            for (int sy = (int)a.y; sy <= (int)c.y; sy++)
            {
                x1 = (int)(a.x + (sy - a.y) * (c.x - a.x) / (c.y - a.y));

                if (sy < b.y)
                {
                    x2 = (int)(a.x + (sy - a.y) * (b.y - a.x) / (b.y - a.y));
                }
                else
                {
                    if (c.y == b.y) 
                        x2 = (int)b.x;
                    else 
                        x2 = (int)(b.x + (sy - b.y) * (c.x - b.x) / (c.y - b.y));
                }

                if (x1 > x2) 
                { 
                    int tmp = x1; 
                    x1 = x2; 
                    x2 = tmp; 
                }
                // Добавляем горизонтальную линию(sy, x1, x2) в список пикселей;
                for (int i = x1; i <= x2; i++) 
                    pixels.Add(new TMPixel(i, sy));
            }
        }*/
    }
}
