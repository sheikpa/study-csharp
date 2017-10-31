using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_17
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n<=10; n++)
                {
                    if(i >= n)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
