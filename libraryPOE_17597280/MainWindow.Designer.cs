namespace libraryPOE_17597280
{
    partial class MainWindow
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
            System.Windows.Forms.Button btnOrderCallNum;
            this.btnIA = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            btnOrderCallNum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIA
            // 
            this.btnIA.BackColor = System.Drawing.Color.Chocolate;
            this.btnIA.Location = new System.Drawing.Point(82, 113);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(157, 40);
            this.btnIA.TabIndex = 0;
            this.btnIA.Text = "Identify Areas";
            this.btnIA.UseVisualStyleBackColor = false;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.Chocolate;
            this.btnTree.Location = new System.Drawing.Point(82, 159);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(157, 40);
            this.btnTree.TabIndex = 1;
            this.btnTree.Text = "Find Book Location";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnOrderCallNum
            // 
            btnOrderCallNum.BackColor = System.Drawing.Color.Chocolate;
            btnOrderCallNum.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOrderCallNum.Location = new System.Drawing.Point(82, 67);
            btnOrderCallNum.Name = "btnOrderCallNum";
            btnOrderCallNum.Size = new System.Drawing.Size(157, 40);
            btnOrderCallNum.TabIndex = 2;
            btnOrderCallNum.Text = "Order Books";
            btnOrderCallNum.UseVisualStyleBackColor = false;
            btnOrderCallNum.Click += new System.EventHandler(this.btnOrderCallNum_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::libraryPOE_17597280.Properties.Resources.Screenshot_2020_11_03_at_10_47_13;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(btnOrderCallNum);
            this.panel1.Controls.Add(this.btnIA);
            this.panel1.Controls.Add(this.btnTree);
            this.panel1.Location = new System.Drawing.Point(238, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 291);
            this.panel1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryPOE_17597280.Properties.Resources.LibraryBackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIA;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Panel panel1;
    }
}