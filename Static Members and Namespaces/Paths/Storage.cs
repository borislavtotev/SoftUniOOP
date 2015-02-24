using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace Paths
{
    class Storage
    {
        public static Path3D LoadPaths(string filePath)
        {
            string text = System.IO.File.ReadAllText(@filePath);

            return new Path3D(text);

        }
        public static void SaveToFile(Path3D points, string filePath) 
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath))
            {
                file.Write(points.path3DString);
            }
        }

        public static void AddPathToFile(string filePath, Path3D newPath)
        {
            Path3D input = Storage.LoadPaths(filePath);

            input.AddListOfPoints(newPath.list3DPoints);

            Storage.SaveToFile(input, filePath);
        }
        
        
        public static void AddPointToFile(string filePath, Point3D point)
        {
            Path3D input = Storage.LoadPaths(filePath);

            input.AddPoint(point);

            Storage.SaveToFile(input, filePath);    
        }
        
        public static void AddListOfPointsToFile(string filePath, List<Point3D> points)
        {
            Path3D input = Storage.LoadPaths(filePath);

            input.AddListOfPoints(points);

            Storage.SaveToFile(input, filePath);
        }
    }
}
