using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Caracteres
            char c = 'a'; // Declara un carácter 'c' y le asigna la letra 'a'
            char d = '1'; // Declara un carácter 'd' y le asigna el número '1'
            char s = '*'; // Declara un carácter 's' y le asigna el símbolo '*'

            // Determina el tamaño de un carácter en bytes
            int i = sizeof(char); // i = 2, el tamaño de un char es 2 bytes en C#

            // C# Cadenas
            string s1 = "hello";  // Declara una cadena 's1' y le asigna "hello"
            string s2 = "12345";  // Declara una cadena 's2' y le asigna "12345"
            string s3 = "***";     // Declara una cadena 's3' y le asigna "***"

            // Imprime cadenas en la consola
            Console.WriteLine("hello, world"); // Imprime "hello, world"
            Console.WriteLine(s1);              // Imprime el contenido de 's1'
            Console.WriteLine(s2);              // Imprime el contenido de 's2'
            Console.WriteLine(s3);              // Imprime el contenido de 's3'

            // Diferentes formas de representar cadenas
            // Literales
            string str1 = "world"; // Declara una cadena 'str1' y le asigna "world"
                                   // Verbatim
            string str2 = @"c:\myfolder\test.txt"; // Declara una cadena 'str2' usando verbatim para evitar la necesidad de escapar el carácter '\'
                                                   // Interpolated
            string str3 = $"hello {str1}"; // Declara una cadena 'str3' interpolando 'str1' en "hello {str1}" 

            // Imprime las cadenas en la consola
            Console.WriteLine(str1); // Imprime el contenido de 'str1'
            Console.WriteLine(str2); // Imprime el contenido de 'str2'
            Console.WriteLine(str3); // Imprime el contenido de 'str3'




        }
    }
}
