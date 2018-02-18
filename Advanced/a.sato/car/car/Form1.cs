using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // 燃料に入力した内容が数字かチェック
            // 数字以外の場合、処理を抜ける
            string checkKekka = errorCheck();
            if (checkKekka == "0")
            {
                nenryouText.Focus();
                return;
            }

            run();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            nenryouText.ReadOnly = false;
        }

        // summary
        // [パラメータ]
        // なし
        // [返却内容]
        // チェックした内容を返却
        //   数字の場合、"1"
        //   数字以外の場合、"0"
        // summary
        public string errorCheck()
        {
            string result = "1";
            string nenryou = nenryouText.Text.ToString();
            Boolean nenryouBool = int.TryParse(nenryou, out int nenryouResult);
            if (nenryouBool == false)
            {
                MessageBox.Show("入力できるのは数字のみです。", "エラー", MessageBoxButtons.OK);
                result = "0";
            }

            return result;
        }

        // summary
        // [パラメータ]
        // なし
        // [返却内容]
        // なし
        // summary
        public void run()
        {
            nenryouText.ReadOnly = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        // summary
        // [パラメータ]
        // なし
        // [返却内容]
        // なし
        // summary
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nenryou = int.Parse(nenryouText.Text.ToString());

            string nenryouResul = nenryou0(nenryou);
            if (nenryouResul == "0")
            {
                return;
            }

            nenryou -= 1;
            nenryouText.Text = nenryou.ToString();

            // 車名１の進んだ距離を求める
            kyori1.Text = runKyori(kyori1.Text.ToString(), 30);

            // 車名２の進んだ距離を求める
            kyori2.Text = runKyori(kyori2.Text.ToString(), 20);

            // 車名３の進んだ距離を求める
            kyori3.Text = runKyori(kyori3.Text.ToString(), 15);

            nenryou0(nenryou);
        }

        // summary
        // [パラメータ]
        // souKyori  進んだ距離の合計
        // nextKyori 次に進む距離
        // [返却内容]
        // 進んだ距離の合計
        // summary
        public string runKyori(string souKyori, int nextKyori)
        {
            string kyori = souKyori.Replace("走行距離：\r\n", "");
            int kyoriInt = 0;

            if (string.IsNullOrEmpty(kyori))
            {
                kyoriInt = nextKyori;
            }
            else
            {
                kyoriInt = int.Parse(kyori) + nextKyori;
            }
            return "走行距離：\r\n" + kyoriInt.ToString();
        }

        // summary
        // [パラメータ]
        // nenryou  燃料
        // [返却内容]
        //   燃料がある場合、"1"
        //   燃料がない場合、"0"
        // summary
        public string nenryou0(int nenryou)
        {
            if (nenryou <= 0)
            {
                timer1.Enabled = false;
                nenryouText.ReadOnly = false;
                return "0";
            }

            return "1";
        }
    }
}
