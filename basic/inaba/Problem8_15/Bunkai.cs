using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem8_15
{
    class Bunkai
    {
        public static int bunkai(int num, int sosuu)
        {
            while (true)
            {
                if (num % sosuu == 0)
                {
                    Console.Write(" {0}", sosuu);
                    num = num / sosuu;
                }
                else
                {
                    break;
                }
                if (num != 1)
                {
                    Console.Write(" *");
                }
            }

            return num;
        }
    }
}