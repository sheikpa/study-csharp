using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean[] ertstns = new Boolean[101];

            //0と1は最初から除外
            ertstns[0] = true;
            ertstns[1] = true;

            for (int i = 2; i < ertstns.Length; i++)
            {
                for(int j = 2; i * j < ertstns.Length; j++)
                {
                    ertstns[i * j] = true;
                }
            }
            for(int i = 0; i < ertstns.Length; i++)
            {
                if (ertstns[i] == false)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
        }
    }
}
