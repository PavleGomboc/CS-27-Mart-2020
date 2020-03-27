namespace SQLCommand
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnExecuteNonScalar = new System.Windows.Forms.Button();
            this.btnNonScalarStoredProcedure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerID.Location = new System.Drawing.Point(101, 9);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerID.Size = new System.Drawing.Size(134, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(16, 38);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(219, 23);
            this.btnExecuteScalar.TabIndex = 2;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            this.btnExecuteScalar.Click += new System.EventHandler(this.btnExecuteScalar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Execute Scalar Stored Procedure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCompanyName.Location = new System.Drawing.Point(101, 106);
            this.txtCompanyName.MaxLength = 40;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.Size = new System.Drawing.Size(134, 20);
            this.txtCompanyName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.Location = new System.Drawing.Point(101, 132);
            this.txtPhone.MaxLength = 24;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(134, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // btnExecuteNonScalar
            // 
            this.btnExecuteNonScalar.Location = new System.Drawing.Point(16, 168);
            this.btnExecuteNonScalar.Name = "btnExecuteNonScalar";
            this.btnExecuteNonScalar.Size = new System.Drawing.Size(219, 23);
            this.btnExecuteNonScalar.TabIndex = 8;
            this.btnExecuteNonScalar.Text = "Execute Non Scalar";
            this.btnExecuteNonScalar.UseVisualStyleBackColor = true;
            this.btnExecuteNonScalar.Click += new System.EventHandler(this.btnExecuteNonScalar_Click);
            // 
            // btnNonScalarStoredProcedure
            // 
            this.btnNonScalarStoredProcedure.Location = new System.Drawing.Point(16, 197);
            this.btnNonScalarStoredProcedure.Name = "btnNonScalarStoredProcedure";
            this.btnNonScalarStoredProcedure.Size = new System.Drawing.Size(219, 23);
            this.btnNonScalarStoredProcedure.TabIndex = 9;
            this.btnNonScalarStoredProcedure.Text = "Execute Non Scalar Stored Procedure";
            this.btnNonScalarStoredProcedure.UseVisualStyleBackColor = true;
            this.btnNonScalarStoredProcedure.Click += new System.EventHandler(this.btnNonScalarStoredProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 231);
            this.Controls.Add(this.btnNonScalarStoredProcedure);
            this.Controls.Add(this.btnExecuteNonScalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecuteScalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnExecuteNonScalar;
        private System.Windows.Forms.Button btnNonScalarStoredProcedure;
    }
}

