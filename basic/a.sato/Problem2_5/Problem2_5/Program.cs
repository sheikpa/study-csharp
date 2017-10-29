using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列１を入力:");
            string strA = Console.ReadLine();
            Console.Write("文字列２を入力:");
            string strB = Console.ReadLine();
            Console.WriteLine("文字列１＋文字列２＝" + strA + strB);
        }
    }
}
