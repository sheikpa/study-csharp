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

            if (20 <= a && a < 80)
          //if (a < 80 && a >= 20)
            {
                Console.WriteLine("20以上80未満です。");
            }else if((0 <= a && a < 20) || ( 80 <= a && a <= 100))
          //}else if( (a < 20 && a >= 0) || (a <= 100 && a >= 80) )
            {
                Console.WriteLine("20未満か、80以上です。");
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }

        }
    }
}
