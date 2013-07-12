//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0
using System;
using System.Collections.Generic;

class SubsetSumZero
{
    static void Main()
    {
        int[] array = { -3, -5, 1, -1, 8 };

        //If the sum of five elements is zero
        if (array[0] + array[1] + array[2] + array[3] + array[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} == 0", array[0], array[1], array[2], array[3], array[4]);
            return;
        }

        for (int i = 0; i < array.Length; i++)
        {
            //If the sum of two elements is zero 
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == 0)
                {
                    Console.WriteLine("{0} + {1} == 0", array[i], array[j]);
                    return;
                }
                //If the sum of three elements is zero
                for (int k = 2; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} == 0", array[i], array[j], array[k]);
                        return;
                    }
                    //If the sum of four elements is zero
                    for (int l = 3; l < array.Length; l++)
                    {
                        if (array[i] + array[j] + array[k] + array[l] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} == 0", array[i], array[j], array[k], array[l]);
                            return;
                        }
                    }
                }
            }
        }
    }
}