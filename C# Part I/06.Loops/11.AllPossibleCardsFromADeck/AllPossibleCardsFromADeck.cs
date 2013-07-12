//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.
using System;
using System.Collections.Generic;

class AllPossibleCardsFromADeck
{
    static void Main()
    {
        string[] suit = { "spades", "hearts", "diamonds", "clubs" };
        for (int i = 2; i <= 14; i++)//for the cards
        {
            for (int j = 0; j < 4; j++)//for the suit
			{
                switch (i)
                {
                    case 2: Console.WriteLine("Two of {0}", suit[j]);
                        break;
                    case 3: Console.WriteLine("Three of {0}", suit[j]);
                        break;
                    case 4: Console.WriteLine("Four of {0}", suit[j]);
                        break;
                    case 5: Console.WriteLine("Five of {0}", suit[j]);
                        break;
                    case 6: Console.WriteLine("Six of {0}", suit[j]);
                        break;
                    case 7: Console.WriteLine("Seven of {0}", suit[j]);
                        break;
                    case 8: Console.WriteLine("Eight of {0}", suit[j]);
                        break;
                    case 9: Console.WriteLine("Nine of {0}", suit[j]);
                        break;
                    case 10: Console.WriteLine("Ten of {0}", suit[j]);
                        break;
                    case 11: Console.WriteLine("Jack of {0}", suit[j]);
                        break;
                    case 12: Console.WriteLine("Queen of {0}", suit[j]);
                        break;
                    case 13: Console.WriteLine("King of {0}", suit[j]);
                        break;
                    case 14: Console.WriteLine("Ace of {0}", suit[j]);
                        break;
                    default: Console.WriteLine("Someting went wrong");
                        break;
                }
			}
        }
    }
}