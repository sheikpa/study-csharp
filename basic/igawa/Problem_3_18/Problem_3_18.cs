using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_18
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("摂氏：{0}", a);

            if (a < -10 || 35 < a)
          //if (a < -10 || a > 35)
            {
                Console.WriteLine("適切な値を入力してください。");
            }
            else if (30 <= a && a <= 35)
          //else if (a >= 30 && a <= 35)
            {
                Console.WriteLine("真夏日です。");
                
            }
            else if (25 <= a && a < 30)
          //else if (a >= 25 && a < 30)
            {
                Console.WriteLine("夏日です");
            }
            else if (-10 <= a && a < 0)
          //else if (a < 0 && a >= -10)
            {
                Console.WriteLine("真冬日です。");
            }
        }
    }
}
