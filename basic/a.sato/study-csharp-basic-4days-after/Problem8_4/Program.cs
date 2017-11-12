using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 1001);
            Console.Write("{0}は{1}桁です", i, i.ToString().Length);
        }
    }
}
