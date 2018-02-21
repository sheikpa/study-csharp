using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rnd = new Random();
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write(array[i] + " ");
                sum += array[i];
            }

            avg = sum / 5;

            Console.Write("\n\n");
            Console.WriteLine("合計値：{0}\n平均値：{1}", sum, avg);
            Console.Write("\n平均値より大きい数：");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > avg)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.Write("\n平均値より小さい数：");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
