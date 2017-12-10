using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex2_3
{
    class Program
    {
        static void Square(int a, int b)
        {
            if(a <= 0 | b <= 0)
            {
                return;
            }
            for(int i=0; i<a; i++)
            {
                for(int n=0; n<b; n++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int tate = r.Next(1, 11);
            int yoko = r.Next(1, 11);
            
            Square(tate, yoko);

            }

    }
}