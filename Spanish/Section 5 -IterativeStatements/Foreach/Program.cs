using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demostración de la sentencia Foreach

            // Declarar un array de días de la semana
            string[] days = new string[]
            {
                "Domingo",      // Sunday
                "Lunes",        // Monday
                "Martes",       // Tuesday
                "Miércoles",    // Wednesday
                "Jueves",       // Thursday
                "Viernes",      // Friday
                "Sábado"        // Saturday
            };

            // Usar un bucle foreach para iterar sobre cada elemento del array
            foreach (string s in days)
            {
                Console.WriteLine(s);  // Imprimir cada día en la consola
            }

            // Imprimir un mensaje indicando el final del programa
            Console.WriteLine("¡Fin del programa!");  // End of the program

        }
    }
}
