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
    public partial class AdminHome : Form
    {
    
     



        public AdminHome()
        {
            InitializeComponent();
            
           // string loginname = unn;
           // lblun.Text= loginname;
        }
        

        private void AdminHome_Load(object sender, EventArgs e)
        {
           
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegister reg = new frmRegister(); reg.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frmmain = new Main();
            frmmain.Show();
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent upstudent = new UpdateStudent();
            upstudent.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recd2 frmRecord = new Recd2();
            frmRecord.Show();
        }
    }
}
