//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int [,] Create2DArray()
{
    Console.Write("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] create2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            create2dArray[i,j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return create2dArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement (int [,] array)
{
    Console.Write("Input number of row: ");
    int rowNumb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of column: ");
    int columnNumb = Convert.ToInt32(Console.ReadLine());
    
    int find = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowNumb == i && columnNumb == j)
            {
                find = array[i, j];
                Console.WriteLine ($"{find}");
                //object c = array.GetValue(rowNumb, columnNumb);
                //Console.WriteLine(c);   
            }
                
            else if (rowNumb > array.GetLength(0) || columnNumb > array.GetLength(1))
            {
                Console.WriteLine ("There is not suitable position in this array");
            }   
        }
    }  
   
}

int [,] userArray = Create2DArray();
Show2dArray(userArray);
FindElement(userArray);
*/


//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*int [,] Create2DArray (int rows, int columns, int minPos, int maxPos)
{
    int [,] created2dArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2dArray[i, j] = new Random().Next(minPos, maxPos + 1);
        }
    }
    return created2dArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageOfColumns (int [,] arr)
{
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i,j];
        }

        double average = Math.Round (sum / arr.GetLength(0), 2);
        Console.Write($"{average}; ");
    }
    Console.Write("\b\b.");  
}



Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal possible number: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal possible number: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2DArray (rows, columns, minVal, maxVal);
Show2DArray (newArray);
AverageOfColumns (newArray);
*/


// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateArray2D ()
{
    Console.Write("Input count of rows: ");
    int mSize = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns: ");
    int nSize = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minimal possible number: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximal possible number: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] createdArray2D = new double [mSize, nSize];

    for (int i = 0; i < mSize; i++)
    {
        for (int j = 0; j < nSize; j++)
        {
            createdArray2D[i,j] = Math.Round((new Random().Next(minVal, maxVal)) + (new Random().NextDouble()), 2);
        }
    }
    return createdArray2D;
}

void PrintArray2D (double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] user2dArray = CreateArray2D ();
PrintArray2D (user2dArray);
