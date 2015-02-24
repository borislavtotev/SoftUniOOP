using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
