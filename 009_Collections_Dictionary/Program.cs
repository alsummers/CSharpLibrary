using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze Badge
            Dictionary<string, int> dictionary =
                new Dictionary<string, int>();
            dictionary.Add("American Beauty", 2000);
            dictionary.Add("Gladiator", 2001);
            dictionary.Add("A Beautiful Mind", 2002);
            dictionary.Add("Chicago", 2003);
            dictionary.Add("Lord of the Rings: The Return of the King", 2004);
            dictionary.Add("Million Dollar Baby", 2005);

            foreach(KeyValuePair<string, int> movies in dictionary)
            {
                Console.WriteLine("{0}, {1}", movies.Key, movies.Value);
            }
            Console.ReadLine();

            //Silver

            Dictionary<int, string> nominees = new Dictionary<int, string>()
            {
                {2000, new string []{"Green Mile", "Sixth Sense" },
                {2000, "The Sixth Sense" },
                {2001, "Chocolat" },
                {2001, "Crouching Tiger, Hidden Dragon" },
                {2002, "Gosford Park" },
                {2002, "In the Bedroom" },
                {2003, "The Pianist" },
                {2003, "Gangs of New York" },

            };
            foreach (KeyValuePair<int, string> nom in nominees)
            {
                Console.WriteLine(nom.Value);
            }
            Console.ReadLine();

            //Gold
            if(movies.ContainsKey(readline))
            { }
        }
    }
}
