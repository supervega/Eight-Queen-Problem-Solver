namespace EightQueen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Solvebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(93, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 390);
            this.panel1.TabIndex = 0;
            // 
            // Solvebtn
            // 
            this.Solvebtn.Location = new System.Drawing.Point(12, 12);
            this.Solvebtn.Name = "Solvebtn";
            this.Solvebtn.Size = new System.Drawing.Size(75, 23);
            this.Solvebtn.TabIndex = 1;
            this.Solvebtn.Text = "Solve";
            this.Solvebtn.UseVisualStyleBackColor = true;
            this.Solvebtn.Click += new System.EventHandler(this.Solvebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 411);
            this.Controls.Add(this.Solvebtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Eight Queen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Solvebtn;
    }
}

