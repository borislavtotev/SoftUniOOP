using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(-7, -4, 3);
            Point3D b = new Point3D(17, 6, 2.5);
            Console.WriteLine("The distance between ({0}) and ({1}) is: {2}", a.ToString(), b.ToString(), DistanceCalculator.Calculate(a,b));
        }
    }
}
