using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_OOP_Game
{
    class Creature : Character //inherited Character properties
    {
      public Creature(string creatureName, int creatureLevel, int creaturePowerLevel, bool lowPower, string name, string type)
        {
            this.CreatureName = creatureName;
            this.Level = creatureLevel;
            this.CurrentPower = creaturePowerLevel;
            this.IsLowOnPower = lowPower;
            this.Name = name;
            this.Type = type;

        }
        public string CreatureName { get; set; }
    }
}
