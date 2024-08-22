using System;

namespace MathematicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores matemáticos en C#

            int a = 10, b = 3;  // Declara dos variables enteras 'a' y 'b', y les asigna los valores 10 y 3, respectivamente

            // Suma de 'a' y 'b'
            Console.WriteLine($"a + b = {a + b}");  // Imprime la suma de 'a' y 'b' (10 + 3 = 13)

            // Resta de 'a' y 'b'
            Console.WriteLine($"a - b = {a - b}");  // Imprime la resta de 'a' y 'b' (10 - 3 = 7)

            // Multiplicación de 'a' y 'b'
            Console.WriteLine($"a * b = {a * b}");  // Imprime la multiplicación de 'a' y 'b' (10 * 3 = 30)

            // División de 'a' y 'b'
            Console.WriteLine($"a / b = {a / b}");  // Imprime la división entera de 'a' entre 'b' (10 / 3 = 3)

            // División con punto flotante
            float f = 11.0f;  // Declara una variable de punto flotante 'f' y le asigna el valor 11.0
            Console.WriteLine($"f / b = {f / b}");  // Imprime la división de 'f' entre 'b' (11.0 / 3 ≈ 3.6667)

            // Módulo de 'a' y 'b' (resto de la división entera)
            Console.WriteLine($"a % b = {a % b}");  // Imprime el resto de la división de 'a' entre 'b' (10 % 3 = 1)

        }
    }
}
