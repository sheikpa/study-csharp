using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[4];
            array[0] = 0.2;
            array[1] = -5.1;
            array[2] = 3.2;
            array[3] = 1.8;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("d[{0}]={1} ", i, array[i]);
            }
        }
    }
}
