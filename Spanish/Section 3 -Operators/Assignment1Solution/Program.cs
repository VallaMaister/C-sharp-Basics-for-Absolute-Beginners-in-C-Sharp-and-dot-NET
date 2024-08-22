using System;

namespace Assignment1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Escribe un programa en C# para calcular (a-b)^2 leyendo los valores de a y b desde la consola.
            // Por ejemplo,
            //    (5-3)^2 = 4
            //    (10-6)^2 = 16
            // Nota: La fórmula de (a-b)^2 es (a x a) + (b x b) - (2 x a x b)

            // Leer los dos números y asignarlos a a y b.
            Console.WriteLine("Introduce el primer número: ");
            int a = int.Parse(Console.ReadLine());  // Lee y convierte la entrada en un entero para 'a'
            Console.WriteLine("Introduce el segundo número: ");
            int b = int.Parse(Console.ReadLine());  // Lee y convierte la entrada en un entero para 'b'

            // Realizar el cálculo según la fórmula
            int result = (a * a) + (b * b) - (2 * a * b);  // Calcula el resultado de (a-b)^2 utilizando la fórmula
            Console.WriteLine($"Resultado: {result}");  // Imprime el resultado en la consola

        }
    }
}
