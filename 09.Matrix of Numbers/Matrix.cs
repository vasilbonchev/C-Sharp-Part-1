using System;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.



class Matrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            int counter = 1;
            while (counter <= number)
            {
                Console.Write("{0} ", counter + i);
                counter++;
            }
            Console.WriteLine();
        }
    }
}

