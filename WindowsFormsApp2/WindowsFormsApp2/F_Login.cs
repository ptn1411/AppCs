using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Data;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public UserDao user;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //dung dong chuong trinh
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //kiem tra co data khong
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    //kiểm tra trùng khớp tài khoản  mật khẩu không 
                    if (KiemtranDangnhap(txtUserName.Text, txtPassword.Text))
                    {
                     this.Close();   
                    }
                    else
                    {
                        MessageBox.Show("Error", "Thông Báo",
                            MessageBoxButtons.OKCancel);
                    }
                }
                
            }
            
          
        }

        private bool KiemtranDangnhap(string userName, string password)
        {
            if (user.user.Username.Equals(userName) && user.user.Password.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}