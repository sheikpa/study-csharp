using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map["0"] = "〇";
            map["1"] = "一";
            map["2"] = "二";
            map["3"] = "三";
            map["4"] = "四";
            map["5"] = "五";
            map["6"] = "六";
            map["7"] = "七";
            map["8"] = "八";
            map["9"] = "九";
            string num = Console.ReadLine().ToString();
            int digi = num.ToString().Length;
            if (long.TryParse(num, out long i))
            {
                foreach(char c in num)
                {
                    Console.Write(map[c.ToString()]);
                    digi--;
                    if(digi % 3 == 0 && digi != 0)
                    {
                        Console.Write(",");
                    }
                }
            }
            else
            {
                Console.WriteLine("数値を入力してください。");
            }
        }
    }
}
