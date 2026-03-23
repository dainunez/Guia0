

using System;

namespace Guia0
{
    class Program
    {
       static void Main(string[] args)
        {
            Ejercicio1();
        }
        public static void Ejercicio1()
        {
            int limite = 990;

            for (int i = 1; i <= limite; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}