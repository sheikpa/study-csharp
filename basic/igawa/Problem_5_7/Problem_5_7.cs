using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_7
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
          //int sz = 5;
            int[] data = new int[5];
          //int[] data = new int[sz];
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < data.Length; i++)
          //for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 10);
                Console.Write("{0} ", data[i]);
                sum = sum + data[i];
            }
            Console.WriteLine();
            Console.WriteLine("合計値：{0}", sum);
            avg = sum / data.Length;
          //avg = sum / sz;
            Console.WriteLine("平均値：{0}", avg);

            Console.Write("平均値より大きい数：");
            foreach (int i in data)
            {
                if (avg < i)
              //if (i > avg)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
            Console.Write("平均値より小さい数：");
            foreach (int i in data)
            {
                if (i < avg)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
