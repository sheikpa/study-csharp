using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値：");
            int num = int.Parse(Console.ReadLine()); ;
            int kaijyou = 0;
            for (int i = num; i > 0; i--)
            {
                if (i == num)
                {
                    kaijyou = i;
                    Console.Write("{0}", i);
                }
                else
                {
                    kaijyou *= i;
                    Console.Write(" * {0}", i);
                }
            }
            Console.Write(" = {0}", kaijyou);
        }
    }
}
