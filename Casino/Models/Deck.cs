using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casino.Models
{
    public  class Deck
    {

        public  List<Card> deck;


        public  Deck()
        {
            deck = Shuffle(PopulateDeck());
        }


        public static List<string> suits
        {
            get
            {
                return new List<string> { "heart", "spade", "diamond", "club" };
            }
        }

        public  List<Card> PopulateDeck()
        {
           List<Card> cards = new List<Card>();

            for(int suit=0;suit < 4; ++suit)
            {
                for(int i = 1; i < 14; ++i)
                {
                    cards.Add(new Card(i, suits[suit]));
                }
            }
            return cards;
        }

      
        public  List<E> Shuffle<E>(List<E> cards)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (cards.Count > 0)
            {
                randomIndex = r.Next(0, cards.Count); //Choose a random object in the list
                randomList.Add(cards[randomIndex]); //add it to the new, random list
                cards.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }

    }
}