using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player robin = new Player();
            robin.Attack();
            robin.Attack(3);
            robin.Attack(4, "axe");

            Console.ReadLine();
        }
    }
}
