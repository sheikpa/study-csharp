using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock ac = new AlarmClock();   //  アラーム付き時計クラスのインスタンスを生成
            IAlarm ar = (IAlarm)ac;
            IClock cl = (IClock)ac;
            FuncAlarm(ar);
            FuncClock(cl);
        }
        //  アラームとしての処理
        public static void FuncAlarm(IAlarm alarm)
        {
            alarm.SetAlarm();   //  アラームのセット
            alarm.Alarm();      //  アラームを鳴らす
            alarm.StopAlarm();  //  アラームを止める
        }
        //  時計としての処理
        public static void FuncClock(IClock clock)
        {
            clock.AdjustTime(); //  時間を調整する
            clock.ShowTime();   //  時間を表示する
        }
    }
}