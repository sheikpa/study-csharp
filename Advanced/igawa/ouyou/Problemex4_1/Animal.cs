using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_1
{
    //  抽象クラス動物
    abstract class Animal
    {
        //  名前
        protected string name = "";
        //  吠える
        public abstract void Bark();
        //  動く
        public abstract void Move();
        //  名前を表示する
        public void ShowName()
        {
            Console.WriteLine("名前:{0}", name);
        }
    }
}