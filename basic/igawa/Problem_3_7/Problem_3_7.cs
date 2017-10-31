using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem{
    class Problem_3_7    {
        static void Main(string[] args){
            Console.Write("数値を入力");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0){
                Console.WriteLine("この数は偶数です。");
            }else{
                Console.WriteLine("この数は奇数です。");
            }
        }
    }
}
