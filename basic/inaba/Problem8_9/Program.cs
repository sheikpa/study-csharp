using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("10000以下の完全数は以下のとおり");

            for (int i = 1; i < 10001; i++)
            {
                List<int> array = new List<int>();
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        array.Add(j);
                    }
                }
                int sum = 0;
                for (int j = 0; j < array.Count; j++)
                {
                    sum += array[j];
                }
                if (i == sum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
