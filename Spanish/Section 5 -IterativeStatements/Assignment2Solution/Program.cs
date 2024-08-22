using System;

namespace Assignment2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un fragmento de código en C# para leer un número entero positivo desde la consola e imprimir su valor factorial. 
            // El factorial de un número se refiere al producto de todos los números por debajo de él. 
            // Por ejemplo, 
            //  factorial(3) = 3 * 2 * 1 = 6
            //  factorial(5) = 5 * 4 * 3 * 2 * 1 = 120

            // Declaración de variables
            int a;
            int resultado = 1;  // Inicializar el resultado en 1

            // Leer la entrada y almacenarla en la variable 'a'
            string s = Console.ReadLine();
            a = int.Parse(s);  // Convertir la cadena de entrada a un número entero

            // Bucle para calcular el factorial
            while (a > 0)
            {
                resultado = resultado * a;  // Multiplicar el resultado por el valor actual de 'a'
                a--;  // Decrementar 'a' en 1
            }

            // Imprimir el resultado en la consola
            Console.WriteLine(resultado);

        }
    }
}
