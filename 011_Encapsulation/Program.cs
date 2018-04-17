using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _005_OOP_Game; // added reference from another project. Put a _ in front of project name

namespace _011_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankPublic bankPublic = new BankPublic();
            decimal amount = bankPublic.GetAmount();
            Console.WriteLine("Your balance is: {0}", amount);

            BankProtected bankProtected = new BankProtected();
            bankProtected.CloseAccount();


        }
    }
}
///public -> Open to all
///protected -> open to the class and all derived classes
///private -> open only to the class itself
///internal -> open to the namespace
///protected interval -> limited to current assemply and derived types
