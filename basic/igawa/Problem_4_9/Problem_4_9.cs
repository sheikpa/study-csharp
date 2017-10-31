using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_9
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int i = rnd.Next(1, 100);
                Console.WriteLine(i);
                if(i % 10 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("終了します");
        }
    }
}
