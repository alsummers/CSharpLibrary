using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekday day = Weekday.Wednesday;

            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("It's the beginning of the week for godssakes");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("Taco Tuesday");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("Comic book day");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("Prime Time");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("TGIF boys");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("Ahhhh yeahhh!");
                    break;
                case Weekday.Sunday:
                    Console.WriteLine("It's the lords day");
                    break;
                default:
                    Console.WriteLine("It's a leap week");
                    break;
            }
            Console.ReadLine();
        }
    }

    enum Weekday ///freezes properties in place
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }
}
