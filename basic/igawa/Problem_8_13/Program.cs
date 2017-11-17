using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] kyoutu = new int[0];
            int[] dotika = new int[0];
            Random rnd = new Random();
            
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 11);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 11);
            }

            //重複している値を検索し配列kyoutuに格納
            Boolean[] flag = new Boolean[11];
            for (int i = 1; i < flag.Length; i++)
            {
                for(int j = 0; j < array1.Length; j++)
                {
                    if(array1[j] == i)
                    {
                        for(int k = 0; k < array2.Length; k++)
                        {
                            if(array2[k] == i)
                            {
                                flag[i] = true;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == true)
                {
                    Array.Resize(ref kyoutu, kyoutu.Length + 1);
                    kyoutu[kyoutu.Length - 1] = i;
                }
            }

            //どちらかにある値を検索し配列dotikaに格納
            flag = new Boolean[11];
            for (int i = 1; i < flag.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] == i || array2[j] == i)
                    {
                        flag[i] = true;
                    }
                }
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i] == true)
                {
                    Array.Resize(ref dotika, dotika.Length + 1);
                    dotika[dotika.Length - 1] = i;
                }
            }

            //出力
            Console.Write("配列1:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }
            Console.Write("\n配列2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(" " + array2[i]);
            }
            Console.Write("\n共通の数:");
            for (int i = 0; i < kyoutu.Length; i++)
            {
                Console.Write(" " + kyoutu[i]);
            }
            Console.Write("\nどちらか入っている数:");
            for (int i = 0; i < dotika.Length; i++)
            {
                Console.Write(" " + dotika[i]);
            }
            Console.WriteLine();

            //int[] andAry = array1.Intersect(array2).ToArray();
            //Array.Sort(andAry);

        }
    }
}
