namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExitlogin = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 333);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExitlogin);
            this.panel4.Controls.Add(this.btnDangnhap);
            this.panel4.Location = new System.Drawing.Point(3, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 107);
            this.panel4.TabIndex = 2;
            // 
            // btnExitlogin
            // 
            this.btnExitlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitlogin.Location = new System.Drawing.Point(458, 17);
            this.btnExitlogin.Name = "btnExitlogin";
            this.btnExitlogin.Size = new System.Drawing.Size(173, 46);
            this.btnExitlogin.TabIndex = 3;
            this.btnExitlogin.Text = "Thoát";
            this.btnExitlogin.UseVisualStyleBackColor = true;
            this.btnExitlogin.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(265, 17);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(173, 46);
            this.btnDangnhap.TabIndex = 2;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 101);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 101);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitlogin;
            this.ClientSize = new System.Drawing.Size(673, 357);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDangnhap;

        private System.Windows.Forms.Button btnExitlogin;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button buttonT;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}