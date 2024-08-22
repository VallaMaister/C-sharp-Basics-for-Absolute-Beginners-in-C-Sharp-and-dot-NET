using System;

namespace Assignment3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un fragmento de código en C# para imprimir solo los números de un array que contiene tanto valores enteros como cadenas. 
            // Por ejemplo, 
            //  { "2", "Red", "67" } --> 2, 67
            //  { "Hello", "45", "12", "Rose" } --> 45, 12

            // Declaración del array
            string[] array = new string[] { "2", "Red", "67" };  // Un array de cadenas con valores mixtos

            int value;  // Variable para almacenar el valor numérico convertido

            // Iterar a través de cada elemento del array y verificar si es un valor numérico
            for (int j = 0; j < array.Length; j++)
            {
                // Intenta convertir el elemento actual a un entero
                if (int.TryParse(array[j], out value))
                {
                    // ¡Se encontró un valor numérico! Imprimirlo en la consola
                    Console.WriteLine(value);  // Imprime el valor numérico encontrado
                }
            }

        }
    }
}
