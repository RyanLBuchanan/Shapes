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

                new Sphere("Sphere", 5),
                new Cube("Cube", 4)};

            // Header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Shapes and their respective geometry processed polymorphically:\n");
            Console.ResetColor();

            // Generically process each element in shapes
            foreach(var shape in myShapes)
            {
                // Output shape and its appropriate geometry
                Console.WriteLine($"{shape.ToString()}");
                if(shape is TwoDimensionalShape)
                {
                    Console.WriteLine($"This is a 2-D object\n");
                }
                else
                {
                    Console.WriteLine($"This is a 3-D object\n");
                }
            }
        }
    }
}
