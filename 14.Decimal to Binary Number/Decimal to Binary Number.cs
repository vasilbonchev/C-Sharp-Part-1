using System;

//Using loops write a program that converts an integer number to its binary representation.



class DecimalBinary
{
    static void Main()
    {
        Console.Write("decimal: ");
        int number = int.Parse(Console.ReadLine());
        string binary = string.Empty;

        if (number == 0)
        {
            Console.WriteLine("0");
            return;
        }

        do
        {
            int bit = number % 2;
            number /= 2;
            binary = Convert.ToString(bit) + binary;
        }
        while (number > 1);

        binary = Convert.ToString(number) + binary;
        Console.WriteLine(binary);
    }
}

