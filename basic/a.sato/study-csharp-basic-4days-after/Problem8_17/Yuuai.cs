using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_17
{
    class Yuuai
    {
        public static void yuuai(int num)
        {
            int sum = 0;

            if (num != 1)
            {
                for (int i = 1; i < num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
            }
            int yuuai = 0;
            if (sum != 1)
            {
                for (int i = 1; i < sum - 1; i++)
                {
                    if (sum % i == 0)
                    {
                        yuuai += i;
                    }
                }
            }
            if (num == yuuai && num < sum)
            {
                Console.WriteLine("{0}と{1}は友愛数", num, sum);
            }
        }
    }
}
