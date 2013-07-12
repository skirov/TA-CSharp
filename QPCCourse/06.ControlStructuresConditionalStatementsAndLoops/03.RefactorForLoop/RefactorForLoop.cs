// <copyright file="RefactorForLoop.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace RefactorForLoop
{
    using System;

    /// <summary>
    /// This class represents task 3 from homework Control structures, conditional statements and loops
    /// </summary>
    public class RefactorForLoop
    {
        /// <summary>
        /// Prints a number divisible by 10 which is equal to <paramref name="expecdedValue"/>
        /// </summary>
        /// <param name="array">Array to check</param>
        /// <param name="expecdedValue">Value to stop for loop</param>
        private static void PrintRequestedNumberDivisibleBy10(int[] array, int expecdedValue)
        {
            int arrayLength = array.Length;

            for (int index = 0; index < arrayLength; index++)
            {
                if (index % 10 == 0)
                {
                    Console.WriteLine(array[index]);

                    if (array[index] == expecdedValue)
                    {
                        Console.WriteLine("Number was found - {0}", array[index]);
                        return;
                    }
                }
            }

            Console.WriteLine("Value '{0}' was not found", expecdedValue);
        }

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        private static void Main()
        {
            int expecdedValue = 20; // a number divisible by 10

            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            PrintRequestedNumberDivisibleBy10(array, expecdedValue);
        }
    }
}