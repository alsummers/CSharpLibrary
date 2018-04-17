using System;

namespace _002_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "Isaac";

            switch(student)
            {
                case "Isaac":
                    Console.WriteLine("Hello Isaac");
                    break;
                case "Alex":
                    Console.WriteLine("Hi Alex");
                    break;
            }
        }
    }
}
