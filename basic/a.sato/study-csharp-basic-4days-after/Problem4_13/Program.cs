﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 11);
            string flg = "";
            if (dice >= 5)
            {
                flg = "1";
            }
            Console.WriteLine("発生した乱数：" + dice);
            for (int i = 0; i < dice; i++)
            {
                if (flg == "1")
                {
                    Console.Write("★");
                }
                else
                {
                    Console.Write("☆");
                }
            }
        }
    }
}
