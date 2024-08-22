
<details>
<summary>🔻 Introducción al Curso</summary>

## CUESTIONARIO: Conceptos básicos del lenguaje C#

- **Verdadero o Falso:** En C#, las instrucciones terminan con un punto y coma `;`
  - Verdadero [respuesta]
  - Falso

- **¿Cuál de los siguientes símbolos se utiliza para definir el ámbito en C#?**
  - Paréntesis `( )`
  - Llaves `{ }` [respuesta]
  - Corchetes `[ ]`
  - Barras diagonales `//`

- **¿Cuál es el principal propósito de usar comentarios?**
  - Mantener múltiples versiones del código fuente.
  - Hacer que el código fuente sea más fácil de entender para un programador. [respuesta]
  - Transmitir tus emociones mientras escribes el código.

## DESCARGA: Código Fuente Completo

### Bonos del Curso

Puedes descargar el código fuente completo, que cubre lo siguiente, desde el repositorio de GitHub mencionado a continuación:

- Códigos fuente utilizados en todas las demostraciones de este curso.
- Asignaciones (con proyectos listos para que puedas codificar de inmediato).
- Soluciones de las Asignaciones.

### Repositorio de GitHub:
- [https://github.com/CodeWithPraveen/CSharpBasics.git](https://github.com/CodeWithPraveen/CSharpBasics.git)
- También disponible en: [https://github.com/PacktPublishing/C-sharp-Basics-for-Absolute-Beginners-in-C-Sharp-and-dot-NET](https://github.com/PacktPublishing/C-sharp-Basics-for-Absolute-Beginners-in-C-Sharp-and-dot-NET)

### Formas de usar este Repositorio:
1. **Clonar:** Puedes usar tu editor favorito, como Visual Studio Code, Visual Studio, etc., para clonar el repositorio localmente.
2. **Descargar archivo Zip:** Puedes descargar el archivo zip de todo el código fuente y verlo localmente en tu máquina.

</details>

<details>
<summary>🔻 Entendiendo las Variables en C#</summary>

## Introducción

En esta sección, "Entendiendo las Variables en C#", aprenderás:
- ¿Qué son las Variables?
- Cómo trabajar con Texto, como caracteres y cadenas.
- Cómo trabajar con Números, como números enteros y decimales.
- Cómo trabajar con escenarios que involucren estados de verdadero o falso.
- Cómo trabajar con colecciones de datos del mismo tipo en C#.
- Haremos demostraciones del uso de cada tipo, cuestionarios y asignaciones.

¡Empecemos!

## CUESTIONARIO: Texto en C#

- **Verdadero o Falso:** La variable de carácter ocupa 1 byte de memoria.
  - Verdadero
  - Falso [respuesta]

- **¿Qué tipo de variable usarías para almacenar el nombre de un país?**
  - Carácter
  - Cadena [respuesta]

## CUESTIONARIO: Números en C#

- **Verdadero o Falso:** El tipo de variable `uint` solo puede almacenar números positivos.
  - Verdadero [respuesta]
  - Falso

- **¿Cuál de las siguientes opciones es la representación correcta para 1,000,000?**
  - `int i = 1,000,000;`
  - `int i = 1_000_000;` [respuesta]

- **Verdadero o Falso:** Debemos añadir el sufijo ‘F’ a los valores de las variables de tipo `float`.
  - Verdadero [respuesta]
  - Falso

## CUESTIONARIO: Booleanos en C#

- **Verdadero o Falso:** Las variables booleanas solo pueden tomar los valores verdadero o falso.
  - Verdadero [respuesta]
  - Falso

- **¿Cuál de los siguientes detalles de una persona puede representarse como una variable booleana?**
  - Nombre de la ciudad.
  - Masculino/Femenino. [respuesta]
  - Número de teléfono.

## CUESTIONARIO: Arreglos en C#

- **Verdadero o Falso:** El índice de un arreglo siempre comienza en 0.
  - Verdadero [respuesta]
  - Falso

- **¿Cuál de las siguientes es una forma incorrecta de declarar un arreglo de enteros de tamaño 5?**
  - `int[] intArray = new int[] { 1, 2, 3, 4, 5 };`
  - `int[] intArray = new int[5];`
  - `int[5] intArray;` [respuesta]

## Conclusión

En esta sección, "Entendiendo las Variables en C#", aprendiste:
- Una variable es un identificador cuyo valor puede cambiar durante la ejecución del programa y se utiliza para almacenar valores.
- Podemos usar variables de Carácter (`char`) y Cadena (`string`) para trabajar con Texto en C#.
- Podemos usar Enteros (`int`, `short`, `long`, `uint`) y tipos Flotantes (`float`, `double`, `decimal`) para trabajar con números en C#.
- El tipo Booleano (`bool`) puede trabajar con casos de uso de verdadero o falso.
- Finalmente, los Arreglos pueden almacenar un grupo de variables del mismo tipo.
- Sintaxis y ejemplos para cada uno de los tipos de operadores.
- Cuestionarios para comprobar tu comprensión del uso de Variables en C#.
- Asignaciones para aplicar tus nuevos aprendizajes sobre Variables en C#.

En la siguiente sección, "Entendiendo los Operadores en C#", aprenderás qué son los operadores y los diferentes tipos disponibles en C#.

¡Nos vemos en otro video!

</details>

<details>
<summary>🔻Entendiendo los Operadores en C#</summary>

## Introducción

En esta sección, "Entendiendo los Operadores en C#", aprenderás:

- ¿Qué son los Operadores en C#?
- Los diferentes tipos de Operadores en C# y sus usos.
- Cuestionarios para comprobar tu comprensión del uso de varios Operadores en C#.
- Actividades para aplicar tus aprendizajes en la práctica.

¡Empecemos!

## CUESTIONARIO: Operadores Unarios en C#

**¿Cuál es el valor de la variable `i` en el siguiente segmento de código?**

```csharp
int a = 100;
int i = ++a;
```

opciones
- 100
- 101 [respuesta]
- Error de compilacion

**Verdadero o Falso: Si el operador se muestra después de la variable, se conoce como un operador postfijo.**

- Verdadero [respuesta]
- Falso

## CUESTIONARIO: Operadores Matemáticos en C#

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código?**

```csharp
int a = 20;
int b = 3;
int result = a % b;
```

opciones
- 6
- 2 [respuesta]
- 20

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código modificado?**

```csharp
int a = 21;
int b = 3;
int result = a / b;
```

opciones
- 7 [respuesta]
- 0 
- 24
- 18

## CUESTIONARIO: Operadores de Asignación en C#

**¿Cuál es el valor de la variable `a` en el siguiente segmento de código?**

```csharp
int a = 140;
int b = 50;
a += b;
```

opciones
- 50
- 140
- 280
- 190 [respuesta]

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código?**

```csharp
int result = 10;
result *= 3;
```

opciones
- 30 [respuesta]
- 10
- 13
- 3

**¿Cuál es el valor de la variable `b` en el siguiente segmento de código?**

```csharp
int b = 15;
b -= 5;
b *= 5;
```

opciones
- 10 
- 25
- 50
- 75 [respuesta]

## CUESTIONARIO: Operadores de Comparación en C#

**Verdadero o Falso:** Los operadores `==` y `!=` son opuestos entre sí en términos de funcionalidad.

- Verdadero [respuesta]
- Falso

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código?**

```csharp
int result = 5.3 > 3.4;
```

opciones:
- Verdadero [respuesta]
- Falso
- Error de compilación

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código?**

```csharp
int a = 9;
int b = 7 + 2;
bool result = (a != b);
```

opciones:
- Verdadero
- Falso [respuesta]
- Error de compilación

## CUESTIONARIO: Operadores Condicionales en C#

**¿Cuál de los siguientes es un operador condicional en C#?**

- AND
- && [respuesta]
- OR
- *

**¿Cuál es el valor de la variable `result` en el siguiente segmento de código?**

```csharp
bool a = true;
bool b = false;
bool result = a && b;
```

opciones:
- Verdadero
- Falso [respuesta]

## Conclusión

En esta sección, "Entendiendo los Operadores en C#", aprendiste:

- Los operadores son símbolos que informan al compilador para realizar ciertas operaciones sobre uno o dos operandos.

- Tipos de operadores:
  - Unarios (`++`, `--`)
  - Matemáticos (`+`, `-`, `*`, `/`, `%`)
  - De asignación (`=`, `+=`, `-=`, `*=`, `/=`)
  - De comparación (`==`, `!=`, `>`, `<`)
  - Condicionales (`&&`, `||`)
  - A nivel de bits (`&`, `|`, `^`)

- Sintaxis y ejemplos para cada tipo de operador.
- Cuestionarios para comprobar tu comprensión del uso de Operadores en C#.
- Asignaciones para aplicar tus nuevos aprendizajes sobre Operadores en C#.

En la próxima sección, "Entendiendo las Sentencias de Selección en C#", aprenderás sobre el flujo del programa y cómo seleccionar un bloque de código basado en ciertas condiciones.

¡Nos vemos en otro video!


</details>

<details>
<summary>🔻 Entendiendo las Sentencias de Selección en C#</summary>

## Introducción

En esta sección, "Entendiendo las Sentencias de Selección en C#", aprenderás:

- Descripción general del flujo del programa.
- Tipos de sentencias de selección en C#.
- Demostración sobre el uso de las sentencias de selección en C#.
- Cuestionarios y actividades para comprobar tu comprensión y aplicar los nuevos conocimientos.

¡Empecemos!

## CUESTIONARIO: Sentencias `if` en C#

**¿Son válidas las siguientes declaraciones?**

```csharp
string if = "hello, world";
Console.WriteLine(if);
```

- Sí
- No [respuesta]

**¿Cuál de las siguientes es incorrecta?**

- La sentencia `if` puede contener más de 1 comprobación condicional.
- El cuerpo de la condición `if` solo puede contener una sola declaración. [respuesta]
- La sentencia `else` es opcional al usar una sentencia `if`.

**¿Cuándo se ejecuta la parte `else` en el siguiente ejemplo, suponiendo que la variable `isAllowed` es de tipo `bool`?**

```csharp
if (isAllowed == true)
{
   Console.WriteLine("Éxito. Está permitido ejecutar");
}
else
{
   Console.WriteLine("Fallo. No está permitido ejecutar");
}
```

- El valor de `isAllowed` es falso. [respuesta]
- El valor de `isAllowed` es verdadero.
- `isAllowed` es verdadero o falso.

**Verdadero o Falso:** El `if-else` anidado se refiere a tener más de una condición en una sola sentencia `if`.

- Verdadero
- Falso [respuesta]

## CUESTIONARIO: Sentencias `switch` en C#

**Verdadero o Falso:** No podemos usar `case` o `switch` como nombres de variables ya que se consideran palabras clave.

- Verdadero [respuesta]
- Falso

**¿Es correcta la siguiente afirmación?**  
Si tienes sentencias `if-else` anidadas contra una variable con muchas posibilidades, es mejor usar la sentencia `switch`.

- Verdadero [respuesta]
- Falso

**¿Cuál es el propósito del caso `default` en la lógica condicional `switch`?**

- Se ejecuta primero antes que otras sentencias `case`.
- Se ejecuta cuando ninguna otra sentencia `case` coincide con el valor de la variable. [respuesta]
- Siempre se ejecuta después de ejecutar la sentencia `case` coincidente.

## ACTIVIDAD: Asignación de Codificación 1

**Objetivo:**  
Comprueba tu comprensión de las Sentencias de Selección en C# escribiendo un programa en C#.

**Duración:**  
5-10 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un fragmento de código en C# para leer un entero e imprimirlo si es divisible por 3.

**Recursos adicionales:**  
Puedes usar la función `int.Parse(string)` para convertir una cadena en un entero.

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## ACTIVIDAD: Asignación de Codificación 2

**Objetivo:**  
Comprueba tu comprensión de las Sentencias de Selección en C# escribiendo un programa en C#.

**Duración:**  
5-10 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Supón una variable `phonePrice` de tipo entero que contiene el precio de un teléfono en dólares.  
Escribe una secuencia de sentencias de selección en C# para imprimir "budget", "mid-range" o "high end" según el rango de precios del teléfono: menos de 300, entre 300 y 800, y más de 800, respectivamente.

**Recursos adicionales:**  
Ninguno

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## ACTIVIDAD: Asignación de Codificación 3

**Objetivo:**  
Comprueba tu comprensión de las Sentencias de Selección en C# escribiendo un programa en C#.

**Duración:**  
10-20 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un fragmento de código en C# para comprobar si una contraseña introducida es válida o no según las siguientes reglas:
- Longitud de la contraseña entre 8 y 14 (ambos inclusive).
- Al menos una letra mayúscula.
- Al menos una letra minúscula.
- Al menos una letra numérica.
  
**Ejemplo:**

- Password123 --> Válido
- hello9090 --> No válido

**Recursos adicionales:**  
He proporcionado intencionalmente esta asignación que implica buscar en Google o StackOverflow.com ciertos conceptos desconocidos, como cómo encontrar la presencia de letras mayúsculas, etc. Esto es para familiarizarte con el entorno de codificación y el proceso seguido por los desarrolladores de C# en general.

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## ACTIVIDAD: Asignación de Codificación 4

**Objetivo:**  
Comprueba tu comprensión de las Sentencias de Selección en C# escribiendo un programa en C#.

**Duración:**  
10-20 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un programa simple en C# para realizar las operaciones matemáticas esenciales (+, -, *, /) leyendo el tipo de operación y dos valores. Usa sentencias `switch` para comprobar el tipo de operación introducida e imprimir el resultado en la consola.

**Recursos adicionales:**  
Puedes asumir que las entradas son válidas. También, asume que los números introducidos son números enteros positivos.

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado según lo explicado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## Conclusión

En esta sección, "Entendiendo las Sentencias de Selección en C#", aprendiste:

- El Flujo del Programa se refiere a la secuencia de ejecución de instrucciones en un programa.
- La sentencia `if` determina qué bloque seleccionar basado en una condición booleana.
- Dos tipos de sentencias de selección en C#:
  - Sentencias `if`.
  - Sentencias `switch`.
  
- Validaste tu aprendizaje a través de cuestionarios y muchas asignaciones.

En la próxima sección, "Entendiendo las Sentencias Iterativas en C#", discutiremos cómo ejecutar un bloque de código repetidamente o navegar a través de ellos uno a la vez.

¡Nos vemos en otro video!

</details>

<details>
<summary>🔻 Entendiendo las Sentencias Iterativas en C#</summary>

## Introducción

En esta sección, "Entendiendo las Sentencias Iterativas en C#", aprenderás:

- Qué es la iteración y por qué es necesaria.
- Diferentes tipos de sentencias iterativas en C#.
- Demostración sobre el uso de sentencias iterativas en C#.
- Cuestionarios y actividades para comprobar tu comprensión y aplicar los nuevos conocimientos.

¡Empecemos!

## CUESTIONARIO: Sentencias Iterativas en C#

**Verdadero o Falso:** Los bloques de código de los bucles se ejecutan siempre solo una vez.

- Verdadero
- Falso [respuesta]

**¿Cuál de las siguientes opciones no es una estructura de bucle?**

- If Else [respuesta]
- While
- Do While

**¿Qué bucle puedes usar para ejecutar el bloque de código al menos una vez?**

- While loop.
- Do While loop. [respuesta]
- For loop.

## ACTIVIDAD: Asignación de Codificación 1

**Objetivo:**  
Comprueba tu comprensión de las Sentencias Iterativas en C# escribiendo un programa en C#.

**Duración:**  
5-10 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un fragmento de código en C# para leer un número positivo de la consola y mostrar el número total de dígitos que contiene.  
Por ejemplo: 135 --> 3, 90 --> 2, 98788 --> 5

**Recursos adicionales:**  
Puedes usar la función `int.Parse(string)` para convertir una cadena en un entero.

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## ACTIVIDAD: Asignación de Codificación 2

**Objetivo:**  
Comprueba tu comprensión de las Sentencias Iterativas en C# escribiendo un programa en C#.

**Duración:**  
5-10 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un fragmento de código en C# para leer un entero positivo de la consola y mostrar su valor factorial.  
El factorial de un número se refiere al producto de todos los números por debajo de él.  
Por ejemplo:
- factorial(3) = 3 * 2 * 1 = 6
- factorial(5) = 5 * 4 * 3 * 2 * 1 = 120

**Recursos adicionales:**  
Ninguno

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## ACTIVIDAD: Asignación de Codificación 3

**Objetivo:**  
Comprueba tu comprensión de las Sentencias Iterativas en C# escribiendo un programa en C#.

**Duración:**  
10-15 minutos

**Software necesario:**  
Visual Studio Code o Visual Studio o Visual Studio para Mac o cualquier otro IDE que soporte C#.

**Enunciado del problema:**  
Escribe un fragmento de código en C# para imprimir solo los números de un arreglo que contiene tanto valores enteros como cadenas de texto.  
Por ejemplo:
- { "2", "Red", "67" } --> 2, 67
- { "Hello", "45", "12", "Rose" } --> 45, 12

**Recursos adicionales:**  
Ninguno

**Evaluación:**  
- Ejecuta tu programa y comprueba el resultado mencionado en el enunciado del problema anterior.
- Puedes comparar tu solución con mi solución proporcionada en el código fuente descargado.

## Conclusión

En esta sección, "Entendiendo las Sentencias Iterativas en C#", aprendiste:

- Las sentencias de iteración ejecutan un bloque de sentencias hasta que se cumple una condición o para cada elemento en una colección.
- Tipos de Sentencias Iterativas en C#:
  - Sentencia While
  - Sentencia Do While
  - Sentencia For
  - Sentencia Foreach

- Validaste tu aprendizaje a través de cuestionarios y muchas asignaciones.

En la próxima sección, "Entendiendo la Depuración en el Entorno .NET de C#", discutiremos el enfoque para depurar tu programa en C#.

¡Nos vemos en otro video!

</details>

<details>
<summary>🔻 Entendiendo la Depuración en C#</summary>

## Introducción

En esta sección, "Entendiendo la Depuración en C#", aprenderás:

- La depuración en C#.
- Cuestionarios y actividades para comprobar tu comprensión y aplicar los nuevos conocimientos.

¡Empecemos!

</details>
