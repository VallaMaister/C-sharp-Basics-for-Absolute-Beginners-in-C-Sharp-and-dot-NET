using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;  // Declarar una variable entera para almacenar la entrada del usuario

            Console.WriteLine("Introduce un número: ");  // Pide al usuario que introduzca un número
            input = int.Parse(Console.ReadLine());  // Convierte la entrada del usuario a un número entero

            // Bucle While
            Console.WriteLine("Bucle While");
            int i = 0;  // Inicializa la variable 'i' en 0
            while (i < input && i < 5)  // Mientras 'i' sea menor que 'input' y menor que 5
            {
                Console.WriteLine(i);  // Imprime el valor de 'i'
                i++;  // Incrementa 'i' en 1
            }

            // Bucle Do While
            i = 0;  // Reinicia la variable 'i' a 0
            Console.WriteLine("Bucle Do While");
            do
            {
                Console.WriteLine(i);  // Imprime el valor de 'i'
                i++;  // Incrementa 'i' en 1
            } while (i < input && i < 5);  // Mientras 'i' sea menor que 'input' y menor que 5

            // Bucle For
            Console.WriteLine("Bucle For");
            for (int j = 0; j < input && j < 5; j++)  // Itera desde 0 hasta 'input' o 5, el que sea menor
            {
                Console.WriteLine(j);  // Imprime el valor de 'j'
            }
            Console.WriteLine("¡Fin del programa!");  // Imprime un mensaje indicando el final del programa

        }
    }
}
