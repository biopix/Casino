using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casino.Models
{
    public class Game
    {
        private Deck mydeck;
        public List<Card> deck;
        public List<Card> userCards;
        public List<Card> computerCards;
        public static int CardIndex;
        public const  int USERCASH = 500;
        public int currentCash;
        public bool isComputerWon;
        public bool isUserLose;
        public bool isGameON;
        public int bidValue;
        public bool isBidON;
        public int userPointsTotal;
        public int computerPointsTotal;
        public bool isTie;
        public bool isDealOn;
        public string BidStatus;
        public string coinFace { get; set; }


        public Game()
        {
            mydeck = new Deck();
            deck = mydeck.deck;
            userCards = new List<Card>();
            computerCards = new List<Card>();
        }

        // start game button runs startgame method
        public void StartGame()
        {
            
            currentCash = USERCASH;
            isGameON = true;
        }
        public void startDeal(int bidAmount)
        {
            if (chechEnoughCash() && isGameON &&isBidON==false)
            {
                userCards.Clear();
                computerCards.Clear();
                CardIndex = 0;
                deck = mydeck.Shuffle(deck);
                isBidON = true;
                bidValue = bidAmount;
               
               
            }

        }

        public void Deal()
        {
            if (isBidON && (isDealOn==false))
            {
                isDealOn = true;
                UserHit();
                UserHit();
                BidStatus = "";
                ComputerHit();
                ComputerHit();
                
            }
        }

    


        // methods run to add a card to computer's cards
        public void UserHit()
        {
            if (isGameON && isBidON && isDealOn)
            {
                if (chechEnoughCash())
                {
                    userCards.Add(deck[CardIndex]);
                    userPointsTotal += deck[CardIndex].Value;
                    CardIndex++;
                    if((userPointsTotal==21 )&&(computerPointsTotal != 21))
                    {
                        isBidON = false;

                        isDealOn = false;
                        BidStatus = "Won";
                        currentCash += bidValue;
                        userPointsTotal = 0;
                        computerPointsTotal = 0;
                    }
                    if(userPointsTotal > 21)
                    {
                        isBidON = false;
                        isDealOn = false;
                        BidStatus = "Lost";
                        currentCash -= bidValue;
                        userPointsTotal = 0;
                        computerPointsTotal = 0;

                    }
                    if(userPointsTotal==21 && computerPointsTotal == 21)
                    {
                        userPointsTotal = 0;
                        computerPointsTotal = 0;
                        isTie = true;
                        isBidON = false;
                        isDealOn = false;
                        BidStatus = "Tie";
                    }

                }

            }
        }

   


   
 


        // check stand status
    

        public void UserPushedStand()
        {
            if(isGameON && isBidON &&isDealOn)
            {
                while(computerPointsTotal < 17)
                {
                    ComputerHit();
                   
                }
                if(computerPointsTotal > 21)
                {
                    currentCash += bidValue;
                    BidStatus = "Won";
                    isBidON = false;
                    isDealOn = false;
                    userPointsTotal = 0;
                    computerPointsTotal = 0;
                }

                else if (computerPointsTotal < userPointsTotal )
                {
                    currentCash += bidValue;
                    BidStatus = "Won";
                    isBidON = false;
                    isDealOn = false;
                    userPointsTotal = 0;
                    computerPointsTotal = 0;
                }
                else if (computerPointsTotal > userPointsTotal)
                {
                    currentCash -= bidValue;
                    BidStatus = "Lost";
                    isBidON = false;
                    isDealOn = false;
                    userPointsTotal = 0;
                    computerPointsTotal = 0;
                }
                else
                {
                    isTie = true;
                    isBidON = false;
                    isDealOn = false;
                    BidStatus = "Tie";
                    userPointsTotal = 0;
                    computerPointsTotal = 0;
                }
                
            }
        }
        // methods run to add a card to computer's cards
        public void ComputerHit()
        {
            if (isGameON)
            {
                computerCards.Add(deck[CardIndex]);
                computerPointsTotal += deck[CardIndex].Value;
                CardIndex++;
                
            }
        }



    

    // check the game for enough money
        public bool chechEnoughCash()
        {
            if (currentCash <= 0)
            {
                userCards.Clear();
                computerCards.Clear();
                isGameON = false;
                return false;
            }
            else
                return true;
        }

        public void reset()
        {
            HttpContext.Current.Session["Game"] = null;
        }


    }
}