using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            //  乱数の初期設定
            Random rnd = new Random();
            Console.WriteLine("6が出たら終了");
            //  無限ループ
            while (true)
            {
                int dice = rnd.Next(1, 7);  //  1以上7未満の乱数を発生させる（1から6まで）
                Console.WriteLine(dice);
                if (dice == 6)
                {
                    break;      //  ループから抜ける
                }
            }
            Console.WriteLine("終了");
        }
    }
}