using System;
using System.Text;

public static class SubstringExtension
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.Append("123456789");

        Console.WriteLine(text.Substring(3, 3));
        Console.WriteLine(text.Substring(3));
    }
}

