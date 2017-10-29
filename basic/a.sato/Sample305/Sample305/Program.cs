using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample305
{
    class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから数値を入力
            Console.Write("1から3の整数を入力:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");    //  numが1だった場合の処理
                    break;
                case 2:
                    Console.WriteLine("two");    //  numが2だった場合の処理
                    break;
                case 3:
                    Console.WriteLine("three");  //  numが3だった場合の処理
                    break;
                default:
                    Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理
                    break;
            }
        }
    }
}