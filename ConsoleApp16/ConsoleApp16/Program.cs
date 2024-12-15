using System;

namespace ConsoleApp16
{
    class Program
    {
        //Generic class, belirli bir türden bağımsız olarak çalışabilen ve farklı türlerle yeniden kullanılabilir bir
        //yapı sağlayan sınıftır. Generic sınıflar, sınıfın içindeki veri türlerini parametre olarak alır. Bu sayede
        //aynı sınıf birden fazla türle çalışabilir, böylece hem kod tekrarını azaltır hem de daha esnek bir yapı sunar.
        //C#'da generic bir sınıf, <T> gibi bir tür parametresi ile tanımlanır. T, tür parametresini ifade eder, ancak bu isim özelleştirilebilir (T, U, K gibi).

        static void Main(string[] args)
        {
            MyClass<Ornek> m1 = new MyClass<Ornek>();
        }
        class MyClass<T>
        {
            T t;
        }
        class Ornek
        {

        }
    }
}
