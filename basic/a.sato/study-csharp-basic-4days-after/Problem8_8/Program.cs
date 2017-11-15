using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int num = rnd.Next(1, 1001);

            Console.WriteLine("{0}の約数は以下のとおり", num);

            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
