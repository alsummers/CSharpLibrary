using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Overriding
{
    class Enemy : Character
    {
        public override void healAlly (string ally)
        {
            Console.WriteLine("The enemy just healed {0}", ally);
        }
    }
}
