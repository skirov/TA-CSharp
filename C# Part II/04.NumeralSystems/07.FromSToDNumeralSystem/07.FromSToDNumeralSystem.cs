using System;
class FromSToDNumeralSystem
{
    static int s;
    static int d;
    static int ToDecimal(string input)
    {
        int toDecimal = 0;
        for (int i = input.Length-1; i >= 0; i--)
        {
            switch (input[i])
            {
                case 'A': toDecimal += 10 * (int)Math.Pow(s, i);
                    break;                                
                case 'B': toDecimal += 11 * (int)Math.Pow(s, i);
                    break;                                
                case 'C': toDecimal += 12 * (int)Math.Pow(s, i);
                    break;                                
                case 'D': toDecimal += 13 * (int)Math.Pow(s, i);
                    break;                                
                case 'E': toDecimal += 14 * (int)Math.Pow(s, i);
                    break;                                
                case 'F': toDecimal += 15 * (int)Math.Pow(s, i);
                    break;
                default: toDecimal += (input[i] - '0') * (int)Math.Pow(s, i);
                    break;
            }
        }
        return toDecimal;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        s = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        Console.WriteLine(ToDecimal(input));
    }
}

