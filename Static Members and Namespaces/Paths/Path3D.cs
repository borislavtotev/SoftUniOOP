using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace Paths
{
    class Path3D
    {
        public List<Point3D> list3DPoints;
        public string path3DString;

        public Path3D(Point3D point)
        {
            this.list3DPoints = new List<Point3D>();
            this.list3DPoints.Add(point);

            this.path3DString = Path3D.ListToString(this.list3DPoints);
        }
        
        
        public Path3D(List<Point3D> points)
        {
            this.list3DPoints = points;

            this.path3DString = Path3D.ListToString(points);
        }

        public Path3D(string pointSequence)
        {
            this.path3DString = pointSequence;

            this.list3DPoints = Path3D.StringToList(pointSequence);
        }

        public void AddListOfPoints(List<Point3D> points)
        {
            string newPoints = Path3D.ListToString(points);
            this.path3DString += newPoints;
            this.list3DPoints = Path3D.StringToList(this.path3DString);
        }

        public void AddPoint(Point3D newPoint)
        {
            this.path3DString += " " + newPoint.ToString();
        }

        private static string ListToString(List<Point3D> points)
        {
            string path = "";

            foreach (var point in points)
            {
                path += " " + point.ToString();
            }

            return path;
        }

        private static List<Point3D> StringToList(string pointSequence)
        {
            string[] pointAddresses = pointSequence.Split(' ');

            List<Point3D> allPoints = new List<Point3D>();

            foreach (var pointAddress in pointAddresses)
            {
                if (pointAddress != "")
                {
                    string[] cordinates = pointAddress.Split(',');

                    double x;
                    double.TryParse(cordinates[0], out x);
                    double y;
                    double.TryParse(cordinates[1], out y);
                    double z;
                    double.TryParse(cordinates[2], out z);

                    Point3D A = new Point3D(x, y, z);
                    allPoints.Add(A);
                }
            }
            return allPoints;
        }
    }
}
