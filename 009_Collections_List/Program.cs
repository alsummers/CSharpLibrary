using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Collections_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var classList = new List<string>();
            classList.Add("Quincy");
            classList.Add("Spencer");
            classList.Add("Aaron M.");
            classList.Add("Paul");
            classList.Add("DQ");

            foreach (var member in classList)
            {
                Console.WriteLine(member);
            }

            List<string> fruits = new List<string>()
            {
                "Banana", "Mango", "Pineapple", "Jackfruit", "Breadfruit"
            };
            Console.WriteLine(fruits.Capacity);
            Console.WriteLine(classList.Capacity); //sets max--is flexible
            Console.ReadLine();
        }
    }
}
