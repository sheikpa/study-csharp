using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int maxVl = 0;
            int maxNo = 0;
            int tmp;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(array[j] + " ");
                }
                Console.WriteLine();

                for (int j = i; j < array.Length; j++)
                {
                    if (maxVl < array[j])
                    {
                        maxVl = array[j];
                        maxNo = j;
                    }
                }
                tmp = array[i];
                array[i] = maxVl;
                array[maxNo] = tmp;
                maxVl = 0;
            }
        }
    }
}
