﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }
            Console.WriteLine("Sum of Even 1 to 100 :"+even);
            Console.WriteLine("Sum of odd 1 to 100 :"+odd);
        }
    }
}
