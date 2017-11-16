using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 1 };

            for (int i = 1; list[i] < 41; i++)
            {
                list.Add(list[i - 1] + list[i]);
            }

            if (list[list.Count - 1] > 40)
            {
                list.RemoveAt(list.Count - 1);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
    }
}
