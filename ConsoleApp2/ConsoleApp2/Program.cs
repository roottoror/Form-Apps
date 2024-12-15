using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(1,2);
            int Sonuc_one=dikdortgen.AlanHesapla();
            int Sonuc_two=dikdortgen.CevreHesapla();
            Console.WriteLine("Alanı:"+Sonuc_one+"Çevre:"+Sonuc_two);
            
        }
        class Dikdortgen
        {
            private int a, b;
            public Dikdortgen(int a,int b)
            {
                this.a = a;
                this.b = b;
            }
            public int AlanHesapla()
            {
                return a * b;
            }
            public int CevreHesapla()
            {
                return 2 * (a + b);
            }
        }
    }
}
