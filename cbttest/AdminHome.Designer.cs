namespace cbttest
{
    partial class AdminHome
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblun = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.examToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.updateInformationToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
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
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeToolStripMenuItem.Text = "Log Out";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewResultToolStripMenuItem
            // 
            this.viewResultToolStripMenuItem.Name = "viewResultToolStripMenuItem";
            this.viewResultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewResultToolStripMenuItem.Text = "View Result";
            this.viewResultToolStripMenuItem.Click += new System.EventHandler(this.viewResultToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTestToolStripMenuItem,
            this.updateTestToolStripMenuItem1});
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.examToolStripMenuItem.Text = "Test";
            // 
            // updateTestToolStripMenuItem
            // 
            this.updateTestToolStripMenuItem.Name = "updateTestToolStripMenuItem";
            this.updateTestToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.updateTestToolStripMenuItem.Text = "Enter New Test";
            // 
            // updateTestToolStripMenuItem1
            // 
            this.updateTestToolStripMenuItem1.Name = "updateTestToolStripMenuItem1";
            this.updateTestToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.updateTestToolStripMenuItem1.Text = "Update Test";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(12, 24);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(76, 25);
            this.lblun.TabIndex = 1;
            this.lblun.Text = "label1";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 752);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminHome";
            this.Text = "Administrator Page";
            this.Load += new System.EventHandler(this.AdminHome_Load);
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
        private System.Windows.Forms.ToolStripMenuItem viewResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTestToolStripMenuItem1;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}