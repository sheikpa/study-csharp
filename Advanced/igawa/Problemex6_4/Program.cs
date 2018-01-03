using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme6_4
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
            while (strlist[strlist.Count-1] != "");

            Console.WriteLine();
            for (int i = 0; i < strlist.Count-1; i++)
            {
                Console.Write(strlist[i] + " ");
            }
        }
    }
}