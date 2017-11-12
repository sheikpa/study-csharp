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
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    for (int j = 0; j < i.ToString().Length; j++)
                    {
                        if (i.ToString().Substring(j, 1) == "3")
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

            }
        }
    }
}
