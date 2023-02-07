// Задача 2. Напишите программу, к. принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве.

/*double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;

    double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return result;
}

Console.Write("Input X of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xCoordA, yCoordA, zCoordA, xCoordB, yCoordB, zCoordB);
Console.Write($"Distance between A and B is {distance:f2}");
*/

// Задача 3. Напишите программу, к. на вход принимает чило N и выдает таблицу кубов чисел от 1 до N

/*void Cube (int num)
{
    int digit = 1;
    while(digit <= num)
    {
        double result = Math.Pow(digit, 3);    //int result = digit * digit * digit;
        Console.Write($"{result}, ");
        digit++;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber >= 1)
    {
        Console.Write($"{userNumber} -> ");
        Cube(userNumber);
    }
else Console.WriteLine("ERROR! Your number  < 1");
*/

/*void NumberPolindrom(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = num % 10;
    int num4 = (num % 100) /10;

    if (num1 == num3 && num2 == num4)
  {
    Console.WriteLine("Your number is polindrom");
  }
  else  Console.WriteLine("Your number is not polindrom");
}

Console.Write("Input 5digit number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 9999 && userNumber < 100000)
NumberPolindrom(userNumber);

else Console.WriteLine("Your number is not 5digit");
*/

void Polindrom (int num)
{
    int temp_number = num;
    int number2 = 0;

    while (num > 0)
    {
        int digit = num % 10;
        int number3 = number2 * 10 + digit;
        num = num / 10;
        number2 = number3;
    }

    if (temp_number == number2)
    {
        Console.WriteLine("Your number is polindrom");
    }
    else 
    {
        Console.WriteLine("Your number is not polindrom");
    }
}

Console.Write("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 9)
Polindrom(userNumber);

else Console.WriteLine("Your number < 9");