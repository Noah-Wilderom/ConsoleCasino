using System;


namespace ConsoleCasino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo en welkom bij C# Casino!");
            Console.Write("Voer uw naam in >> ");
            string playerName = Console.ReadLine();

            Player Player = new Player(playerName);

            Console.Clear();
            Console.WriteLine("Naam: " + Player.GetPlayerName());
            Console.WriteLine("Chips: " + Player.GetPlayerChips());
            Console.WriteLine("Level: " + Player.GetPlayerLevel());

            Console.WriteLine();
            Console.WriteLine("Welkom " + Player.GetPlayerName() + " bij het casino!");
            Console.WriteLine("Welk spel wil je spelen? (kies tussen 1: Blackjack 2: Roullete 3: Poker)");
            Console.Write(">> ");
            int spelKeuze = Convert.ToInt32(Console.ReadLine());

            if(spelKeuze == 1)
            {
                BlackJack BlackJack = new BlackJack(true);
            }

        }
    }
}
