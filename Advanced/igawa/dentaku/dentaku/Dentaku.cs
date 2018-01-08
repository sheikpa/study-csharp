using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentaku
{
    public partial class Dentaku : Form
    {
        public Dentaku()
        {
            InitializeComponent();
        }

        string Input_str = "";
        string Keka_str = "";
        double Result = 0;
        string Operator = null;
        bool errlock = false;

        

        private void btn0_Click(object sender, EventArgs e)
        {
            if(Keka_str == "")
            {
                init();
            }
            if(errlock != true)
            {
                Button btn = (Button)sender;
                string text = btn.Text;
                Input_str += text;
                Keka_str += text;
                txtKekka.Text = String.Format("{0:#,0}", double.Parse(Input_str));
                txtKeka.Text = Keka_str;
            }
            //btnEqual.Focus();
            //Debug.WriteLine("Debug.WriteLine");
        }

        private void btnKakeru_Click(object sender, EventArgs e)
        {
            if(errlock != true)
            {
                double num1 = Result;
                if (Input_str != "")
                {
                    double num2 = double.Parse(Input_str);
                    if (Operator == "＋")
                        Result = num1 + num2;
                    if (Operator == "－")
                        Result = num1 - num2;
                    if (Operator == "×")
                        Result = num1 * num2;
                    if (Operator == "÷")
                    {
                        if(num2 != 0)
                        {
                            Result = num1 / num2;
                        }
                        else
                        {
                            txtKeka.Text = "0で割ることはできません。";
                            txtKekka.Text = "ERROR";
                            errlock = true;
                            goto errlock;
                        }
                    }

                    //負の数と小数値は0に変換
                    if (Result < 0)
                        Result = 0;
                    if ((int)Result != Result)
                        Result = 0;

                    if (Operator == null)
                        Result = num2;
                }

                //txtKekka.Text = Result.ToString();
                txtKekka.Text = String.Format("{0:#,0}", Result);
                Input_str = "";
                Button btn = (Button)sender;
                Operator = btn.Text;
                Keka_str += Operator.ToString();
                txtKeka.Text = Keka_str;

                if (Operator == "＝")
                {
                    Operator = "";
                    Keka_str = "";
                    txtKeka.Text = "";
                    Input_str = Result.ToString();
                }
            }
            errlock:;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(Input_str != "" && Keka_str != "" && errlock != true)
            {
                Input_str = Input_str.Remove(Input_str.Length - 1).ToString();
                txtKekka.Text = Input_str;
                Keka_str = Keka_str.Remove(Keka_str.Length - 1).ToString();
                txtKeka.Text = Keka_str;
            }
        }

        private void btnAllCl_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            Input_str = "";
            Keka_str = "";
            txtKeka.Text = "";
            txtKekka.Text = "0";
            Result = 0;
            Operator = null;
            errlock = false;
        }

        /*
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            e.Handled = true;
            Debug.WriteLine("Debug.WriteLine");
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    this.btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    this.btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    this.btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    this.btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    this.btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    this.btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    this.btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    this.btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    this.btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    this.btn9.PerformClick();
                    break;
                case Keys.Delete:
                    this.btnAllCl.PerformClick();
                    break;
                case Keys.Back:
                    this.btnDel.PerformClick();
                    break;
                case Keys.Add:
                    this.btnTasu.PerformClick();
                    break;
                case Keys.Subtract:
                    this.btnHiku.PerformClick();
                    break;
                case Keys.Multiply:
                    this.btnKakeru.PerformClick();
                    break;
                case Keys.Divide:
                    this.btnWaru.PerformClick();
                    break;
                case Keys.Enter:
                    this.btnEqual.PerformClick();
                    break;
            }
        }
        */

        private void btnEqual_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.KeyPreview = true;
            //e.Handled = true;
            Debug.WriteLine("Debug.WriteLine");
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    this.btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    this.btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    this.btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    this.btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    this.btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    this.btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    this.btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    this.btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    this.btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    this.btn9.PerformClick();
                    break;
                case Keys.Delete:
                    this.btnAllCl.PerformClick();
                    break;
                case Keys.Back:
                    this.btnDel.PerformClick();
                    break;
                case Keys.Add:
                    this.btnTasu.PerformClick();
                    break;
                case Keys.Subtract:
                    this.btnHiku.PerformClick();
                    break;
                case Keys.Multiply:
                    this.btnKakeru.PerformClick();
                    break;
                case Keys.Divide:
                    this.btnWaru.PerformClick();
                    break;
                case Keys.Enter:
                    this.btnEqual.PerformClick();
                    break;
            }
        }
        /*
private void btn1_KeyDown(object sender, KeyEventArgs e)
{
   Debug.WriteLine("Debug.WriteLine");
*/


    }
}
