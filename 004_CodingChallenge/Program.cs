using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel california = new Hotel();
            california.RoomNumber = "50";
            california.isAvailable = true;
            california.CheckAvailability();

            Console.ReadLine();
        }
    }
}
