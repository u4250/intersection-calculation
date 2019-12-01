using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main7
{
     public class Point
    {
        public double x;
        public double y;
        public Point()
        {

        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point point1)
        {
            double s;
            s = Math.Sqrt((this.x - point1.x) * (this.x - point1.x) + (this.y - point1.y) * (this.y - point1.y));
            Console.WriteLine((this.x - point1.x) * (this.x - point1.x) + (this.y - point1.y) * (this.y - point1.y));
            return s;
        }
    }
}
