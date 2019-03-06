using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace cbttest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Connect c1=new Connect();
        
        public string un = "";
        public string pass = "";

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="")
           {
               MessageBox.Show("Username not inserted");
           }
           else if (textBox2.Text == "")
           {
               MessageBox.Show("Password not inserted");
           }
           else{

               un = c1.Fillstring("Select [Username] from Student Where Username = '" + textBox1.Text.ToString().Trim() + "' ");
            pass = c1.Fillstring("Select [Password] from Student Where Password = '" + textBox2.Text.ToString().Trim() + "' ");
            //sid = Convert.ToInt32(c1.Fillstring("Select S_ID from Student Where name = '" + comboBox1.Text.ToString().Trim() + "' "));



            if (textBox2.Text.Trim().Equals(pass.Trim()) && textBox1.Text.Trim().Equals(un.Trim()))
            {
                string unn = textBox1.Text.Trim();
                this.Hide();
               // ControlID.get_sid = sid;
                Subject frm = new Subject(unn);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.. \r\n Please try again..");
                textBox1.Text = "";
            }
           }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
