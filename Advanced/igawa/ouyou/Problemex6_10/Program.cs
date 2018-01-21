using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemx6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> kazu = new SortedSet<int>();
            Random rnd = new Random();
            Console.Write("乱数：");
            for (int i = 0; i<10; i++)
            {
                int num = rnd.Next(1, 11);
                Console.Write(num + " ");
                kazu.Add(num);
            }
            Console.Write("\n出現した数：");
            foreach (int n in kazu)
            {
                Console.Write(n + " ");
            }
        }
    }
}