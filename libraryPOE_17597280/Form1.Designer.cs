namespace libraryPOE_17597280
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnSelectArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblXpnum = new System.Windows.Forms.Label();
            this.progressbarforXpTv = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(19, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(684, 262);
            this.treeView1.TabIndex = 0;
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.BackColor = System.Drawing.Color.Chocolate;
            this.btnSelectArea.Location = new System.Drawing.Point(483, 351);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(204, 31);
            this.btnSelectArea.TabIndex = 1;
            this.btnSelectArea.Text = "Done Selecting ";
            this.btnSelectArea.UseVisualStyleBackColor = false;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please find where the following Call number or category fits in:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.Location = new System.Drawing.Point(16, 38);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 17);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Question";
            // 
            // lblXpnum
            // 
            this.lblXpnum.AutoSize = true;
            this.lblXpnum.BackColor = System.Drawing.Color.Transparent;
            this.lblXpnum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblXpnum.Location = new System.Drawing.Point(486, 38);
            this.lblXpnum.Name = "lblXpnum";
            this.lblXpnum.Size = new System.Drawing.Size(217, 17);
            this.lblXpnum.TabIndex = 44;
            this.lblXpnum.Text = "Points: Score of Max Level: Level";
            // 
            // progressbarforXpTv
            // 
            this.progressbarforXpTv.Location = new System.Drawing.Point(486, 12);
            this.progressbarforXpTv.Name = "progressbarforXpTv";
            this.progressbarforXpTv.Size = new System.Drawing.Size(217, 17);
            this.progressbarforXpTv.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::libraryPOE_17597280.Properties.Resources.Screenshot_2020_11_03_at_10_47_13;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.lblXpnum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelectArea);
            this.panel1.Controls.Add(this.progressbarforXpTv);
            this.panel1.Location = new System.Drawing.Point(29, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 397);
            this.panel1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryPOE_17597280.Properties.Resources.LibraryBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnSelectArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblXpnum;
        private System.Windows.Forms.ProgressBar progressbarforXpTv;
        private System.Windows.Forms.Panel panel1;
    }
}

