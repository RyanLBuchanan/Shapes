using System;

namespace Shapes
{
    public class ShapeTest
    {
        static void Main(string[] args)
        {
            var myShapes = new List<IGeometry>() { 
                new TwoDimensionalShape("Circle", "Radius"),
                new TwoDimensionalShape("Square", "Length"),

                new ThreeDimensionalShape("Sphere", "Radius"),
                new ThreeDimensionalShape("Cube", "Length")};

            // Header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Shapes and their respective geometry processed polymorphically:\n");
            Console.ResetColor();

            // Generically process each element in shapes
            foreach(var shape in myShapes)
            {
                // Output shape and its appropriate geometry
                Console.WriteLine($"The geometry of a {shape} is: {shape.GetGeometry()}\n");
            }


            // Calculation for a circle
            Console.WriteLine($"The area of a {circle}: {Math.PI} * {Math.Pow(radius, 2)} = {area}");
            Console.WriteLine();

            // Calculation for a square
            Console.WriteLine($"The area of a {square}: {length} * {length} = {area}");
            Console.WriteLine();

            // Calculations for a sphere
            Console.WriteLine($"The area of a {sphere}: {Math.PI} * {Math.Pow(radius, 2)} = {area}");
            Console.WriteLine();

            // Calculations for a cube
            Console.WriteLine($"The area of a {cube}: {length} * {length} = {area}");
            Console.WriteLine();
        }
    }
}
