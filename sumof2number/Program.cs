using System; // System is a namespace

public class SumOfNumber
{
    // Main method which starts the program execution.
    public static void Main()
    {
        int number, sum=0;
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine()); 
        Console.Write("Sum of Number '"+number+ "' : ");

        for (int i = 1; i <= number; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);

     }
}