using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un fragmento de código en C# para leer un número entero e imprimirlo si es divisible por 3.
            // Nota: Puedes usar la función int.Parse(string) para convertir una cadena en un entero.

            // Leer la entrada desde la consola
            string input = Console.ReadLine();

            // Convertir la cadena de entrada a un número entero
            int a = int.Parse(input);

            // Verificar si es divisible por 3
            if (a % 3 == 0)
            {
                Console.WriteLine("El número ingresado es divisible por 3");
            }
            else
            {
                Console.WriteLine("El número ingresado NO es divisible por 3");
            }


        }
    }
}
