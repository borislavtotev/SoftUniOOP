using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 2, 3);
            Console.WriteLine(point1.ToString());
            
            Console.WriteLine(Point3D.StartingPoint().ToString());
        }
    }

}
