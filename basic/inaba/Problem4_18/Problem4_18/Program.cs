using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
