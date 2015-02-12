using System;
//Using loops write a program that converts a hexadecimal integer number to its decimal form.




class HexaToDec
{
    static void Main()
    {
        Console.Write("hexadecimal: ");
        string hexadecimal = Console.ReadLine();
        int length = hexadecimal.Length;
        long decimalNumber = 0;
        string[] hex = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < length; i++)
        {
            string substring = hexadecimal.Substring(hexadecimal.Length - 1, 1);
            long index = Array.IndexOf(hex, substring);

            if (index < 0)
            {
                Console.WriteLine("\nThere is a bad input!\nPlease use capital letters A-F and digits.\n");
                decimalNumber = -1;
                return;
            }

            long power = (long)Math.Pow(16, i);

            hexadecimal = hexadecimal.Substring(0, hexadecimal.Length - 1);
            decimalNumber += index * power;
        }

        Console.WriteLine(decimalNumber);
    }
}

