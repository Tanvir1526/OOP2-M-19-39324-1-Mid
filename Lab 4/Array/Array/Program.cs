using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] a = new int[100];

            Console.WriteLine("Input N: ");

            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input array Element: ");

            for (i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }

            //****************Revese***********************
            Console.WriteLine("The values in reverse : ");

            for (i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(" " + a[i]);
            }

            //******************Sum*************************
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum of All element : " + sum);

            //***************copy element******************

            int[] a2 = new int[100];

            for (i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
            Console.WriteLine("First Array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine("\nSecond Array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + a2[i]);
            }
            //************Duplicate element**************** 

          

        }
    }
}
