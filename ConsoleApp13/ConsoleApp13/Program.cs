using System;

namespace ConsoleApp13
{
    class Program
    {
       //abstract class'ın nesnesi oluşturulmaz! Referans noktası alınabilir.
       //abstract, soyut bir sınıfta yer alan ve türetilen sınıflar tarafından zorunlu olarak uygulanması gereken bir metot olduğunu belirtir. Soyut metotlar gövde içermez.
       //Kullanım Kuralları:
       //abstract metotlar, yalnızca soyut(abstract) sınıflar içinde tanımlanabilir.
       //Bu metot, türetilmiş sınıflar tarafından override edilmelidir.
        static void Main(string[] args)
        {

        }

        abstract class Ornek
        {
            abstract public void X();
            abstract public int Y { get; set; }
            abstract public bool Z();
           
        class Calisma : Ornek
        {
            public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void X()
            {
                throw new NotImplementedException();
            }

            public override bool Z()
            {
                throw new NotImplementedException();
            }
        }
    }
}
