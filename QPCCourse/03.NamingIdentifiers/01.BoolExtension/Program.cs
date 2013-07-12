namespace SimpleClasses
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            PrintBool boolPrint = new PrintBool();
            boolPrint.PrintBoolToString(true);
        }
    }
}
