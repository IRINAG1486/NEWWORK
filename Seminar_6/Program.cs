

/*int [] CreateNewArray (int size, int minV, int maxV)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minV, maxV + 1);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] ReversedArray (int [] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = array[i];
        array[i] = array[k - i - 1];
        array[k - i - 1] = temp;
        
    }
    return array;
}
    
    Console.WriteLine("input size of array: ");
    int userSize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input min: ");
    int usermin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input max: ");
    int usermax = Convert.ToInt32(Console.ReadLine());

    int [] newArray = CreateNewArray (userSize, usermin, usermax);
    ShowArray (newArray);
    ShowArray (ReversedArray(newArray));
*/

    //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11

/*string BinarySystem (int num)
{
   string result = string.Empty;
   while (num != 0)
   {
    result = num % 2 + result;
    num = num / 2;
   }
   return result;
}

Console.WriteLine("input 10 system number: ");
    int number10 = Convert.ToInt32(Console.ReadLine());

    string resBin = BinarySystem (number10);
    Console.WriteLine($"{number10} in binare system is {resBin}");

*/

// Выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).

//F(i) = F(i - 1) + F(i - 2)
//4 5 9 14 23 (N = 5)

/*int [] Fibanacci (int count, int a, int b)
{
    int [] array = new int [count];
    array [0] = a;
    array[1] = b;
    for (int i = 2; i < count; i++)
    {
        array [i] = array[i - 1] + array[i - 2];
        
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input count: ");
int user_count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input a: ");
int user_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input b: ");
int user_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Fibanacci(user_count, user_a, user_b));
ShowArray (Fibanacci(user_count, user_a, user_b));

*/

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.


void Triangle (int firstSide, int secondSide, int thirdSide)
{
    if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
    {
        Console.WriteLine($" Triangle {firstSide}, {secondSide}, {thirdSide} is real");

    }
    else 
    {
        Console.WriteLine($" Triangle {firstSide}, {secondSide}, {thirdSide} is not real");
    }
} 


Console.WriteLine("input first side: ");
int user_first_side = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input second side: ");
int user_second_side = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input third side: ");
int user_third_side = Convert.ToInt32(Console.ReadLine());

Triangle (user_first_side, user_second_side, user_third_side);
