

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
           //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            //Ejercicio13();
            //Ejercicio14();
            Ejercicio15();
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
            Console.WriteLine("Por favor ingrese una fecha en formato dd/mm/aaaa: ");
            string fecha = Console.ReadLine();

            if(DateTime.TryParse (fecha, out DateTime date))
            {
                DateTime hoy = DateTime.Now;
                TimeSpan diferencia = date - hoy;

                int DiasTotales = Math.Abs(diferencia.Days);

                Console.WriteLine("La diferencia entre la fecha ingresada y el dia de hoy es de " + diferencia + " dias.");
            }
            else
            {
                Console.WriteLine("Error. Ingrese una fecha valida.");
            }
        }
        public static void Ejercicio9()
        {
            Console.WriteLine("Por favor ingrese su nombre: "); 
            string nombreUsuario = Console.ReadLine();

            if (nombreUsuario == "Daiana")
            {
                Console.WriteLine("¡Hola, Daiana!");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }

        public static void Ejercicio10()
        {
            Console.WriteLine("Ingrese un solo caracter: ");
            string entrada = Console.ReadLine();

            char c = char.ToLower(entrada[0]);

            if (c >= 0 && c <=9)
            {
                Console.WriteLine("Es una cifra numerica.");
            }
            else if (char.IsLetter(c))
            {
                if (c=='a' || c=='e'||c=='i'||c=='o'||c=='u')
                {
                    Console.WriteLine("Es una vocal");
                }
                else
                {
                    Console.WriteLine("Es una consonante");
                }
            }
            else
            {
                Console.WriteLine("Es un caracter especial");
            }
        }

        public static void Ejercicio11()
        {
            Console.WriteLine("Ingrese nombre, apellido y edad en cualquier orden: ");
            string input = Console.ReadLine();

            string [] partes = input.Split(' ');

            string nombre = "";
            string apellido = "";
            int edad = 0; 

            foreach (string dato in partes)
            {
                if (dato == "") continue; 

                if(int.TryParse(dato, out int num))
                {
                    edad = num;
                }
                else if (nombre == "")
                {
                    nombre = dato;
                }
                else 
                {
                    apellido = dato;
                }
            }
            Console.WriteLine($"Nombre:{nombre}, Apellido: {apellido}, Edad: {edad}");
        }
        public static void Ejercicio12()
        {
            bool flag = false;
            DateTime f1, f2;
            do
            {
                Console.WriteLine("Por favor ingrese una fecha en formato dd/mm/aaaa: ");
                string fecha1 = Console.ReadLine();

                if (!DateTime.TryParse(fecha1, out f1))
                {
                    Console.WriteLine("Error. La fecha 1 es invalida.");
                }
                else
                {
                    flag = true;
                }

            } while (!flag);

            bool flag2 = false;
            do
            {
                Console.WriteLine("Por favor ingrese una segunda fecha en formato dd/mm/aaaa: ");
                string fecha2 = Console.ReadLine();

                if (!DateTime.TryParse(fecha2, out f2))
                {
                    Console.WriteLine("Error. La fecha 2 es invalida.");
                }
                else
                {
                    flag = true;
                }

            } while (!flag);

            TimeSpan diferencia = f1 - f2;

            int DiasTotales = Math.Abs(diferencia.Days);

            int años = DiasTotales / 365;
            int restoDias = DiasTotales % 365;
            int meses = restoDias / 30;
            int dias = restoDias % 30;

            Console.WriteLine($"La diferencia entre las fechas es de {años} años, {meses} meses y {dias} dias.");
        }

        public static void Ejercicio13()
        {
            Console.WriteLine("Ingrese un numero para calcular su factorial: ");
            int numero = int.Parse (Console.ReadLine());

            long resultado = 1; 

            for(int i = 1; i <=numero; i++)
            {
                resultado *= i; // o resultado = resultado * i;
            }
            Console.WriteLine($"El factorial de {numero} es {resultado}");

        }

        public static void Ejercicio14()
        {
            Console.WriteLine("Ingrese un numero: ");
            string numero = Console.ReadLine();
            if (int.TryParse(numero, out int salida))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = salida * i;
                    Console.WriteLine($"{salida} x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido.");
            }            
        }
        public static void Ejercicio15()
        {
            string clave = "daiana";

            for (int intento = 1;intento <= 3;intento++)
            {
                Console.WriteLine("Ingrese la clave: ");
                string entrada = Console.ReadLine();

                if (entrada == clave )
                {
                    Console.WriteLine("Bienvenido al sistema.");
                    break;
                }
                else if (intento < 3)
                {
                    Console.WriteLine("Clave incorrecta. Intente de nuevo.");
                }
                else 
                {
                    Console.WriteLine("Clave Bloqueada.");
                }
            }
        }
    }
}