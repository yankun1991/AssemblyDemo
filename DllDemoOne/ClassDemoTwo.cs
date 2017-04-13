using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllDemoOne
{
    public class ClassDemoTwo
    {
        public int A { get; set; }

        public int B { get; set; }

        public ClassDemoTwo()
        {
        }

        public ClassDemoTwo(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
