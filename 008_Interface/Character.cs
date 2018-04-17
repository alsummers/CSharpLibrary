using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Interface
{
    class Character : ICharacter, IHealable // ctrl + '.' to import interface
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void CastSpell()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public void HealPartner()
        {
            throw new NotImplementedException();
        }

        public void SayName()
        {
            throw new NotImplementedException();
        }
    }
}
