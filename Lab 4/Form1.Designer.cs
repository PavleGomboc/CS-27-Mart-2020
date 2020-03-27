namespace Lab_4
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
            this.cmdExecuteReader = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdExecuteReader
            // 
            this.cmdExecuteReader.Location = new System.Drawing.Point(327, 10);
            this.cmdExecuteReader.Name = "cmdExecuteReader";
            this.cmdExecuteReader.Size = new System.Drawing.Size(75, 23);
            this.cmdExecuteReader.TabIndex = 0;
            this.cmdExecuteReader.Text = "button1";
            this.cmdExecuteReader.UseVisualStyleBackColor = true;
            this.cmdExecuteReader.Click += new System.EventHandler(this.cmdExecuteReader_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 303);
            this.listBox1.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(12, 12);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(309, 20);
            this.txtCategoryID.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 358);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdExecuteReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExecuteReader;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCategoryID;
    }
}

