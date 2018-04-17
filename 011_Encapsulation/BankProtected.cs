using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Encapsulation
{
    class BankProtected
    {
        public void CloseAccount()
        {
            ApplyLateFees();
        }
        protected void ApplyLateFees()
        {
            Console.WriteLine("Late charges were assigned");
        }
    }
}
