using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declara una variable booleana y se inicializa en verdadero
            bool b = true;

            // Imprime el estado de la variable antes de la asignación
            Console.WriteLine("Antes de la asignación");
            Console.WriteLine(b); // Imprime "True"

            // Pide al usuario que introduzca un valor booleano
            Console.Write("Introduce un valor booleano (True/False): ");
            string input = Console.ReadLine(); // Lee la entrada del usuario

            // Intenta convertir la entrada del usuario a un valor booleano
            if (bool.TryParse(input, out b))
            {
                // Si la conversión es exitosa, imprime el nuevo valor de la variable
                Console.WriteLine("Después de la asignación");
                Console.WriteLine(b);
            }
            else
            {
                // Si la conversión falla, muestra un mensaje de error
                Console.WriteLine("Entrada inválida. Por favor, introduce True o False.");
            }
        }
    }
}
