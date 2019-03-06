using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cbttest
{
    public partial class frmRegister : Form
    {
        Connect c1 = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public frmRegister()
        {
            InitializeComponent();
        }


      void cleartxt()
        {
            txtPerson.Text = "";
            txtClass.Text = "";
            txtGender.Text = "";
            txtSurname.Text = "";
            txtOthernames.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";

        }
        private void txtPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPerson.Text == "Administrator")
            {
                txtClass.Enabled = false;
            }
            else
            {
                txtClass.Enabled = true;
            }
        }

       // int ID = 0;


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text == "" && txtOthernames.Text == "" && txtGender.Text =="" && txtUser.Text == "" && txtPass.Text=="")
            {
                MessageBox.Show("Please fill all fields", "CBT");
            }
            else
            {
                try
                {
                    if (txtPerson.Text == "Administrator")
                    {
                        c1.InsDelup("insert into [Admin] ([Surname], OtherNames, [Gender], [Username], [Password]) Values ( '" + txtSurname.Text.Trim() + "','" + txtOthernames.Text.Trim() + "','" + txtGender.Text.Trim() + "','" + txtUser.Text.Trim() + "','" + txtPass.Text.Trim() + "') ");
                        MessageBox.Show("Data Saved.......");
                        cleartxt();
                        btnRegister.Enabled = false;
                        button1.Enabled = true;

                    }
                    else if (txtPerson.Text == "Student")
                    {

                        if (txtClass.Text == "")
                        {
                            MessageBox.Show("Please Class is required for student");
                        }
                        else
                        {
                            c1.InsDelup("insert into Student ([Surname], OtherNames, [Gender], [Username], [Password],[Class]) Values ( '" + txtSurname.Text.Trim() + "','" + txtOthernames.Text.Trim() + "','" + txtGender.Text.Trim() + "','" + txtUser.Text.Trim() + "','" + txtPass.Text.Trim() + "','" + txtClass.Text.Trim() + "') ");
                            MessageBox.Show("Data Saved.......");
                            cleartxt();
                            btnRegister.Enabled = false;
                            button1.Enabled = true;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please specify personnel \r\n (either Administrator or Student)", "CBT");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



         

          }

            

            private void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
                cleartxt();
            }

            private void closeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Hide();
            }

            private void frmRegister_Load(object sender, EventArgs e)
            {

            }
            int count;
            private void button1_Click(object sender, EventArgs e)
            {
                //string str = "select count (*) from Student";
                //OleDbCommand com = new OleDbCommand(str, con);
                //con.Open();
                //count = Convert.ToInt32(com.ExecuteScalar()) + 1;
                //txtId.Text = "CBT/"+count.ToString();
                //con.Close();
                button1.Enabled = false;
                btnRegister.Enabled = true;
            }

        
    }

}
