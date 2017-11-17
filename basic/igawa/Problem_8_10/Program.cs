using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data = new int[10];
            int[] evn = new int[0];
            int[] odd = new int[0];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] % 2 == 0)
                {
                    Array.Resize(ref evn, evn.Length + 1);
                    evn[evn.Length-1] = data[i];
                }
                else
                {
                    Array.Resize(ref odd, odd.Length + 1);
                    odd[odd.Length-1] = data[i];
                }
            }
            Console.Write("偶数　");
            for (int i = 0; i < evn.Length; i++)
            {
                Console.Write(evn[i] + " ");
            }
            Console.Write("\n奇数　");
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
