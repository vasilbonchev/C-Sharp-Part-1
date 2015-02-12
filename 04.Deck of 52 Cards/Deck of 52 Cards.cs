using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).//




class Deck52Cards
{
    static void Main()
    {
        int sum = 0;
        string[] suits = new string[] { "hearts", "spades", "diamonds", "clubs" };
        string[] ranks = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        for (int card = 0; card < 13; card++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                Console.Write("{0} of {1}, ", ranks[card], suits[suit]);
                sum++;
            }
            Console.WriteLine();
        }
    }
}

