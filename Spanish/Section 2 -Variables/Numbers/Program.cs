using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Números enteros
            int i = 10; // Declara un número entero 'i' y le asigna el valor 10
            Console.WriteLine(i); // Imprime el valor de 'i'

            int j = int.Parse(Console.ReadLine()); // Lee un número desde la consola y lo convierte a entero
            Console.WriteLine(j); // Imprime el valor de 'j'

            // Declaración de diferentes tipos de números enteros
            short s = 100; // Declara un número entero corto 's' y le asigna el valor 100
            long l = 10000L; // Declara un número entero largo 'l' y le asigna el valor 10000
            uint ui = 12; // Declara un número entero sin signo 'ui' y le asigna el valor 12

            // Conversión de tipos
            int intNum = (int)l; // Convierte 'l' a int y lo asigna a 'intNum'
            short shortNum = (short)i; // Convierte 'i' a short y lo asigna a 'shortNum'

            // Números decimales
            float f = 10.5f; // Declara un número de punto flotante 'f' y le asigna el valor 10.5
            double d = 123.99; // Declara un número de doble precisión 'd' y le asigna el valor 123.99
            decimal dd = 345.80m; // Declara un número decimal 'dd' y le asigna el valor 345.80

            // Conversión entre tipos decimales
            float floatNew = (float)dd; // Convierte 'dd' a float y lo asigna a 'floatNew'
            decimal decimalNew = (decimal)f; // Convierte 'f' a decimal y lo asigna a 'decimalNew'
            decimal decimalNew2 = (decimal)d; // Convierte 'd' a decimal y lo asigna a 'decimalNew2'

        }
    }
}

