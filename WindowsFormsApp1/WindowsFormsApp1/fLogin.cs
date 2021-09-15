using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  UserDao user;

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    //kiem tra xem txt vua nhap co trung voi username va pass hay khong--> if...else...

                    if (KiemTraDangNhap(textBox1.Text, textBox2.Text))
                    {
                        TableManager f = new TableManager();
                        //Kiem tra bien nho
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo");
                    }
                }
            }
        }


        private bool KiemTraDangNhap(string userName, string passWord)
        {
            // if (user.user.Username==userName && user.user.Password==passWord)
            // {
            //     return true;
            // }
            // return false;
            if ("admin" == userName && "admin" == passWord)
            {
                return true;
            }
            return false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông Báo", MessageBoxButtons.OKCancel) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}