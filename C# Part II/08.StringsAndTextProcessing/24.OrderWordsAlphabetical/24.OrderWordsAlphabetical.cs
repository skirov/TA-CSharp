using System;
using System.Linq;
class OrderWordsAlphabetical
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        foreach (var item in input.OrderBy(x => x))
        {
            Console.WriteLine(item);
        }
    }
}

