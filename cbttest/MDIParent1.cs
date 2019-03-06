using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cbttest
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1(string unn)
        {
            InitializeComponent();
          string loginname = unn;
          lblun.Text= loginname;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     
      
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

       

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            //rec.Show();
            reg.MdiParent = this; 
            reg.Show();
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent UpdateStudent2 = new UpdateStudent();
            //rec.Show();
            UpdateStudent2.MdiParent = this; UpdateStudent2.Show();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {
            //MDIParent1.ScrollStateAutoScrolling. = false;

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
       
            Recd2 rec = new Recd2();
            //rec.Show();
            rec.MdiParent = this; rec.Show();
        
        }

      

        private void adminRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recod2 rec2 = new Recod2();
            rec2.MdiParent = this;
            rec2.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Record3 rec2 = new Record3();
            rec2.MdiParent = this;
            rec2.Show();
        }

        private void addNewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject subadd = new AddSubject();
            subadd.MdiParent = this;
            subadd.Show();

        }

        private void editExamInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enterTest frmQues = new enterTest();
            frmQues.MdiParent = this;
            frmQues.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
