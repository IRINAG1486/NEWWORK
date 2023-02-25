//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Create2DArray ()
{
Console.WriteLine ("Inpyt count of rows: ");
int row =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Inpyt count of columns: ");
int column =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Inpyt minimal passible value: ");
int min =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Inpyt maximal passible value: ");
int max =  Convert.ToInt32(Console.ReadLine());

int [,] create2dArray = new int [row, column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        create2dArray [i, j] = new Random().Next (min, max + 1);
    }
}
return create2dArray;
}

void Print2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + " ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int [,] Change2DArrayRows (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int max = 0; max < array.GetLength(1) - 1; max++)
            {
               
                if (array [i,max] < array [i, max + 1]) 
                {
                int temp = array [i,max];
                array [i,max] = array [i, max + 1];
                array [i,max + 1] = temp;
                }
            }
        }
    }
    return array;
}

int [,] NewArray = Create2DArray ();
Print2DArray (NewArray);
Print2DArray (Change2DArrayRows (NewArray));
*/

//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int [] FindSummOfEachRows (int [,] array)
{
    int [] arrayForSumm = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array [i,j];
        }
        arrayForSumm [i] = sum;
        //Console.WriteLine(arrayForSumm [i] + " ");
    }
    return arrayForSumm;
}


void FindRowsWithMinSumm (int [] array)
{
    int minSum = array [0];
    int indexMin = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array [i] <= minSum)
        {
            minSum = array [i];
            indexMin = i;
        }

        
    }
    Console.WriteLine($"String with minimal summ is {indexMin}"); 
}

void PrintArray (int [] array2)
 {
    for (int i = 0; i < array2.Length; i++)
    {
        Console.WriteLine(array2 [i] + " ");
    }
    Console.WriteLine();
 }


int [,] NewArray = Create2DArray ();
Print2DArray (NewArray);
PrintArray (FindSummOfEachRows (NewArray));

FindRowsWithMinSumm(FindSummOfEachRows(NewArray));
*/


//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

/*void AmountOfEachElement (int [,] array)
{
    int count = 0;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             int result = 0;
            for (int inum = 0; inum < array.GetLength(0); inum++)
            {
                for (int jnum = 0; jnum < array.GetLength(1); jnum++)
                {
                    if (array [i,j] == array [inum, jnum]) count++;
                   
                }
               
            }
            Console.WriteLine($"{array [i,j]} is met {count} times");
            count = result;
        }
        
        
    }
     
    
}
*/



void AmountOfEachElement (int [,] array)
{
    int count = 0;
   
    int result = 0;
    for (int temp = 0; temp <= 9; temp++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
             
                if (array [i,j] == temp) count++;
                      
            }
        
        }
    Console.WriteLine($"{temp} is met {count} times");  
   
    count = result;
    }
}


int [,] NewArray = Create2DArray ();
Print2DArray (NewArray);
AmountOfEachElement (NewArray);