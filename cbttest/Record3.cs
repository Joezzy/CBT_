using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using DevComponents.DotNetBar;
using Excel = Microsoft.Office.Interop.Excel;
namespace cbttest
{
    public partial class Record3 : Form
    {
       Connect c1 = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public Record3()
        {
            InitializeComponent();
            viewAll("SELECT * FROM Result2");
        }

        

        private void Record_Load(object sender, EventArgs e)
        { 
           // DataGridViewCheckBoxColumn cbc = new DataGridViewCheckBoxColumn();
            //cbc.HeaderText = "CHECKBOXES";
            //dataGridView1.Columns.Add(cbc);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 0 && txtClass.Text.Length <1)
            {
                viewAll("SELECT * FROM Result2 WHERE Surname='" + txtSurname.Text + "'  ");
            }

            else if (txtSurname.Text.Length < 1 && txtClass.Text.Length > 0)
            {
                viewAll("SELECT * FROM Result2 WHERE Class='" + txtClass.Text + "'  ");
            }

            else if (txtSurname.Text.Length > 0 && txtClass.Text.Length > 0)
            {
                viewAll("SELECT * FROM Result2 WHERE Class='" + txtClass.Text + "' and Surname='" + txtSurname.Text + "'  ");
            }
            else
            {
                MessageBox.Show("Enter parameter to search");
            }
        }

       

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAll("SELECT * FROM Result2");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook WB; Excel.Worksheet Ws; Excel.Range Rang;

            WB = XcelApp.Workbooks.Add(Type.Missing); WB.Worksheets.Add(Type.Missing, Type.Missing, 1, Excel.XlSheetType.xlWorksheet);
            // I am opening Excel
            Ws = (Excel.Worksheet)WB.Worksheets.get_Item(1);
            XcelApp.Visible = true; XcelApp.StandardFont = "Tahoma";
            //I am filling Data
            XcelApp.Cells[1, 1] = "Student Result";
            Rang = Ws.get_Range("A1", "G2"); Rang.Font.Name = "MV Boli";
            Rang.Font.Size = 22F;
            Rang.Font.Bold = true;
            Rang.MergeCells = true;
            Rang.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Rang.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            XcelApp.Cells[3, 1] = "Sno";
            XcelApp.Cells[3, 2] = "surname";
            XcelApp.Cells[3, 3] = "other names";
            XcelApp.Cells[3, 4] = "gender";
            XcelApp.Cells[3, 5] = "Class";
            XcelApp.Cells[3, 6] = "Mathematics";

            //Rang = Ws.get_Range("C3", "E3"); Rang.MergeCells = true;
            Rang = Ws.get_Range("A3", "G3"); Rang.Font.Bold = true;
            DataSet ds = new DataSet();
            ds = c1.FillDs("Select * from Result2");
            int cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i <= cnt - 1; i++)
            {
                XcelApp.Cells[4 + i, 1] = ds.Tables[0].Rows[i]["S_ID"].ToString();
                XcelApp.Cells[4 + i, 2] = ds.Tables[0].Rows[i]["Surname"].ToString();
                XcelApp.Cells[4 + i, 3] = ds.Tables[0].Rows[i]["OtherNames"].ToString();
                XcelApp.Cells[4 + i, 4] = ds.Tables[0].Rows[i]["Gender"].ToString();
                XcelApp.Cells[4 + i, 5] = ds.Tables[0].Rows[i]["Class"].ToString();
                XcelApp.Cells[4 + i, 6] = ds.Tables[0].Rows[i]["Mathematics"].ToString();
            }

            XcelApp.Columns.AutoFit();

        }



    }
}
