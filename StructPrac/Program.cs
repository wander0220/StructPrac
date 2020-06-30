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

    class Pointclass
    {
        public int x;
        public int y;
        public Pointclass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct PointStruct
    {
        public int x;
        public int y;
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
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


            Pointclass pointClassA = new Pointclass(10, 20);
            Pointclass pointClassB = pointClassA;

            pointClassB.x = 100;
            pointClassB.y = 200;

            Console.WriteLine("pointClassA : " + pointClassA.x + "," + pointClassA.y);
            Console.WriteLine("pointClassB : " + pointClassB.x + "," + pointClassB.y);


            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;

            pointStructB.x = 100;
            pointStructB.y = 200;

            Console.WriteLine("pointStructA : " + pointStructA.x + "," + pointStructA.y);
            Console.WriteLine("pointStructB : " + pointStructB.x + "," + pointStructB.y);

        }
    }
}
