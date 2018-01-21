using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex5_2
{
    class AlarmClock : IAlarm, IClock
    {
        public void Alarm()
        {
            Console.WriteLine("アラームを鳴らす");
        }
        public void SetAlarm()
        {
            Console.WriteLine("アラームをセットする");
        }
        public void StopAlarm()
        {
            Console.WriteLine("アラームを止める");
        }
        public void ShowTime()
        {
            Console.WriteLine("時刻を知る");
        }
        public void AdjustTime()
        {
            Console.WriteLine("時刻を修正する");
        }
    }
}