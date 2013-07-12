using System;
class SolveThreeTasks
{
    static void PrintUserMenu()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("1) Reverse digits of a number");
        Console.WriteLine("2) Calculate average from sequence of integers");
        Console.WriteLine("3) Solve a linear equation a * x + b = 0");
        Console.WriteLine("-----------------------------------------");
    }

    static void ReverseDigits()
    {
        Console.Write("Enter a positive decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        if (number<0)
        {
            Console.WriteLine("The number must be positive.");
            return;
        }
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        Console.Write("Number -> {0} Reversed -> ", number);
        foreach (var digit in digits)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    static void AverageSequence()
    {
        Console.Write("Enter numbers in one row: ");
        string input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
	    {
            Console.WriteLine("Please enter a number.");
		    return;
	    }
        string[] numbers = input.Split();
        double sum = 0;
        foreach (var number in numbers)
        {
            sum += double.Parse(number);
        }
        Console.WriteLine("Average of numbers -> {0}", sum / numbers.Length);
    }

    static void SolveLinearEqusion()
    {
        Console.Write("Enter a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        if (a==0)
        {
            Console.WriteLine("A cannot be equal to 0.");
        }
        else
        {
            Console.WriteLine("x = {0}",-b / a);            
        }
    }

    static void Main()
    {
        PrintUserMenu();

        byte input = byte.Parse(Console.ReadLine());
        switch (input)
        {
            case 1: ReverseDigits();
                break;
            case 2: AverageSequence();
                break;
            case 3: SolveLinearEqusion();
                break;
            default: Console.WriteLine("Enter a number between 1 and 3 inclusive.");
                break;
        }
    }
}