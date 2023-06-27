using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Point
    {
        private int x, y;
        private string name;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
        public Point(string name, int a,  int b)
        {
            this.x = a;
            this.y = b;
            this.name = name;
        }
    }
}
