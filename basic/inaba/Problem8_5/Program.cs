using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
