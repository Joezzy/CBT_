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
    public partial class Subject : Form
    {
        Connect c1 = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public Subject(string unn)
        {
            InitializeComponent();

            string log = unn;
            lblun.Text = log;
            listLoad("select [Subject] from CBT_SUBJECT");
        }

        private void Subject_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text == "")
            {
                MessageBox.Show("Please Choose a Subject to write", "CBT");
            }
          
            else
            {
                string sql = "Select * from QUESTIONS where [SBJ]='" + txtSubject.Text.Trim() + "' ";
                OleDbDataAdapter s = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                s.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    readtym("Select * From CBT_SUBJECT where [Subject]='" + txtSubject.Text + "'");
                    groupBox1.Visible = true;
                    if (lblStatus.Text == "CLOSED")
                        btnContinue.Enabled = false;

                    if (lblStatus.Text == "OPEN")
                        btnContinue.Enabled = true;


                }
                else
                {
                    MessageBox.Show("NO Question(s) Available for  "+ txtSubject.Text);
                }
            }
        }


        public void readtym(string qry)
        {
           
            OleDbCommand cmd = new OleDbCommand(qry, con);
            OleDbDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                lblMark.Text = reader["Mark"].ToString();
                lblSubject.Text = reader["Subject"].ToString();
                lblDuration.Text = reader["Exam_Time"].ToString();
                lblStatus.Text = reader["Status"].ToString();
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
           // return men;
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
                    txtSubject.Items.Add(dr["Subject"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string col= lblSubject.Text.Trim();

            string sql = "Select * from Student where "+col+" IS NOT NULL and Username='"+lblun.Text.Trim()+"' ";
                OleDbDataAdapter s = new OleDbDataAdapter(sql, con);
                DataTable dt = new DataTable();
                s.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You have already taken this test");
                }
                else
                {
                    string unn2 = lblun.Text;
                    string sub = txtSubject.Text;
                    string tym = lblDuration.Text;
                    Quiz frm = new Quiz(unn2, sub, tym);
                    frm.Show();
                    this.Hide();
                }
        }
    }
}
