using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100)：");
            int i = int.Parse(Console.ReadLine());
            if (i > 0 && i <101)
            {
                if (i >= 80)
                {
                    Console.WriteLine("優");
                }
                else if (i < 80 && i >= 70)
                {
                    Console.WriteLine("良");
                }
                else if (i < 70 && i >= 60)
                {
                    Console.WriteLine("可");
                }
                else
                {
                    Console.WriteLine("不可");
                }
            }
            else
            {
                Console.WriteLine("範囲外");
            }
        }
    }
}
