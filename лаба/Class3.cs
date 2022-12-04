using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба
{
    internal class Class3
    {
        public int x;
        public Class3()
        {

        }
        public Class3(int x)
        {
            this.x = x;
        }
        public Class3(Class3 x)
        {
            X = x.X;
        }

        public int X { get; set; }
        public object Clone()
        {
            return new Class3(this.x);
        }
    }
}
