using System;

namespace ConsoleApp17
{
    //Base class constraint
    //Base class constraint (temel sınıf kısıtlaması), generic sınıflar veya generic metotlar kullanırken, tür
    //parametresinin yalnızca belirli bir sınıfı veya sınıflar hiyerarşisinde bir sınıfı miras alan türleri kabul
    //etmesini sağlamak için kullanılan bir kısıtlamadır. Bu kısıtlama, belirli bir temel sınıfın alt sınıflarıyla sınırlı olmasını sağlar.
    //C#'ta where T : BaseClass şeklinde kullanılır. Bu, tür parametresi olarak sadece BaseClass veya onun türetilmiş sınıflarının kullanılmasına izin verir.
    //Özet:
    //Base class constraint, generic tür parametresini belirli bir temel sınıf veya onun alt sınıflarıyla sınırlamak için kullanılır.
    //Bu kısıtlama, sınıfın tür güvenliğini artırır ve sadece belirli sınıfların özelliklerine erişim sağlar.
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<A> m1 = new MyClass<A>();
            MyClass<B> m2 = new MyClass<B>();
            MyClass<C> m3 = new MyClass<C>();

        }

        class MyClass<T> where T:A
        {
            T t;
            public void X()
            {

            }
        }
        class A
        {

        }
        class B:A
        {

        }
        class C:B
        {

        }
        class Ds
        {

        }
    }
}
