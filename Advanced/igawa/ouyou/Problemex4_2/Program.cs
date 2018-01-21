using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  四角形の生成
            Box b = new Box(2.0, 4.0);
            //  三角形の生成
            Triangle t = new Triangle(4.0, 1.5);
            Console.WriteLine("幅{0}、高さ{1}の四角形の面積は{2}", b.Width, b.Height, b.Area);
            Console.WriteLine("幅{0}、高さ{1}の三角形の面積は{2}", t.Width, t.Height, t.Area);
        }
    }
}