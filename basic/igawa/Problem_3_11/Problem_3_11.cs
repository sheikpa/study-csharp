using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_11
    {
        static void Main(string[] args)
        {
            Console.Write("0から100までの整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            
            if (a < 80 && a >= 20)
            {
                Console.WriteLine("20以上か80未満です。");
            }else if( (a < 20 && a >= 0) || (a <= 100 && a >= 80) )
            {
                Console.WriteLine("20未満かか80以上です。");
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }

        }
    }
}
