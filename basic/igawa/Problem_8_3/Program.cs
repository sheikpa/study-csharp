using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            kaijyo kai = new kaijyo();
            kai.N = long.Parse(Console.ReadLine());
            //kai.N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(kai.KeisanKaijyo());
        }
    }
}
