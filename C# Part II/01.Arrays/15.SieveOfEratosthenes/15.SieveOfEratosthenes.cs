//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] isPrime = new bool[10000000];

        for (int i = 2; i < isPrime.Length; i++)
        {
            if (isPrime[i] == true)
            {
                continue;
            }
            else
            {
                for (int j = i; j < Math.Sqrt(isPrime.Length); j++)
                {
                    isPrime[i * j] = true;
                }
            }
        }
    }
}