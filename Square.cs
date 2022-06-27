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
        public decimal length;
        
        // One parameter constructor
        public Square(string name, decimal length)
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
        public decimal Length
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

        public override decimal Area() => length * length;

        public override decimal GetGeometry() => Area();
     

        public override string ToString() => $"The area of a {this.name}: {length} * {length} = {this.Area()}";
    }
}
