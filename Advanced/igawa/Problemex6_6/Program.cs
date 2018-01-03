using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> kazu = new List<int>();
            do
            {
                kazu.Add(rnd.Next(0,11));
            }
            while (kazu[kazu.Count - 1] != 0);

            Console.WriteLine();
            for (int i = 0; i < kazu.Count - 1; i++)
            {
                Console.WriteLine("0~10の値を出力：{0}",kazu[i]);
            }

            kazu.RemoveAll(checkLine);
            foreach(int n in kazu)
            {
                Console.Write(n + " ");
            }

            bool checkLine(int n)
            {
                return n == 2;
            }

        }
    }
}