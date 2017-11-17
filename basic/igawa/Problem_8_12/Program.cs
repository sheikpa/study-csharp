using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tribo = { 1, 1, 2 };
            while (tribo[tribo.Length - 1] + tribo[tribo.Length - 2] + tribo[tribo.Length-3] <= 30)
            {
                Array.Resize(ref tribo, tribo.Length + 1);
                tribo[tribo.Length - 1] = tribo[tribo.Length - 2] + tribo[tribo.Length - 3] + tribo[tribo.Length -4];
            }
            for (int i = 0; i < tribo.Length; i++)
            {
                Console.Write(tribo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
