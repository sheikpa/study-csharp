using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10] { 4, 9, 4, 3, 6, 8, 7, 1, 3, 10 };
            int[] array2 = new int[10] { 7, 3, 10, 7, 5, 9, 4, 9, 9, 1 };
            ArraySousa.consoleOutput("配列１：", array1);
            ArraySousa.consoleOutput("配列２：", array2);

            int[] array1sort = ArraySousa.sort(array1);
            int[] array2sort = ArraySousa.sort(array2);

            int[] arrayKyoutsu = ArraySousa.kyoutsu(array1sort, array2sort);
            ArraySousa.consoleOutput("共通の数：", arrayKyoutsu);

            int[] arrayWa = ArraySousa.wa(array1sort, array2sort);
            ArraySousa.consoleOutput("どちらか入っている数：", arrayWa);
        }
    }
}
