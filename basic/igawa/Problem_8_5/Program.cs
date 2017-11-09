using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 1001; i++)
            {
                string s = i.ToString();
                if (i % 3 == 0 || 0 < s.IndexOf("3"))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
