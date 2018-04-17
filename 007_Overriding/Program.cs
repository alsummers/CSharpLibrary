using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Gregg = new Character();
            Gregg.healAlly("Jen");

            Player jenn = new Player();
            jenn.healAlly("gregg");

            Enemy Anxiety = new Enemy();
            Anxiety.healAlly("depression");
        }
    }
}
