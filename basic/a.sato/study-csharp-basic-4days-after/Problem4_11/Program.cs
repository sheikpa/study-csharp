using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int min = 100;
            int max = 1;
            for (int i = 0; i < 5; i++)
            {
                int dice = rdn.Next(1, 101);
                Console.WriteLine(dice);
                if (dice < min)
                {
                    min = dice;
                }
                else if (dice > max)
                {
                    max = dice;
                }
            }
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
        }
    }
}
