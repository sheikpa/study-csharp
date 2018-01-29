using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0から100までの数値を入力してください：");
            int i = int.Parse(Console.ReadLine());
            if (i >= 0 && i <= 100)

            {
                if (i >= 20 && i < 80)
                {
                    Console.WriteLine("20以上80未満です。");
                }
                else if (i < 20 || i >= 80)
                {
                    Console.WriteLine("20未満か、80以上です。");
                }
            }
            else
            {

                Console.WriteLine("範囲外です。");
            }
        }
    }
}
