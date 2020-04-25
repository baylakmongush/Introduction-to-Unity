using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("\t\t\t\tWelcom!\n");
            Console.WriteLine("This program'll deal two cards to three players (including the dealer),");
            Console.WriteLine("\t\tthen print the cards for each player.\n");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1 = deck.TakeTopCard();
            Card cplayer1 = deck.TakeTopCard();
            Card player2 = deck.TakeTopCard();
            Card cplayer2 = deck.TakeTopCard();
            Card player3 = deck.TakeTopCard();
            Card cplayer3 = deck.TakeTopCard();

            // flip all the cards over
            player1.FlipOver();
            player2.FlipOver();
            player3.FlipOver();
            cplayer1.FlipOver();
            cplayer2.FlipOver();
            cplayer3.FlipOver();

            // print the cards for player 1
            Console.WriteLine("\nThe cards for player 1: \n");
            Console.WriteLine("First Card: " + player1.Rank + " of " + player1.Suit);
            player1 = deck.TakeTopCard();
            Console.WriteLine("Second Card: " + cplayer1.Rank + " of " + player1.Suit);

            // print the cards for player 2
            Console.WriteLine("\nThe cards for player 2: \n");
            Console.WriteLine("First Card: " + player2.Rank + " of " + player2.Suit);
            player2 = deck.TakeTopCard();
            Console.WriteLine("Second Card: " + cplayer2.Rank + " of " + player2.Suit);

            // print the cards for player 3
            Console.WriteLine("\nThe cards for player 3: \n");
            Console.WriteLine("First Card: " + player3.Rank + " of " + player3.Suit);
            player3 = deck.TakeTopCard();
            Console.WriteLine("Second Card: " + cplayer3.Rank + " of " + player3.Suit);

            Console.WriteLine();
        }
    }
}
