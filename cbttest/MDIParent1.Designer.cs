namespace cbttest
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExamInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.subjectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.updateInformationToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registerStudentToolStripMenuItem.Text = "Registeration";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // updateInformationToolStripMenuItem
            // 
            this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateInformationToolStripMenuItem.Text = "Update Information";
            this.updateInformationToolStripMenuItem.Click += new System.EventHandler(this.updateInformationToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.adminRecordToolStripMenuItem,
            this.studentResultToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordToolStripMenuItem.Text = "Student Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // adminRecordToolStripMenuItem
            // 
            this.adminRecordToolStripMenuItem.Name = "adminRecordToolStripMenuItem";
            this.adminRecordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adminRecordToolStripMenuItem.Text = "Admin Record";
            this.adminRecordToolStripMenuItem.Click += new System.EventHandler(this.adminRecordToolStripMenuItem_Click);
            // 
            // studentResultToolStripMenuItem
            // 
            this.studentResultToolStripMenuItem.Name = "studentResultToolStripMenuItem";
            this.studentResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentResultToolStripMenuItem.Text = "Student Result";
            this.studentResultToolStripMenuItem.Click += new System.EventHandler(this.studentResultToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSubjectToolStripMenuItem,
            this.editExamInformationToolStripMenuItem,
            this.toolStripMenuItem2});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.subjectsToolStripMenuItem.Text = "Examination";
            // 
            // addNewSubjectToolStripMenuItem
            // 
            this.addNewSubjectToolStripMenuItem.Name = "addNewSubjectToolStripMenuItem";
            this.addNewSubjectToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addNewSubjectToolStripMenuItem.Text = "Add New Subject";
            this.addNewSubjectToolStripMenuItem.Click += new System.EventHandler(this.addNewSubjectToolStripMenuItem_Click);
            // 
            // editExamInformationToolStripMenuItem
            // 
            this.editExamInformationToolStripMenuItem.Name = "editExamInformationToolStripMenuItem";
            this.editExamInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editExamInformationToolStripMenuItem.Text = "Add & Modify Question";
            this.editExamInformationToolStripMenuItem.Click += new System.EventHandler(this.editExamInformationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Location = new System.Drawing.Point(633, 5);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(55, 13);
            this.lblun.TabIndex = 4;
            this.lblun.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Page";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminRecordToolStripMenuItem;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem studentResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExamInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;


    }
}



