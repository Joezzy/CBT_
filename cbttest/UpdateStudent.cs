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
    
    public partial class UpdateStudent : Form
    {
       Connect c1 = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public UpdateStudent()
        {
            InitializeComponent();
        }

        void cleartxt()
        {
           
            txtClass.Text = "";
            txtGender.Text = "";
            txtSurname.Text = "";
            txtOthernames.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void listRead(string qry)
        {
           
            OleDbCommand cmd = new OleDbCommand(qry, con);
            OleDbDataReader reader;



            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                reader.Read();

                txtSurname.Text = reader["Surname"].ToString();
                txtOthernames.Text = reader["OtherNames"].ToString();
                txtGender.Text = reader["Gender"].ToString();
               
               
                txtUser.Text = reader["Username"].ToString();
                txtPass.Text = reader["Password"].ToString();
                if (rbnStudent.Checked == true)
                {
                    txtId.Text = reader["S_ID"].ToString();
                    txtClass.Text = reader["Class"].ToString();
                }

                if (rbnAdmin.Checked == true)
                {
                    txtId.Text = reader["A_ID"].ToString();
                 
                }
                
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbnAdmin.Checked == true)
            {
                cleartxt();
                listRead("SELECT * FROM Admin WHERE Surname='" + listBox1.Text.ToString() + "'");
                btnUpdate.Enabled = true;
                button1.Enabled = true;
            }
            if (rbnStudent.Checked == true)
            {
                cleartxt();
                listRead("SELECT * FROM Student WHERE Surname='" + listBox1.Text.ToString() + "'");
                btnUpdate.Enabled = true;
                button1.Enabled = true;
            }



       
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
           

        

        }

   
    public void listLoad(string str)
        {
           
            OleDbCommand cm = new OleDbCommand(str, con);
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["Surname"]);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void updateRecord(string qry)
        {
             OleDbCommand cmd;
            con.Open();
           
            
                cmd = con.CreateCommand();
                cmd.CommandText = qry;

                cmd.ExecuteNonQuery();
      
         
                con.Close();
            
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (txtSurname.Text == "" && txtOthernames.Text == "" && txtGender.Text == "" && txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Please fill all fields", "CBT"); 
            }
            else
            {

                if (rbnStudent.Checked == true)
                {
                    if (txtClass.Text == "")
                    {
                        MessageBox.Show("Please Class is required for student");
                    }
                    else
                    {
                        updateRecord("update Student SET [Surname]='" + txtSurname.Text.Trim() + "'," +
                            " [OtherNames]='" + txtOthernames.Text.Trim() + "', " +
                              "   [Gender]='" + txtGender.Text.Trim() + "'," +
                               "      [Username]='" + txtUser.Text.Trim() + "'," +
                                       "  [Password]='" + txtPass.Text.Trim() + "'," +
                                         "    [Class]='" + txtClass.Text.Trim() + "' where S_ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");

                        MessageBox.Show("Record Updated  successfully");
                        listBox1.Items.Clear(); listLoad("select Surname  from [Student]");
                        btnUpdate.Enabled = false;
                        button1.Enabled = false;
                        
                    }
                }

                if (rbnAdmin.Checked == true)
                {
                    updateRecord("update [Admin] SET [Surname]='" + txtSurname.Text.Trim() + "'," +
                        " [OtherNames]='" + txtOthernames.Text.Trim() + "', " +
                          "   [Gender]='" + txtGender.Text.Trim() + "'," +
                           "      [Username]='" + txtUser.Text.Trim() + "'," +
                                   "  [Password]='" + txtPass.Text.Trim() + "' where A_ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");
                   
                    MessageBox.Show("Record Updated  successfully");
                    listBox1.Items.Clear(); listLoad("select Surname  from [Admin]");
                    btnUpdate.Enabled = false;
                    button1.Enabled = false;
                    
                }
                cleartxt();
            }
        }

        private void rbnStudent_CheckedChanged(object sender, System.EventArgs e)
        {
            txtClass.Enabled = true;
            listBox1.Items.Clear(); cleartxt(); if (rbnStudent.Checked == true)
                listLoad("select Surname  from [Student]");
        }

        private void rbnAdmin_CheckedChanged(object sender, System.EventArgs e)
        {
            txtClass.Enabled = false;
            listBox1.Items.Clear();
            cleartxt();
            if (rbnAdmin.Checked == true)
                listLoad("select Surname  from [Admin]");
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            cleartxt();
            if (rbnAdmin.Checked == true)
            {
                listLoad("select Surname  from Admin  where Surname like'%" + txtSearch.Text + "%' order by Surname ASC");
            }

            if (rbnStudent.Checked == true)
            {
                listLoad("select Surname  from Student  where Surname like'%" + txtSearch.Text + "%' order by Surname ASC");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult result= MessageBox.Show("Are you sure you want to delete this record?", "CBT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             if (result.Equals(DialogResult.OK))
             {

                 updateRecord("Delete * from Student   where S_ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");

                 MessageBox.Show("Subject Deleted", "CBT");
                 listBox1.Items.Clear(); listLoad("select Surname  from [Student]");
                 btnUpdate.Enabled = false;
                 button1.Enabled = false;
             }
             else
             {

             }
        }

    }
}
