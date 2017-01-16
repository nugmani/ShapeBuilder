using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    public class TMMatrix
    {
        public double M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44;

        public TMMatrix(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
        {
            M11 = m11; M12 = m12; M13 = m13; M14 = m14;
            M21 = m21; M22 = m22; M23 = m23; M24 = m24;
            M31 = m31; M32 = m32; M33 = m33; M34 = m34;
            M41 = m41; M42 = m42; M43 = m43; M44 = m44;
        }

        public static TMMatrix operator *(TMMatrix a, TMMatrix b)
        {
            double m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44;

            m11 = a.M11 * b.M11 + a.M12 * b.M21 + a.M13 * b.M31 + a.M14 * b.M41;
            m12 = a.M11 * b.M12 + a.M12 * b.M22 + a.M13 * b.M32 + a.M14 * b.M42;
            m13 = a.M11 * b.M13 + a.M12 * b.M23 + a.M13 * b.M33 + a.M14 * b.M43;
            m14 = a.M11 * b.M14 + a.M12 * b.M24 + a.M13 * b.M34 + a.M14 * b.M44;

            m21 = a.M21 * b.M11 + a.M22 * b.M21 + a.M23 * b.M31 + a.M24 * b.M41;
            m22 = a.M21 * b.M12 + a.M22 * b.M22 + a.M23 * b.M32 + a.M24 * b.M42;
            m23 = a.M21 * b.M13 + a.M22 * b.M23 + a.M23 * b.M33 + a.M24 * b.M43;
            m24 = a.M21 * b.M14 + a.M22 * b.M24 + a.M23 * b.M34 + a.M24 * b.M44;

            m31 = a.M31 * b.M11 + a.M32 * b.M21 + a.M33 * b.M31 + a.M34 * b.M41;
            m32 = a.M31 * b.M12 + a.M32 * b.M22 + a.M33 * b.M32 + a.M34 * b.M42;
            m33 = a.M31 * b.M13 + a.M32 * b.M23 + a.M33 * b.M33 + a.M34 * b.M43;
            m34 = a.M31 * b.M14 + a.M32 * b.M24 + a.M33 * b.M34 + a.M34 * b.M44;

            m41 = a.M41 * b.M11 + a.M42 * b.M21 + a.M43 * b.M31 + a.M44 * b.M41;
            m42 = a.M41 * b.M12 + a.M42 * b.M22 + a.M43 * b.M32 + a.M44 * b.M42;
            m43 = a.M41 * b.M13 + a.M42 * b.M23 + a.M43 * b.M33 + a.M44 * b.M43;
            m44 = a.M41 * b.M14 + a.M42 * b.M24 + a.M43 * b.M34 + a.M44 * b.M44;

            return new TMMatrix(m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44);
        }

        public static TMMatrix RotateX(double alpha)
        {
            return new TMMatrix(
                1, 0, 0, 0,
                0, Math.Cos(alpha), -Math.Sin(alpha), 0,
                0, Math.Sin(alpha), Math.Cos(alpha), 0,
                0, 0, 0, 1);
        }

        public static TMMatrix RotateY(double alpha)
        {
            return new TMMatrix(
                Math.Cos(alpha), 0, -Math.Sin(alpha), 0,
                0, 1, 0, 0,
                Math.Sin(alpha), 0, Math.Cos(alpha), 0,
                0, 0, 0, 1);
        }

        public static TMMatrix RotateZ(double alpha)
        {
            return new TMMatrix(
                Math.Cos(alpha), -Math.Sin(alpha), 0, 0,
                Math.Sin(alpha), Math.Cos(alpha), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }

        public static TMMatrix Perspective(double c)
        {
            return new TMMatrix(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, -(1 / c),
                0, 0, 0, 1);
        }

        public static TMMatrix Shift(double a, double b, double c)
        {
            return new TMMatrix(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                a, b, c, 1);
        }

        public static TMMatrix Invert()
        {
            return new TMMatrix(
                -1, 0, 0, 0,
                0, -1, 0, 0,
                0, 0, -1, 0,
                0, 0, 0, -1);
        }

        public static TMMatrix E()
        {
            return new TMMatrix(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }
    }
}
