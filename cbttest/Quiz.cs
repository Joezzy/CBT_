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
    public partial class Quiz : Form
    {
        public Quiz(string unn2,string sub, string tym)
        {
            InitializeComponent();
            string loginname = unn2;
            lblun.Text = loginname;
            lblsub.Text = sub;
           lbltimer.Text = tym;
        }
       
        Connect c1 = new Connect();

        int ID = 0;
        int max_quetion = 0;
        int c_marks = 0;
        int w_marks = 0;
        string tot_time ;
       int sid;

     //   string sname = "";
        private void get_rule()
        {
            max_quetion = Convert.ToInt32(c1.Fillstring("Select Count(*) From QUESTIONS where SBJ='" + lblsub.Text + "'"));
            c_marks = Convert.ToInt32(c1.Fillstring("Select mark From CBT_SUBJECT where Subject='"+ lblsub.Text+"' "));
           // w_marks = Convert.ToInt32(c1.Fillstring("Select mark From CBT_SUBJECT where Subject='"+ lblsub.Text+"' "));
           
        }

        System.DateTime m_stoptime = default(System.DateTime);
        void stopage(string tyme)
        {
            TimeSpan duration = TimeSpan.Parse(tyme);
            m_stoptime = DateTime.Now.Add(duration);
            timer1.Enabled = true;
        }

        /// <summary>
        /// ///////////////////////////////////
        /// </summary>

        Random r = new Random();
        int cnt = 1;
        int marks = 0;
        string Ans1 = "";
        string check_id = "";

        private void get_id()
        {
            int max, min;

            max = Convert.ToInt32(c1.Fillstring("Select max(Q_ID) From QUESTIONS where SBJ='"+lblsub.Text+"' "));
            min = Convert.ToInt32(c1.Fillstring("Select min(Q_ID) From QUESTIONS where SBJ='" + lblsub.Text + "'"));

            if (cnt == 1)
            {

                ID = r.Next(min, max);
            }
            else
            {
                ID++;
                if (ID >= max)
                {
                    ID = min;
                }
                while (check_id == "")
                {
                    check_id = c1.Fillstring("Select QUESTION from QUESTIONS Where Q_ID = " + ID + " ").Trim();
                    if (check_id == "")
                        ID++;
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        public void SELCECT_QUE()
        {
           // string tbl = nameTable;
            get_id();
            buttonX1.Text = "Q: " + cnt + " / " + max_quetion;
            Question.Text = c1.Fillstring("Select QUESTION from QUESTIONS Where Q_ID = " + ID + " ");
            A.Text = "     A :     " + c1.Fillstring("Select OP1 From QUESTIONS Where Q_ID = " + ID + " ");
            B.Text = "     B :     " + c1.Fillstring("Select OP2 From QUESTIONS Where Q_ID = " + ID + " ");
            C.Text = "     C :     " + c1.Fillstring("Select OP3 From QUESTIONS Where Q_ID = " + ID + " ");
            D.Text = "     D :     " + c1.Fillstring("Select OP4 From QUESTIONS Where Q_ID = " + ID + " ");
        }
/// <summary>
/// //
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        public void Answer()
        {
            string Ans = c1.Fillstring("Select ANS from QUESTIONS Where Q_ID = " + ID + " ");
            if (Ans == Ans1)
            {
                marks += c_marks;
               // Question.Text = "";
                A.Checked = false;
                B.Checked = false;
                C.Checked = false;
                D.Checked = false;

            }
            else
            {
                //marks = marks;
               // Question.Text = "";
                A.Checked = false;
                B.Checked = false;
                C.Checked = false;
                D.Checked = false;
            }

            if (cnt == max_quetion)
            {
                Question.Visible = false;
                A.Visible = false;
                B.Visible = false;
                C.Visible = false;
                D.Visible = false;
                
                save_result(lblsub.Text);
               // timer1.Stop(); buttonX3.Text = "Timer";
                //buttonX3.Enabled = false;
              //  groupPanel4.Enabled = false;
                MessageBox.Show("Completed !! thank you for Taking Test.. you scored  "+ marks);
                Application.Exit();
               
            }
            else
            {
                string subject = lblsub.Text;
                cnt++;
                SELCECT_QUE();
            }
        }



/// </summary>
/// <param name="sender"></param>

/// 
        int r_id = 1;
        private void save_result(string subj)
        {

            string naz = "naz";
                c1.InsDelup("update student set  "+subj+"=" + marks + ", EXAM_DATE='" + DateTime.Today.ToString("dd-MM-yyyy") + "'  Where Username ='"+lblun.Text+"' ");
            
        }

       /// <summary>
       /// /
       /// </summary>
 
        private void Form1_Load(object sender, EventArgs e)
        {
            string subject = lblsub.Text;
            get_rule();
            stopage(lbltimer.Text);
           
            SELCECT_QUE();
        }

     
     
        private void btnNxt_Click(object sender, EventArgs e)
        {
            if (A.Checked)
            {
                Ans1 = A.Text.Remove(0, 13); Answer();
            }
            else if (B.Checked)
            {
                Ans1 = B.Text.Remove(0, 13); Answer();
            }

            else if (C.Checked)
            {
                Ans1 = C.Text.Remove(0, 13); Answer();
            }

            else if (D.Checked)
            {
                Ans1 = D.Text.Remove(0, 13); Answer();
            }
            else
            {
                Answer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             TimeSpan remaining = m_stoptime.Subtract(DateTime.Now);
            remaining = new TimeSpan(remaining.Hours, remaining.Minutes, remaining.Seconds);
            if (remaining.TotalSeconds < 0)
                remaining = TimeSpan.Zero;

            lbltimer.Text = remaining.ToString();

            if (remaining.TotalSeconds <= 0)
            {
                timer1.Enabled = false;
                save_result(lblsub.Text);
                MessageBox.Show("Your time elapsed !! thank you for Taking Test.. you scored  " + marks);
                Application.Exit();
               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
