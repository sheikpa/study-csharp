using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_10
    {
        static void Main(string[] args)
        {
            Console.Write("文字列1を入力");
            string str1 = Console.ReadLine();
            Console.Write("文字列2を入力");
            string str2 = Console.ReadLine();
            if (str1.Equals(str2))
            //if (str1 == str2)
            {
                Console.WriteLine("2つの文字は等しい");
            }
            else
            {
                Console.WriteLine("2つの文字は等しくない");
            }
        }
    }
}
