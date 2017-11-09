using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_1
{
    class Data
    {
        //  メンバ変数number
        private int number = 0;
        //  メンバ変数comment
        private string comment = "";

        public int Number
        {
            set { number = value; }
            get { return number; }
        }
        public string Comment
        {
            set { comment = value; }
            get { return comment; }
        }
    }
}
