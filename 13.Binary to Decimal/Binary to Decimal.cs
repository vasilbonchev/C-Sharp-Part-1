using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.



class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Binary: ");
        string binary = Console.ReadLine();
        int iter = binary.Length;
        int decimalN = 0;

        for (int i = 0; i < iter; i++)
			{
                int index = binary.Length - 1;
                string bit = binary.Substring(index, 1);
                decimalN += (int.Parse(bit)) * ((int)Math.Pow(2, i));
                binary = binary.Substring(0, binary.Length - 1);

			}
        Console.WriteLine(decimalN);
    }
}

