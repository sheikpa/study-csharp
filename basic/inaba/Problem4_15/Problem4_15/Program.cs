using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write(i + "\n");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
