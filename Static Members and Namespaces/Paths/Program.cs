using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "../../3Dpaths.txt";

            Point3D pointA = new Point3D(1, 1, 1); 
            Path3D newPath = new Path3D(pointA); 
            Storage.AddPathToFile(filePath, newPath);

            Point3D pointB = new Point3D(2, 2, 2);
            Storage.AddPointToFile(filePath, pointB);

            List<Point3D> points = new List<Point3D>(){new Point3D(3,3,3), new Point3D(4,4,4), new Point3D(5,5,5)};
            Storage.AddListOfPointsToFile(filePath, points);
        }
    }
}
