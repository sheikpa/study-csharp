using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rnd = new Random();
            int zeroD = 0;
            int zeroS = 0;
            int zero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 11);
                Console.Write(array[i] + " ");
                if (array[i] == 0)
                {
                    zero++;
                }
                else if (array[i] > 0)
                {
                    zeroD++;
                }
                else
                {
                    zeroS++;
                }
            }

            Console.Write("\n\n0より大きい数：{0}\n0より小さい数：{1}\n0の個数：{2}", zeroD, zeroS, zero);
        }
    }
}
