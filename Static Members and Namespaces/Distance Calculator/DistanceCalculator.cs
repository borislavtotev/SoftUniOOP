using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace Distance_Calculator
{
    public static class DistanceCalculator
    {
        public static double Calculate(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.Z - a.Z), 2));
            return distance;
        }
    }
}
