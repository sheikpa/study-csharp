using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCalc n = new NewCalc();
            n.Number1 = 10;   //  一つ目の数を設定
            n.Number2 = 2;    //  二つ目の数を設定
            Console.WriteLine(n.Number1 + " + " + n.Number2 + " = " + n.Add());
            Console.WriteLine(n.Number1 + " - " + n.Number2 + " = " + n.Sub());
            Console.WriteLine(n.Number1 + " * " + n.Number2 + " = " + n.Mul());
            Console.WriteLine(n.Number1 + " / " + n.Number2 + " = " + n.Div());
        }
    }
}