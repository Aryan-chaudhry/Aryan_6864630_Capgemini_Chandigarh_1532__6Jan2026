namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtDesignation = new TextBox();
            txtDOJ = new TextBox();
            txtSalary = new TextBox();
            txtDeptNo = new TextBox();
            this.btnInsert = new Button();
            this.btnFind = new Button();
            this.btnClear = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClose = new Button();
            btnUpdateToDatabase = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter EmpId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter EmpName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 142);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter Designation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 200);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Enter DOJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 252);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "Enter Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 301);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Enter DeptNo";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(192, 39);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(125, 27);
            txtEmpId.TabIndex = 6;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(192, 90);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(125, 27);
            txtEmpName.TabIndex = 7;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(192, 142);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(125, 27);
            txtDesignation.TabIndex = 8;
            // 
            // txtDOJ
            // 
            txtDOJ.Location = new Point(192, 200);
            txtDOJ.Name = "txtDOJ";
            txtDOJ.Size = new Size(125, 27);
            txtDOJ.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(192, 252);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 10;
            // 
            // txtDeptNo
            // 
            txtDeptNo.Location = new Point(192, 301);
            txtDeptNo.Name = "txtDeptNo";
            txtDeptNo.Size = new Size(125, 27);
            txtDeptNo.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new Point(54, 354);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new Size(94, 29);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += this.btnInsert_Click;
            // 
            // btnFind
            // 
            this.btnFind.Location = new Point(192, 354);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new Size(94, 29);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += this.btnFind_Click;
            // 
            // btnClear
            // 
            this.btnClear.Location = new Point(319, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(94, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += this.btnClear_Click;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(54, 389);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(94, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += this.btnUpdate_Click;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(192, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(94, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += this.btnDelete_Click;
            // 
            // btnClose
            // 
            this.btnClose.Location = new Point(319, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(94, 29);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += this.btnClose_Click;
            // 
            // btnUpdateToDatabase
            // 
            btnUpdateToDatabase.Location = new Point(440, 389);
            btnUpdateToDatabase.Name = "btnUpdateToDatabase";
            btnUpdateToDatabase.Size = new Size(176, 29);
            btnUpdateToDatabase.TabIndex = 18;
            btnUpdateToDatabase.Text = "Update into Database";
            btnUpdateToDatabase.UseVisualStyleBackColor = true;
            btnUpdateToDatabase.Click += btnUpdateToDatabase_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdateToDatabase);
            Controls.Add(this.btnClose);
            Controls.Add(this.btnDelete);
            Controls.Add(this.btnUpdate);
            Controls.Add(this.btnClear);
            Controls.Add(this.btnFind);
            Controls.Add(this.btnInsert);
            Controls.Add(txtDeptNo);
            Controls.Add(txtSalary);
            Controls.Add(txtDOJ);
            Controls.Add(txtDesignation);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtDesignation;
        private TextBox txtDOJ;
        private TextBox txtSalary;
        private TextBox txtDeptNo;
        private Button btnInsert;
        private Button btnFind;
        private Button b;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnUpdateToDatabase;
        private DataGridView dataGridView1;
    }
}