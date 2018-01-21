using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex2_4
{
    class Counter
    {
        //  カウント
        private int count = 0;
        private static int totalCount = 0;
        //  コンストラクタ
        public void Reset()
        {
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                totalCount += count;
                return count;
            }
        }

        public static int TotalCount()
        {
            return totalCount;
        }
    }
}