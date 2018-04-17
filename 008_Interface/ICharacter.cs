using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    interface ICharacter //class must use inferface methods defined here
    {
        void Attack();
        void Defend();
        void SayName();
        void CastSpell();
    }
}
