using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_1
{
    //  猿クラス
    class Monkey : Animal
    {
        public Monkey()
        {
            name = "猿";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("キーキー");
        }
        //  動く
        public override void Move()
        {
            Console.WriteLine("木に登る");
        }
    }
}