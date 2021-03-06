using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class TwoDimensionalShape : IGeometry
    {
        // One parameter constructor
        public TwoDimensionalShape(string name)
        {
            Name = name;
        }

        public string Name { get; }

        // Abstract method to be overridden by respective shapes
        public abstract double Area();

        // Abstract method to be overridden by derived classes
        public abstract string ToString();  // No implementation 
    }
}
