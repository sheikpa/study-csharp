﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_14
    {
        static void Main(string[] args)
        {
            Console.Write("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (a < 1 || b < 1 || 10 < a || 10 < b)
          //if (a < 1 || b < 1 || a > 10 || b > 10)
            {
                Console.WriteLine("範囲外です。");
            }
            else
            {
                if (b < a)
              //if (a > b)
                {
                    Console.WriteLine("aの方が大きいです。");
                }
                else if (a < b)
                {
                    Console.WriteLine("bの方が大きいです。");
                }
                else
                {
                    Console.WriteLine("等しいです。");
                }
            }
        }
    }
}
