using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

class MessagesInABottle
{
    static List<KeyValuePair<char, string>> cipherDict = new List<KeyValuePair<char, string>>();
    static OrderedBag<string> results = new OrderedBag<string>();
    static string code;

    static void Main()
    {
        code = Console.ReadLine();
        string fullCipher = Console.ReadLine();

        for (int i = 0; i < fullCipher.Length; i++)
        {
            //if is letter
            if ('A' <= fullCipher[i] && fullCipher[i] <= 'Z')
            {
                char key = fullCipher[i];
                StringBuilder codeForTheLetter = new StringBuilder();
                for (int j = i+1; j < fullCipher.Length; j++)
                {
                    //if is digit
                    if ('0' <= fullCipher[j] && fullCipher[j] <= '9')
                    {
                        codeForTheLetter.Append(fullCipher[j]);
                    }
                    else
                    {
                        break;
                    }
                }

                cipherDict.Add(new KeyValuePair<char, string>(key, codeForTheLetter.ToString()));
            }
        }

        Solve(0, 0);

        if (results.Count == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(results.Count);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }

    static StringBuilder result = new StringBuilder();

    static void Solve(int codePosition, int cipherPosition)
    {
        if (codePosition >= code.Length)
        {
            results.Add(result.ToString());
            return;
        }

        foreach (var cipher in cipherDict)
        {
            if (codePosition+cipher.Value.Length <= code.Length)
            {
                if (code.Substring(codePosition, cipher.Value.Length) == cipher.Value)
                {
                    result.Append(cipher.Key);
                    Solve(codePosition + cipher.Value.Length, cipherPosition);
                    result.Remove(result.Length - 1, 1);
                }
            }
        }
    }
}