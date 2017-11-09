using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_8
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
          //int sz = 5;
            int cntbig = 0;
          //int countbig = 0;
            int cntsml = 0;
          //int countsml = 0;
            int cntzr = 0;
          //int countzero = 0;
            int[] data = new int[5];
          //int[] data = new int[sz];

            for (int i = 0; i < data.Length; i++)
          //for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(-10, 10);
                Console.Write("{0} ", data[i]);
                if (0 < data[i])
              //if (data[i] > 0)
                {
                    cntbig += 1;
                  //countbig += 1;
                } else if (data[i] < 0 )
                {
                    cntsml += 1;
                  //countsml += 1;
                }
                else
                {
                    cntzr += 1;
                  //countzero += 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("0より大きい数：{0}", cntbig);
          //Console.WriteLine("0より大きい数：{0}", countbig);
            Console.WriteLine("0より小さい数：{0}", cntsml);
          //Console.WriteLine("0より小さい数：{0}", countsml);
            Console.WriteLine("0の数：{0}", cntzr);
          //Console.WriteLine("0の数：{0}", countzero);
            
        }
    }
}
