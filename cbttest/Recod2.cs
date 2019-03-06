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
    public partial class Recod2 : Form
    {
        // Connect con = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public Recod2()
        {
            InitializeComponent();
            viewAll("SELECT * FROM Admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {


          

        }




        void viewAll(string qry)
        {

            con.Open();
            try
            {
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = qry;
                OleDbDataAdapter adap = new OleDbDataAdapter(cmd1);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;


            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                con.Close();

            }
        }

      

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
             if (txtSurname.Text.Length > 0)
            {
                viewAll("SELECT * FROM Admin WHERE Surname='" + txtSurname.Text + "'  ");
            }

           
            else
            {
                MessageBox.Show("Enter Admin Name to search");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              int i = 0;
            List<int> ChkedRow = new List<int>();
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Select"].Value) == true)
                {
                    ChkedRow.Add(i);
                }
            }

            if (ChkedRow.Count == 0)
            {
                MessageBox.Show("select one or more box to delete", "CBT");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "CBT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                foreach (int j in ChkedRow)
                {
                    string str = "Delete from Admin where A_ID=" + dataGridView1.Rows[j].Cells["A_ID"].Value + "";

                    try
                    {
                        OleDbCommand com = new OleDbCommand(str, con);
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Selected data deleted", "CBT");
                        con.Close();
                    
                       
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                  
                    viewAll("SELECT * FROM Admin");
                }
            }

        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
             viewAll("SELECT * FROM Admin");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
              this.Hide();
        }

        private void Recod2_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        



    
}
}