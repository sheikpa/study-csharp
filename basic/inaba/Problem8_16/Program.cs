using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            for (int i = 0; i < array.Length; i++)
            {
                int max = 0;
                int maxIndex = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (max < array[j])
                    {
                        max = array[j];
                        maxIndex = j;
                    }
                }

                int iTemp = array[i];
                int jTemp = array[maxIndex];

                array[i] = jTemp;
                array[maxIndex] = iTemp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
