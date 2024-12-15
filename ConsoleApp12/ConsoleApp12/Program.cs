using System;

namespace ConsoleApp12
{
    class Program
    {
        //Polimorfizm(çok biçimlilik):
        static void Main(string[] args)
        {
            A a = new B();
            B b = (B)a;
            

        }
    }
    class A
    {
        public int X { get; set; }
    }
    class B:A
    {
        public int Y { get; set; }
    }
}
