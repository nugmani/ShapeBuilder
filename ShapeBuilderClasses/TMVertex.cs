using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    /* Класс точка хранит координаты вершин в пространстве
     * */
    public class TMVertex
    {
        public double x,y,z,w;
        private TMVertex n;
        private Color intensity; 

        /* Список полигонов примыкающих к этой вершине
         * */
        private List<TMPolygon> adjacentPolygons = new List<TMPolygon>();

        /* Конструктор
         * */
        public TMVertex(double x, double y, double z, double w)
        {
            this.x = x; this.y = y; this.z = z; this.w = w;
        }
        public TMVertex(TMVertex vertex)
        {
            this.x = vertex.x; 
            this.y = vertex.y; 
            this.z = vertex.z; 
            this.w = vertex.w;
        }

        /* Свойство - доступ к списку примыкающих полигонов
         * */
        public List<TMPolygon> AdjacentPolygons
        {
            set {
                this.adjacentPolygons = value;
            }
            get {
                return this.adjacentPolygons;
            }
        }

        public Color Intensity
        {
            set {
                intensity = value;
            }
            get {
                return intensity;
            }
        }

        public TMVertex Normal
        {
            set {
                n = value;
            }
            get {
                return n;
            }
        }

        public void evaluateNormal()
        {
            TMVertex normal = new TMVertex(0, 0, 0, 0);
            foreach (TMPolygon p in adjacentPolygons)
                normal = normal + p.n;

            normal.Normalize();
            normal.w = 1;

            n = normal;
        }

        public double getLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public void offset(double dx, double dy, double dz, double dw)
        {
            x += dx; 
            y += dy; 
            z += dz; 
            w += dw;
        }

        public void copyParamFrom(TMVertex v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        /* Определение косинуса угла между векторами a и b
         * */
        public static double getCos(TMVertex a, TMVertex b)
        {
            if (a.getLength()==0 || b.getLength()==0)
                return 0;
            return (a.x * b.x + a.y * b.y + a.z * b.z) / (a.getLength() * b.getLength());
        }

        public static TMVertex operator +(TMVertex a, TMVertex b)
        {
            return new TMVertex(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        public static TMVertex operator -(TMVertex a, TMVertex b)
        {
            return new TMVertex(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

        public static TMVertex operator *(double a, TMVertex b)
        {
            return new TMVertex(a * b.x, a * b.y, a * b.z, b.w);
        }

        public static double operator *(TMVertex a, TMVertex b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        /* Определяет координаты вектора нормали плоскости, заданной векторами a и b
         * */
        public static TMVertex operator ^(TMVertex a, TMVertex b)
        {
            return new TMVertex(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x, 1);
        }

        /* Нормализует вектор, т.е. приводит его к единичному размеру
         * */
        public void Normalize()
        {
            double l = getLength();
            if (l != 0) 
            { 
                x /= l; 
                y /= l; 
                z /= l; 
            };
        }

        public static TMVertex operator *(TMVertex a, TMMatrix b)
        {
            double x, y, z, w;
            x = a.x * b.M11 + a.y * b.M21 + a.z * b.M31 + a.w * b.M41;
            y = a.x * b.M12 + a.y * b.M22 + a.z * b.M32 + a.w * b.M42;
            z = a.x * b.M13 + a.y * b.M23 + a.z * b.M33 + a.w * b.M43;
            w = a.x * b.M14 + a.y * b.M24 + a.z * b.M34 + a.w * b.M44;

            return new TMVertex(x, y, z, w);
        }

        public static TMVertex operator /(TMVertex a, double b)
        {
            if (b == 0)
                return new TMVertex(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
            else
                return new TMVertex(a.x / b, a.y / b, a.z / b, a.w);
        }
    }
}
