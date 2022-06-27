using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : TwoDimensionalShape
    {
        public string name;

        // One parameter constructor
        public Circle(string name)
        {
            Name = name;
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

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal GetGeometry()
        {
            throw new NotImplementedException();
        }
    }
}
