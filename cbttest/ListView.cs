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
    public partial class ListView : Form
    {
        // Connect con = new Connect();
        public static string ThePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ThePath + "\\RESULT_DB.accdb;Jet OLEDB:Database Password=;");

        public ListView()
        {
            InitializeComponent();
            list_header();
            loadList("Select * from Student");
        }


        void list_header()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Surname", 150);
            listView1.Columns.Add("Other Names", 150);
            listView1.Columns.Add("Gender", 150);
            listView1.Columns.Add("Class", 150);
            listView1.Columns.Add("Username", 150);
            listView1.Columns.Add("Password", 150);
        }


        private void loadList(string qry)
        {
           // string sql = "Select * from Student";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(qry, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetInt32(0).ToString());
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));
                lv.SubItems.Add(reader.GetString(6));

                listView1.Items.Add(lv);


            }
            reader.Close();
            con.Close();

        }
        private void ListView_Load(object sender, EventArgs e)
        {
            


           
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 0 && txtClass.Text.Length < 1)
            {
                loadList("SELECT * FROM Student WHERE Surname='" + txtSurname.Text + "'  ");
            }

            else if (txtSurname.Text.Length < 1 && txtClass.Text.Length > 0)
            {
                loadList("SELECT * FROM Student WHERE Class='" + txtClass.Text + "'  ");
            }

            else if (txtSurname.Text.Length > 0 && txtClass.Text.Length > 0)
            {
                loadList("SELECT * FROM Student WHERE Class='" + txtClass.Text + "' and Surname='" + txtSurname.Text + "'  ");
            }
            else
            {
                MessageBox.Show("Enter parameter to search");
            }
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadList("Select * from Student");
        }



    }
}
