using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface'de nesne oluşturulamaz ama referans noktası oluşturalabilir.
            //Interface'ler kendisinden kalıtılım alan sınıfların içerisinden olması zorunlu olan yapıları tanımlayan bir yapıydı.
        
        }
      
        interface IOrnek
        {
            int X();
            int OrnekProperty { get; set; }
            void Y();

        }
        class Ornek : IOrnek
        {
            //imzalarda public,private,protected vs gibi erişim belirleyicileri olmaz.
            public int OrnekProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int X()
            {
                throw new NotImplementedException();
            }

            public void Y()
            {
                throw new NotImplementedException();
            }
        }
    }
}
