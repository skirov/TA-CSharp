using System;
class CheckExpression
{
    static void Main()
    {
        string input = Console.ReadLine();
        int countBackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                countBackets++;
            }
            else if (input[i] == ')')
            {
                countBackets--;
            }
        }

        if (countBackets==0)
        {
            Console.WriteLine("Correct Expression");
        }
        else
        {
            Console.WriteLine("Inorrect Expression");
        }
    }
}

