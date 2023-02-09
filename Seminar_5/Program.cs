// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма отрицательных равна -20.

/*int [] CreateNewArray(int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next (min, max + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSumNeg (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int sizeM = 12;
int minM = -9;
int maxM = 9;

int [] newArray = CreateNewArray(sizeM, minM, maxM);
ShowArray(newArray);

int resSum = FindSumNeg (newArray);
Console.Write($" sum of negativ is {resSum}");

*/


//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*int [] CreateNewArray(int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next (min, max + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] RewriteArray (int [] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        array[i] = (-1) * array[i];
    }
    return array;
}

Console.Write("Input count of elements of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());// sizeArray > 0

Console.Write("Input minimal of array: ");
int minM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximal of array: ");
int maxM = Convert.ToInt32(Console.ReadLine());

int [] createdArray = CreateNewArray(sizeArray, minM, maxM);
ShowArray(createdArray);// исходннный массив
RewriteArray(createdArray);// преобразовать
ShowArray(createdArray); //показать замененный массив
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

/*int NewArray (int [] array, int find_numb)
{
    for ( int i = 0; i < array.Length; i++)
    {
        if (array[i] == find_numb)
        {
            return array[i];
        }
    
    }
    return -1;
}

int []array2 = {6, 7, 19, 345, 3};
int find = 4;

int NewNumber = NewArray (array2, find);
if (NewNumber > 0)
    Console.Write("yes");
else Console.Write("no");
*/

/*bool NewArray (int [] array, int find_numb)
{
    for ( int i = 0; i < array.Length; i++)
    {
        if (array[i] == find_numb)
        {
            return true;
        }
    
    }
    return false;
}

int []array2 = {6, 7, 19, 345, 3};

int find = 4;

int NewNumber = NewArray (array2, find);
if (NewNumber > 0)
    Console.Write("yes");
else Console.Write("no");
*/


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int NewArraySize (int start_size)
{
    int end_size = 0;
    if (start_size % 2 == 0)
        end_size = start_size / 2;
    else
        end_size = start_size / 2 + 1;
    return end_size;
}

int [] Multi (int [] massive)
{
    int result_size = NewArraySize(massive.Length);
    int [] resultArrayresultArray = new int [result_size];
    for( int i = 0; i < massive.Length / 2 + 1; i++)
    {
        if (i == massive.Length - 1 - i)
            resultArray[i] = massive[i];
        else
            resultArray[i] = massive[i] * massive[massive.Length - 1 - i];

    }
    return resultArray;
}

int [] firstArray = CreateNewArray(5, 0, 9);
ShowArray(firstArray);

int [] secondArray = Multi(firstArray);
ShowArray(secondArray);