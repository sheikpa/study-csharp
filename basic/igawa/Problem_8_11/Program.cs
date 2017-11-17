using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = { 1, 1 };
            while (fibo[fibo.Length-1] + fibo[fibo.Length - 2] <= 40)
            {
                Array.Resize(ref fibo, fibo.Length + 1);
                fibo[fibo.Length-1] = fibo[fibo.Length-2] + fibo[fibo.Length-3];
            }
            for (int i = 0; i < fibo.Length; i++)
            {
                Console.Write(fibo[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
