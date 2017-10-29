using probrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_benkyou_kihon
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 基本 */
            ShowHeaderLog("基本1-1");
            Program101 program101 = new Program101();
            program101.call();

            /* 基本 */
            ShowHeaderLog("基本1-2");
            Program102 program102 = new Program102();
            program102.call();

            /* 問題 */
            ShowHeaderLog("練習5-1");
            RProgram501 rprogram501 = new RProgram501();
            rprogram501.call();
        }

        private static void ShowHeaderLog(String log)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine(log);
            Console.WriteLine("***************************************");
        }

    }
}
