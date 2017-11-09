using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_1
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[7];
            for(int i = 0; i < a.Length; i++)
          //for(int i = 0; i < 7; i++)
            {
                a[i] = rnd.Next(1, 10);
                Console.Write("a[{0}]={1} ", i, a[i]);
            }
            Console.WriteLine();
        }
    }
}
