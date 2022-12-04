using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба
{
    internal class Class2
    {
        public int x = 5;
        public Class2()
        {

        }
        public Class2(int x)
        {
            this.x = x;
        }
        public Class2(Class2 x)
        {
            X = x.X;
        }

        public int X { get; set; }
        public object Clone()
        {
            return new Class2(this.x);
        }
    }
}
