using System;
class SqrtNumber
{
    static double Sqrt(double number)
    {
        if (number<0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return Math.Sqrt(number);
        }
    }
    static void Main()
    {
        Console.Write("Enter a number bigger than 0: ");
        try
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine("The square root is {0}.", Sqrt(input));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number must be greater than 0.");
        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter an integer.");
        }
        finally
        {
            Console.WriteLine("Please try again");
        }
    }
}

