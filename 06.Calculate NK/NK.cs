using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).//




class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorielN = 1;
        int factorielk = 1;

        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
            if (i <= k)
            {
                factorielk *= i;
            }
        }
        Console.WriteLine(factorielN / factorielk);
    }
}

