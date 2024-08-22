using System;

namespace UnaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores unarios en C#

            int a, b;  // Declara dos variables enteras 'a' y 'b'

            a = 10;    // Asigna el valor 10 a 'a'
            b = ++a;   // Aplica el operador de incremento prefijo a 'a' y asigna el valor a 'b'
            Console.WriteLine($"Prefijo ++ , a = {a}, b = {b}");  // Imprime 'a' y 'b' después de la operación

            a = 10;    // Reasigna el valor 10 a 'a'
            b = a++;   // Aplica el operador de incremento sufijo a 'a' y asigna el valor a 'b'
            Console.WriteLine($"Sufijo ++ , a = {a}, b = {b}");  // Imprime 'a' y 'b' después de la operación

            a = 10;    // Reasigna el valor 10 a 'a'
            b = --a;   // Aplica el operador de decremento prefijo a 'a' y asigna el valor a 'b'
            Console.WriteLine($"Prefijo -- , a = {a}, b = {b}");  // Imprime 'a' y 'b' después de la operación

            a = 10;    // Reasigna el valor 10 a 'a'
            b = a--;   // Aplica el operador de decremento sufijo a 'a' y asigna el valor a 'b'
            Console.WriteLine($"Sufijo -- , a = {a}, b = {b}");  // Imprime 'a' y 'b' después de la operación

        }
    }
}
