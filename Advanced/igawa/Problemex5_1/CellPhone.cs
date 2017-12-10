using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex5_1
{
    class CellPhone : IComputer, IMailer, IPhone
    {
        //  メールを送信する
        public void SendMail()
        {
            Console.WriteLine("メールを送る");
        }
        //  メールを受信する
        public void RecieveMail()
        {
            Console.WriteLine("メールを受信する");
        }
        //  webを閲覧する
        public void BrowseWeb()
        {
            Console.WriteLine("ウェブを閲覧する");
        }
        //  ゲームをする
        public void PlayGame()
        {
            Console.WriteLine("ゲームをする");
        }
        //  電話をかける
        public void CallPhone()
        {
            Console.WriteLine("電話を掛ける");
        }
        //  電話を受ける
        public void RecievePhone()
        {
            Console.WriteLine("電話を受ける");
        }
    }
}