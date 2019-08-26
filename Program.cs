using System;
using System.Linq;
using System.Collections.Generic;

namespace DiceRacer
{

    class Dice
    {
        Random rand = new Random();
        int value;

        public Dice()
        {
            this.value = this.rollDice();
        }

        public int rollDice()
        {
            return rand.Next(1, 6);
        }

    }
    class Deck
    {
        public List<Card> newDeck = new List<Card>();

        public List<Card> CreateDeck()
        {
            for (int face = 2; face <= 14; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    Card card = new Card(face, suits);
                    newDeck.Add(card);
                }
            }

            return newDeck;
        }


        public Card Shuffle()
        {

        }

    }

    public class Card
    {
        public enum SuitValues { Clubs = 0, Diamonds = 1, Hearts = 2, Spades = 4 };
        Array suits = Enum.GetValues(typeof(SuitValues));
        SuitValues randomSuitValue = (SuitValues)(new Random()).Next(0, 3);

        Random randomCardValue = new Random();

        public int CardValue;
        public string CardSuit;

        public Card()
        {
            this.CardValue = randomCardValue.Next( 1, 14);
            this.CardSuit = randomSuitValue.ToString();
        }

        public Card(int CardValue, int CardSuit)
        {
            this.CardValue = CardValue;
            this.CardSuit = randomSuitValue.ToString();
        }

        public Card(int CardValue)
        {
            this.CardValue = randomCardValue.Next(1, 14);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




}
