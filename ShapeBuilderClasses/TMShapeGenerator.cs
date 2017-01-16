using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    static public class TMShapeGenerator
    {
        /* Генерирует поверхность фигуры путём генерации каждой 
         * вершины поверхности по её параметрам
         * */
        static public void generateShape(out TMVertex[,] vertices, int cout_U, int cout_V, double min_U, double min_V, double max_U, double max_V, double a)
        {
            vertices = new TMVertex[cout_U, cout_V];

            double delta_U = (max_U - min_U) / (cout_U - 1);
            double delta_V = (max_V - min_V) / (cout_V - 1);
            double cur_U = min_U;
            double cur_V = min_V;

            for (int u = 0; u < cout_U; u++)
            {
                for (int v = 0; v < cout_V; v++)
                {
                    TMVertex p;
                    TMVertexGenerator.generateVertex(out p, cur_U, cur_V, a);
                    vertices[u, v] = p;                    

                    TMVertex v1, v2, v3, v4, v5;
                    TMVertexGenerator.generateVertex(out v1, cur_U - delta_U, cur_V, a);
                    TMVertexGenerator.generateVertex(out v2, cur_U, cur_V - delta_V, a);
                    TMVertexGenerator.generateVertex(out v3, cur_U + delta_U, cur_V, a);
                    TMVertexGenerator.generateVertex(out v4, cur_U, cur_V + delta_V, a);
                    TMVertexGenerator.generateVertex(out v5, cur_U, cur_V, a);
                    vertices[u, v].Normal =
                        TMPolygon.calcPolyNormal(v5, v1, v4) +
                        TMPolygon.calcPolyNormal(v5, v2, v1) +
                        TMPolygon.calcPolyNormal(v5, v3, v2) +
                        TMPolygon.calcPolyNormal(v5, v4, v3);
                    vertices[u, v].Normal.Normalize();

                    cur_V += delta_V;
                }
                cur_V = min_V;
                cur_U += delta_U;
            }
        }

        /* Формирует полигоны по переданному списку точек
         * */
        static public void generatePolygons(out List<TMPolygon> polygons, ref TMVertex[,] vertices)
        {
            polygons = new List<TMPolygon>();
            for (int i = 0; i < vertices.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < vertices.GetLength(1) - 1; j++)
                {
                    polygons.Add(new TMPolygon(ref vertices[i, j], ref vertices[i, j + 1], ref  vertices[i + 1, j]));
                    polygons.Add(new TMPolygon(ref vertices[i + 1, j + 1], ref vertices[i + 1, j], ref  vertices[i, j + 1]));
                }
            }
        }
    }
}
