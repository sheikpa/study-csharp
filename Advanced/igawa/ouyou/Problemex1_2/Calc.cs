using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex1_2
{
    class Calc
    {
        //  一つ目の数
        private int num1;
        //  二つ目の数
        private int num2;
        //  一つ目の数のプロパティ
        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        //  二つ目の数のプロパティ
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }
        public void ShowAdd()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
        public Calc()
        {

        }
        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
    }
}