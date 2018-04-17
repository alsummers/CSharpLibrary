using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Constructors
{
    class Character
    {
        public Character(string username, int age, int health)
        {
            this.Username = username;
            this.Age = age;
            this.Health = health;
        }
        public Character(string username, int age)
        {
            this.Username = username;
            this.Age = age;
        }

        public int Age { get; set; }
        public int Health { get; set; }
        public string Username { get; set; }
    }
}
