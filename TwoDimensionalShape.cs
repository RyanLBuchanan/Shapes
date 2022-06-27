using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class TwoDimensionalShape : Shape , IGeometry
    {
        // One parameter constructor
        public TwoDimensionalShape(string name)
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

        // Abstract method to be overridden by respective shapes
        public abstract decimal Area();
        
        // Abstract method to be overridden by derived classes
        //public virtual decimal GetGeometry() => Area();  // No implementation 

        // Return a string replacement of Shape object and properties
        public override string ToString() => $"{Name}";

    }
}
