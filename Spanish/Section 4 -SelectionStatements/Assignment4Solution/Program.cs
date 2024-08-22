using System;

namespace Assignment4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa de calculadora simple en C# para realizar operaciones matemáticas básicas (+, -, *, /)
            // leyendo el tipo de operación y dos valores. Utiliza sentencias switch para verificar 
            // el tipo de operación introducida e imprime el resultado en la consola. 

            // Mostrar las instrucciones.
            Console.WriteLine("Introduce tu elección:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            // Leer la elección de la operación.
            int choice = int.Parse(Console.ReadLine());  // Convierte la entrada del usuario a un entero

            // Leer los dos números y asignarlos a 'a' y 'b'.
            Console.WriteLine("Introduce el primer número: ");
            int a = int.Parse(Console.ReadLine());  // Convierte la entrada del usuario a un entero y la asigna a 'a'
            Console.WriteLine("Introduce el segundo número: ");
            int b = int.Parse(Console.ReadLine());  // Convierte la entrada del usuario a un entero y la asigna a 'b'

            // Se utiliza el tipo de variable decimal para almacenar valores fraccionarios en caso de división.
            decimal result = 0;  // Inicializa la variable 'result' como decimal

            // Sentencia switch basada en la elección introducida.
            switch (choice)
            {
                case 1:
                    result = a + b;  // Realiza la suma de 'a' y 'b'
                    Console.WriteLine($"Suma : {result}");  // Imprime el resultado de la suma
                    break;
                case 2:
                    result = a - b;  // Realiza la resta de 'a' y 'b'
                    Console.WriteLine($"Resta : {result}");  // Imprime el resultado de la resta
                    break;
                case 3:
                    result = a * b;  // Realiza la multiplicación de 'a' y 'b'
                    Console.WriteLine($"Multiplicación : {result}");  // Imprime el resultado de la multiplicación
                    break;
                case 4:
                    // Es necesario convertir la primera variable a decimal, de lo contrario se perderá la parte fraccionaria en caso de variables int.
                    result = (decimal)a / b;  // Realiza la división y asegura que el resultado sea decimal
                    Console.WriteLine($"División : {result}");  // Imprime el resultado de la división
                    break;
                default:
                    // Opción por defecto. Se ejecuta cuando el usuario introduce entradas diferentes a las esperadas.
                    Console.WriteLine("Entrada inválida");  // Imprime un mensaje de error si la elección no es válida
                    break;
            }

        }
    }
}
