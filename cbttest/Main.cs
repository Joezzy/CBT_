using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cbttest
{
    public partial class Main : Form
    {
        Login loginfrm = new Login();
        AdminLog adlog = new AdminLog();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           // loginfrm.SetDesktopLocation(this.Location.X + this.Width + 1, this.Location.Y);
            loginfrm.StartPosition = FormStartPosition.CenterScreen;

            loginfrm.ShowDialog();
            
        }

        private void administratorLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adlog.ShowDialog();
        }

        private void studentLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginfrm.ShowDialog();
        }

      
    }
}
