namespace Ejercicios_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        {
                            Suma();
                        }
                        break;
                    case 2:
                        {
                            Nombre();
                        }
                        break;
                    case 3:
                        {
                            Edad();
                        }
                        break;
                    case 4:
                        {
                            CargaNumeros();
                        };
                        break;
                    case 5:
                        {
                            AdivinarNumero();
                        }
                        break;
                    case 6:
                        {
                            ContarPalabrasyVocales();
                        }
                        break;
                    case 7:
                        {
                            PalabraPolíndromo();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("¡Hasta luego!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }

            } while (opcion != 8);

        }

        //Ejericio 1: saludo al nombre introducido.
        static void Nombre()
        {
            Console.Write("Cual es tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Un gusto conocerte, " + nombre);
        }

        //Ejercicio 2: cálculo de la edad.
        static void Edad()
        {
            Console.WriteLine("Ingrese su año de nacimiento");
            int year = Convert.ToInt32(Console.ReadLine());
            int edad = 2024 - year;
            Console.WriteLine("Su edad es: " + edad);
        }

        //Ejercicio 3: suma de dos números.
        static void Suma()
        {
            int respuesta, val1, val2 = 0;
            Console.WriteLine("Ingrese el primer número:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            val2 = Convert.ToInt32(Console.ReadLine());
            respuesta = val1 + val2;
            Console.WriteLine("Sumatoria: " + respuesta);
        }

        // Ejercicio 1 presentación:
        // Escribir un programa que solicite la carga de valores positivos,
        // hasta que el usuario ingrese un cero, luego muestre cual fue el 
        // numero mayor ingresado y el menor.
        static void CargaNumeros()
        {
            int numero;
            int mayor = int.MinValue;
            int menor = int.MaxValue;

            do
            {
                Console.Write("Ingresa un número (ingresa 0 para salir): ");

                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine("Por favor, ingresa un número positivo.");
                    Console.Write("Ingresa un número (ingresa 0 para salir): ");
                }

                if (numero != 0)
                {

                    mayor = Math.Max(mayor, numero);
                    menor = Math.Min(menor, numero);
                }

            } while (numero != 0);

            if (mayor != int.MinValue && menor != int.MaxValue)
            {
                Console.WriteLine($"El número mayor ingresado fue: {mayor}");
                Console.WriteLine($"El número menor ingresado fue: {menor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
            }
        }

        // Ejercicio 2 presentación:
        // Adivinar el número que piensa el usuario.
        static void AdivinarNumero()
        {
            int respuesta, val1, val2;
            Console.WriteLine("Hola, primero piense en un número");
            Console.WriteLine("\n");
            Console.WriteLine("Al número que usted pensó multipliquelo por 2");
            Console.WriteLine("\n");
            Console.WriteLine("Al resultado sumele 8");
            Console.WriteLine("\n");
            Console.WriteLine("Por ultimo al resultado multipliquelo por 5");
            Console.WriteLine("\n");
            Console.WriteLine("Ahora, ingrese el resultado final de las operaciones");
            val1 = Convert.ToInt32(Console.ReadLine());

            val2 = val1 / 10;
            respuesta = val2 - 4;
            Console.WriteLine("El Numero en el que pensó es: " + respuesta);
        }

        //Ejercicio 3 presentación:
        //Contador de palabras y vocales de una frase que el usuario ingrese.
        static void ContarPalabrasyVocales()
        {
            Console.Write("Ingresa una frase o una oración: ");
            string Palabra = Console.ReadLine();

            int cantidadPalabras = ContarPalabras(Palabra);

            Console.WriteLine($"La cantidad de palabras en la frase es: {cantidadPalabras}");

            static int ContarPalabras(string texto)
            {
                string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                return palabras.Length;
            }

            int cantidadVocales = ContarVocales(Palabra);

            Console.WriteLine($"La cantidad de vocales en la frase es: {cantidadVocales}");

            static int ContarVocales(string texto)
            {

                texto = texto.ToLower();

                int contadorVocales = 0;

                foreach (char caracter in texto)
                {
                    if (EsVocal(caracter))
                    {
                        contadorVocales++;
                    }
                }

                return contadorVocales;
            }

            static bool EsVocal(char letra)
            {

                return "aeiou".Contains(letra);
            }

        }

        //Ejercicio 4 presentación:
        //Detectar que palabras que el usuario ingresa son y no son políndromos.
        static void PalabraPolíndromo()
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
            {
                Console.WriteLine($"{palabra} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palabra} no es un palíndromo.");
            }


            static bool EsPalindromo(string palabra)
            {

                palabra = palabra.ToLower();

                int longitud = palabra.Length;

                for (int i = 0; i < longitud / 2; i++)
                {
                    if (palabra[i] != palabra[longitud - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione la opción que desea realizar: ↓");
            Console.WriteLine("\n");
            Console.WriteLine("---------------------- MENÚ -----------------------");
            Console.WriteLine("1. Suma de dos números.");
            Console.WriteLine("2. Un saludo.");
            Console.WriteLine("3. Cálculo de edad");
            Console.WriteLine("4. Número mayor y menor de una serie de números introducidos");
            Console.WriteLine("5. Adivinar el número en el que piensas.");
            Console.WriteLine("6. Contador de palabras y vocales de una frase.");
            Console.WriteLine("7. Ver si una palabra que ingreses es o no es políndromo");
            Console.WriteLine("8. Salir");
            Console.WriteLine("---------------------------------------------------");
        }

        static int ObtenerOpcion()
        {
            Console.Write("Elige una opción: ");
            int opción;
            while (!int.TryParse(Console.ReadLine(), out opción))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                Console.Write("Elige una opción: ");
            }
            return opción;
        }
    }
}
