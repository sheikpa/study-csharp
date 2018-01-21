using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> kazu = new List<int>();
            while(true)
            {
                kazu.Add(rnd.Next(0, 11));
                Console.WriteLine("0~10の値を出力：{0}", kazu.Last());
                if(kazu.Last() == 0)
                {
                    break;
                }
                kazu.Sort();
                Console.Write("出力された数：");
                foreach (int n in kazu)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}