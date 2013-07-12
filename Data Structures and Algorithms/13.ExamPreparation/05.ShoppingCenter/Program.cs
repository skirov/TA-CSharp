using System;
using System.Text;
class Program
{
    static void Main()
    {
        ShoppingCenter engine = new ShoppingCenter();
        int numberOfCommands = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < numberOfCommands; i++)
        {
            result.AppendLine(engine.ParseCommands(Console.ReadLine()));
        }

        Console.WriteLine(result.ToString());
    }
}

