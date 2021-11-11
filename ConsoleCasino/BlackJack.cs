using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    class BlackJack
    {
        public int[] DealerHandInt;
        public int[] PlayerHandInt;

        public string[] DealerHandStr;
        public string[] PlayerHandStr;

        public int PlayerBet;

        public BlackJack(bool Boolean = false)
        {
            if(Boolean)
            {
                this.BeginGame();
            }
        }

        public void BeginGame()
        {
            Console.Clear();
            this.GetBeginCard();
            Player Player = new Player("false");
            Console.WriteLine("Welkom bij BlackJack");
            Console.WriteLine("Druk op enter om te starten!");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                bool betValid = false;
                Console.Clear();
                while (betValid = false)
                {
                    Console.WriteLine("Hoeveel chips wil je inzetten");
                    Console.Write(">> ");
                    int bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > 0)
                    {
                        this.PlayerBet = bet;
                        betValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Je moet meer dan 1 chip inzetten");
                  }
                }
                

                this.GetBeginCard();
                Console.WriteLine("Dealer: " + DealerHandStr[0] + " " + DealerHandStr[1]);
                Console.WriteLine(Player.GetPlayerName() + " :" + PlayerHandStr[0] + " " + PlayerHandStr[1]);
            }


        }

        public void GameLogic()
        {

        }

        public int Random()
        {
            Random Random = new Random();
            int random = Random.Next(1, 14); // Random int tussen de 1 en 13 (Aantal kaarten in blackjack)
            return random;

        }

        public void GetBeginCard()
        {
            for(int i = 0; i <= 1; i++)
            {
                int random = this.Random();
                this.PlayerHandInt[i] = random;                    
            }
            for (int i = 0; i <= 1; i++)
            {
                int random = this.Random();
                this.DealerHandInt[i] = random;
            }

            this.NameOfCard();

        }

        public string Hit()
        {
            return "";
        }

        public void NameOfCard()
        {
            for (int i = 0; i < this.PlayerHandInt.Length; i++)
            {
                
                switch(PlayerHandInt[i])
                {
                    case 1:
                        this.PlayerHandStr[i] = "2";
                        break;
                    case 2:
                        this.PlayerHandStr[i] = "3";
                        break;
                    case 3:
                        this.PlayerHandStr[i] = "4";
                        break;
                    case 4:
                        this.PlayerHandStr[i] = "5";
                        break;
                    case 5:
                        this.PlayerHandStr[i] = "6";
                        break;
                    case 6:
                        this.PlayerHandStr[i] = "7";
                        break;
                    case 7:
                        this.PlayerHandStr[i] = "8";
                        break;
                    case 8:
                        this.PlayerHandStr[i] = "9";
                        break;
                    case 9:
                        this.PlayerHandStr[i] = "10";
                        break;
                    case 10:
                        this.PlayerHandStr[i] = "Boer";
                        break;
                    case 11:
                        this.PlayerHandStr[i] = "Koningin";
                        break;
                    case 12:
                        this.PlayerHandStr[i] = "Koning";
                        break;
                    case 13:
                        this.PlayerHandStr[i] = "Koningin";
                        break;
                }
            }

            for (int i = 0; i < this.DealerHandInt.Length; i++)
            {

                switch (PlayerHandInt[i])
                {
                    case 1:
                        this.DealerHandStr[i] = "2";
                        break;
                    case 2:
                        this.DealerHandStr[i] = "3";
                        break;
                    case 3:
                        this.DealerHandStr[i] = "4";
                        break;

                }
            }
        }
    }
}
