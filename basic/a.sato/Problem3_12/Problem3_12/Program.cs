using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数の値を入力:");
            int i = int.Parse(Console.ReadLine());
            if (i < 0)
            {
                Console.WriteLine("負の値です");
            }
            else if (i > 0)
            {
                Console.WriteLine("正の値です");
            }
            else
            {
                Console.WriteLine("0です");
            }
        }
    }
}
