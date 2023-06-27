using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Figure
    {
        Point[] point;
        public string Type { get; }
        public Figure(Point a, Point b, Point c)
        {
            point = new Point[3];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            Type = "Triangle";

        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            point = new Point[4];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            point[3] = d;
            Type = "Tetragon";
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            point = new Point[5];
            point[0] = a;
            point[1] = b;
            point[2] = c;
            point[3] = d;
            point[4] = e;
            Type = "Pentagon";

        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LengthSide(point[i], point[i + 1]);
            }

            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
    }
}
