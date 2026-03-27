

using System;

namespace Guia0
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio1();
           // Ejercicio2();
           // Ejercicio3();
           //Ejercicio4();
           //Ejercicio5();
           //Ejercicio6();
           Ejercicio7();
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

        public static void Ejercicio2()
        {
            int limite = 990;

            for (int i = 1; i <= limite; i++)
            {
                int contadorDivisores = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    { contadorDivisores++; }
                }

                if (contadorDivisores == 2 && i % 3 == 0)
                {
                    Console.WriteLine(i + " es primo y divisble por 3 ");
                }
                else if (contadorDivisores == 2)
                {
                    Console.WriteLine(i + " es primo");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " es divisble por 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabraOriginal = Console.ReadLine();

            char[] caracteres = palabraOriginal.ToCharArray(); //Con un array de caracteres divide la palabra en caracteres. 
            Array.Reverse(caracteres); //Voltea el array. 
            string palabraInvertida = new string(caracteres); // convierte el array a la palabra. 

            if (palabraOriginal == palabraInvertida)
            {
                Console.WriteLine(palabraOriginal + " es un palindromo.");
            }
            else
            {
                Console.WriteLine(palabraOriginal + " no es un palindromo.");
            }
        }

        public static void Ejercicio4()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string p1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra palabra: ");
            string p2 = Console.ReadLine();

            if (p1.Length != p2.Length)
            {
                Console.WriteLine(p1 + " y " + p2 + " NO son anagramas");
                return;
            }

            char[] c1 = p1.ToCharArray();
            char[] c2 = p2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string s1 = new string(c1);
            string s2 = new string(c2);

            if (s1 == s2)
            {
                Console.WriteLine(s1 + " y " + s2 + " son anagramas.");
            }
            else
            {
                Console.WriteLine(s1 + " y " + s2 + " NO son anagramas.");
            }

        }

        public static void Ejercicio5()
        {
            bool flag;
            do
            {
                flag = false;
                Console.WriteLine("Ingrese un numero de 5 cifras: ");
                string numero = Console.ReadLine();

                if (numero.Length != 5 || !int.TryParse(numero, out int salidaNumero))
                {
                    Console.WriteLine("Error. Ingrese un numero de 5 cifras.");
                }
                else
                {
                    char[] arrayLetras = numero.ToCharArray();
                    Array.Reverse(arrayLetras);
                    string invertido = new string(arrayLetras);

                    Console.WriteLine("El numero invertido es " + invertido);

                    flag = true;
                }
            } while (!flag);
            
        }

        public static void Ejercicio6()
        {
            float nA, nB;
            bool flagA = false;
            bool flagB = false;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroA = Console.ReadLine();

                if (float.TryParse(numeroA, out nA))
                {
                    flagA = true;
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero.");
                }
            } while (!flagA);

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroB = Console.ReadLine();

                if (float.TryParse(numeroB, out nB))
                {
                    flagB = true;
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero.");
                }
            } while (!flagB);

            float resultado = (nA + nB) * (nA - nB);

            Console.WriteLine("El resultado es " + resultado);
        }
        public static void Ejercicio7()
        {
            int[] numeros = new int[5];
            int i = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                string n = Console.ReadLine();

                if (!int.TryParse(n, out int num))
                {
                    Console.WriteLine("Error. Ingrese un numero.");
                }
                else
                {
                    numeros[i] = num;
                    i++;
                }
            } while (i < 5);

            Array.Sort(numeros);

            int mayor = numeros[4]; 
            int intermedio = numeros[2];
            int menor = numeros[0];

            Console.WriteLine("De los numeros ingresados, el mayor es " + mayor + 
                ", el menor es " + menor + " y el intermedio es " + intermedio);
        }

        public static void Ejercicio8()
        {

        }
    }
}