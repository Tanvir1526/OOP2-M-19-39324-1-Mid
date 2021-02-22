using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 =new Account("Tanvir",1413,100000);
            Account a2 = new Account("Hossain", 2560, 20000);
            a1.Transfer(5000, a2);
            a1.ShowInfo();
            a2.ShowInfo();
            Console.WriteLine("***********Saving**********");
            Saving s1 = new Saving("Habib", 5555, 50000);
            Saving s2 = new Saving("Niaz", 1111, 20000);
            s1.Transfer(2000, s2);
            s1.ShowInfo();
            s2.ShowInfo();
            Console.WriteLine("*******Spacial Current******");
            SpacialCurrent sc1 = new SpacialCurrent("Hamim", 1505, 30000);
            SpacialCurrent sc2 = new SpacialCurrent("Munna", 5050, 25000);
            sc1.transfer(2500, sc2);
            sc1.ShowInfo();
            sc2.ShowInfo();
            Console.WriteLine("*************Fixed**********");
            Fixed f1 = new Fixed("Munif",1020,50000,6);
            Fixed f2 = new Fixed("Towshik", 2060, 60000, 8);
            f1.transfer(15000, f2);
            f1.ShowInfo();
            f2.ShowInfo();
            Console.WriteLine("**********Over Draft*********");
            OverDraft o1 = new OverDraft("Saikot", 5020, 40000);
            OverDraft o2 = new OverDraft("Miad", 4060, 80000);
            f1.transfer(20000, o2);
            f1.ShowInfo();
            f2.ShowInfo();


        }
    }
}
