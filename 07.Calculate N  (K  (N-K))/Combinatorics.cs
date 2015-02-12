using System;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.




class Math
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int difference = n - k;

        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger diffFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;

            if (i <= k)
            {
                factorielK *= i;
            }

            if (difference >= i)
            {
                diffFactorial *= i;
            }
        }

        Console.WriteLine(factorielN / (factorielK * diffFactorial));

    }
}

