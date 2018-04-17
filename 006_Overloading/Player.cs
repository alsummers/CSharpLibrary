using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Overloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("Player attacked for some points");
        }

        public void Attack(int points)
        {
            Console.WriteLine("The player attacked for {0} points", points);
        }

        public void Attack(int points, string weaponType)
        {
            Console.WriteLine("The player attacked with a {1} for {0} points", points, weaponType);
        }
    }
}
