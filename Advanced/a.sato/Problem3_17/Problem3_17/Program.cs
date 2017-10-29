using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください(1-100)：");
            int i = int.Parse(Console.ReadLine());
            if (i > 0 && i < 101)
            {
                if (i % 2 == 0)
                {
                    if (i <= 50)
                    {
                        Console.WriteLine("50以下の偶数です。");
                    }
                    else
                    {
                        Console.WriteLine("偶数です。");
                    }
                }
                else if (i <= 50)
                {
                    Console.WriteLine("50以下です。");
                }
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
