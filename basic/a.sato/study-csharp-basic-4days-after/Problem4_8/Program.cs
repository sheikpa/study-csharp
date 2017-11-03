using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("0以上の数値を入力してください:");
                int i = int.Parse(Console.ReadLine());
                if (i >= 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("終了します");
                    break;
                }
            }
        }
    }
}
