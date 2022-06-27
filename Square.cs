using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : TwoDimensionalShape
    {
        public string name;
        public double length;
        
        // One parameter constructor
        public Square(string name, double length)
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

        public override double Area() => length * length;

        public override double GetGeometry() => Area();
     
        public override string ToString() => $"The area of a {this.name}: {length} * {length} = {this.Area()}";
    }
}
