using System;
class NumbersInRange
{//i'm not sure about the task so i made users to enter the inuput
    static void ReadNumber(int start, int end)
    {
        int number;
        Console.Write("Enter a number: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out number);
        if (isNumber == false)
        {
            throw new FormatException();
        }
        else if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            Console.WriteLine("{0} is in range between {1} and {2}", number, start, end);
        }
    }
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(1, 100);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number must be between 1 and 100");
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid integer number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("You have enter a number too big or too small to fit in an integer");
            }

        }
    }
}