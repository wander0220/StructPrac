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
            //point = new Point(); // x=0,y=0; new 키워드 쓰면 기본값으로 초기화해준다.
            point.x = 10;
            point.y = 10;
        }
    }
}
