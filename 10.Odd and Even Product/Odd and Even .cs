using System;

//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.



class OddAndEven
{
    static void Main()
    {
        Console.Write("type the numbers on one line: ");
        string numbers = Console.ReadLine();

        string[] splittedNumbers = numbers.Split(new char[] { ' ' });

        int length = splittedNumbers.GetLength(0);
        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                oddProduct *= int.Parse(splittedNumbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(splittedNumbers[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

