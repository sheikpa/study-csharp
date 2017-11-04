using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_5
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

            Console.Write("\n\n3の倍数 ： ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write("\n3の倍数以外の数 ： ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
