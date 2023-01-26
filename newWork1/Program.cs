Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int digit_3 = num % 10;
    console.WriteLine($"Third digit is {digit_3}");     
}
else
{
    Console.WriteLine("your number is not 3-digit!");
}





