using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_8
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("春");
                    break;
                case 2:
                    Console.WriteLine("夏");
                    break;
                case 3:
                    Console.WriteLine("秋");
                    break;
                case 4:
                    Console.WriteLine("冬");
                    break;
                default:
                    Console.WriteLine("エラーです");
                    break;
            }

        }
    }
}
