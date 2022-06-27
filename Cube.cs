using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cube : ThreeDimensionalShape
    {
        public string name;
        public double length;

        // One parameter constructor
        public Cube(string name, double length)
            : base(name)
        {
            Name = name;
            Length = length;
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

        // Property to get set length
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Length)} must be >= 1");
                }

                length = value;
            }
        }

        public override double Area() => 6 * Math.Pow(length, 2);

        public override double GetGeometry()
        {
            throw new NotImplementedException();
        }

        public override double Volume() => Math.Pow(length, 3);


    }
}
