using System;

namespace Dentaku
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtKeka = new System.Windows.Forms.Label();
            this.txtKekka = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAllCl = new System.Windows.Forms.Button();
            this.btnKakeru = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnWaru = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnHiku = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnTasu = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeka
            // 
            this.txtKeka.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKeka.Location = new System.Drawing.Point(12, 9);
            this.txtKeka.Name = "txtKeka";
            this.txtKeka.Size = new System.Drawing.Size(382, 19);
            this.txtKeka.TabIndex = 0;
            this.txtKeka.Text = "txtKeka";
            this.txtKeka.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKekka
            // 
            this.txtKekka.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKekka.Location = new System.Drawing.Point(10, 31);
            this.txtKekka.Name = "txtKekka";
            this.txtKekka.Size = new System.Drawing.Size(402, 34);
            this.txtKekka.TabIndex = 1;
            this.txtKekka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKekka.TextChanged += new System.EventHandler(this.txtKekka_TextChanged);
            this.txtKekka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKekka_KeyDown);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDel.Location = new System.Drawing.Point(12, 109);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 50);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAllCl
            // 
            this.btnAllCl.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAllCl.Location = new System.Drawing.Point(114, 109);
            this.btnAllCl.Name = "btnAllCl";
            this.btnAllCl.Size = new System.Drawing.Size(196, 50);
            this.btnAllCl.TabIndex = 2;
            this.btnAllCl.Text = "ALL CL";
            this.btnAllCl.UseVisualStyleBackColor = true;
            this.btnAllCl.Click += new System.EventHandler(this.btnAllCl_Click);
            // 
            // btnKakeru
            // 
            this.btnKakeru.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKakeru.Location = new System.Drawing.Point(316, 109);
            this.btnKakeru.Name = "btnKakeru";
            this.btnKakeru.Size = new System.Drawing.Size(96, 50);
            this.btnKakeru.TabIndex = 2;
            this.btnKakeru.Text = "×";
            this.btnKakeru.UseVisualStyleBackColor = true;
            this.btnKakeru.Click += new System.EventHandler(this.btnKakeru_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn7.Location = new System.Drawing.Point(12, 165);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(96, 50);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn8.Location = new System.Drawing.Point(114, 165);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(96, 50);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn9.Location = new System.Drawing.Point(216, 165);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(96, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnWaru
            // 
            this.btnWaru.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWaru.Location = new System.Drawing.Point(316, 165);
            this.btnWaru.Name = "btnWaru";
            this.btnWaru.Size = new System.Drawing.Size(96, 50);
            this.btnWaru.TabIndex = 2;
            this.btnWaru.Text = "÷";
            this.btnWaru.UseVisualStyleBackColor = true;
            this.btnWaru.Click += new System.EventHandler(this.btnWaru_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn4.Location = new System.Drawing.Point(12, 221);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(96, 50);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn5.Location = new System.Drawing.Point(114, 221);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(96, 50);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn6.Location = new System.Drawing.Point(216, 221);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(96, 50);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnHiku
            // 
            this.btnHiku.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHiku.Location = new System.Drawing.Point(316, 221);
            this.btnHiku.Name = "btnHiku";
            this.btnHiku.Size = new System.Drawing.Size(96, 50);
            this.btnHiku.TabIndex = 2;
            this.btnHiku.Text = "－";
            this.btnHiku.UseVisualStyleBackColor = true;
            this.btnHiku.Click += new System.EventHandler(this.btnHiku_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn1.Location = new System.Drawing.Point(12, 277);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(96, 50);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn2.Location = new System.Drawing.Point(114, 277);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 50);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn3.Location = new System.Drawing.Point(216, 277);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(96, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnTasu
            // 
            this.btnTasu.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTasu.Location = new System.Drawing.Point(316, 277);
            this.btnTasu.Name = "btnTasu";
            this.btnTasu.Size = new System.Drawing.Size(96, 50);
            this.btnTasu.TabIndex = 2;
            this.btnTasu.Text = "＋";
            this.btnTasu.UseVisualStyleBackColor = true;
            this.btnTasu.Click += new System.EventHandler(this.btnTasu_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn0.Location = new System.Drawing.Point(12, 333);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 50);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEqual.Location = new System.Drawing.Point(316, 333);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(96, 50);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn00.Location = new System.Drawing.Point(114, 333);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(196, 50);
            this.btn00.TabIndex = 2;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 398);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnAllCl);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnKakeru);
            this.Controls.Add(this.btnTasu);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnHiku);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnWaru);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtKekka);
            this.Controls.Add(this.txtKeka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label txtKeka;
        private System.Windows.Forms.TextBox txtKekka;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAllCl;
        private System.Windows.Forms.Button btnKakeru;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnWaru;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnHiku;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnTasu;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn00;
    }
}

