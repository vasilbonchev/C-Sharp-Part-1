using System;
class RandomNumbers
{
    static void Main()
    {
        while (true)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 1000);
            int counterHodove = 0;
            while (true)
            {
                counterHodove++;
                Console.Write("Insert number: ");
                // variable scope - vidimost na promenlivata
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                Console.Clear();

                if (number < secretNumber)
                {
                    Console.WriteLine("Up");
                }
                else if (number > secretNumber)
                {
                    Console.WriteLine("Down");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("You guess! The number is: " + secretNumber + " You win with: " + counterHodove + " hoda");

            Console.WriteLine("One more game? (yes) or tap any key to terminate");
            String responseNewGame = Console.ReadLine();
            if (responseNewGame.ToUpper().Equals("Yes".ToUpper()))
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }
}