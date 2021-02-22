using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Fixed : Account
    {
        private int tenureYear = 5;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Fixed()
        {
            Console.WriteLine("Default Fixed");
        }

        public Fixed(string Name , int accNo , int balance, int year) :base (Name,accNo,balance)
        {
            this.year = year;
            Console.WriteLine("Perametere Fixed");

        }

        public void transfer(int ammount , Account acc)
        {
            if(tenureYear== this.year)
            {
                base.Transfer(ammount, acc);
            }
            else
            {
                Console.WriteLine("Transfer not Available at this moment ");

            }
        }

    }
    
	
	
}
