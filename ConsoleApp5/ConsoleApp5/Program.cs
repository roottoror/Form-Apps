using System;

namespace ConsoleApp5
{
    class Program
    {
        //This anahtar
        static void Main(string[] args)
        {
            Ornek o1 = new Ornek();
            o1.Deger = 123;
            Console.WriteLine(o1.Gonder().Deger);
            Console.Read();
        }

        class Ornek
        {
            public int Deger { get; set; }
            public Ornek Gonder()
            {
                return this;
            }
        }
    }
}
