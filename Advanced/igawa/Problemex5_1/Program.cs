using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone();
            FuncPhone(cp);
            FuncMailer(cp);
            FuncComputer(cp);
        }
        //  電話としての処理
        public static void FuncPhone(IPhone phone)
        {
            phone.CallPhone();      //  電話を掛ける
            phone.RecievePhone();   //  電話を受ける
        }
        //  メーラーとしての処理
        public static void FuncMailer(IMailer mailer)
        {
            mailer.SendMail();      //  メールを送信する
            mailer.RecieveMail();   //  メールを受信する
        }
        //  コンピュータとしての処理
        public static void FuncComputer(IComputer computer)
        {
            computer.PlayGame();    //  ゲームをする
            computer.BrowseWeb();   //  ウェブを閲覧する
        }
    }
}