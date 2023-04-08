using System;
using GeometryLibrary;

class Program
{
    static void Main(string[] args)
    {
        double circleRadius = 5;
        double triangleSide1 = 3;
        double triangleSide2 = 4;
        double triangleSide3 = 5;

        // Circle area
        double circleArea = Geometryc.GetCircleArea(circleRadius);
        Console.WriteLine($"Circle area with radius {circleRadius} is {circleArea:F2}");

        // Triangle area
        double triangleArea = Geometryc.GetTriangleArea(triangleSide1, triangleSide2, triangleSide3);
        Console.WriteLine($"Triangle area with sides {triangleSide1}, {triangleSide2}, {triangleSide3} is {triangleArea:F2}");

        // Right triangle check
        bool isRightTriangle = Geometryc.IsRightTriangle(triangleSide1, triangleSide2, triangleSide3);
        Console.WriteLine($"Triangle with sides {triangleSide1}, {triangleSide2}, {triangleSide3} is right triangle: {isRightTriangle}");
    }
}

