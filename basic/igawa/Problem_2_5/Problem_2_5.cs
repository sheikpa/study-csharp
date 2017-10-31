using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_2_5
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.Write("文字列1を入力:");
            str1 = Console.ReadLine();  //  １つ目の文字列を入力
            Console.Write("文字列2を入力:");
            str2 = Console.ReadLine();  //  ２つ目の文字列を入力
            Console.WriteLine("文字列1 + 文字列2 = {0}", str1 + str2);
        }
    }
}