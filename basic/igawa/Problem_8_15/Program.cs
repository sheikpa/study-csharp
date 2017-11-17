using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 201);

            Console.Write(n + " = ");
            insu(n);
            Console.WriteLine();
        }

        
        static void insu(int num)
        {
            int ctnum = 2;
            while (ctnum <= num)
            {
                if (num % ctnum == 0)
                {
                    Console.Write(ctnum + " ");
                    insu(num / ctnum);
                    break;
                }
                ctnum++;
            }
        }
    }
}
