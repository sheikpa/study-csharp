using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 1, 2 };

            for (int i = 2; list[i] < 31; i++)
            {
                list.Add(list[i - 2] + list[i - 1] + list[i]);
            }

            if (list[list.Count - 1] > 30)
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
