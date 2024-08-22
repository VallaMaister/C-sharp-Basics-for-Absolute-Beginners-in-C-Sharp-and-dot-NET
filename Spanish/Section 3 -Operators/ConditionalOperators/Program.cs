using System;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores condicionales en C#

            bool a = false;  // Declara una variable booleana 'a' y la inicializa en 'false'
            bool b = true;   // Declara una variable booleana 'b' y la inicializa en 'true'

            // Imprime el valor de 'a' y 'b'
            Console.WriteLine($"a  b : {a} {b}");  // Imprime "a  b : false true"

            // Operador AND (&&) - Ambas condiciones deben ser verdaderas para que el resultado sea verdadero
            Console.WriteLine($"a && b : {a && b}");  // Imprime el resultado de 'a && b' (false && true = false)

            // Operador OR (||) - Al menos una condición debe ser verdadera para que el resultado sea verdadero
            Console.WriteLine($"a || b : {a || b}");  // Imprime el resultado de 'a || b' (false || true = true)

            // Cambia los valores de 'a' y 'b' a true
            a = true;
            b = true;

            // Imprime el valor de 'a' y 'b'
            Console.WriteLine($"a  b : {a} {b}");  // Imprime "a  b : true true"

            // Operador AND (&&) con ambos valores verdaderos
            Console.WriteLine($"a && b : {a && b}");  // Imprime el resultado de 'a && b' (true && true = true)

            // Operador OR (||) con ambos valores verdaderos
            Console.WriteLine($"a || b : {a || b}");  // Imprime el resultado de 'a || b' (true || true = true)

            // Cambia los valores de 'a' y 'b' a false
            a = false;
            b = false;

            // Imprime el valor de 'a' y 'b'
            Console.WriteLine($"a  b : {a} {b}");  // Imprime "a  b : false false"

            // Operador AND (&&) con ambos valores falsos
            Console.WriteLine($"a && b : {a && b}");  // Imprime el resultado de 'a && b' (false && false = false)

            // Operador OR (||) con ambos valores falsos
            Console.WriteLine($"a || b : {a || b}");  // Imprime el resultado de 'a || b' (false || false = false)


        }
    }
}
