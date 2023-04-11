using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}

