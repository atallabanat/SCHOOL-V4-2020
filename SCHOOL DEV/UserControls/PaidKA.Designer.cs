namespace SCHOOL_DEV.UserControls
{
    partial class PaidKA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaidKA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label9 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.textAmountMonthlyGuarantee = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNameEmp = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textAmountMonthly = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAmountOnAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textAmountSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(195, 599);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(735, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------";
            this.label9.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1013, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "تاريخ السلفة :";
            // 
            // textAmountMonthlyGuarantee
            // 
            this.textAmountMonthlyGuarantee.Location = new System.Drawing.Point(364, 143);
            this.textAmountMonthlyGuarantee.Name = "textAmountMonthlyGuarantee";
            this.textAmountMonthlyGuarantee.Size = new System.Drawing.Size(170, 20);
            this.textAmountMonthlyGuarantee.TabIndex = 28;
            this.textAmountMonthlyGuarantee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(540, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "قيمة اقتطاع الضمان شهريا :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1013, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الموظف :";
            // 
            // comboNameEmp
            // 
            this.comboNameEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNameEmp.FormattingEnabled = true;
            this.comboNameEmp.Location = new System.Drawing.Point(683, 31);
            this.comboNameEmp.Name = "comboNameEmp";
            this.comboNameEmp.Size = new System.Drawing.Size(324, 21);
            this.comboNameEmp.TabIndex = 18;
            this.comboNameEmp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(966, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "إضافة سلفة جديدة";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAmountMonthly
            // 
            this.textAmountMonthly.Location = new System.Drawing.Point(21, 87);
            this.textAmountMonthly.Name = "textAmountMonthly";
            this.textAmountMonthly.Size = new System.Drawing.Size(144, 20);
            this.textAmountMonthly.TabIndex = 24;
            this.textAmountMonthly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "قيمة الاقتطاع الشهري :";
            // 
            // textAmountOnAccount
            // 
            this.textAmountOnAccount.Location = new System.Drawing.Point(364, 87);
            this.textAmountOnAccount.Name = "textAmountOnAccount";
            this.textAmountOnAccount.Size = new System.Drawing.Size(170, 20);
            this.textAmountOnAccount.TabIndex = 22;
            this.textAmountOnAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "قيمة السلفة :";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(21, 31);
            this.textSalary.Name = "textSalary";
            this.textSalary.ReadOnly = true;
            this.textSalary.Size = new System.Drawing.Size(144, 20);
            this.textSalary.TabIndex = 20;
            this.textSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "الراتب الإساسي :";
            // 
            // textJobName
            // 
            this.textJobName.Enabled = false;
            this.textJobName.Location = new System.Drawing.Point(364, 31);
            this.textJobName.Name = "textJobName";
            this.textJobName.ReadOnly = true;
            this.textJobName.Size = new System.Drawing.Size(170, 20);
            this.textJobName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "الوظيفة :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.textAmountSalary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textAmountMonthlyGuarantee);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboNameEmp);
            this.groupBox1.Controls.Add(this.textAmountMonthly);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textAmountOnAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textSalary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textJobName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1117, 263);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(651, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "حذف السلفة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(807, 210);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 32);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "تعديل السلفة";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textAmountSalary
            // 
            this.textAmountSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textAmountSalary.Location = new System.Drawing.Point(21, 217);
            this.textAmountSalary.Name = "textAmountSalary";
            this.textAmountSalary.ReadOnly = true;
            this.textAmountSalary.Size = new System.Drawing.Size(144, 20);
            this.textAmountSalary.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(171, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "صافي الراتب :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 314);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clmStartDateOnAccount.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmStartDateOnAccount.HeaderText = "تاريخ السلفة";
            this.clmStartDateOnAccount.Name = "clmStartDateOnAccount";
            this.clmStartDateOnAccount.ReadOnly = true;
            // 
            // PaidKA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaidKA";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.PaidKA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAmountMonthlyGuarantee;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNameEmp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textAmountMonthly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAmountOnAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textAmountSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountMonthlyGuarantee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountOnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountMonthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartDateOnAccount;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
    }
}
