using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.//




class Numbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n;
        for (int i = 1; i <= a; i++)
        {
            Console.Write(i + " ");
        }
        
    }
}

