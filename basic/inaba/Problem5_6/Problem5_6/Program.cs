using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\n");
            int max = 0;
            int min = 10;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }
                sum += array[i];
            }

            Console.WriteLine("最大値 ： {0}", max);
            Console.WriteLine("最小値 ： {0}", min);
            Console.WriteLine("平均値 ： {0}", sum / 10);
        }
    }
}
