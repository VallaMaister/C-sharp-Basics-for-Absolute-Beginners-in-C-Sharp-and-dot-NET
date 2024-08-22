using System;

namespace Assignment2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Supongamos una variable phonePrice de tipo entero para almacenar el precio de un teléfono en dólares.
            // Escribe una secuencia de declaraciones de selección en C# para imprimir "budget" (económico) o "mid-range" (gama media) o "high end" (alta gama) 
            // en función del rango de precios del teléfono - menos de 300, entre 300 y 800, y más de 800 - respectivamente.

            decimal phonePrice;  // Declarar una variable phonePrice de tipo decimal para almacenar el precio del teléfono

            // Leer el precio del teléfono desde la consola
            string input = Console.ReadLine();
            phonePrice = decimal.Parse(input);  // Convertir la entrada del usuario a decimal

            // Nota: El compilador infiere el sufijo decimal 'm' o 'M' del tipo de variable phonePrice
            if (phonePrice < 300)
            {
                Console.WriteLine("económico");  // Imprimir "económico" si el precio es menor de 300
            }
            // Nota: 'M' para decimal se puede agregar explícitamente
            else if (phonePrice >= 300M && phonePrice <= 800M)
            {
                Console.WriteLine("gama media");  // Imprimir "gama media" si el precio está entre 300 y 800
            }
            // Nota: 'm' para decimal también puede estar en minúsculas
            else if (phonePrice > 800m)
            {
                Console.WriteLine("alta gama");  // Imprimir "alta gama" si el precio es mayor de 800
            }

        }
    }
}
