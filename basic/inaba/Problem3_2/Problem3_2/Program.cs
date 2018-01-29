using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力してください:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("i=" + i);
            if (i != 4)
            {
                Console.WriteLine("4ではありません");
            }
        }
    }
}
