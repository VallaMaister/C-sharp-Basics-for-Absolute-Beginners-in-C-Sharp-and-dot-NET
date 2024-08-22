using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de asignación en C#

            int a;  // Declara una variable entera 'a'

            a = 10;  // Asigna el valor 10 a 'a'

            a += 5;  // Suma 5 al valor de 'a' y asigna el resultado a 'a'
            Console.WriteLine($"a += 5 : {a}");  // Imprime el valor de 'a' después de la operación (a = a + 5)

            a -= 5;  // Resta 5 al valor de 'a' y asigna el resultado a 'a'
            Console.WriteLine($"a -= 5 : {a}");  // Imprime el valor de 'a' después de la operación (a = a - 5)

            a *= 5;  // Multiplica el valor de 'a' por 5 y asigna el resultado a 'a'
            Console.WriteLine($"a *= 5 : {a}");  // Imprime el valor de 'a' después de la operación (a = a * 5)

            a /= 5;  // Divide el valor de 'a' entre 5 y asigna el resultado a 'a'
            Console.WriteLine($"a /= 5 : {a}");  // Imprime el valor de 'a' después de la operación (a = a / 5)

        }
    }
}
