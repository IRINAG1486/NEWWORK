/* int [] NewArray (int size)
{
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray [i] = new Random(). Next(-100, 100);
    }
    return randomArray;
}
 void PrintArray (int [] array2)
 {
    for (int i = 0; i < array2.Length; i++)
    Console.Write(array2 [i] + " ");
 }

 Console.WriteLine("Input length of array: ");
 int user_length = Convert.ToInt32(Console.ReadLine());

 int [] array3 = NewArray(user_length);
 PrintArray(array3);
 */

 /*int SummofNumbers (int number)
 {
    int sum = 0;

    while (number > 0)
    {
        int num1 = number % 10;
        sum = sum + num1;
        number = number / 10;
    }
    return sum;

 }

 Console.WriteLine("Input your number: ");
 int user_number = Convert.ToInt32(Console.ReadLine());

 if (user_number < 0)
    Console.Write("Your number is incorrect");
else
 Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number)}");
*/

/*int SummofNumbers (int number)
 {
    int sum = 0;

    while (number > 0)

    {
        int num1 = number % 10;
        sum = sum + num1;
        number = number / 10;
    }
    return sum;

 }

 Console.WriteLine("Input your number: ");
 int user_number = Convert.ToInt32(Console.ReadLine());

 int user_number1 = (-1) * user_number;

 if (user_number > 0)
    Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number)}");

 else
    Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number1)}");
    */


void Stepen (int a, int b)
{
    if (a > 0 && b > 0)
    {
        double result = Math.Pow(a, b);
        Console.Write($"Digit {a} in stpen {b} is {result}");
    }
    else
        Console.Write("your numbers is incorrect");

}

Console.WriteLine("Input first number: ");
 int first_number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input second number: ");
 int second_number = Convert.ToInt32(Console.ReadLine());

 Stepen (first_number, second_number);