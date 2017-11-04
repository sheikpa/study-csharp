using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\n50以上の数 ： ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 50)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write("\n50未満の数 ： ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 50)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
