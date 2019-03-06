namespace cbttest
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            this.Question = new System.Windows.Forms.Label();
            this.buttonX1 = new System.Windows.Forms.Label();
            this.btnNxt = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblun = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(131, 157);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(51, 20);
            this.Question.TabIndex = 0;
            this.Question.Text = "label1";
            // 
            // buttonX1
            // 
            this.buttonX1.AutoSize = true;
            this.buttonX1.Location = new System.Drawing.Point(634, 31);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(35, 13);
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "label1";
            // 
            // btnNxt
            // 
            this.btnNxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnNxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNxt.Location = new System.Drawing.Point(924, 340);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(133, 50);
            this.btnNxt.TabIndex = 6;
            this.btnNxt.Text = "Next";
            this.btnNxt.UseVisualStyleBackColor = true;
            this.btnNxt.Click += new System.EventHandler(this.btnNxt_Click);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(129, 229);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(38, 24);
            this.A.TabIndex = 7;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(129, 264);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(38, 24);
            this.B.TabIndex = 8;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(129, 296);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(38, 24);
            this.C.TabIndex = 9;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(129, 328);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(39, 24);
            this.D.TabIndex = 10;
            this.D.TabStop = true;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question";
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(421, 16);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(128, 31);
            this.lbltimer.TabIndex = 12;
            this.lbltimer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(125, 31);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(66, 24);
            this.lblun.TabIndex = 13;
            this.lblun.Text = "label2";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub.Location = new System.Drawing.Point(111, 76);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(138, 24);
            this.lblsub.TabIndex = 14;
            this.lblsub.Text = "Subject name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Candidate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.btnNxt);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.Question);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label buttonX1;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

