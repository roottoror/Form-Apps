using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //PROPERTY(Özellik) KAVRAMI:
        //Sınıf içerisindeki field(alan)'ları dışarı kontrollü bir şekilde açmamızı sağlayan yapılardır.
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek();
            ornek.Adi = "Bulut";

            Console.WriteLine(ornek.Adi);
            Console.WriteLine(ornek.Sayi);
            Console.ReadLine();

            
            


        }
        class Ornek
        {
            //fielde
            string adi;
            public string Adi//Property
            {
                get
                {
                    return adi.Substring(0,5);
                }
                set
                {
                    adi = value.ToUpper();
                }
            }

            //Auto property Initializers
            public int Sayi { get; set; } = 123;

        }
    }
}
