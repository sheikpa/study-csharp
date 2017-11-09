using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_7
{
    class Yakubun
    {
        private int bunsi;
        private int bunbo;

        public int Bunsi
        {
            set { bunsi = value; }
            get { return bunsi; }
        }
        public int Bunbo
        {
            set { bunbo = value; }
            get { return bunbo; }
        }

        public void keisan()
        {
            for (int i = bunsi * bunbo; 1 <= i; i--)
            {
                if (bunsi % i == 0 && bunbo % i == 0)
                {
                    bunsi /= i;
                    bunbo /= i;
                }
            }
            if (bunbo <= bunsi)
            {
                if (bunsi % bunbo == 0)
                {
                    Console.Write(bunsi / bunbo);
                }
                else
                {
                    Console.Write("{0}.{1}/{2}", bunsi / bunbo, bunsi % bunbo, bunbo);
                }
            }
            else
            {
                Console.Write("{0}/{1}", bunsi, bunbo);
            }
        }
    }
}
