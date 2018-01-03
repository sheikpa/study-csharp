using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> anml = new Dictionary<String, String>();
            anml["cat"] = "猫";
            anml["dog"] = "犬";
            anml["bird"] = "鳥";
            anml["tiger"] = "トラ";
            Console.Write("英語で動物の名前を入力してください：");
            string name = Console.ReadLine();
            Console.WriteLine("{0}は「{1}」です。", name, anml[name]);
        }
    }
}
