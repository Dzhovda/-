using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба
{
    internal class Class1
    {
        public int x;
        public Class1()
        {

        }
        public Class1(int x)
        {
            this.x = x;
        }
        public Class1(Class1 x)
        {
            X = x.X;
        }

        public int X { get; set; }
        public object Clone()
        {
            return new Class1(this.x);
        }
    }
}
