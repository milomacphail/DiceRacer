using System;
using System.Linq;
using System.Collections.Generic;

namespace DiceRacer
{
    class Card
    {
        public enum SuitValues { Clubs = 0, Diamonds = 1, Hearts = 2, Spades = 3 };
        Array suits = Enum.GetValues(typeof(SuitValues));
        SuitValues SuitValue = (SuitValues)(new Random()).Next(0, 4);

        public int CardValue;
        public string CardSuit;

        Random value = new Random();

        public Card()
        {
            this.CardValue = value.Next(1, 7);
            this.CardSuit = SuitValue.ToString();
        }

        public Card(int CardValue, int CardSuit)
        {
            this.CardValue = CardValue;
            this.CardSuit = SuitValue.ToString();
        }

        public Card(int CardValue)
        {
            this.CardValue = value.Next(1, 7);
        }


    }

    class Deck
    {
        public List<Card> deck = new List<Card>();

        public Deck()
        {
            for (int face = 1; face <= 7; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    Card card = new Card(face, suits);
                    deck.Add(card);
                }
            }
        }

        /*public IEnumerable<Card> Shuffle()
        {
           Random random = new Random();
           IOrderedEnumerable<Card> shuffled = deck.OrderBy(Card => random.Next());
           return shuffled;
        }*/

        public List<Card> Shuffle()
        {
            Random random = new Random();
            IOrderedEnumerable<Card> shuffled = deck.OrderBy(Card => random.Next());
            List<Card> shuffledList = shuffled.ToList();
            return shuffledList;
        }

        public List<Card> QualityCheck()
        {
            int listLength = deck.Count();

            if (deck[0].CardValue == 1 || deck[0].CardValue == 2 || deck[0].CardValue == 6 || deck[0].CardValue == 7 ||
                deck[1].CardValue == 1 || deck[1].CardValue == 2 || deck[1].CardValue == 6 || deck[1].CardValue == 7 ||
                deck[listLength].CardValue == 1 || deck[listLength].CardValue == 2 || deck[listLength].CardValue == 6 || deck[listLength].CardValue == 7 ||
                deck[listLength - 1].CardValue == 1 || deck[listLength - 1].CardValue == 2 || deck[listLength - 1].CardValue == 6 || deck[listLength - 1].CardValue == 7)
            {
                Shuffle();
            }

                return deck;
        }

    }

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


    class Output
        {
            public static void ConsoleIt(dynamic deck)
            {
                foreach (Card item in deck)
                {
                  Console.WriteLine("Card:   {0} of {1}", item.CardValue, item.CardSuit.ToString()); ;
                }

                //Console.WriteLine("Total Cards:  {0}");
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            var shuffleDeck = newDeck.Shuffle();

            Output.ConsoleIt(shuffleDeck);
        }
    }




}
