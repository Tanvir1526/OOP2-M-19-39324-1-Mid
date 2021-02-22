using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class SpacialCurrent : Account
    {
        private int openBalance;
        private int MinBalance;

        public SpacialCurrent() 
        {
            Console.WriteLine("Default Spacial Current");
        }

        public SpacialCurrent(string Name, int accNo ,int balance ) :base ( Name,accNo,balance)
        {
            openBalance = balance;
            MinBalance = (openBalance * 10) / 100;
        }
        public void transfer(int ammount ,Account acc)
        {
            if(base.Balance-ammount >= MinBalance)
            {
                base.Transfer(ammount, acc);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }
    }
}
