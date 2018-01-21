using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> kazu = new HashSet<int>();
            Random rnd = new Random();
            bool flg = true;
            while (flg)
            {
                int num = rnd.Next(0, 101);
                Console.WriteLine("0~100の値を出力：" + num);
                if (num != 0)
                {
                    kazu.Add(num);
                }
                else
                {
                    flg = false;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                string nocnt = "なし";
                Console.Write("一の位が{0}：",i);
                foreach(int j in kazu)
                {
                    if(j % 10 == i)
                    {
                        Console.Write(j + " ");
                        nocnt = "";
                    }
                }
                Console.WriteLine(nocnt);
            }
        }
    }
}