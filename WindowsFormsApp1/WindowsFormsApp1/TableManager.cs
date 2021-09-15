using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

  
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            
            f.ShowDialog();
        }
    }
}