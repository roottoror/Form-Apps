﻿using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan[3] = "Bulut";
            insan[5] = "Haydar";
            Console.WriteLine(insan[3]);
            Console.WriteLine(insan[5]);


            Console.Read();
            

        }
        class Insan
        {
            string[] Isimler = new string[10];
            public string this[int i]
            {
                get
                {
                    return Isimler[i];
                }
                set
                {
                    Isimler[i] = value;
                }
            }

        }
        class Ornek
        {
            //Indexer
            public string this[int index]
            {
                get
                {
                    return "";
                }
                set
                {

                }
            }

        }
    }
}
