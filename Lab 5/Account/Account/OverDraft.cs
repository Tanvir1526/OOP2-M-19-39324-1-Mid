using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class OverDraft : Account
    {
        private int limit = 20000;

        public OverDraft()
        {
            Console.WriteLine("Default Over Draft");

        }
        public OverDraft(string Name ,int accNo, int balance) : base (Name,accNo,balance)
        {
            base.Balance = balance + limit;
        }

        public void transfer(int ammount ,Account acc)
        {
            if((base.Balance)>=ammount)
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
