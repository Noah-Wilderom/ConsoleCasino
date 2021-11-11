using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    class Player
    {
        public string playerName;
        public int playerChips;
        public int playerLevel;
        private int playerExp;

        public Player(string playerName)
        {
            if(this.playerName == playerName)
            {
                return;
            }
            if (playerName == "false")
            {
                return;
            }
            this.playerName = playerName;
            this.playerChips = 1000;
            this.playerLevel = 1;
            this.playerExp = 0;
        }

        public string GetPlayerName()
        {
            return this.playerName;
        }
        public int GetPlayerChips()
        {
            return this.playerChips;
        }
        public int GetPlayerLevel()
        {
            return this.playerLevel;
        }

    }
}
