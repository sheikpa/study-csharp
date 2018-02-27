using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                for (int j = 1; j < 101; j++)
                {
                    for (int k = 1; k < 101; k++)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine("{0}*{0}+{1}*{1}={2}*{2}", i, i, j, j, k, k);
                            sum++;
                        }
                    }
                }
            }
            Console.WriteLine("組み合わせの数は{0}個です", sum);
        }
    }
}
