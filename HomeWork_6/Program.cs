/*double [] CreateArray (int size, double k1, double k2, double b1, double b2)
{   
   
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        int x = 2;
        int y = 2;  //k2 * x + b2;
        array [0] = array [x];
        array [1] = array [y];
        
    }
    return array;

}
Console.Write("Input number one: ");
double num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
double num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number three: ");
double num_3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number four: ");
double num_4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());


if(num_1 == num_2)
    Console.Write("Прямые паралельны");
else if (num_1 == num_2 && num_3 == num_4)
    Console.Write("Прямые СОВПАДАЮТ"); 
else
CreateArray (size, num_1, num_2, num_3, num_4);
*/

/*void CreateArray (double k1, double k2, double b1, double b2)
{
    if(k1 == k2)
        Console.Write("Прямые паралельны");
    else if (k1 == k2 && b1 == b2)
        Console.Write("Прямые совпадают");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k2 * x) + b2;
        Console.Write($"Точка пересечения прямых имеет координаты {x} and {y}");
    }

}

Console.Write("Input numbe one: ");
double num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
double num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number three: ");
double num_3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number four: ");
double num_4 = Convert.ToInt32(Console.ReadLine());

CreateArray (num_1, num_2, num_3, num_4);
*/

/*int CountPositivNumbers ()
{
    string userNumber =  String.Empty;
    int count = 0;
   while (userNumber != "z")
    {
        
    Console.WriteLine ("Input your number and press ENTER: ");
    userNumber = Console.ReadLine();
    int firstArg = Convert.ToInt32(userNumber);
 
        {

            
            {
            
                if (firstArg > 0)
                count = count + 1;
            }
            
        }
     
    
    }
   
    return count;    
    
}


int result = CountPositivNumbers ();
Console.WriteLine($"Count of entered numbers which > 0 is {result}");
*/

int CountPositivNumbers (int c)
{
    int count = 0;
   for (int i = 0; i < c; i++)
    {
    Console.WriteLine ("Input your number and press ENTER: ");
      
    int Number = Convert.ToInt32(Console.ReadLine());  
    
   
        {
           
                if (Number > 0)
                count = count + 1;
                
            
            
        } 
    
    }
  return count;
    
    
    }
   
Console.Write("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


int result = CountPositivNumbers (userNumber);
Console.WriteLine($"Count of entered numbers which > 0 is {result}");

