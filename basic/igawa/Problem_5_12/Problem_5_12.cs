using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_12
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[4, 3];
          //int m, n;
            for (int i = 0; i < a.GetLength(0); i++)
          //for (m = 0; m < 3; m++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
              //for (n = 0; n < 3; n++)
                {
                    a[i, j] = rnd.Next(0, 9);
                  //a[m, n] = rnd.Next(0, 9);
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
          //for (m = 0; m < 3; m++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
              //for (n = 0; n < 3; n++)
                {
                    Console.Write("{0} ", a[i, j]);
                  //Console.Write("{0} ", a[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
