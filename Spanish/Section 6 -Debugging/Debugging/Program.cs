using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Depuración
            //  - Proceso de localizar errores/problemas y eliminarlos utilizando herramientas de depuración.
            //  - ¡Usualmente toma más tiempo depurar que programar!
            //  - La depuración es parte de la vida diaria de todos los programadores.

            // Imprimir todos los números pares menores de 10
            PrintEvenNumbers();
        }

        static void PrintEvenNumbers()
        {
            int input = 10;  // Definir el límite superior (10)
            int i = 1;  // Inicializar el contador en 1

            while (i < input)
            {
                bool result = ((i % 2) == 0);  // Verificar si 'i' es divisible por 2, lo que indica que es un número par
                if (result)  // Si es un número par
                {
                    // Se encontró un número par.
                    // Imprimirlo.
                    Console.WriteLine(i);
                }
                i++;  // Incrementar el contador
            }
        }

    }
}
