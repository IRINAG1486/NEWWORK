// Решаю задачи лекции

// Первая задача. Нахождение максимума из 9 чисел.

/*int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 98;
int a3 = 13;
int b3 = 61;
int c3 = 32;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(c2 > max) max = c2;
if(b2 > max) max = b2;

if(a3 > max) max = a3;
if(c3 > max) max = c3;
if(b3 > max) max = b3;

Console.WriteLine(max);

*/

// Теперь в этой же задаче воспользуемся функциями

/*int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 61;
int c3 = 32;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 =  Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
*/


/*int Max (int arg1, int arg2, int arg3) // внесла изменения воформление
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 78;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 5326;
int a3 = 13;
int b3 = 61;
int c3 = 32;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
*/



// Задача массивы

/*int [] array = {34, 45, 12, 45, 5, 9, 46};
int n = array.Length;
int find = 46;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
*/

/*int Max (int arg1, int arg2, int arg3) // в этом примере функция макс объявлена но не используется
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array = {34, 45, 12, 45, 5, 9, 46};
array[0] = 25;
Console.WriteLine(array[0]);
*/

// Следующий пример

/*int Max (int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array = {34, 45, 12, 106, 5, 9, 46, 65, 90};

int result = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(result);
*/


// Еслив массиве несколько одинаковых элементов то алгоритм покажет их все, поэтому можно использовать оператор break

/*int [] array = {34, 45, 12, 45, 5, 9, 46};
int n = array.Length;
int find = 45;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // необходимый оператор
    }
    index++;
}
*/

// Следующая задача создает массив из случайных чисел с помощью метода 1 - FillArray и выводит его на экран с помощью второго метода PrintArray

/*void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
*/

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);
