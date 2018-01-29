using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35)：");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("摂氏" + i + "度");
            Console.WriteLine("");
            if (i > -11 && i < 36)
            {
                if (i >= 30)
                {
                    Console.WriteLine("真夏日です。");
                }
                else if (i >= 25 && i < 30)
                {
                    Console.WriteLine("夏日です。");
                }
                else if (i < 0)
                {
                    Console.WriteLine("真冬日です。");
                }
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
