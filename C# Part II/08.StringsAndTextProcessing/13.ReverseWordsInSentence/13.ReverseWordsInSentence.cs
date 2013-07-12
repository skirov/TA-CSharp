using System;
class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        string[] splitText = text.Split(' ');

        Array.Reverse(splitText);

        foreach (var item in splitText)
        {
            Console.Write("{0} ", item);
        }
    }
}

