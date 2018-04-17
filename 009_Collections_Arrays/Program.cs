using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 23223, 23243, 11233, 15677, 12998 };

            foreach(int i in scores)
            {
                Console.WriteLine(i);
                
            }


            //arrays cannot grow in size or have elements removed
            //arrays must remain the same type (int, string, etc)
            //arrays are immutable in C#
            Console.ReadLine();
        }
    }
}
