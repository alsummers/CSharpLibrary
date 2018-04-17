using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_CodingChallenge
{
    public class Hotel
    {
        public string RoomNumber { get; set; }
        public bool isAvailable { get; set; }
        public int NumRooms { get; set; }

        public void PrintNumber()
        {
            Console.WriteLine("Hello, your room number is {0}", RoomNumber);
        }

        public void CheckAvailability()
        {
            if (isAvailable)
                Console.WriteLine("{0} is available", RoomNumber);
            else
                Console.WriteLine("Doesn't look like {0} is available", RoomNumber);
        }
    }
}
