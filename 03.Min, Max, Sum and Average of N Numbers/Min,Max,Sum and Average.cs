using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).//
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.//
//The output is like in the examples below.//



class MinMaxSumAndAverage
{
    static void Main()
    {

        int number1, number2, number3;
        double min = 0, max = 0, sum = 0, avg = 0;


        int amount = int.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++)
        {
            number1 = int.Parse(Console.ReadLine());
            sum += number1;
            if (number1 > max)
            {
                max = number1;
            }
            if (number1 < max)
            {
                min = number1;
            }

        }



        avg = sum / amount;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0}", Math.Round(avg, 2));

        

    }
}

