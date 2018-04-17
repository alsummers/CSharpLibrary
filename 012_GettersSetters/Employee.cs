using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_GettersSetters
{
    class Employee
    {
        //Fields

        //Properties --'prop' [tab][tab]
        public int EmployeeID
        {
            set
            {
                if (EmployeeID < 1)
                    throw new Exception("The Employee ID is not valid.");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        //Methods
    }
}
