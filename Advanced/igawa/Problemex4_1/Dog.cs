using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_1
{
    //  犬クラス
    class Dog : Animal
    {
        public Dog()
        {
            name = "犬";
        }
        //  吠える
        public override void Bark()
        {
            Console.WriteLine("ワンワン");
        }
        //  動く
        public override void Move()
        {
            Console.WriteLine("歩く");
        }
    }
}