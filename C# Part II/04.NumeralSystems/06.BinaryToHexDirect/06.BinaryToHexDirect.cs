//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Text;
class BinaryToHexDirect
{
    static StringBuilder hex = new StringBuilder();

    static void AppendFourBitsFromHex(string bin)
    {
        for (int i = bin.Length-4; i >=-bin.Length%4 ; i-=4)
        {
            string bits = string.Empty;
            if(i<0)
            {
                i = 0;
                bits = bin.Substring(i, bin.Length % 4).PadLeft(4, '0');
            }
            else
            {
                bits = bin.Substring(i, 4);
            }
            switch (bits)
            {
                case "0000": hex.Append("0"); break;
                case "0001": hex.Append("1"); break;
                case "0010": hex.Append("2"); break;
                case "0011": hex.Append("3"); break;
                case "0100": hex.Append("4"); break;
                case "0101": hex.Append("5"); break;
                case "0110": hex.Append("6"); break;
                case "0111": hex.Append("7"); break;
                case "1000": hex.Append("8"); break;
                case "1001": hex.Append("9"); break;
                case "1010": hex.Append("A"); break;
                case "1011": hex.Append("B"); break;
                case "1100": hex.Append("C"); break;
                case "1101": hex.Append("D"); break;
                case "1110": hex.Append("E"); break;
                case "1111": hex.Append("F"); break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }

    static void Main()
    {
        AppendFourBitsFromHex("10111101001011");
        char[] reversedHex = hex.ToString().ToCharArray();
        Array.Reverse(reversedHex);
        Console.WriteLine(reversedHex);
    }
}