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
    public partial class enterTest : Form
    {
        Connect c1 = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

      
        public enterTest()
        {
            InitializeComponent();
            //viewAll("Select * from Questions");
            listLoad("select Subject from CBT_SUBJECT");
        }

        private void enterTest_Load(object sender, EventArgs e)
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
                    txtSubject.Items.Add(dr["Subject"]);
                    txtSubject2.Items.Add(dr["Subject"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text=="" || txtQuestion.Text == "" || txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || txtAns.Text == "")
            {
                MessageBox.Show("Please fill all textboxes", "CBT");
            }
            else{
                c1.InsDelup("insert into [QUESTIONS] ([QUESTION] , [OP1], [OP2], [OP3],[OP4],[ANS], SBJ) Values ('" + txtQuestion.Text.Trim() + "','" + txtA.Text.Trim() + "','" + txtB.Text.Trim() + "','" + txtC.Text.Trim() + "','" + txtD.Text.Trim() + "','" + txtAns.Text.Trim() + "','" + txtSubject.Text.Trim() + "') ");
MessageBox.Show("Questions Inserted .......");
           cleartxt();
           button1.Enabled = false;
         //  viewAll("Select * from Questions");
           viewAll("Select * from Questions where [SBJ] ='" + txtSubject2.Text + "'");
            }
        }

        void cleartxt()
        {
            txtId.Text = "";
            txtQuestion.Text = ""; 
            txtA.Text = ""; 
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtAns.Text = "";

        }

        int i;
       
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
      //  int count;
        private void button2_Click(object sender, EventArgs e)
        {
         
            //string   str="select count (*) from Questions";
            //OleDbCommand com = new OleDbCommand(str, con);
            //con.Open();
            //count = Convert.ToInt32(com.ExecuteScalar()) + 1;
            //txtId.Text = count.ToString(); 
            //con.Close();
            button1.Enabled = true;
            button3.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                btnDelete.Enabled = true;
                i = dataGridView1.SelectedCells[0].RowIndex;
                txtId.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

                txtQuestion.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtA.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtC.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtD.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtAns.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message,"CBT");
            }
        }


        public void updateRecord(string qry)
        {
            OleDbCommand cmd;
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandText = qry;

            cmd.ExecuteNonQuery();
          //  MessageBox.Show("Record Updated  successfully");

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text=="" || txtQuestion.Text == "" || txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || txtAns.Text == "")
            {
                MessageBox.Show("Please fill all textboxes", "CBT");
            }
            else
            {

                updateRecord("update [Questions] SET [Question]='" + txtQuestion.Text.Trim() + "'," +
                            " [OP1]='" + txtA.Text.Trim() + "', " +
                              "   [OP2]='" + txtB.Text.Trim() + "'," +
                               "      [OP3]='" + txtC.Text.Trim() + "'," +
                                "      [OP4]='" + txtD.Text.Trim() + "'," +
                                "      [SBJ]='" + txtSubject.Text.Trim() + "'," +
                                       "  [ANS]='" + txtAns.Text.Trim() + "' where Q_ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");
                MessageBox.Show("Update Successful", "CBT");

                button3.Enabled = false;
                button2.Enabled = true;
                cleartxt();
                //viewAll("Select * from Questions");
                viewAll("Select * from Questions where [SBJ] ='" + txtSubject2.Text + "'");
            }
        }

        private void txtSbj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure you want to delete this record?", "CBT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result.Equals(DialogResult.OK))
            {

            updateRecord("Delete * from Questions   where Q_ID= " + Convert.ToInt32(txtId.Text.Trim()) + "");
            MessageBox.Show("Deleted", "CBT");
         //   viewAll("Select * from Questions");
            viewAll("Select * from Questions where [SBJ] ='" + txtSubject2.Text + "'");
            button3.Enabled = false;
            button2.Enabled = true;
            btnDelete.Enabled = false;
            }
            else
            {
                button3.Enabled = false;
            button2.Enabled = true;
            btnDelete.Enabled = false;
            }

        }

        private void txtSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewAll("Select * from Questions where [SBJ] ='" + txtSubject2.Text + "'");
        }

        

     

       
      
    }
}
