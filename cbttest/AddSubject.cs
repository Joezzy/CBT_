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
    public partial class AddSubject : Form
    {
        Connect connect = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public AddSubject()
        {
            InitializeComponent();
            listLoad("select Subject  from CBT_SUBJECT");
            
        }

    
        private void AddSubject_Load(object sender, EventArgs e)
        {
            
        }

    


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listRead("SELECT * FROM CBT_SUBJECT WHERE Subject='" + listBox1.Text.ToString() + "'");
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            txtStatus.Enabled = true;
            button5.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                updateRecord("update CBT_SUBJECT SET [Subject]='" + txtSubject2.Text.Trim() + "'," +
                              " [Exam_Time]='" + txtSubtime.Text.Trim() + "', " +
                                "   [Mark]='" + txtSubmark.Text.Trim() + "'," +
                                           "    [Status]='" + txtStatus.Text.Trim() + "' where ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");
                MessageBox.Show("Record Updated  successfully");
                listBox1.Items.Clear(); listLoad("select Subject  from [CBT_SUBJECT]"); cleartxt();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = false;
                txtStatus.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        void cleartxt()
        {
            txtSubject2.Text = "";
            txtSubmark.Text = "";
            txtSubtime.Text = "";
            txtStatus.Text = "";
        }

         void listLoad(string str)
        {

            OleDbCommand cm = new OleDbCommand(str, con);
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["Subject"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                 txtId.Text = reader["ID"].ToString();
                 txtSubject2.Text = reader["Subject"].ToString();
                 txtSubtime.Text = reader["Exam_Time"].ToString();
                 txtSubmark.Text = reader["Mark"].ToString();
                 txtStatus.Text = reader["Status"].ToString();


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


         public void updateRecord(string qry)
         {
             OleDbCommand cmd;
             con.Open();


             cmd = con.CreateCommand();
             cmd.CommandText = qry;

             cmd.ExecuteNonQuery();
            // MessageBox.Show("Record Updated  successfully");
             
             con.Close();

         }

         private void button4_Click(object sender, EventArgs e)
         {
             button3.Enabled = true;
             button4.Enabled = false;
             button2.Enabled = false;
             txtStatus.Text = "CLOSED";
             txtStatus.Enabled = false;
         }

         private void button3_Click(object sender, EventArgs e)
         {

             if (txtSubject2.Text == "" || txtSubmark.Text=="" || txtSubtime.Text=="")
             {
                 MessageBox.Show("Please fill the box with a subject name", "CBT");
             }
             else
             {
                 string varsubject=txtSubject2.Text;
                 connect.InsDelup("insert into [CBT_SUBJECT] (Subject,Mark,Exam_Time,Status) Values ( '" + txtSubject2.Text.Trim() + "','"+txtSubmark.Text.Trim()+"', '"+txtSubtime.Text.Trim()+"','"+txtStatus.Text.Trim()+"') ");
                 connect.InsDelup("ALTER TABLE Student ADD ["+varsubject+"] VARCHAR(100)");

                 MessageBox.Show("Subject Added Sucessfully ...");
                 listBox1.Items.Clear();
                 cleartxt();
                 listLoad("select Subject  from CBT_SUBJECT");
                 button3.Enabled = false;
                 button4.Enabled = true;
                 
             }

         }

         private void txtSubject2_Leave(object sender, EventArgs e)
         {
             string sql = "Select * from CBT_SUBJECT where Subject='"+txtSubject2.Text.Trim()+"' ";
             OleDbDataAdapter s = new OleDbDataAdapter(sql, con);
             DataTable dt = new DataTable ();
             s.Fill(dt);
             if (dt.Rows.Count > 0)
             {

                     MessageBox.Show("Subject Already Existed");
                       txtSubject2.Text="";
                       txtSubject2.Focus(); 

             }


         }

         private void button5_Click(object sender, EventArgs e)
         {
             DialogResult result= MessageBox.Show("Are you sure you want to delete this record?", "CBT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             if (result.Equals(DialogResult.OK))
             {
                 string varsubject = txtSubject2.Text;
                 updateRecord("Delete * from CBT_SUBJECT   where ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");
                 connect.InsDelup("ALTER TABLE Student DROP COLUMN [" +varsubject + "] ");
                 MessageBox.Show("Subject Deleted", "CBT");
                 listBox1.Items.Clear();
                 cleartxt();
                 listLoad("select Subject  from CBT_SUBJECT");

                 button5.Enabled = false;
                 button2.Enabled = false;
                 button4.Enabled = true;
             }
             else
             {


             }
         }

         private void txtSubmark_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
           
         }

    
        

        

       

        

    
    
    
    
    
    
    
    
    
    }
}
