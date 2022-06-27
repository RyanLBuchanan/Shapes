using System;

namespace Shapes
{
    public class ShapeTest
    {
        static void Main(string[] args)
        {

            var circle = new TwoDimensionalShape("Radius");
            var square = new TwoDimensionalShape("Length");

            var sphere = new ThreeDimensionalShape("Radius");
            var cube = new ThreeDimensionalShape("Length");

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
