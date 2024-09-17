using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
       
        // Constructor for creating a triangle by three sides
        public Triangle(double sideA, double sideB, double sideC)
        {
            // Validate the sides based on the triangle inequality theorem
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The given sides do not form a valid triangle.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Method to check if the triangle inequality holds for the given sides
        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        // Area calculation method
        public double GetArea()
        {  
                // Use Heron's formula to calculate area
                double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}