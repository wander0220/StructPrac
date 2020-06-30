using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    struct Point
    {
        public int x;
        public int y;
        public Program program;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.program = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point; //== int x
        }
    }
}
