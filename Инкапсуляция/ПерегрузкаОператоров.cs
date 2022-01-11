using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    class Vector
    {
        public double X;
        public double Y;

        public static Vector operator +(Vector p1, Vector p2)
        {
            return new Vector { X = p1.X + p2.X, Y = p1.Y + p1.Y };
        }

        public static Vector operator *(Vector p1, double c)
        {
            return new Vector { X = p1.X * c, Y = p1.Y * c };
        }

        public static double operator *(Vector p1, Vector p2)
        {
            return p1.X * p2.Y + p1.Y * p2.Y;
        }

        public static explicit operator PointF (Vector p1)
        {
            return new PointF((float)p1.X, (float)p1.Y);
        }
    }

    class A
    {
        public int a;
        public static int operator +(A obj1, A obj2)
        {
            return obj1.a + obj2.a;
        }

        public static int operator *(A obj, string str)
        {
            return 1;
        }
    }
    class ПерегрузкаОператоров
    {
        public static void MainX()
        {
            int a = new A() + new A() + new A() * "abc";

            var v1 = new Vector { X = 1, Y = 1 };
            var v2 = new Vector { X = 2, Y = 3 };
            var v3 = v1 + v2;
            var v4 = v1 * 5;
            PointF point = (PointF)v1;
        }
    }
}
