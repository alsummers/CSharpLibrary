using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Character dave = new Character();
            dave.HealPartner();
            dave.Attack();
        }
    }
}
