namespace Activity6_2
{
    partial class EmployeeInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.btnExistingEmp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSI = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateHR = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(397, 52);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(260, 38);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(787, 45);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1051, 45);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(208, 191);
            this.btnNewEmp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(301, 55);
            this.btnNewEmp.TabIndex = 4;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnExistingEmp
            // 
            this.btnExistingEmp.Location = new System.Drawing.Point(624, 191);
            this.btnExistingEmp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExistingEmp.Name = "btnExistingEmp";
            this.btnExistingEmp.Size = new System.Drawing.Size(333, 55);
            this.btnExistingEmp.TabIndex = 5;
            this.btnExistingEmp.Text = "Existing Employee";
            this.btnExistingEmp.UseVisualStyleBackColor = true;
            this.btnExistingEmp.Click += new System.EventHandler(this.btnExistingEmp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateSI);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLoginName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(152, 284);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1099, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Info";
            // 
            // btnUpdateSI
            // 
            this.btnUpdateSI.Location = new System.Drawing.Point(821, 48);
            this.btnUpdateSI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdateSI.Name = "btnUpdateSI";
            this.btnUpdateSI.Size = new System.Drawing.Size(200, 55);
            this.btnUpdateSI.TabIndex = 4;
            this.btnUpdateSI.Text = "Update";
            this.btnUpdateSI.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(245, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(423, 38);
            this.txtPassword.TabIndex = 3;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(245, 48);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(423, 38);
            this.txtLoginName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "LoginName:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateHR);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.txtSSN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(152, 501);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1099, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HR Info";
            // 
            // btnUpdateHR
            // 
            this.btnUpdateHR.Location = new System.Drawing.Point(821, 38);
            this.btnUpdateHR.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdateHR.Name = "btnUpdateHR";
            this.btnUpdateHR.Size = new System.Drawing.Size(200, 55);
            this.btnUpdateHR.TabIndex = 4;
            this.btnUpdateHR.Text = "Update";
            this.btnUpdateHR.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(245, 129);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(423, 38);
            this.txtDepartment.TabIndex = 3;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(245, 48);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(423, 38);
            this.txtSSN.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "SSN:";
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 765);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExistingEmp);
            this.Controls.Add(this.btnNewEmp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EmployeeInfoForm";
            this.Text = "Employee Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.Button btnExistingEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateSI;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateHR;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

