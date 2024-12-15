using System;

namespace ConsoleApp15
{
    class Program
    {
        //C# 8.0 ile birlikte, default implementations (varsayılan uygulamalar) özelliği eklenmiştir. Artık bir interface içinde metot gövdesi tanımlanabilir. Ancak bu metotlar, varsayılan bir davranış sunar ve gerekirse uygulayan sınıf tarafından override edilebilir.
        //Bu tür metotlara default metot denir.
        static void Main(string[] args)
        {
            Ornek o = new Ornek();
            IA a = new Ornek();
            IB b = new Ornek();
            
        }
        interface IA
        {
            void x();
            void y();
            void z();
        }
        interface IB
        {
            void x();
            void m();
            void n();
        }
        class Ornek :C, IA, IB // 2 tane bulunan interface kalıtım yani miras aldırdık.
        {
            void IB.m()
            {
                throw new NotImplementedException();
            }

            void IB.n()
            {
                throw new NotImplementedException();
            }

            void IA.x()
            {
                throw new NotImplementedException();
            }

            void IB.x()
            {
                throw new NotImplementedException();
            }

            void IA.y()
            {
                throw new NotImplementedException();
            }

            void IA.z()
            {
                throw new NotImplementedException();
            }
        }
        class C
        {
            public int MyProperty { get; set; }
        }
    }
}
