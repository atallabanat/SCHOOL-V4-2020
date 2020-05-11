namespace SCHOOL_DEV.UserControls
{
    partial class quary_salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAmountSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNameEmp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountMonthlyGuarantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountOnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountMonthly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartDateOnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textSalary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textJobName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textAmountSalary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboNameEmp);
            this.groupBox1.Location = new System.Drawing.Point(3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1117, 118);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الراتب";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(433, 78);
            this.textSalary.Name = "textSalary";
            this.textSalary.ReadOnly = true;
            this.textSalary.Size = new System.Drawing.Size(144, 20);
            this.textSalary.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "الراتب الإساسي :";
            // 
            // textJobName
            // 
            this.textJobName.Enabled = false;
            this.textJobName.Location = new System.Drawing.Point(846, 78);
            this.textJobName.Name = "textJobName";
            this.textJobName.ReadOnly = true;
            this.textJobName.Size = new System.Drawing.Size(170, 20);
            this.textJobName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1022, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "الوظيفة :";
            // 
            // textAmountSalary
            // 
            this.textAmountSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textAmountSalary.Location = new System.Drawing.Point(63, 78);
            this.textAmountSalary.Name = "textAmountSalary";
            this.textAmountSalary.ReadOnly = true;
            this.textAmountSalary.Size = new System.Drawing.Size(144, 20);
            this.textAmountSalary.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(213, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "صافي الراتب :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "اسم الموظف :";
            // 
            // comboNameEmp
            // 
            this.comboNameEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNameEmp.FormattingEnabled = true;
            this.comboNameEmp.Location = new System.Drawing.Point(692, 27);
            this.comboNameEmp.Name = "comboNameEmp";
            this.comboNameEmp.Size = new System.Drawing.Size(324, 21);
            this.comboNameEmp.TabIndex = 20;
            this.comboNameEmp.SelectedIndexChanged += new System.EventHandler(this.comboNameEmp_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmIDTeacher,
            this.clmNameEmp,
            this.clmSalary,
            this.clmAmountMonthlyGuarantee,
            this.clmAmountOnAccount,
            this.clmAmountMonthly,
            this.clmStartDateOnAccount});
            this.dataGridView1.Location = new System.Drawing.Point(10, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 466);
            this.dataGridView1.TabIndex = 24;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmIDTeacher
            // 
            this.clmIDTeacher.DataPropertyName = "IDTeacher";
            this.clmIDTeacher.HeaderText = "IDTeacher";
            this.clmIDTeacher.Name = "clmIDTeacher";
            this.clmIDTeacher.ReadOnly = true;
            this.clmIDTeacher.Visible = false;
            // 
            // clmNameEmp
            // 
            this.clmNameEmp.DataPropertyName = "name";
            this.clmNameEmp.HeaderText = "اسم الموظف";
            this.clmNameEmp.Name = "clmNameEmp";
            this.clmNameEmp.ReadOnly = true;
            // 
            // clmSalary
            // 
            this.clmSalary.DataPropertyName = "salary";
            this.clmSalary.HeaderText = "الراتب الاساسي";
            this.clmSalary.Name = "clmSalary";
            this.clmSalary.ReadOnly = true;
            // 
            // clmAmountMonthlyGuarantee
            // 
            this.clmAmountMonthlyGuarantee.DataPropertyName = "AmountMonthlyGuarantee";
            this.clmAmountMonthlyGuarantee.HeaderText = "إقتطاع الضمان";
            this.clmAmountMonthlyGuarantee.Name = "clmAmountMonthlyGuarantee";
            this.clmAmountMonthlyGuarantee.ReadOnly = true;
            // 
            // clmAmountOnAccount
            // 
            this.clmAmountOnAccount.DataPropertyName = "AmountOnAccount";
            this.clmAmountOnAccount.HeaderText = "قيمة السلفة";
            this.clmAmountOnAccount.Name = "clmAmountOnAccount";
            this.clmAmountOnAccount.ReadOnly = true;
            // 
            // clmAmountMonthly
            // 
            this.clmAmountMonthly.DataPropertyName = "AmountMonthly";
            this.clmAmountMonthly.HeaderText = "إقتطاع السلفة";
            this.clmAmountMonthly.Name = "clmAmountMonthly";
            this.clmAmountMonthly.ReadOnly = true;
            // 
            // clmStartDateOnAccount
            // 
            this.clmStartDateOnAccount.DataPropertyName = "StartDateOnAccount";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clmStartDateOnAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmStartDateOnAccount.HeaderText = "تاريخ السلفة";
            this.clmStartDateOnAccount.Name = "clmStartDateOnAccount";
            this.clmStartDateOnAccount.ReadOnly = true;
            // 
            // quary_salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "quary_salary";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.quary_salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNameEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountMonthlyGuarantee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountOnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountMonthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartDateOnAccount;
        private System.Windows.Forms.TextBox textAmountSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJobName;
        private System.Windows.Forms.Label label2;
    }
}
