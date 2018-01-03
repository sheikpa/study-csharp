using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 };

            try
            {
                //  配列の内容を表示
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
            finally
            {
                Console.WriteLine("終了");
            }

        }
    }
}