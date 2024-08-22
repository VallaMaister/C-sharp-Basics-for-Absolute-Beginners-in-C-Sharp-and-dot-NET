using System;

namespace Basics
{
    class Program
    {
        /// <summary>
        /// Conceptos básicos del lenguaje C#.
        /// </summary>
        static void Main(string[] args)
        {
            // Instrucciones en C#
            // Instrucción individual de código
            // Similar al inglés.
            // Termina con ;
            Console.WriteLine("Hola");

            // Bloques en C#
            // Grupo de instrucciones
            // Comienza con { y termina con }
            if (true)
            {
                /* Verificación de la instrucción if
                con algunas declaraciones de ejemplo
                Fin de las declaraciones multilínea
                */
                int a = 100;
                int b = a;
            }

            // Comentarios en C#
            // 3 tipos de comentarios
            // Comentario de una sola línea //
            // Comentario de múltiples líneas /* */
            // Comentario de documentación ///

            // Lectura y escritura en C#
            string str = Console.ReadLine();
            Console.WriteLine("Hola, Mundo");
            Console.Write("hola");
            Console.WriteLine(str);
        }

    }
}
