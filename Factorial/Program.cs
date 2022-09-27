using System;
class Program
{
    static void Main()
    {
        int fact = 1;
        Console.Write("Enter Number to Find Factorial :");

        try
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please Enter Numeric Number");
        }
        
        Console.WriteLine(fact);
    }
}