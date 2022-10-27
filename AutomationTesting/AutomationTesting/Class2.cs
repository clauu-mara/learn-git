using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    class Class2
    {
        private int myVariable;

        public void SetValue(int value)
        {
            myVariable = value; 
        }

        public void GetValue()
        {
            if (myVariable > 0)
            {
                Console.WriteLine("Variable {0} > 0 ", myVariable);
            }
            else if (myVariable < 0)
            {
                Console.WriteLine("Variable {0} < 0 " + myVariable);
            }
            else
            {
                Console.WriteLine("Variable = 0");
            }
        }
    }
}
