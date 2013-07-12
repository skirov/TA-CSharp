using System;
using System.Globalization;
using System.Text.RegularExpressions;
class ExtractDatesAndShowThemForCanada
{
    static void Main()
    {
        string text = "Lorem ipsum 17.17.2035 dolor sit amet, consectetur 05.12.2012 adipiscing elit. Proin in rutrum sem. Integer ornare est a tortor ultrices et tempus2004.1.2000 eros interdum. ";

        MatchCollection matchDates = Regex.Matches(text, @"\b\d{2}\.\d{2}\.\d{4}\b");

        DateTime date = new DateTime();

        foreach (var matchedDate in matchDates)
        {
            bool isValidDate = DateTime.TryParse(matchedDate.ToString(), out date);
            if (isValidDate)
            {
                Console.WriteLine("{0}", date.ToString("d.m.y", CultureInfo.CreateSpecificCulture("ca-CA")));
            }
        }
    }
}