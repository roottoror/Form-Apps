using System;

namespace ConsoleApp18
{
    class Program
    {
        //new constraint (yeni kısıtlama), C#'ta generic tür parametrelerinin yalnızca parametreli
        //bir kurucuya sahip sınıflarla kullanılmasını sağlayan bir kısıtlamadır. Bu kısıtlama, tür parametresinin parametresiz bir
        //kurucuya sahip olmasını zorunlu kılar. Bununla birlikte, bu kısıtlama, sadece parametresiz kurucuları olan türlerin generic
        //sınıflarda veya metotlarda kullanılmasını sağlar.

        static void Main(string[] args)
        {
          
        }
        class MyClass<T> where T:new()
        {
            public void X() {
                T t = new T();
            }

        }
        class MyClass2
        {

        }
    }
}
