using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class ThreeDimensionalShape : IGeometry
    {
        // One parameter constructor
        public ThreeDimensionalShape(string name)
        {
            Name = name;
        }

        public string Name { get; }

        // Abstract method to be overridden by derived classes
        public abstract double Area();  // No implementation 

        // Abstract method to be overridden by derived classes
        public abstract double Volume();  // No implementation 

        // Abstract method to be overridden by derived classes
        public abstract string ToString();  // No implementation 
    }
}
