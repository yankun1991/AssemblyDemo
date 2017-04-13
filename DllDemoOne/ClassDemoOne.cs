using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllDemoOne
{
    public class ClassDemoOne
    {
        public int A { get; set; }

        public int B { get; set; }

        public ClassDemoOne(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public ClassDemoOne()
        {
        }

        public int Sum()
        {
            return this.A + this.B;
        }
    }
}
