using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1, c2;
            c1 = new Counter();
            c2 = new Counter();
            c1.Increment();
            c2.Increment();
            c2.Increment();
            c2.Reset();
            c1.Increment();
            c1.Increment();
            c2.Increment();
            Console.WriteLine("c1のカウント数：" + c1.Count);
            Console.WriteLine("c2のカウント数：" + c2.Count);
            Console.WriteLine("トータルのカウント数:" + Counter.TotalCount());
        }
    }
}