using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_OOP_Game
{
    class Player : Character //inhereted Character class
    {
        public Player(string firstName, int playerLevel, int currentPowerLevel, bool lowPower, string name, string type)
        {
            this.PlayerName = firstName;
            this.Level = playerLevel;
            this.CurrentPower = currentPowerLevel;
            this.IsLowOnPower = lowPower;
            this.Name = name;
            this.Type = type;
        }

        //properties
        public string PlayerName { get; set; }
    }
}
