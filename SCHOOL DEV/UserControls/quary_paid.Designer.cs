namespace SCHOOL_DEV.UserControls
{
    partial class quary_paid
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalSumStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(19, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1111, 49);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بحث ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SCHOOL_DEV.Properties.Resources.search_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(520, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 36;
            this.button2.Text = "بحث طالب       ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::SCHOOL_DEV.Properties.Resources.search_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "بحث تاريخ       ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 21);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(670, 19);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(329, 21);
            this.textBox9.TabIndex = 1;
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "تاريخ الدفع :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1003, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "اسم الطالب :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.IDPaid,
            this.clmName_Student,
            this.clmNamePaid,
            this.clmAmountPaid,
            this.clmDateAmount,
            this.clmTotalSumStudent,
            this.clmTotalAmount,
            this.clmRestAmount,
            this.clmClass});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(19, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 553);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ID_Student";
            this.Column6.HeaderText = "ID_Student";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // IDPaid
            // 
            this.IDPaid.DataPropertyName = "IDPaid";
            this.IDPaid.HeaderText = "IDPaid";
            this.IDPaid.Name = "IDPaid";
            this.IDPaid.ReadOnly = true;
            this.IDPaid.Visible = false;
            // 
            // clmName_Student
            // 
            this.clmName_Student.DataPropertyName = "Name_Student";
            this.clmName_Student.HeaderText = "اسم الطالب";
            this.clmName_Student.Name = "clmName_Student";
            this.clmName_Student.ReadOnly = true;
            // 
            // clmNamePaid
            // 
            this.clmNamePaid.DataPropertyName = "NamePaid";
            this.clmNamePaid.HeaderText = "الدفعة";
            this.clmNamePaid.Name = "clmNamePaid";
            this.clmNamePaid.ReadOnly = true;
            // 
            // clmAmountPaid
            // 
            this.clmAmountPaid.DataPropertyName = "AmountPaid";
            this.clmAmountPaid.HeaderText = "قيمة الدفعة";
            this.clmAmountPaid.Name = "clmAmountPaid";
            this.clmAmountPaid.ReadOnly = true;
            // 
            // clmDateAmount
            // 
            this.clmDateAmount.DataPropertyName = "DateAmount";
            this.clmDateAmount.HeaderText = "تاريخ الدفع";
            this.clmDateAmount.Name = "clmDateAmount";
            this.clmDateAmount.ReadOnly = true;
            // 
            // clmTotalSumStudent
            // 
            this.clmTotalSumStudent.DataPropertyName = "TotalSumStudent";
            this.clmTotalSumStudent.HeaderText = "إجمالي الأقساط";
            this.clmTotalSumStudent.Name = "clmTotalSumStudent";
            this.clmTotalSumStudent.ReadOnly = true;
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.DataPropertyName = "TotalAmount";
            this.clmTotalAmount.HeaderText = "المدفوع";
            this.clmTotalAmount.Name = "clmTotalAmount";
            this.clmTotalAmount.ReadOnly = true;
            // 
            // clmRestAmount
            // 
            this.clmRestAmount.DataPropertyName = "RestAmount";
            this.clmRestAmount.HeaderText = "الباقي";
            this.clmRestAmount.Name = "clmRestAmount";
            this.clmRestAmount.ReadOnly = true;
            // 
            // clmClass
            // 
            this.clmClass.DataPropertyName = "NameClass";
            this.clmClass.HeaderText = "الصف الدراسي";
            this.clmClass.Name = "clmClass";
            this.clmClass.ReadOnly = true;
            // 
            // quary_paid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "quary_paid";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.quary_paid_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalSumStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClass;
    }
}
