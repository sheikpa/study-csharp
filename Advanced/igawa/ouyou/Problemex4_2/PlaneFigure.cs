using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_2
{
    //  三角形クラス
    abstract class PlaneFigure
    {
        //  面積
        protected double area = 0;
        //  底辺
        protected double width = 0;
        //  高さ
        protected double height = 0;

        //  幅のプロパティ
        public abstract double Width
        {
            get;
            set;
        }
        //  高さのプロパティ
        public abstract double Height
        {
            get;
            set;
        }
        //  面積の取得
        public abstract double Area
        {
            get;
            set;
        }
    }
}