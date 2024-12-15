using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizilerin olumsuz yönleri:
            //Eleman sayısını önceden belirtmemiz gerekiyor.
            //Elemanları atamasak dahi bellekte yerleri ayrılıyor.
            //Performans açısından zayıf.
            //Eleman atarken yahut okurken kod maliyeti vb vb..

            //Koleksiyonlar yukarıdan bahsedilen durumların tam tersi bu console örneğinde 2 koleksiyon türünden 
            //bahsedicez ilki Arraylist diğeri list koleksiyonudur.
            #region Arraylist
            /*
            ArrayList liste = new ArrayList();
            liste.Add("Bulut");
            liste.Add(100);
            liste.Add(true);
            foreach (var item in liste)
            {
                if(item is int)
                {
                    Console.WriteLine((int)item+120);
                }
            }
            */




            #endregion
            #region list
            List<int> liste = new List<int>();
            liste.Add(15);
            liste.Add(20);
            liste.Add(25);
            liste.Add(30);
            liste.Add(35);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
