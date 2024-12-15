using System;

namespace ConsoleApp9
{
    //Kalıtım Örnek:
    class Program
    {
        static void Main(string[] args)
        {
            Erkek e = new Erkek();

            Kadın kadin=new Kadın();

            
            
        }
    }
    class Insan
    {
        public int Adi { get; set; }
        public int Soyadi { get; set; }
        public int Meslek { get; set; }
    }

    class Erkek:Insan
    {
        public int Sakal { get; set; }
    }
    class Kadın:Insan
    {
        public int Makyaj { get; set; }

    }
}
