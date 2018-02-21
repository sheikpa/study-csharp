using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guusu = 0;
            int kisuu = 0;
            for (int i = 0; i < 5; i++)
            {
                int dice = rnd.Next(1, 101);
                Console.WriteLine(dice);
                if (dice % 2 == 0)
                {
                    guusu++;
                }
                else
                {
                    kisuu++;
                }
            }
            Console.WriteLine("偶数の数：" + guusu);
            Console.WriteLine("奇数の数：" + kisuu);
        }
    }
}
