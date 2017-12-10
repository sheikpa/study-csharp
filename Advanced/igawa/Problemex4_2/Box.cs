using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_2
{
    //  四角形クラス
    class Box : PlaneFigure
    {
        public Box()
        {
        }
        //  コンストラクタ（引数あり）
        public Box(double width, double height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
        }
        //  幅のプロパティ
        public override double Width
        {
            get { return width; }
            set { width = value; }
        }
        //  高さのプロパティ
        public override double Height
        {
            get { return height; }
            set { height = value; }
        }
        //  面積の取得
        public override double Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}