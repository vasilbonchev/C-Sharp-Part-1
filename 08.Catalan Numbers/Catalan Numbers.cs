using System;
using System.Numerics;

//In combinatorics, the Catalan numbers are calculated by the following formula: 
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


class CatalanNumbers
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger numberFactoriel = 1;

        BigInteger numberIncremented = number + 1;
        BigInteger incrementedFactorial = 1;

        BigInteger doubleNumber = number * 2;
        BigInteger doubleFactoriel = 1;

        int counter = 1;

        while (counter <= number)
        {
            numberFactoriel *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= numberIncremented)
        {
            incrementedFactorial *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= doubleNumber)
        {
            doubleFactoriel *= counter;
            counter++;
        }

        BigInteger catalan = doubleFactoriel / (incrementedFactorial * numberFactoriel);

        Console.WriteLine("{0}", catalan);     
    }
}

