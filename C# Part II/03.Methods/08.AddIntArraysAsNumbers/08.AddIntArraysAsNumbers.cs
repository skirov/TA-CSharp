using System;
using System.Collections.Generic;
class AddIntArraysAsNumbers
{
    static Stack<int> sum = new Stack<int>();
    static int[] numberArray1;
    static int[] numberArray2;
    static void AddInArray(string input1, string input2)
    {
        int arraysLength = Math.Max(input1.Length, input2.Length);
        numberArray1 = new int[arraysLength];
        numberArray2 = new int[arraysLength];
        for (int i = 1; i <= input1.Length; i++)
        {
            int number = input1[input1.Length - i] - '0'; //a trick to get the number out of the char
            numberArray1[arraysLength - i] = number;
        }
        for (int i = 1; i <= input2.Length; i++)
        {
            int number = input2[input2.Length - i] - '0'; //a trick to get the number out of the char
            numberArray2[arraysLength - i] = number;
        }
    }

    static void AddArrays(int[] array1, int[] array2)
    {
        int reminder = 0;
        for (int i = array2.Length - 1; i >= 0; i--)
        {
            int whatToAdd = 0;
            if (i>0)
            {
                whatToAdd = (array1[i] + array2[i]) % 10;
                if (whatToAdd + reminder >= 10)
                {
                    sum.Push((whatToAdd+reminder)%10);
                }
                else
                {
                    sum.Push(whatToAdd + reminder);
                }
            }
            else
            {
                whatToAdd = array1[i] + array2[i];
                sum.Push(whatToAdd + reminder);
            }

            if (array1[i] + array2[i] + reminder >= 10 && array1[i] + array2[i] + reminder < 20)
            {
                reminder = 1;
            }
            else
            {
                reminder = 0;
            }

        }
    }
    static void Main()
    {
        AddInArray("9825823257757597925792592597353529579929239235923529", "972397259253923592357379935929579929239235923529");

        AddArrays(numberArray1, numberArray2);
        foreach (var item in sum)
        {
            Console.Write(item);
        }
    }
}