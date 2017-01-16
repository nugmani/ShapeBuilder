using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    public class TMPolygon
    {
        /* Вершины полигона p1,p2,p3 и нормаль n
         * */
        public TMVertex v1, v2, v3, n;

        public TMPolygon(ref TMVertex v1, ref TMVertex v2, ref TMVertex v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            // Если данный полигон не сожержится в списке примыкающих
            // полигонов каждой вершины полигона - добовляем его туда
            if (!this.v1.AdjacentPolygons.Contains(this))
                v1.AdjacentPolygons.Add(this);
            if (!this.v2.AdjacentPolygons.Contains(this))
                v2.AdjacentPolygons.Add(this);
            if (!this.v2.AdjacentPolygons.Contains(this))
                v2.AdjacentPolygons.Add(this);
        }
        public TMPolygon(TMPolygon p)
        {
            this.v1 = p.v1;
            this.v2 = p.v2;
            this.v3 = p.v3;
            this.n = p.n;
        }

        /* Высчитвает нормаль полигона
         */
        public bool сalculateNormale()
        {
            if (v1 != null && v2 != null && v3 != null)
            {
                // С помощью двух векторов (p2 - p1) и (p3 - p1)
                // полигона находим его нормаль 
                n = (v2 - v1) ^ (v3 - v1);
                // приводим нормаль к единичному вектору
                n.Normalize();
                return true;
            }
            else return false;
        }

        /* Выисляет нормаль произвольного полигона 
         * по трём его переданным вершинам
         * */
        public static TMVertex calcPolyNormal(TMVertex v1, TMVertex v2, TMVertex v3)
        {
            TMVertex normal = null;
            if (v1 != null && v2 != null && v3 != null)
            {
                normal = (v2 - v1) ^ (v3 - v1);
                normal.Normalize();
            }
            return normal;
        }

        /* Используется в качестве метода сравнения для сортировки полигонов в списке.
         * Чем больше Z, тем ближе полигон, тем больше вероятность, что он отобразится
         * поверх других полигонов
         * */
        public static int compareByZ(TMPolygon p1, TMPolygon p2)
        {
            double z1 = p1.v1.z + p1.v2.z + p1.v3.z;
            double z2 = p2.v1.z + p2.v2.z + p2.v3.z;

            if (z1 < z2) return -1;
            else if (z1 > z2) return 1;
            else return 0;
        }
    }
}
