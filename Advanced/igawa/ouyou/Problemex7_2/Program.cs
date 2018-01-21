﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex7_2
{
    //  でりゲート
    delegate void Delegatefunc(int num);
    class Showcharas
    {
        //  星を表示
        public void showStars(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("☆");
            }
            Console.WriteLine();
        }
        //  資格を表示
        public void showBoxes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
        //  +を表示
        public void showPlus(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("＋");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Showcharas s = new Showcharas();
            Delegatefunc f = new Delegatefunc(s.showStars);
            f += new Delegatefunc(s.showBoxes);
            f += new Delegatefunc(s.showPlus);
            f(4);

        }
    }
}