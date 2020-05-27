using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casino.Models
{
    public class Card
    {

        public int Number { get; set; }
        public int Value { get
            { 
                if (Number > 10)
                {
                    return 10;
                }
                else if (Number == 1)
                {
                    return 11;
                }
                else
                    return Number;
            }
        }

        public string Suit { get; set; }
        public string Name { get 
            {
                return Number + Suit;
            }  
        }

 
        public Card(int num,string suit)
        {
            Number = num;
            Suit = suit;
        }


    }
}