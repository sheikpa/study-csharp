using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 9)
                    {
                        Console.Write(i + "*" + j + "=" + i * j + "\n");
                    }
                    else
                    {
                        Console.Write(i + "*" + j + "=" + i * j + " ");
                    }
                }
            }
        }
    }
}
