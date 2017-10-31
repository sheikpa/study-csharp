using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sz = 10;
            int[] data = new int[sz];
            int max = 0;
            int min = 10;
            int sum = 0;
            for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 10);
                Console.Write("{0} ", data[i]);
                if (data[i] > max)
                {
                    max = data[i];
                }
                if (data[i] < min)
                {
                    min = data[i];
                }
                sum = sum + data[i];
            }
            Console.WriteLine();

            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
            Console.WriteLine("平均値：{0}", sum/sz);
            Console.WriteLine();
        }
    }
}
