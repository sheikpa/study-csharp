using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3,3];
            Random rnd = new Random();
            int min = 9;
            int max = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
                Console.Write("\n");
            }

            Console.Write("\n\n");
            Console.WriteLine("最大値：" + max);
            Console.WriteLine("最小値：" + min);
        }
    }
}
