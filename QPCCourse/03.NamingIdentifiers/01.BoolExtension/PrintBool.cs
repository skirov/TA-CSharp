namespace SimpleClasses
{
    using System;
    using System.Linq;

    public class PrintBool
    {
        public void PrintBoolToString(bool boolToPrint)
        {
            string convertBoolToString = boolToPrint.ToString();
            Console.WriteLine(convertBoolToString);
        }
    }
}
