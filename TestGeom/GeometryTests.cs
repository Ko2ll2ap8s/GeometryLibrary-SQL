using NUnit.Framework;

namespace GeometryLibrary.Tests
{
    public class GeometryTests
    {
        [Test]
        public void GetCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = 78.54;

            double actualArea = Geometryc.GetCircleArea(radius);

            Assert.AreEqual(expectedArea, actualArea, 0.01);
        }

        [Test]
        public void GetTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;

            double actualArea = Geometryc.GetTriangleArea(side1, side2, side3);

            Assert.AreEqual(expectedArea, actualArea, 0.01);
        }

        [Test]
        public void GetTriangleArea_InvalidSides_ThrowsArgumentException()
        {
            double side1 = -1;
            double side2 = 4;
            double side3 = 5;

            Assert.Throws<System.ArgumentException>(() => Geometryc.GetTriangleArea(side1, side2, side3));
        }
    }
}
