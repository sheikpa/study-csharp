namespace dentaku
{
    partial class Dentaku
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
            this.txtKeka = new System.Windows.Forms.Label();
            this.txtKekka = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAllCl = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnKakeru = new System.Windows.Forms.Button();
            this.btnWaru = new System.Windows.Forms.Button();
            this.btnHiku = new System.Windows.Forms.Button();
            this.btnTasu = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeka
            // 
            this.txtKeka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeka.Location = new System.Drawing.Point(13, 9);
            this.txtKeka.Name = "txtKeka";
            this.txtKeka.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKeka.Size = new System.Drawing.Size(307, 17);
            this.txtKeka.TabIndex = 0;
            this.txtKeka.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtKeka.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // txtKekka
            // 
            this.txtKekka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKekka.Font = new System.Drawing.Font("MS UI Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKekka.Location = new System.Drawing.Point(13, 29);
            this.txtKekka.Name = "txtKekka";
            this.txtKekka.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKekka.Size = new System.Drawing.Size(307, 50);
            this.txtKekka.TabIndex = 2;
            this.txtKekka.TabStop = false;
            this.txtKekka.Text = "0";
            this.txtKekka.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDel.Location = new System.Drawing.Point(12, 86);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 54);
            this.btnDel.TabIndex = 3;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnAllCl
            // 
            this.btnAllCl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllCl.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAllCl.Location = new System.Drawing.Point(91, 86);
            this.btnAllCl.Name = "btnAllCl";
            this.btnAllCl.Size = new System.Drawing.Size(152, 54);
            this.btnAllCl.TabIndex = 4;
            this.btnAllCl.TabStop = false;
            this.btnAllCl.Text = "ALL CL";
            this.btnAllCl.UseVisualStyleBackColor = true;
            this.btnAllCl.Click += new System.EventHandler(this.btnAllCl_Click);
            this.btnAllCl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn9.Location = new System.Drawing.Point(170, 146);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 54);
            this.btn9.TabIndex = 4;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            this.btn9.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn8.Location = new System.Drawing.Point(91, 146);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 54);
            this.btn8.TabIndex = 4;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            this.btn8.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn7.Location = new System.Drawing.Point(12, 146);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 54);
            this.btn7.TabIndex = 4;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            this.btn7.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn6.Location = new System.Drawing.Point(170, 206);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 54);
            this.btn6.TabIndex = 4;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            this.btn6.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn5.Location = new System.Drawing.Point(91, 206);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 54);
            this.btn5.TabIndex = 4;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            this.btn5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn4.Location = new System.Drawing.Point(12, 206);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 54);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            this.btn4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn3.Location = new System.Drawing.Point(170, 266);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 54);
            this.btn3.TabIndex = 4;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            this.btn3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn2.Location = new System.Drawing.Point(91, 266);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 54);
            this.btn2.TabIndex = 4;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            this.btn2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn1.Location = new System.Drawing.Point(12, 266);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 54);
            this.btn1.TabIndex = 4;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            this.btn1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn0.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn0.Location = new System.Drawing.Point(12, 326);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 54);
            this.btn0.TabIndex = 4;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btn00
            // 
            this.btn00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn00.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn00.Location = new System.Drawing.Point(91, 326);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(73, 54);
            this.btn00.TabIndex = 4;
            this.btn00.TabStop = false;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn0_Click);
            this.btn00.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnKakeru
            // 
            this.btnKakeru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKakeru.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKakeru.Location = new System.Drawing.Point(249, 146);
            this.btnKakeru.Name = "btnKakeru";
            this.btnKakeru.Size = new System.Drawing.Size(73, 54);
            this.btnKakeru.TabIndex = 4;
            this.btnKakeru.TabStop = false;
            this.btnKakeru.Text = "×";
            this.btnKakeru.UseVisualStyleBackColor = true;
            this.btnKakeru.Click += new System.EventHandler(this.btnKakeru_Click);
            this.btnKakeru.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnWaru
            // 
            this.btnWaru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWaru.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWaru.Location = new System.Drawing.Point(249, 206);
            this.btnWaru.Name = "btnWaru";
            this.btnWaru.Size = new System.Drawing.Size(73, 54);
            this.btnWaru.TabIndex = 4;
            this.btnWaru.TabStop = false;
            this.btnWaru.Text = "÷";
            this.btnWaru.UseVisualStyleBackColor = true;
            this.btnWaru.Click += new System.EventHandler(this.btnKakeru_Click);
            this.btnWaru.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnHiku
            // 
            this.btnHiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHiku.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHiku.Location = new System.Drawing.Point(249, 266);
            this.btnHiku.Name = "btnHiku";
            this.btnHiku.Size = new System.Drawing.Size(73, 54);
            this.btnHiku.TabIndex = 4;
            this.btnHiku.TabStop = false;
            this.btnHiku.Text = "－";
            this.btnHiku.UseVisualStyleBackColor = true;
            this.btnHiku.Click += new System.EventHandler(this.btnKakeru_Click);
            this.btnHiku.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnTasu
            // 
            this.btnTasu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTasu.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTasu.Location = new System.Drawing.Point(249, 326);
            this.btnTasu.Name = "btnTasu";
            this.btnTasu.Size = new System.Drawing.Size(73, 54);
            this.btnTasu.TabIndex = 4;
            this.btnTasu.TabStop = false;
            this.btnTasu.Text = "＋";
            this.btnTasu.UseVisualStyleBackColor = true;
            this.btnTasu.Click += new System.EventHandler(this.btnKakeru_Click);
            this.btnTasu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEqual.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEqual.Location = new System.Drawing.Point(170, 326);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(73, 54);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnKakeru_Click);
            this.btnEqual.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnEqual_PreviewKeyDown);
            // 
            // Dentaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 386);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnTasu);
            this.Controls.Add(this.btnHiku);
            this.Controls.Add(this.btnWaru);
            this.Controls.Add(this.btnKakeru);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnAllCl);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtKekka);
            this.Controls.Add(this.txtKeka);
            this.Name = "Dentaku";
            this.Text = "Dentaku";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEqual_PreviewKeyDow);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtKeka;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAllCl;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnKakeru;
        private System.Windows.Forms.Button btnWaru;
        private System.Windows.Forms.Button btnHiku;
        private System.Windows.Forms.Button btnTasu;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox txtKekka;
    }
}

