using System;

namespace ConsoleApp11
{
    //base anahtar kelimesi, C# dilinde türetilmiş bir sınıfın içinden temel sınıfın üyelerine erişim sağlamak için kullanılır.
    //this anahtar kelimesi, mevcut sınıfın üyelerine erişmek için kullanılır.
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.OrnekMetod();
            Console.Read();
           
        }
    }
    class A
    {
        public virtual void OrnekMetod()
        {
            Console.WriteLine("Bu bir örnek metodtur.");
        }
    }
    class B:A
    {
        public override void OrnekMetod()
        {
            Console.WriteLine("Bu bir ezilmiş bir metodtur.");
            
        }

    }
}
