using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Dginv num = new Dginv();
            
            num.N = rnd.Next(1, 1001);
            Console.WriteLine("{0} は {1} 桁です。",num.N, num.DigitInv());

        }
    }
}
