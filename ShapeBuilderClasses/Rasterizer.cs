using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    static public class Rasterizer
    {
        private static void Swap(ref TMVertex v1, ref TMVertex v2)
        {
            TMVertex tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        private static void Sort_By_Y(ref TMVertex v1, ref TMVertex v2, ref TMVertex v3)
        {
            if (v1.y > v2.y) 
                Swap(ref v1, ref v2);
            if (v1.y > v3.y) 
                Swap(ref v1, ref v3);
            if (v2.y > v3.y) 
                Swap(ref v2, ref v3);
        }

        static public void DoRasterization(TMPolygon p, out List<TMPixel> pixels)
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
        }
    }
}
