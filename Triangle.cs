
using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        
        private bool IsUsingSidesOnly { get; set; }

        // Constructor for creating a triangle by three sides
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsUsingSidesOnly = true;
        }


        // Area calculation method
        public double GetArea()
        {
            if (IsUsingSidesOnly)
            {
                // Use Heron's formula to calculate area
                double semiPerimeter = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            }
            else
            {
                // Use trigonometric formula (Sine rule) to calculate area
                double angleInRadians = AngleInDegrees * (Math.PI / 180.0); // Convert degrees to radians
                return 0.5 * SideA * SideB * Math.Sin(angleInRadians);
            }
        }
    }
}
