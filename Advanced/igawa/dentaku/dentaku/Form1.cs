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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Input_str = "";
        string Keka_str = "";
        double Result = 0;
        string Operator = null;
        bool twiceEq = false;
        bool errlock = false;


        private void btnNumClick(object sender, EventArgs e)
        {
            if (Keka_str == "")
            {
                init();
            }
            if(errlock != true)
            {
                Button btn = (Button)sender;
                string text = btn.Text;
                Input_str += text;
                Keka_str += text;
                txtKekka.Text = String.Format("{0:#,0}", validateDigit(Input_str));
                txtKeka.Text = Keka_str;
            }
            twiceEq = false;
        }

        private void btnOperatorClick(object sender, EventArgs e)
        {
            if (errlock != true)
            {
                Button btn = (Button)sender;
                if (twiceEq == true)
                {
                    Keka_str += Input_str;
                    txtKeka.Text = Keka_str;
                }
                if (txtKeka.Text.EndsWith("＋") ||
                    txtKeka.Text.EndsWith("－") ||
                    txtKeka.Text.EndsWith("×") ||
                    txtKeka.Text.EndsWith("÷") )
                {
                    if(Keka_str.Length != 0)
                    {
                        Keka_str = Keka_str.Remove(Keka_str.Length - 1).ToString();
                    }
                    Operator = btn.Text;
                    Keka_str += Operator.ToString();
                    txtKeka.Text = Keka_str;
                    goto end;
                }


                double num1 = Result;
                if (Input_str != "")
                {
                    double num2 = double.Parse(Input_str);
                    if (Operator == "＋")
                    {
                        Result = num1 + num2;
                        twiceEq = false;
                    }
                    if (Operator == "－")
                    {
                        Result = num1 - num2;
                        twiceEq = false;
                    }
                    if (Operator == "×")
                    {
                        Result = num1 * num2;
                        twiceEq = false;
                    }
                    if (Operator == "÷") 
                    {
                        if(num2 != 0)
                        {
                            Result = num1 / num2;
                            twiceEq = false;
                        }
                        else
                        {
                            txtKeka.Text = "0で割ることはできません。";
                            txtKekka.Text = "0で割ることはできません。";
                            errlock = true;
                            goto end;
                        }
                    }

                    //負の数と小数値は0に変換
                    if (Result < 0)
                        Result = 0;
                    if (Result - System.Math.Floor(Result) != 0)
                        Result = 0;

                    if (Operator == null)
                        Result = num2;
                }

                //txtKekka.Text = Result.ToString();
                txtKekka.Text = String.Format("{0:#,0}", validateDigit(Result.ToString()));
                Input_str = "";
                Operator = btn.Text;
                Keka_str += Operator.ToString();
                txtKeka.Text = Keka_str;

                if (Operator == "＝")
                {
                    if (twiceEq == true)
                    {
                        init();
                        goto end;
                    }
                    Operator = "";
                    Keka_str = "";
                    txtKeka.Text = "";
                    twiceEq = true;
                    Input_str = String.Format("{0:#,0}", validateDigit(Result.ToString()));
                }
            }
            end:;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(Input_str != "" && Keka_str != "" && errlock != true)
            {
                Input_str = Input_str.Remove(Input_str.Length - 1).ToString();
                txtKekka.Text = String.Format("{0:#,0}", validateDigit(Input_str.ToString()));
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
            twiceEq = false;
            errlock = false;
        }

        private Double validateDigit(string str)
        {
            if(10 < str.Length)
            {
                Keka_str = "11桁以上は対応していません。";
                txtKeka.Text = Keka_str;
                errlock = true;
                return 999;
            }
            else if(str.Length == 0)
            {
                return 0;
            }
            else
            {
                return Double.Parse(str);
            }
        }

        private void btnEqual_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            this.KeyPreview = true;
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    this.btn0.Focus();
                    this.btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    this.btn1.Focus();
                    this.btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    this.btn2.Focus();
                    this.btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    this.btn3.Focus();
                    this.btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    this.btn4.Focus();
                    this.btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    this.btn5.Focus();
                    this.btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    this.btn6.Focus();
                    this.btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    this.btn7.Focus();
                    this.btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    this.btn8.Focus();
                    this.btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    this.btn9.Focus();
                    this.btn9.PerformClick();
                    break;
                case Keys.Delete:
                    this.btnAllCl.Focus();
                    this.btnAllCl.PerformClick();
                    break;
                case Keys.Back:
                    this.btnDel.Focus();
                    this.btnDel.PerformClick();
                    break;
                case Keys.Add:
                    this.btnTasu.Focus();
                    this.btnTasu.PerformClick();
                    break;
                case Keys.Subtract:
                    this.btnHiku.Focus();
                    this.btnHiku.PerformClick();
                    break;
                case Keys.Multiply:
                    this.btnKakeru.Focus();
                    this.btnKakeru.PerformClick();
                    break;
                case Keys.Divide:
                    this.btnWaru.Focus();
                    this.btnWaru.PerformClick();
                    break;
                case Keys.Enter:
                    this.btnEqual.Focus();
                    this.btnEqual.PerformClick();
                    break;
            }

        }
    }
}
