using System;

namespace ConsoleApp3
{
    class Program
    {
        //Yapıcı Metotlar (Constructors)
        /*
         -Yapıcı metot public olmalıdır.
         -Yapıcı metodun geri dönüş değeri olmaz.
         -Yapıcı metodun ismi sınıf ismi ile aynı olmak zorundadır.

        Not:Statik yapıcı metot:
           -Normal yapıcıdan önce çalışan metottur.
           -ilgili sınıftan yapılan nesne taleplerinden ilkinde tetiklenir,sonrakilerde tetiklenmez.
          */
        static void Main(string[] args)
        {
            new Ornek();
            new Ornek();
            new Ornek();
            new Ornek();
            new Ornek();
            new Ornek();




        }
        class Ornek
        {
            public int x { get; set; }
            public Ornek()
            {
                Console.WriteLine("Nesne oluşturuldu");
            }

            public Ornek(int a,int b,int c)
            {

            }
            static Ornek()
            {
                Console.WriteLine("Yapıcıdan önce çalıştı.");
            }

        }
    }
}
