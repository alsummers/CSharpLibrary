using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_OOP_Game
{
    class Character
    {
        //properties
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public bool IsLowOnPower { get; set; }
        public int CurrentPower { get; set; }
    }
}
