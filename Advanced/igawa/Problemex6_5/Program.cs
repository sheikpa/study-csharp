using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strlist = new List<string>();
            do
            {
                strlist.Add(Console.ReadLine());
            }
            while (strlist[strlist.Count - 1] != "");

            strlist.RemoveAll(checkLine);

            Console.WriteLine();
            for (int i = 0; i < strlist.Count - 1; i++)
            {
                Console.Write(strlist[i] + " ");
            }

            bool checkLine(string s)
            {
                return 5 <= s.Length;
            }
            
        }
    }
}