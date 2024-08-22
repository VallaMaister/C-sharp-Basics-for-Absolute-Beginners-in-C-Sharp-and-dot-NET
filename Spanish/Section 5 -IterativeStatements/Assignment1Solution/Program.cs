using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un fragmento de código en C# para leer un número positivo desde la consola e imprimir la cantidad total de dígitos que tiene.
            // Por ejemplo, 135 --> 3, 90 --> 2, 98788 --> 5
            // Nota: Puedes usar la función int.Parse(string) para convertir una cadena en un entero.

            // Declarar las variables
            int i = 0;
            int count = 0;

            // Leer la entrada y almacenarla en la variable 'i'
            string input = Console.ReadLine();
            i = int.Parse(input);

            // Bucle para contar los dígitos, dividiendo cada vez por 10.
            do
            {
                count++;  // Incrementar el contador de dígitos
                i = i / 10;  // Dividir 'i' por 10 para eliminar el último dígito
            } while (i > 0);  // Continuar hasta que 'i' sea 0

            // Imprimir el resultado en la consola
            Console.WriteLine(count);

        }
    }
}
