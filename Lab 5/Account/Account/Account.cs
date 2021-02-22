using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string name;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int accNo;

        public int AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Account ()
        {
            Console.WriteLine("Default Account");
        }
        public Account(string name, int accNo ,int balance)
        {
            this.name = name;
            this.accNo = accNo;
            Console.WriteLine("Perametere Account");
        }
       
        void Transfer(int ammount,Account acc)
        {
            if(balance>ammount)
            {
                balance -= ammount;
                acc.balance += ammount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("********Show Account *********");
            Console.WriteLine("Account Name :" + name);
            Console.WriteLine("Account No :" + accNo);
            Console.WriteLine("Balance :" + accNo);



        }

    }
}
