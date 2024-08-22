using System;

namespace Assignment3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un fragmento de código en C# para verificar si la contraseña ingresada es válida o no según las siguientes reglas:
            //  - Longitud de la contraseña entre 8 y 14 caracteres (ambos inclusive)
            //  - Al menos 1 letra mayúscula
            //  - Al menos 1 letra minúscula
            //  - Al menos 1 carácter numérico.
            // Por ejemplo.,
            //  Password123 --> Válido
            //  hello9090 --> Inválido

            // Estas variables booleanas mantendrán el resultado de cada verificación
            bool isLengthValid = false;
            bool isUppercase = false;
            bool isLowercase = false;
            bool isNumeric = false;

            // Leer la contraseña como texto plano
            string password = Console.ReadLine();

            // Verificar la longitud de la contraseña
            if (password.Length >= 8 && password.Length <= 14)
            {
                isLengthValid = true;
            }

            // Iterar a través de cada carácter de la cadena
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                // Verificar si contiene una letra minúscula
                if (char.IsLower(ch))
                {
                    isLowercase = true;
                }
                // Verificar si contiene una letra mayúscula
                if (char.IsUpper(ch))
                {
                    isUppercase = true;
                }
                // Verificar si contiene un número
                if (char.IsNumber(ch))
                {
                    isNumeric = true;
                }
            }

            // Verificar si la contraseña cumple con todas las condiciones
            if (isLengthValid && isUppercase && isLowercase && isNumeric)
            {
                Console.WriteLine("La contraseña es válida");
            }
            else
            {
                Console.WriteLine("La contraseña es inválida");
            }

        }
    }
}
