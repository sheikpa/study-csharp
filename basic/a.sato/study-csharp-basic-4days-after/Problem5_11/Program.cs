using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\n0以上60未満：");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0 && array[i] < 60)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write("\n60以上80未満：");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 60 && array[i] < 80)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write("\n80以上：");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 80)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
