﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentaku
{
    public partial class Form1 : Form
    {
        internal string beforeNum = "";
        internal string beforeEnzan = "";
        internal string beforeKeka = "";

        public Form1()
        {
            InitializeComponent();
            txtKeka.Text = Convert.ToString("");
            txtKekka.Text = Convert.ToString("");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("1");
            kanma();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("2");
            kanma();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("3");
            kanma();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("4");
            kanma();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("5");
            kanma();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("6");
            kanma();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("7");
            kanma();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("8");
            kanma();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("9");
            kanma();
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            enzanKeka();
            string temp = Convert.ToString(txtKekka.Text);

            if (temp == "" || temp == "0")
            {
                if (temp == "")
                {
                    txtKekka.Text = txtKekka.Text + Convert.ToString("0");
                }
            }
            else
            {
                txtKekka.Text = txtKekka.Text + Convert.ToString("0");
            }

            kanma();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            enzanKeka();
            string temp = Convert.ToString(txtKekka.Text);

            if (temp == "" || temp == "0")
            {
                if (temp == "")
                {
                    txtKekka.Text = txtKekka.Text + Convert.ToString("0");
                }
            }
            else
            {
                txtKekka.Text = txtKekka.Text + Convert.ToString("00");
            }

            kanma();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string temp = Convert.ToString(txtKekka.Text);

            switch (temp.Length)
            {
                case 0:
                    break;
                case 1:
                    txtKekka.Text = Convert.ToString("");
                    break;
                default:
                    txtKekka.Text = temp.Substring(0, temp.Length - 1);
                    kanma();
                    break;
            }
        }

        private void btnAllCl_Click(object sender, EventArgs e)
        {
            txtKeka.Text = Convert.ToString("");
            txtKekka.Text = Convert.ToString("");
        }

        private void btnTasu_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToString(txtKekka.Text).Contains("+")) ||
                 (Convert.ToString(txtKekka.Text).Contains("-")) ||
                 (Convert.ToString(txtKekka.Text).Contains("X")) ||
                 (Convert.ToString(txtKekka.Text).Contains("/")))
            {
                if (beforeNum != "")
                {
                    beforeKeka = (int.Parse(beforeNum) + int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                }

                beforeNum = Convert.ToString(txtKekka.Text).Replace(",", "");

                txtKekka.Text = "+";

                txtKeka.Text = txtKeka.Text + " " + beforeNum;
            }
        }

        private void btnHiku_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToString(txtKekka.Text).Contains("+")) ||
                 (Convert.ToString(txtKekka.Text).Contains("-")) ||
                 (Convert.ToString(txtKekka.Text).Contains("X")) ||
                 (Convert.ToString(txtKekka.Text).Contains("/")))
            {
                if (beforeNum != "")
                {
                    beforeKeka = (int.Parse(beforeNum) - int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                }

                beforeNum = Convert.ToString(txtKekka.Text).Replace(",", "");

                txtKekka.Text = "-";

                txtKeka.Text = txtKeka.Text + " " + beforeNum;
            }
        }

        private void btnWaru_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToString(txtKekka.Text).Contains("+")) ||
                 (Convert.ToString(txtKekka.Text).Contains("-")) ||
                 (Convert.ToString(txtKekka.Text).Contains("X")) ||
                 (Convert.ToString(txtKekka.Text).Contains("/")))
            {
                if (beforeNum != "")
                {
                    if (int.Parse(Convert.ToString(txtKekka.Text)) == 0)
                    {
                        txtKekka.Text = "0で除算することはできません";
                    }
                    else
                    {
                        beforeKeka = (int.Parse(beforeNum) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                }

                beforeNum = Convert.ToString(txtKekka.Text).Replace(",", "");

                txtKekka.Text = "/";

                txtKeka.Text = txtKeka.Text + " " + beforeNum;
            }
        }

        private void btnKakeru_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToString(txtKekka.Text).Contains("+")) ||
                 (Convert.ToString(txtKekka.Text).Contains("-")) ||
                 (Convert.ToString(txtKekka.Text).Contains("X")) ||
                 (Convert.ToString(txtKekka.Text).Contains("/")))
            {
                if (beforeNum != "")
                {
                    beforeKeka = (int.Parse(beforeNum) * int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                }

                beforeNum = Convert.ToString(txtKekka.Text).Replace(",", "");

                txtKekka.Text = "X";

                txtKeka.Text = txtKeka.Text + " " + beforeNum;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            String temp = "";
            switch (beforeEnzan)
            {
                case "+":
                    if (beforeKeka != "")
                    {
                        temp = (int.Parse(beforeKeka) + int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    else
                    {
                        temp = (int.Parse(beforeNum) + int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    break;
                case "-":
                    if (beforeKeka != "")
                    {
                        temp = (int.Parse(beforeKeka) - int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    else
                    {
                        temp = (int.Parse(beforeNum) - int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    break;
                case "/":
                    if (int.Parse(Convert.ToString(txtKekka.Text)) == 0)
                    {
                        temp = "0で除算することはできません";
                    }
                    else
                    {
                        if (beforeKeka != "")
                        {
                            temp = (int.Parse(beforeKeka) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                        }
                        else
                        {
                            temp = (int.Parse(beforeNum) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                        }
                    }
                    break;
                case "X":
                    if (beforeKeka != "")
                    {
                        temp = (int.Parse(beforeKeka) * int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    else
                    {
                        temp = (int.Parse(beforeNum) * int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                    }
                    break;
            }

            txtKeka.Text = "";
            if (temp == "0で除算することはできません")
            {
                txtKekka.Text = temp;
            }
            else
            {
                txtKekka.Text = temp;
                kanma();
            }
        }

        private void zeroClear()
        {
            string temp = Convert.ToString(txtKekka.Text);

            if (temp == "0")
            {
                txtKekka.Text = Convert.ToString("");
            }
        }

        private void kanma()
        {
            string result = "";

            string temp = Convert.ToString(txtKekka.Text);

            temp = temp.Replace(",", "");

            int tempL = temp.Length;

            string[] array = new string[3];

            int j = 0;

            string flg = "";

            if (temp.Length > 3)
            {
                for (int i = tempL - 1; i > -1; i--)
                {
                    if (j == 2)
                    {
                        if (flg == "")
                        {
                            array[j] = temp.Substring(i, 1);
                            result = "," +  array[2] + array[1] + array[0];
                            flg = "1";
                        }
                        else
                        {
                            if (flg == "1")
                            {
                                array[j] = temp.Substring(i, 1);
                                result = array[2] + array[1] + array[0] + result;
                                flg = "2";
                            }
                            else
                            {
                                array[j] = temp.Substring(i, 1);
                                result = array[2] + array[1] + array[0] + "," + result;
                            }
                        }
                        j = 0;
                    }
                    else
                    {
                        array[j] = temp.Substring(i, 1);
                        j++;
                    }
                }

                switch (j - 1)
                {
                    case 0:
                        if (flg == "1")
                        {
                            result = array[0] + result;
                            break;
                        }
                        else
                        {
                            result = array[0] + "," + result;
                            break;
                        }
                    case 1:
                        if (flg == "1")
                        {
                            result = array[1] + array[0] + result;
                            break;
                        }
                        else
                        {
                            result = array[1] + array[0] + "," + result;
                            break;
                        }
                        break;
                    case 2:
                        array[j] = temp.Substring(2, 1);
                        result = array[2] + array[1] + array[0] + "," + result;
                        break;
                }
            }
            else
            {
                result = temp;
            }

            txtKekka.Text = Convert.ToString(result);
        }

        private void enzanKeka()
        {
            if (Convert.ToString(txtKekka.Text).Contains("+") ||
                Convert.ToString(txtKekka.Text).Contains("-") ||
                Convert.ToString(txtKekka.Text).Contains("X") ||
                Convert.ToString(txtKekka.Text).Contains("/"))
            {
                beforeEnzan = Convert.ToString(txtKekka.Text).Replace(",", "");
                txtKekka.Text = "";
                txtKeka.Text = txtKeka.Text + " " + beforeEnzan;
            }
        }
    }
}
