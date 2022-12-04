using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба
{
    internal class Class4
    {
        public int x;
        public Class4()
        {

        }
        public Class4(int x)
        {
            this.x = x;
        }
        public Class4(Class4 x)
        {
            X = x.X;
        }

        public int X { get; set; }
        public object Clone()
        {
            return new Class2(x);
        }

        static void Ma(string[] args)
        {
           //Point point = new Point(5);
            //Point point1 = (Point)point.Clone();
            //Console.WriteLine(point1.x);
        }
    }
}
