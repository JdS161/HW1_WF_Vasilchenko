namespace HW1_WF_Vasilchenko
{
    partial class HW1_WF
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
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2_1 = new System.Windows.Forms.Button();
            this.buttonTask2_2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTask2_2);
            this.panel1.Controls.Add(this.buttonTask2_1);
            this.panel1.Controls.Add(this.buttonTask1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 315);
            this.panel1.TabIndex = 0;
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(110, 62);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(220, 49);
            this.buttonTask1.TabIndex = 0;
            this.buttonTask1.Text = "Maze";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // buttonTask2_1
            // 
            this.buttonTask2_1.Location = new System.Drawing.Point(110, 133);
            this.buttonTask2_1.Name = "buttonTask2_1";
            this.buttonTask2_1.Size = new System.Drawing.Size(220, 49);
            this.buttonTask2_1.TabIndex = 3;
            this.buttonTask2_1.Text = "MessageBox_part1";
            this.buttonTask2_1.UseVisualStyleBackColor = true;
            this.buttonTask2_1.Click += new System.EventHandler(this.buttonTask2_1_Click);
            // 
            // buttonTask2_2
            // 
            this.buttonTask2_2.Location = new System.Drawing.Point(110, 201);
            this.buttonTask2_2.Name = "buttonTask2_2";
            this.buttonTask2_2.Size = new System.Drawing.Size(220, 49);
            this.buttonTask2_2.TabIndex = 4;
            this.buttonTask2_2.Text = "MessageBox_part2";
            this.buttonTask2_2.UseVisualStyleBackColor = true;
            this.buttonTask2_2.Click += new System.EventHandler(this.buttonTask2_2_Click);
            // 
            // WinForms_HW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 315);
            this.Controls.Add(this.panel1);
            this.Name = "WinForms_HW1";
            this.Text = "WinForms_HW1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Button buttonTask2_2;
        private System.Windows.Forms.Button buttonTask2_1;
    }
}

