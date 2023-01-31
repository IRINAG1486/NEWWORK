// Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число болшее, а какое меньшее.


Console.WriteLine("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if( number_1 > number_2)
{
    Console.WriteLine($"{number_1} is bigger than {number_2}");
}
else 
{
    Console.WriteLine($"{number_2} is bigger than {number_1}");
}



// Задача 2. Напишите программу, которая принимает на вход 3 чbсла и выдает максимальное из этих чисел.

/*Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.Write("max = ");
Console.Write(max);
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).

/*Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write($"{number} - четное");
}
else
{
    Console.Write($"{number} - нечетное");
}
*/


// Задача 4. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

/*Console.WriteLine("Input number N: ");
int number = Convert.ToInt32(Console.ReadLine());

int current_num = 1;

while(current_num < number)
{
    if(current_num % 2 == 0)
    {
        Console.WriteLine(current_num);
    }
    current_num++;
}
*/

