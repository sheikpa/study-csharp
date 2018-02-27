using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int[] sosuuTemp = new int[100];

            for (int i = 1; i < 101; i++)
            {
                array[i - 1] = i;
            }

            int countSosuuTemp = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    sosuuTemp[countSosuuTemp] = array[i];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] != 0)
                        {
                            if (array[j] % sosuuTemp[countSosuuTemp] == 0)
                            {
                                array[j] = 0;
                            }
                        }
                    }
                    countSosuuTemp++;
                }
            }

            int[] sosuu = new int[countSosuuTemp];

            for (int i = 0; i < sosuu.Length; i++)
            {
                sosuu[i] = sosuuTemp[i];
            }

            for (int i = 0; i < sosuu.Length; i++)
            {
                Console.WriteLine(sosuu[i]);
            }
        }
    }
}
