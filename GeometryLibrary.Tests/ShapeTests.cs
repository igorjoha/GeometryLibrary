
using System;
using Xunit;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_GetArea_ShouldReturnCorrectArea()
        {
            var circle = new Circle(3);
            double area = circle.GetArea();
            Assert.Equal(Math.PI * 9, area, precision: 5);
        }

        [Fact]
        public void Triangle_GetArea_BySides_ShouldReturnCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            Assert.Equal(6, area);
        }
    }
}
