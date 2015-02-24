using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]{
                new Circle(2.3),
                new Triangle(2,3,4.5),
                new Rectangle(5,6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} has area:{1} and perimetre:{2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }

        }
    }
}
