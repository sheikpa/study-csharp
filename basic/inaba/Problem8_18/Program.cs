using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (j % i == 0)
                    {
                        if (array[j - 1] == 0)
                        {
                            array[j - 1] = 1;
                        }
                        else
                        {
                            array[j - 1] = 0;
                        }
                    }

                }
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    sum++;
                }
            }

            Console.WriteLine("開いている扉は{0}です", sum);
        }
    }
}
