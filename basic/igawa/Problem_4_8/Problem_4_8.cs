using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_8
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i >= 0)
            {
                Console.Write("0以上の数値を入力してください:");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
            }
            Console.WriteLine("終了します");
        }
    }
}
