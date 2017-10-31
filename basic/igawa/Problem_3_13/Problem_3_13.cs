using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_13
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の値を入力:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("グー");
                    break;
                case 2:
                    Console.WriteLine("チョキ");
                    break;
                case 3:
                    Console.WriteLine("パー");
                    break;
                default:
                    Console.WriteLine("正しい値ではありません");
                    break;
            }
        }
    }
}
