// Выполнение задач семинара


//Task

/*
Console.WriteLine("Imput your number: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your number is {number}");
*/ 


// Задача 1. Напишите программу, к. на вход принимает число и выдает его квадрат на выходе
/*
Console.WriteLine("Imput your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine($"Square {number} - {result}");
Console.WriteLine(number * number);
*/

// Задача 2. Написать программу, к. на  вход принимает два числа и проверяет, является ли 1ое число квадратом 2го числа.

/*
Console.WriteLine("Imput first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2 * number_2)
{
    Console.WriteLine($"Число {number_1} является квадратом числа {number_2}");
}
else
{
    Console.WriteLine($"Число {number_1} не является квадратом числа {number_2}");
}
*/

// Задача 3. Напишите программу, к. на вход принимает одно число (N), а на выходе показывет все целые числа в промежутке от -N до N

/*
Console.Write("Imput your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current_num = (-1) * num;

while (current_num <= num)
{
    Console.Write(current_num + " ");
    current_num++;
}
*/

// Задача 4. Напишите программу которая принимет на вход трехзначное число, и на выходе показывает последнюю цифру этого числа

Console.Write("Imput your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int digit_3 = num % 10;
    Console.WriteLine($"Third digit is {digit_3}");
}
else
{
    Console.WriteLine("Your number is not 3-digit");
}