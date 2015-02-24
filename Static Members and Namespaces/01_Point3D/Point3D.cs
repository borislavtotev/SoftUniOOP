using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        private static Point3D startingPoint = new Point3D();

        public Point3D(double x=0, double y=0, double z=0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartingPoint() 
        {
            return Point3D.startingPoint;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}",
                this.X, this.Y, this.Z);
        }  
    }
}