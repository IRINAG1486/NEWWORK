//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

/*int [,] Create2dArray()
{
    Console.Write("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] createdArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return createdArray;
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

int [,] newArray = Create2dArray();
Show2dArray(newArray);
*/

/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
1 2 3 4      [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/

/*int [,] Fill2dArray()
{
    Console.Write("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] fillArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            fillArray[i,j] = i + j;
        }
    }
    return fillArray;
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
}

int [,] filledArray = Fill2dArray();
Show2dArray(filledArray);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

//  в тетраде для int 

double[,] Create2DArray(int row, int column, int min, int max)
{
    double [,] create2dArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            create2dArray[i,j] = Math.Round((new Random().Next(min, max)) + (new Random().NextDouble()), 2);
        }
    }
    return create2dArray;

}

double[,] Change2dArray(double [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i %2 != 1 && j % 2 != 1)
                array [i,j] *=  Math.Round(Math.Pow(array [i,j], 2), 2); // array [i,j] *= array [i,j] 
        }
    }
    return array;
}

void Show2dArray(double [,] array)
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



Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] createArray = Create2DArray(rows, columns, min, max);
Show2dArray(createArray);
Change2dArray(createArray);
Show2dArray(createArray);
