using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int dice = rnd.Next(1, 100);
                Console.WriteLine(dice);
                if (dice % 10 == 0)
                {
                    Console.WriteLine("終了します");
                    break;
                }
            }
        }
    }
}
