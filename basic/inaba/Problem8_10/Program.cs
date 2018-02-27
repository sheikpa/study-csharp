using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[10];
            int[] gusuu = new int[10];
            int[] kisuu = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write("{0} ", array[i]);
            }

            Console.Write("\n");

            int countG = 0;
            int countK = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    gusuu[countG] = array[i];
                    countG++;
                }
                else
                {
                    kisuu[countK] = array[i];
                    countK++;
                }
            }

            Console.Write("偶数：");
            for (int i = 0; i < countG; i++)
            {
                Console.Write("{0} ", gusuu[i]);
            }

            Console.Write("\n奇数：");
            for (int i = 0; i < countK; i++)
            {
                Console.Write("{0} ", kisuu[i]);
            }
        }
    }
}
