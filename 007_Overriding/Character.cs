using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Overriding
{
    class Character
    {
        public virtual void healAlly(string ally) /// virtual keyword allows method to be overwritten
        {
            Console.WriteLine("Character healed {0}", ally);
        }
    }
}
