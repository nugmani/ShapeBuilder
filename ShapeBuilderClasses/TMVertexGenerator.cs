using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    static public class TMVertexGenerator
    {
        /* Высчитывает координаты x,y,z каждой вершины 
         * поверхности по её параметрам U,V,a
         * */
        static public void calculateShape(out double x, out double y, out double z, double U, double V, double a)
        {
            /// Tor R = a, r = a/2
            x = (a + a / 2 * Math.Cos(U)) * Math.Sin(V);
            y = (a + a / 2 * Math.Cos(U)) * Math.Cos(V);
            z = (a / 2) * Math.Sin(U);

           /* x = (a + (a / 2) * Math.Cos(U)) * Math.Sin(V);
            y = (a + (a / 2) * Math.Cos(U)) * Math.Cos(V);
            z = (a / 2) * Math.Sin(U) + 30 * V;*/

        }

        /* Генерирует вершину p по переданным параметрам поверхности U,V,a
         * */
        static public void generateVertex(out TMVertex p, double U, double V, double a)
        {
            double x, y, z;
            calculateShape(out x, out y, out z, U, V, a);
            p = new TMVertex(x, y, z, 1);
        }
    }
}
