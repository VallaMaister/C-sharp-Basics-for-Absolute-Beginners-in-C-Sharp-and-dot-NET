using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            // Escribe un fragmento de código en C# para declarar un carácter y asignar el valor 'C'.
            // Imprime el mismo en la consola.
            char ch;
            ch = 'C';
            Console.WriteLine(ch);

            // Ejercicio 2
            // Escribe un fragmento de código en C# para leer un nombre como una cadena desde la consola
            // e imprimir "Hola, " junto con el nombre en la consola.
            string str;
            Console.WriteLine("Ingresa tu nombre: ");
            str = Console.ReadLine();
            Console.WriteLine("Hola, " + str);

            // Ejercicio 3
            // Reescribe la solución del Ejercicio 2 para usar interpolación de cadenas ('$')
            // para combinar dos cadenas en lugar de usar el símbolo '+'.
            string str2;
            Console.Write("Ingresa tu nombre: ");
            str2 = Console.ReadLine();
            Console.WriteLine($"Hola, {str2}");

        }
    }
}
