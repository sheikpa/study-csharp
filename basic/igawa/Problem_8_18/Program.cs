using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tobira = new int[50];
            int cnt = 0;
            for(int i = 0; i < tobira.Length; i++)
            {
                tobira[i] = 1;
            }

            for(int i = 1; i <= tobira.Length; i++)
            {
                for(int j = 1; i*j <= tobira.Length; j++)
                {
                    tobira[(i * j)-1] *= -1;
                }
            }
            for(int i = 0; i < tobira.Length; i++)
            {
                if(tobira[i] < 0)
                {
                    cnt += 1;
                }
            }
            Console.WriteLine("扉が開いているロッカーは、" + cnt + "個");
        }
    }
}
