using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gusu = new List<int>();
            List<int> kisu = new List<int>();
            Random rnd = new Random();
            bool flg = true;
            while (flg)
            {
                int num;
                num = rnd.Next(0, 11);
                Console.WriteLine("0~10の値を出力：" + num);
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        gusu.Add(num);
                    }
                    else
                    {
                        kisu.Add(num);
                    }
                }
                else
                {
                    flg = false;
                }
            }
            Console.Write("\n偶数：");
            for (int i = 0; i < gusu.Count; i++)
            {
                Console.Write(gusu[i] + " ");
            }
            Console.Write("\n奇数：");
            for (int i = 0; i < kisu.Count; i++)
            {
                Console.Write(kisu[i] + " ");
            }
        }
    }
}