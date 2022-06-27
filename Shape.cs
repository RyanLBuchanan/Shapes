using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IGeometry
    {
        public string Name { get; set; }

        //// One-parameter constructor
        //public Shape(string name)
        //{
        //    Name = name;
        //}

        //// Return a string replacement of Shape object and properties
        //public override string ToString() => $"{Name}";

        //// Abstract method to be overridden by derived classes
        //public abstract decimal Area();  // No implementation 

        // Implementation of interface contract
        public abstract decimal GetGeometry();
    }
}
