using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float phy = 89f;
            float chem = 85f;
            float bio = 77f;
            float math = 95f;
            float comp = 98f;

            float Total = phy + chem + bio + math + comp;
            float Percent = (100 * Total) / 500;

            if (Percent >= 90)
                { Console.WriteLine("Grade A+"); }
            else if (Percent >= 85 && Percent < 90) 
                { Console.WriteLine("Grade A"); }
            else if (Percent >= 80 && Percent < 85)
                { Console.WriteLine("Grade B+"); }
            else if (Percent >= 75 && Percent < 80) 
                { Console.WriteLine("Grade B"); }
            else if (Percent >= 50 && Percent < 75) 
                { Console.WriteLine("Grade C+"); }
            else 
                { Console.WriteLine("Grade F"); }
        }
    }
}
