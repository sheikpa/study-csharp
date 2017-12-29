using System;
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
        internal string beforeKeka = "";
        internal string beforeEnzanshi = "";
        internal string enzanFlg = "";
        internal string equaleFlg = "";
        internal string erorreMsg = "0で除算することはできません";

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
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            enzanKeka();
            zeroClear();
            txtKekka.Text = txtKekka.Text + Convert.ToString("9");
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
                    break;
            }
        }

        private void btnAllCl_Click(object sender, EventArgs e)
        {
            txtKeka.Text = Convert.ToString("");
            txtKekka.Text = Convert.ToString("");
            beforeNum = "";
            beforeKeka = "";
            beforeEnzanshi = "";

            txtKekka.Enabled = true;
            btnDel.Enabled = true;
            btn0.Enabled = true;
            btn00.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnEqual.Enabled = true;
            btnTasu.Enabled = true;
            btnHiku.Enabled = true;
            btnKakeru.Enabled = true;
            btnWaru.Enabled = true;
        }

        private void btnTasu_Click(object sender, EventArgs e)
        {
            keisan("+");
        }

        private void btnHiku_Click(object sender, EventArgs e)
        {
            keisan("-");
        }

        private void btnWaru_Click(object sender, EventArgs e)
        {
            if (int.Parse(Convert.ToString(txtKekka.Text)) == 0)
            {
                error();
                return;
            }
            else
            {
                keisan("/");
            }
        }

        private void btnKakeru_Click(object sender, EventArgs e)
        {
            keisan("*");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            String temp = "";
            switch (beforeEnzanshi)
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
                        error();
                        return;
                    }
                    else
                    {
                        if (beforeKeka != "")
                        {
                            if (int.Parse(beforeKeka) % int.Parse(Convert.ToString(txtKekka.Text)) == 0)
                            {
                                temp = (int.Parse(beforeKeka) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            }
                            else
                            {
                                temp = "0";
                            }
                        }
                        else
                        {
                            if (int.Parse(beforeNum) % int.Parse(Convert.ToString(txtKekka.Text).Replace(",", "")) == 0)
                            {
                                temp = (int.Parse(beforeNum) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            }
                            else
                            {
                                temp = "0";
                            }
                        }
                    }
                    break;
                case "*":
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
            if (temp == erorreMsg)
            {
                txtKekka.Text = temp;
            }
            else
            {
                txtKekka.Text = temp;
            }
            beforeNum = "";
            beforeKeka = "";
            beforeEnzanshi = "";
            equaleFlg = "1";
        }

        private void txtKekka_TextChanged(object sender, EventArgs e)
        {
            if (txtKekka.Text == erorreMsg)
            {
                return;
            }

            if (equaleFlg == "1")
            {
                txtKekka.Text = "";
                equaleFlg = "";
            }

            string txtKekkaStr = txtKekka.Text.Replace(",", "");
            string tempNum = "";
            string tempTxtKekka = "";
            string flg = "";

            for (int i = 0; i < txtKekkaStr.Length; i++)
            {
                if (txtKekkaStr.Substring(i, 1) == "0" ||
                    txtKekkaStr.Substring(i, 1) == "1" ||
                    txtKekkaStr.Substring(i, 1) == "2" ||
                    txtKekkaStr.Substring(i, 1) == "3" ||
                    txtKekkaStr.Substring(i, 1) == "4" ||
                    txtKekkaStr.Substring(i, 1) == "5" ||
                    txtKekkaStr.Substring(i, 1) == "6" ||
                    txtKekkaStr.Substring(i, 1) == "7" ||
                    txtKekkaStr.Substring(i, 1) == "8" ||
                    txtKekkaStr.Substring(i, 1) == "9")
                {
                    tempNum = tempNum + txtKekkaStr.Substring(i, 1);
                    flg = "1";
                }
                else
                {
                    tempTxtKekka = tempTxtKekka + txtKekka_kanma(tempNum) + txtKekkaStr.Substring(i, 1);
                    tempNum = "";
                    flg = "2";
                }
            }

            if (flg == "1")
            {
                if (tempTxtKekka == "")
                {
                    tempTxtKekka = txtKekka_kanma(tempNum);
                }
                else
                {
                    tempTxtKekka = tempTxtKekka + txtKekka_kanma(tempNum);
                }
            }

            txtKekka.Text = tempTxtKekka;
            txtKekka.Select(txtKekka.Text.Length, 0);
        }

        private void txtKekka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string temp = Convert.ToString(txtKekka.Text).Replace(",", "");

                if (temp.IndexOf("/0") >= 0)
                {
                    error();
                    return;
                }

                string numNext = "";

                int j = 0;
                int k = 0;

                string numKekka = "";
                string numKeika = "";
                string enzanshi = "";

                for (int i = 0; i < temp.Length; i++)
                {
                    switch (temp.Substring(i, 1))
                    {
                        case ("0"):
                            if (numNext == "")
                            {
                                numKeika = "0";
                                numNext = "1";
                            }
                            else
                            {
                                numKeika = numKeika + "0";
                            }
                            break;
                        case ("1"):
                            if (numNext == "")
                            {
                                numKeika = "1";
                                numNext = "1";
                            }
                            else
                            {
                                numKeika = numKeika + "1";
                            }
                            break;
                        case ("2"):
                            if (numNext == "")
                            {
                                numKeika = "2";
                                numNext = "2";
                            }
                            else
                            {
                                numKeika = numKeika + "2";
                            }
                            break;
                        case ("3"):
                            if (numNext == "")
                            {
                                numKeika = "3";
                                numNext = "3";
                            }
                            else
                            {
                                numKeika = numKeika + "3";
                            }
                            break;
                        case ("4"):
                            if (numNext == "")
                            {
                                numKeika = "4";
                                numNext = "4";
                            }
                            else
                            {
                                numKeika = numKeika + "4";
                            }
                            break;
                        case ("5"):
                            if (numNext == "")
                            {
                                numKeika = "5";
                                numNext = "5";
                            }
                            else
                            {
                                numKeika = numKeika + "5";
                            }
                            break;
                        case ("6"):
                            if (numNext == "")
                            {
                                numKeika = "6";
                                numNext = "6";
                            }
                            else
                            {
                                numKeika = numKeika + "6";
                            }
                            break;
                        case ("7"):
                            if (numNext == "")
                            {
                                numKeika = "7";
                                numNext = "7";
                            }
                            else
                            {
                                numKeika = numKeika + "7";
                            }
                            break;
                        case ("8"):
                            if (numNext == "")
                            {
                                numKeika = "8";
                                numNext = "8";
                            }
                            else
                            {
                                numKeika = numKeika + "8";
                            }
                            break;
                        case ("9"):
                            if (numNext == "")
                            {
                                numKeika = "9";
                                numNext = "9";
                            }
                            else
                            {
                                numKeika = numKeika + "9";
                            }
                            break;
                        case ("+"):
                            if (numKekka == "" && enzanshi == "")
                            {
                                numKekka = numKeika;
                                enzanshi = "+";
                            }
                            else
                            {
                                switch (enzanshi)
                                {
                                    case "+":
                                        numKekka = (int.Parse(numKekka) + int.Parse(numKeika)).ToString();
                                        break;
                                    case "-":
                                        numKekka = (int.Parse(numKekka) - int.Parse(numKeika)).ToString();
                                        break;
                                    case "*":
                                        numKekka = (int.Parse(numKekka) * int.Parse(numKeika)).ToString();
                                        break;
                                    case "/":
                                        numKekka = (int.Parse(numKekka) / int.Parse(numKeika)).ToString();
                                        break;
                                }
                                enzanshi = "+";
                            }
                            numNext = "";
                            break;
                        case ("-"):
                            if (numKekka == "" && enzanshi == "")
                            {
                                numKekka = numKeika;
                                enzanshi = "-";
                            }
                            else
                            {
                                switch (enzanshi)
                                {
                                    case "+":
                                        numKekka = (int.Parse(numKekka) + int.Parse(numKeika)).ToString();
                                        break;
                                    case "-":
                                        numKekka = (int.Parse(numKekka) - int.Parse(numKeika)).ToString();
                                        break;
                                    case "*":
                                        numKekka = (int.Parse(numKekka) * int.Parse(numKeika)).ToString();
                                        break;
                                    case "/":
                                        numKekka = (int.Parse(numKekka) / int.Parse(numKeika)).ToString();
                                        break;
                                }
                                enzanshi = "-";
                            }
                            numNext = "";
                            break;
                        case ("*"):
                            if (numKekka == "" && enzanshi == "")
                            {
                                numKekka = numKeika;
                                enzanshi = "*";
                            }
                            else
                            {
                                switch (enzanshi)
                                {
                                    case "+":
                                        numKekka = (int.Parse(numKekka) + int.Parse(numKeika)).ToString();
                                        break;
                                    case "-":
                                        numKekka = (int.Parse(numKekka) - int.Parse(numKeika)).ToString();
                                        break;
                                    case "*":
                                        numKekka = (int.Parse(numKekka) * int.Parse(numKeika)).ToString();
                                        break;
                                    case "/":
                                        numKekka = (int.Parse(numKekka) / int.Parse(numKeika)).ToString();
                                        break;
                                }
                                enzanshi = "*";
                            }
                            numNext = "";
                            break;
                        case ("/"):
                            if (numKekka == "" && enzanshi == "")
                            {
                                numKekka = numKeika;
                                enzanshi = "/";
                            }
                            else
                            {
                                switch (enzanshi)
                                {
                                    case "+":
                                        numKekka = (int.Parse(numKekka) + int.Parse(numKeika)).ToString();
                                        break;
                                    case "-":
                                        numKekka = (int.Parse(numKekka) - int.Parse(numKeika)).ToString();
                                        break;
                                    case "*":
                                        numKekka = (int.Parse(numKekka) * int.Parse(numKeika)).ToString();
                                        break;
                                    case "/":
                                        numKekka = (int.Parse(numKekka) / int.Parse(numKeika)).ToString();
                                        break;
                                }
                                enzanshi = "/";
                            }
                            numNext = "";
                            break;
                    }
                }

                switch (enzanshi)
                {
                    case "+":
                        numKekka = (int.Parse(numKekka) + int.Parse(numKeika)).ToString();
                        break;
                    case "-":
                        numKekka = (int.Parse(numKekka) - int.Parse(numKeika)).ToString();
                        break;
                    case "*":
                        numKekka = (int.Parse(numKekka) * int.Parse(numKeika)).ToString();
                        break;
                    case "/":
                        numKekka = (int.Parse(numKekka) / int.Parse(numKeika)).ToString();
                        break;
                }

                txtKekka.Text = numKekka;
                equaleFlg = "1";
            }
        }

        private void keisan(string enzanshi)
        {
            if (!(Convert.ToString(txtKekka.Text).Contains("+")) ||
                 (Convert.ToString(txtKekka.Text).Contains("-")) ||
                 (Convert.ToString(txtKekka.Text).Contains("X")) ||
                 (Convert.ToString(txtKekka.Text).Contains("/")))
            {
                txtKeka.Text = txtKeka.Text + " " + Convert.ToString(txtKekka.Text).Replace(",", "");

                if (beforeNum != "")
                {
                    switch (beforeEnzanshi)
                    {
                        case ("+"):
                            beforeNum = (int.Parse(beforeNum) + int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            break;
                        case ("-"):
                            beforeNum = (int.Parse(beforeNum) - int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            break;
                        case ("*"):
                            beforeNum = (int.Parse(beforeNum) * int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            break;
                        case ("/"):
                            if (int.Parse(beforeNum) % int.Parse(Convert.ToString(txtKekka.Text).Replace(",", "")) == 0)
                            {
                                beforeNum = (int.Parse(beforeNum) / int.Parse(Convert.ToString(txtKekka.Text).Replace(",", ""))).ToString();
                            }
                            else
                            {
                                beforeNum = "0";
                            }
                            break;
                    }
                    txtKekka.Text = beforeNum;
                }
                else
                {
                    beforeNum = Convert.ToString(txtKekka.Text).Replace(",", "");
                    txtKekka.Text = enzanshi;
                }

                beforeEnzanshi = enzanshi;

                enzanFlg = "1";
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

        public string txtKekka_kanma(string num)
        {
            string result = "";

            string temp = num;

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
                            result = "," + array[2] + array[1] + array[0];
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
                        }
                        else
                        {
                            result = array[0] + "," + result;
                        }
                        break;
                    case 1:
                        if (flg == "1")
                        {
                            result = array[1] + array[0] + result;
                        }
                        else
                        {
                            result = array[1] + array[0] + "," + result;
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

           return result;
        }

        private void enzanKeka()
        {
            if (enzanFlg == "1")
            {
                if (beforeEnzanshi.Contains("+") ||
                    beforeEnzanshi.Contains("-") ||
                    beforeEnzanshi.Contains("*") ||
                    beforeEnzanshi.Contains("/"))
                {
                    txtKekka.Text = "";
                    txtKeka.Text = txtKeka.Text + " " + beforeEnzanshi;
                    enzanFlg = "";
                }
            }

            if (equaleFlg == "1")
            {
                txtKekka.Text = "";
                equaleFlg = "";
            }
        }

        private void error()
        {
            txtKeka.Text = "";
            txtKekka.Text = erorreMsg;
            txtKekka.Enabled = false;
            btnDel.Enabled = false;
            btn0.Enabled = false;
            btn00.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnEqual.Enabled = false;
            btnTasu.Enabled = false;
            btnHiku.Enabled = false;
            btnKakeru.Enabled = false;
            btnWaru.Enabled = false;
        }
    }
}
