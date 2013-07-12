using System;
using System.Text.RegularExpressions;
class ExtractEmail
{
    static void Main()
    {
        string text = "Lorem ipsum test@test dolor sit amet, consectetur test_4me@test.co.uk adipiscing elit-test_4me@test.info";

        MatchCollection matchEmails = Regex.Matches(text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

        foreach (var email in matchEmails)
        {
            Console.WriteLine(email);
        }
    }
}