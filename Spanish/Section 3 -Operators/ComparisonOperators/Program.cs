using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de comparación en C#

            int a = 60;  // Declara una variable entera 'a' y le asigna el valor 60

            Console.WriteLine($"a : {a}");  // Imprime el valor de 'a'

            // Operador de igualdad (==) - Verifica si 'a' es igual a 50
            Console.WriteLine($"a == 50 : {a == 50}");  // Imprime el resultado de 'a == 50' (false)

            // Operador de desigualdad (!=) - Verifica si 'a' es diferente de 50
            Console.WriteLine($"a != 50 : {a != 50}");  // Imprime el resultado de 'a != 50' (true)

            // Operador mayor que (>) - Verifica si 'a' es mayor que 50
            Console.WriteLine($"a > 50 : {a > 50}");  // Imprime el resultado de 'a > 50' (true)

            // Operador menor que (<) - Verifica si 'a' es menor que 50
            Console.WriteLine($"a < 50 : {a < 50}");  // Imprime el resultado de 'a < 50' (false)


        }
    }
}
