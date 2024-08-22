using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa en C# para obtener la opción de la asignatura favorita del usuario y imprimir el nombre de la asignatura en la consola.

            char ch;  // Declara una variable de tipo char para almacenar la opción del usuario

            Console.WriteLine("Introduce la opción de tu asignatura favorita: ");  // Pide al usuario que introduzca la opción de su asignatura favorita
            ch = (char)Console.Read();  // Lee un carácter de la consola y lo asigna a 'ch'

            // Utiliza una estructura if-else para verificar el valor de 'ch' y determinar la asignatura favorita
            if (ch == 'e')  // Si el usuario introduce 'e'
            {
                Console.WriteLine("La asignatura favorita es Inglés");  // Imprime que la asignatura favorita es Inglés
            }
            else if (ch == 'm')  // Si el usuario introduce 'm'
            {
                Console.WriteLine("La asignatura favorita es Matemáticas");  // Imprime que la asignatura favorita es Matemáticas
            }
            else if (ch == 's')  // Si el usuario introduce 's'
            {
                Console.WriteLine("La asignatura favorita es Ciencia");  // Imprime que la asignatura favorita es Ciencia
            }
            else  // Si el usuario introduce cualquier otro valor
            {
                Console.WriteLine("¡Otras opciones diferentes de mis favoritas!");  // Imprime un mensaje indicando que no es una de las asignaturas favoritas
            }

            Console.WriteLine("Fin del programa");  // Imprime un mensaje indicando el final del programa

        }
    }
}
