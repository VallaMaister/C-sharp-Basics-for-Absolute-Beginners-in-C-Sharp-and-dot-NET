using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa en C# para obtener la opción de la asignatura favorita del usuario y imprimir el nombre de la asignatura en la consola.

            char ch;  // Declara una variable de tipo char para almacenar la opción del usuario

            Console.WriteLine("Introduce la opción de tu asignatura favorita: ");
            ch = (char)Console.Read();  // Lee un carácter de la consola y lo asigna a 'ch'

            // Utiliza una estructura switch para verificar el valor de 'ch' y determinar la asignatura favorita
            switch (ch)
            {
                case 'e':  // Si el usuario introduce 'e'
                    {
                        Console.WriteLine("La asignatura favorita es Inglés");  // Imprime que la asignatura favorita es Inglés
                        break;  // Termina el caso
                    }
                case 'm':  // Si el usuario introduce 'm'
                    {
                        Console.WriteLine("La asignatura favorita es Matemáticas");  // Imprime que la asignatura favorita es Matemáticas
                        break;  // Termina el caso
                    }
                case 's':  // Si el usuario introduce 's'
                    {
                        Console.WriteLine("La asignatura favorita es Ciencia");  // Imprime que la asignatura favorita es Ciencia
                        break;  // Termina el caso
                    }
                default:  // Si el usuario introduce cualquier otro valor
                    {
                        Console.WriteLine("¡Otra asignatura diferente de las favoritas!");  // Imprime un mensaje indicando que no es una de las asignaturas favoritas
                        break;  // Termina el caso
                    }
            }

        }
    }
}
