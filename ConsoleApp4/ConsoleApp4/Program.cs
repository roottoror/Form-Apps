using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i < 10; i++)
            {
                new Ornek(i);
                Console.WriteLine("*********");
                GC.Collect();
            }
        }

        class Ornek
        {
            int numara;
            public Ornek(int id)
            {
                numara = id;
                Console.WriteLine(numara + "Nesne üretildi");
            }

            //Destructor(Yıkıcı Metot)
            ~Ornek(){
                Console.WriteLine(numara + " Nesne siliniyor");
            }
        }
    }
}
