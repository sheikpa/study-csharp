using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 1001);
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("は、{0}の約数です。", num);
        }
    }
}
