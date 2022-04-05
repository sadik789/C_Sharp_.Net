using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implement_Hierarchical_Inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a=10;
        }
    }
    class B:A
    {
        public int b;
        public B()
        {
           b=15;
        }
    }
        class C:A
        {
            public int c;
            public C()
            {
                c=20;
            }
        }
    class program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierchical Inheritance :");
            B obj1 = new B();
            C obj2 = new C();
            Console.WriteLine("Using Class B object(obj1)");
            Console.WriteLine("a={0}", obj1.a);
            Console.WriteLine("b={0}", obj1.b);
            Console.WriteLine("Using Class C ject(obj2");
            Console.WriteLine("a={0}", obj2.a);
            Console.WriteLine("b={0}", obj2.c);

            Console.ReadKey();
        }
    }
}
