using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            
            f.ShowDialog();
            
        }
    }
}