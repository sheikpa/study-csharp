using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);  // 足し算
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);  // 引き算
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);  // 掛け算
            Console.WriteLine("{0} / {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);  // 割り算
        }
    }
}
