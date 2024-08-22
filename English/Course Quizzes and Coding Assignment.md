<details>
<summary>🔻 Course Introduction</summary>

## QUIZ: Basics of C# Language

- **True or False:** In C#, statements end with a semicolon `;`
  - True [answer]
  - False

- **Which of the following symbols is used to define the scope in C#?**
  - Parentheses `( )`
  - Curly braces `{ }` [answer]
  - Square brackets `[ ]`
  - Forward slashes `//`

- **What is the main purpose of using comments?**
  - To maintain multiple versions of the source code.
  - To make the source code easier for a programmer to understand. [answer]
  - To convey your emotions while writing the code.

## DOWNLOAD: Complete Source Code

### Course Bonuses

You can download the complete source code, which covers the following, from the GitHub repository mentioned below:

- Source codes used in all the demonstrations in this course.
- Assignments (with ready-made projects for you to code right away).
- Assignment Solutions.

### GitHub Repository:
- [https://github.com/CodeWithPraveen/CSharpBasics.git](https://github.com/CodeWithPraveen/CSharpBasics.git)
- Also available at: [https://github.com/PacktPublishing/C-sharp-Basics-for-Absolute-Beginners-in-C-Sharp-and-dot-NET](https://github.com/PacktPublishing/C-sharp-Basics-for-Absolute-Beginners-in-C-Sharp-and-dot-NET)

### Ways to use this Repository:
1. **Clone:** You can use your favorite editor, such as Visual Studio Code, Visual Studio, etc., to clone the repository locally.
2. **Download Zip file:** You can download the zip file of the entire source code and view it locally on your machine.

</details>

<details>
<summary>🔻 Understanding Variables in C#</summary>

## Introduction

In this section, "Understanding Variables in C#", you will learn:
- What are Variables?
- How to work with Text, such as characters and strings.
- How to work with Numbers, such as whole numbers and decimals.
- How to work with scenarios involving true or false states.
- How to work with collections of data of the same type in C#.
- We will demonstrate the usage of each type, quizzes, and assignments.

Let’s get started!

## QUIZ: C# Text

- **True or False:** The character variable takes up 1 byte of memory.
  - True
  - False [answer]

- **Which variable type would you use to store a country name?**
  - Character
  - String [answer]

## QUIZ: C# Numbers

- **True or False:** The `uint` variable type can only store positive numbers.
  - True [answer]
  - False

- **Which of the following options is the correct representation for 1,000,000?**
  - `int i = 1,000,000;`
  - `int i = 1_000_000;` [answer]

- **True or False:** We must add the suffix ‘F’ to values of `float` type variables.
  - True [answer]
  - False

## QUIZ: C# Boolean

- **True or False:** Boolean variables can only take true or false values.
  - True [answer]
  - False

- **Which of the following details about a person can be represented as a boolean variable?**
  - City name.
  - Male/Female. [answer]
  - Phone number.

## QUIZ: C# Arrays

- **True or False:** The index of an array always starts at 0.
  - True [answer]
  - False

- **Which of the following is an incorrect way to declare an integer array of size 5?**
  - `int[] intArray = new int[] { 1, 2, 3, 4, 5 };`
  - `int[] intArray = new int[5];`
  - `int[5] intArray;` [answer]

## Conclusion

In this section, "Understanding Variables in C#", you learned:
- A variable is an identifier whose value can change during program execution and is used to store values.
- We can use Character (`char`) and String (`string`) variables to work with Text in C#.
- We can use Integer (`int`, `short`, `long`, `uint`) and Floating (`float`, `double`, `decimal`) types to work with numbers in C#.
- The Boolean (`bool`) type can work with true or false use cases.
- Finally, Arrays can store a group of variables of the same type.
- Syntaxes and examples for each operator type.
- Quizzes to check your understanding of using Variables in C#.
- Assignments to apply your new learnings on Variables in C#.

In the next section, "Understanding Operators in C#", you will learn what operators are and the different types available in C#.

See you in another video!

</details>

<details>
<summary>🔻Understanding Operators in C#</summary>

## Introduction

In this section, "Understanding Operators in C#", you will learn:

- What are Operators in C#?
- Different types of Operators in C# and their uses.
- Quizzes to check your understanding of using various Operators in C#.
- Activities to apply your learnings in practice.

Let’s get started!

## QUIZ: Unary Operators in C#

**What is the value of the variable `i` in the following code segment?**
```csharp
int a = 100;
int i = ++a;
```
options:
- 100
- 101 [answer]
- Compilation error

**True or False: If the operator is shown after the variable, it is known as a postfix operator.**

- True [answer]
- False

## QUIZ: Mathematical Operators in C#

**What is the value of the variable `result` in the following code segment?**
```csharp
int a = 20;
int b = 3;
int result = a % b;
```
options:
- 6
- 2 [answer]
- 20

**What is the value of the variable `result` in the following modified code segment?**
```csharp
int a = 21;
int b = 3;
int result = a / b;
```
options:
- 7 [answer]
- 0 
- 24
- 18

## QUIZ: Assignment Operators in C#

**What is the value of the variable `a` in the following code segment?**
```csharp
int a = 140;
int b = 50;
a += b;
```
options:
- 50
- 140
- 280
- 190 [answer]

**What is the value of the variable `result` in the following code segment?**
```csharp
int result = 10;
result *= 3;
```
options:
- 30 [answer]
- 10
- 13
- 3

**What is the value of the variable `b` in the following code segment?**
```csharp
int b = 15;
b -= 5;
b *= 5;
```
options:
- 10 
- 25
- 50
- 75 [answer]

## QUIZ: Comparison Operators in C#

**True or False:** The `==` and `!=` operators are opposite to each other in terms of functionality.

- True [answer]
- False

**What is the value of the variable `result` in the following code segment?**
```csharp
bool result = 5.3 > 3.4;
```
options:
- True [answer]
- False
- Compilation error

**What is the value of the variable `result` in the following code segment?**
```csharp
int a = 9;
int b = 7 + 2;
bool result = (a != b);
```
options:
- True
- False [answer]
- Compilation error

## QUIZ: Conditional Operators in C#

**Which of the following is a conditional operator in C#?**

- AND
- && [answer]
- OR
- *

**What is the value of the variable `result` in the following code segment?**
```csharp
bool a = true;
bool b = false;
bool result = a && b;
```
options:
- True
- False [answer]

## Conclusion

In this section, "Understanding Operators in C#", you learned:

- Operators are symbols that inform the compiler to perform certain operations on one or two operands.

- Types of operators:
  - Unary (`++`, `--`)
  - Mathematical (`+`, `-`, `*`, `/`, `%`)
  - Assignment (`=`, `+=`, `-=`, `*=`, `/=`)
  - Comparison (`==`, `!=`, `>`, `<`)
  - Conditional (`&&`, `||`)
  - Bitwise (`&`, `|`, `^`)

- Syntaxes and examples for each operator type.
- Quizzes to check your understanding of using Operators in C#.
- Assignments to apply your new learnings on Operators in C#.

In the next section, "Understanding Selection Statements in C#", you will learn about program flow and how to select a block of code based on certain conditions.

See you in another video!

</details>

<details>
<summary>🔻 Understanding Selection Statements in C#</summary>

## Introduction

In this section, "Understanding Selection Statements in C#", you will learn:

- Overview of program flow.
- Types of selection statements in C#.
- Demonstration on the usage of selection statements in C#.
- Quizzes and activities to check your understanding and apply your new learnings.

Let’s get started!

## QUIZ: `if` Statements in C#

**Are the following statements valid?**
```csharp
string if = "hello, world";
Console.WriteLine(if);
```
- Yes
- No [answer]

**Which of the following is incorrect?**

- The `if` statement can contain more than 1 conditional check.
- The body of the `if` condition can contain only a single statement. [answer]
- The `else` statement is optional when using an `if` statement.

**When does the `else` part get executed in the following example, assuming the `isAllowed` variable is of type `bool`?**
```csharp
if (isAllowed == true)
{
   Console.WriteLine("Success. It is allowed to execute");
}
else
{
   Console.WriteLine("Fail. Not allowed to execute");
}
```
- The value of `isAllowed` is false. [answer]
- The value of `isAllowed` is true.
- `isAllowed` is either true or false.

**True or False:** Nested `if-else` refers to having more than one condition in a single `if` statement.

- True
- False [answer]

## QUIZ: `switch` Statements in C#

**True or False:** We cannot use `case` or `switch` as variable names since they are considered keywords.

- True [answer]
- False

**Is the following statement correct?**  
If you have nested `if-else` statements against a variable with many possibilities, it's better to use the `switch` statement.

- True [answer]
- False

**What is the purpose of the `default` case in the `switch` conditional logic?**

- It gets executed first before other case statements.
- It gets executed when no other case statements match the variable value. [answer]
- It always gets executed after executing the matching case statement.

## ACTIVITY: Coding Assignment 1

**Goal:**  
Check your understanding of Selection Statements in C# by writing a C# program.

**Duration:**  
5-10 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a C# code snippet to read an integer and print it if divisible by 3.

**Additional Resources:**  
You can use the `int.Parse(string)` function to convert a string to an integer.

**Evaluate:**  
- Execute your program and check the output mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## ACTIVITY: Coding Assignment 2

**Goal:**  
Check your understanding of Selection Statements in C# by writing a C# program.

**Duration:**  
5-10 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Assume a variable `phonePrice` of type integer holding the price of a phone in dollars.  
Write a sequence of selection statements in C# to print “budget”, “mid-range” or “high end” based on the price range of the phone: less than 300, between 300 and 800, and more than 800, respectively.

**Additional Resources:**  
None

**Evaluate:**  
- Execute your program and check the output mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## ACTIVITY: Coding Assignment 3

**Goal:**  
Check your understanding of Selection Statements in C# by writing a C# program.

**Duration:**  
10-20 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a C# code snippet to check whether an entered password is valid or not according to the following rules:
- Password length between 8 and 14 (inclusive)
- At least one uppercase letter
- At least one lowercase letter
- At least one numeric letter

**Example:**

- Password123 --> Valid
- hello9090 --> Invalid

**Additional Resources:**  
I have intentionally provided this assignment that involves searching on Google or StackOverflow.com for certain unknowns, such as how to find the presence of uppercase letters, etc. This is to familiarize you with the coding environment and process followed by general C# developers.

**Evaluate:**  
- Execute your program and check the output mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## ACTIVITY: Coding Assignment 4

**Goal:**  
Check your understanding of Selection Statements in C# by writing a C# program.

**Duration:**  
10-20 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a simple C# calculator program to perform essential mathematical operations (+, -, *, /) by reading the type of operation and two values. Use `switch` statements to check the type of operation entered and print the result to the console.

**Additional Resources:**  
You can assume the inputs are valid. Also, assume the numbers entered are positive integers.

**Evaluate:**  
- Execute your program and check the output as explained in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## Conclusion

In this section, "Understanding Selection Statements in C#", you learned:

- Program Flow refers to the sequence of execution of instructions in a program.
- The `if` statement determines which block to select based on a boolean condition.
- Two types of selection statements in C#:
  - `if` statements
  - `switch` statements
  
- You validated your learning through quizzes and many assignments.

In the next section, "Understanding Iterative Statements in C#", we will discuss how to execute a block of code repeatedly or navigate through them one at a time.

See you in another video!

</details>

<details>
<summary>🔻 Understanding Iterative Statements in C#</summary>

## Introduction

In this section, "Understanding Iterative Statements in C#", you will learn:

- What is meant by iteration and why it is needed.
- Different types of iterative statements in C#.
- Demonstration on the usage of iterative statements in C#.
- Quizzes and activities to check your understanding and apply the new learnings.

Let’s get started!

## QUIZ: Iterative Statements in C#

**True or False:** Loop code blocks are always executed only once.

- True
- False [answer]

**Which of the following options is not a looping construct?**

- If Else [answer]
- While
- Do While

**Which loop can you use to execute the code block at least once?**

- While loop.
- Do While loop. [answer]
- For loop.

## ACTIVITY: Coding Assignment 1

**Goal:**  
Check your understanding of Iterative Statements in C# by writing a C# program.

**Duration:**  
5-10 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a C# code snippet to read a positive number from the console and print the total number of digits it contains.  
For example: 135 --> 3, 90 --> 2, 98788 --> 5

**Additional Resources:**  
You can use the `int.Parse(string)` function to convert a string to an integer.

**Evaluate:**  
- Execute your program and check the output as mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## ACTIVITY: Coding Assignment 2

**Goal:**  
Check your understanding of Iterative Statements in C# by writing a C# program.

**Duration:**  
5-10 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a C# code snippet to read a positive integer from the console and print its factorial value.  
The factorial of a number refers to the product of all numbers below it.  
For example:
- factorial(3) = 3 * 2 * 1 = 6
- factorial(5) = 5 * 4 * 3 * 2 * 1 = 120

**Additional Resources:**  
None

**Evaluate:**  
- Execute your program and check the output as mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## ACTIVITY: Coding Assignment 3

**Goal:**  
Check your understanding of Iterative Statements in C# by writing a C# program.

**Duration:**  
10-15 minutes

**Software needed:**  
Visual Studio Code or Visual Studio or Visual Studio for Mac or any other IDE that supports C#.

**Problem Statement:**  
Write a C# code snippet to print only the numbers from an array containing both integer and string values.  
For example:
- { "2", "Red", "67" } --> 2, 67
- { "Hello", "45", "12", "Rose" } --> 45, 12

**Additional Resources:**  
None

**Evaluate:**  
- Execute your program and check the output as mentioned in the problem statement above.
- You may cross-check my solution for this assignment provided in the downloaded source code.

## Conclusion

In this section, "Understanding Iterative Statements in C#", you learned:

- Iteration statements execute a block of statements until a condition is met or for each item in a collection.
- Types of Iterative Statements in C#:
  - While statement
  - Do While statement
  - For statement
  - Foreach statement

- You validated your learning through quizzes and many assignments.

In the next section, "Understanding Debugging in the .NET Environment in C#", we will discuss the approach for debugging your C# program.

See you in another video!

</details>

<details>
<summary>🔻 Understanding Debugging in C#</summary>

## Introduction

In this section, "Understanding Debugging in C#", you will learn:

- Debugging in C#.
- Quizzes and activities to check your understanding and apply the new learnings.

Let’s get started!

</details>
