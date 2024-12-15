using System;

namespace ConsoleApp8
{
    //Kalıtım(inheritance)=miras alma
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            B b = new B();
            //C c= new C();

            Console.Read();
        }

    }
    class A
    {
        public A()
        {
            Console.WriteLine("A nesnesi üretildi");
        }
        public void X() { }
        public int Y { get; set; }
        public bool Z;
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("B nesnesi üretildi");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("C nesnesi üretildi");
        }

    }
}
