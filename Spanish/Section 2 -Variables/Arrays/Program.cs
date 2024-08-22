using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran dos variables de tipo string que contienen los nombres de los días en inglés
            string sun = "domingo"; // "sunday" en inglés
            string mon = "lunes";    // "monday" en inglés

            // Se crea un array de strings que contiene los nombres de los días de la semana en español
            string[] dias = new string[]
            {
                "Domingo",
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábado"
            };

            // Se imprime en consola los tres primeros días de la semana desde el array 'dias'
            Console.WriteLine(dias[0]); // Imprime "Domingo"
            Console.WriteLine(dias[1]); // Imprime "Lunes"
            Console.WriteLine(dias[2]); // Imprime "Martes"

            // Se declara un nuevo array de strings para almacenar los días de la semana
            string[] diasNuevos;
            // Se inicializa el array 'diasNuevos' con una longitud de 7
            diasNuevos = new string[7];
            // Se asignan los nombres de los días de la semana a las primeras tres posiciones del array
            diasNuevos[0] = "Domingo";
            diasNuevos[1] = "Lunes";
            diasNuevos[2] = "Martes";

            // Se imprime en consola los tres primeros días de la semana desde el array 'diasNuevos'
            Console.Write(diasNuevos[0]); // Imprime "Domingo"
            Console.Write(diasNuevos[1]); // Imprime "Lunes"
            Console.Write(diasNuevos[2]); // Imprime "Martes"

            // Se obtiene la longitud del array 'diasNuevos' y se almacena en la variable 'length'
            int length = diasNuevos.Length;
            // Se imprime la longitud del array en consola, que será 7
            Console.WriteLine(length); // Imprime "7" ya que el array tiene 7 elementos
        }

    }
}
