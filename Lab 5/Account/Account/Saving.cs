using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Saving : Account
    {
        private int MinBalance = 430;

        public Saving()
        {
            Console.WriteLine("Default Saving");
        }

        public Saving ( string Name, int accNo ,int balance ) : base ( Name, accNo, balance)
        {
            Console.WriteLine("Perametere Saving");
        }
        
        public void transfer (int ammount ,Account acc)
        {
            if((base.Balance-ammount) >= MinBalance)
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
