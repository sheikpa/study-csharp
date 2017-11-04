using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\n");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j <= array[i]; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
