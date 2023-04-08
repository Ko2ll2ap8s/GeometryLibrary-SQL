using System;

namespace GeometryLibrary
{
    public static class Geometryc
    {
        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double GetTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Triangle sides must be positive.");
            }

            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}

