using System;
using System.Collections.Generic;
using System.Numerics;

class TrailingZerosInFactoriel
{
    static BigInteger CalculateFactoriel(int number)
    {
        BigInteger factoriel = 1;
        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }

        return factoriel;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorielNumber = CalculateFactoriel(n);

        byte counter = 0;

        while (factorielNumber%5 == 0) //while there is a 0 at the end
        {
            counter++; //increase the counter
            factorielNumber /= 10; //remove the last zero
        }

        Console.WriteLine("{0} -> {1}", CalculateFactoriel(n), counter);
    }
}