// Задача 1. Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.

/*int [] CreateArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenAmount (int [] array2)
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] % 2 == 0) 
        count = count + 1;
    }
    return count;
}

Console.Write("Input counts of elements of array: ");
int user_count = Convert.ToInt32(Console.ReadLine());

int [] userArray = CreateArray (user_count);
PrintArray (userArray);

int amountEven = FindEvenAmount(userArray);
Console.WriteLine($"Count of even numbers in array is {amountEven}");
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.


/*int [] CreateNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowNewArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}

int SummOddPosition (int [] array2)
{
    int sum = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (i % 2 != 0) 
        sum = sum + array2[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int user_size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal value of array: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximal value of array: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray (user_size, user_minValue, user_maxValue);
ShowNewArray (newArray);

int summ = SummOddPosition(newArray);
Console.WriteLine($"Summ of elements on odd positions is {summ}");
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
//[3.0 7.1 22.5 2.7 78.8] -> 76.1

double [] CreateNewArray (int size_array, int min, int max)
{
    double [] array = new double [size_array];
    Random rand = new Random();
    for (int i = 0; i < size_array; i++)
    {
        array[i] = rand.Next(min, max + 1) + Math.Round(rand.NextDouble(), 3);
    }
    return array;
}

void ShowNewArray (double [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}

double DifferenceMaxMin (double [] array2)
{
    
    double max_position = array2[0];
    double min_position = array2[0];
    double diff = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] < min_position)
        { 
        min_position = array2[i];
        }
            else if (array2[i] > max_position)
            { 
                max_position = array2[i];
            }
    
    }
    diff = max_position - min_position;
    return diff;
}



Console.Write("Input size of array: ");
int user_size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal value of array: ");
int user_minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximal value of array: ");
int user_maxValue = Convert.ToInt32(Console.ReadLine());

double [] newArray = CreateNewArray (user_size, user_minValue, user_maxValue);
ShowNewArray (newArray);


double diffMaxMin = DifferenceMaxMin(newArray);
Console.WriteLine($"Difference is {diffMaxMin:f2}");
