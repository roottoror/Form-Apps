using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
        }
        class A
        {
            public A(string x)
            {

            }
        }
        class B:A
        {
            public B(bool x):base("abc")
            {

            }

        }
        class C:B
        {
            public C():base(true)
            {

            }

        }
    }
}
