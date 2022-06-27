using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Sphere : ThreeDimensionalShape
    {
        public string name;
        public double radius;

        // One parameter constructor
        public Sphere(string name, double radius)
            : base(name)
        {
            Name = name;
            Radius = radius;
        }
        // Property to get set name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Property to get set radius
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Radius)} must be >= 1");
                }

                radius = value;
            }
        }

        public override double Area() => 4 * Math.PI * Math.Pow(radius, 2);

        public override double Volume() => (4 / 3) * Math.PI * Math.Pow(radius, 3);

        //public override string GetGeometry()
        //    {
        //        Console.WriteLine($"A {name} with a {nameof(radius)} of {radius.ToString()} has an area of {Area():F2}");
        //    }

        public override string ToString() => $"A {name} with a {nameof(radius)} of {radius.ToString()} has an area of {Area():F2}" +
            $" and a volume of {Volume():F2}";
    }
}
