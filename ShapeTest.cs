using System;
using System.Collections.Generic;

namespace Shapes
{
    public class ShapeTest
    {
        static void Main(string[] args)
        {
            var myShapes = new List<IGeometry>() { 
                new Circle("Circle", 5),
                new Square("Square", 4),

                new Sphere("Sphere", 3),
                new Cube("Cube", 2)};

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
        }
    }
}
