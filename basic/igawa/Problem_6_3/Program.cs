using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndmin = 1;
            int rndmax = 100;
            Circle c = new Circle();
            //  円の半径を設定
            c.r = rnd.Next(rndmin, rndmax) * 0.1;
            //c.r = 4.0;
            Console.WriteLine("半径" + c.r + "の円の円周の長さは" + c.Circumference());
            Console.WriteLine("半径" + c.r + "の円の面積は" + c.Area());
        }
    }
}
