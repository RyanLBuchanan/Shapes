using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class ThreeDimensionalShape : Shape , IGeometry
    {
        // One parameter constructor
        public ThreeDimensionalShape(string name)
        {
            Name = name;
        }
        //// Property to get set name
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set 
        //    {
        //        name = value;
        //    }
        //}

        // Return a string replacement of Shape object and properties
        public override string ToString() => $"{Name}";

        // Abstract method to be overridden by derived classes
        public abstract decimal Area();  // No implementation 

        // Abstract method to be overridden by derived classes
        public abstract decimal Volume();  // No implementation 
    }
}
