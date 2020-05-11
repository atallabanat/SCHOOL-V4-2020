namespace SCHOOL_DEV.UserControls
{
    partial class AP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkPaid = new System.Windows.Forms.CheckBox();
            this.combo_To = new System.Windows.Forms.ComboBox();
            this.combo_From = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmName_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaidDefult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.combo_Student = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkStudent = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(781, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkPaid);
            this.groupBox3.Controls.Add(this.combo_To);
            this.groupBox3.Controls.Add(this.combo_From);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1130, 55);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // checkPaid
            // 
            this.checkPaid.AutoSize = true;
            this.checkPaid.Checked = true;
            this.checkPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPaid.Location = new System.Drawing.Point(333, 22);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(97, 23);
            this.checkPaid.TabIndex = 43;
            this.checkPaid.Text = "جميع الدفعات";
            this.checkPaid.UseVisualStyleBackColor = true;
            this.checkPaid.CheckedChanged += new System.EventHandler(this.checkPaid_CheckedChanged);
            // 
            // combo_To
            // 
            this.combo_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_To.FormattingEnabled = true;
            this.combo_To.Location = new System.Drawing.Point(452, 22);
            this.combo_To.Name = "combo_To";
            this.combo_To.Size = new System.Drawing.Size(236, 27);
            this.combo_To.TabIndex = 42;
            // 
            // combo_From
            // 
            this.combo_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_From.FormattingEnabled = true;
            this.combo_From.Location = new System.Drawing.Point(795, 22);
            this.combo_From.Name = "combo_From";
            this.combo_From.Size = new System.Drawing.Size(236, 27);
            this.combo_From.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "إلى الدفعة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1037, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "من الدفعة :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName_Student,
            this.ID_Student,
            this.clmNamePaid,
            this.clmPaidDefult,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.clmSumm,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.Location = new System.Drawing.Point(3, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1133, 430);
            this.dataGridView2.TabIndex = 50;
            // 
            // clmName_Student
            // 
            this.clmName_Student.DataPropertyName = "Name_Student";
            this.clmName_Student.HeaderText = "اسم الطالب";
            this.clmName_Student.Name = "clmName_Student";
            this.clmName_Student.ReadOnly = true;
            // 
            // ID_Student
            // 
            this.ID_Student.DataPropertyName = "ID_Student";
            this.ID_Student.HeaderText = "ID_Student";
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.ReadOnly = true;
            this.ID_Student.Visible = false;
            // 
            // clmNamePaid
            // 
            this.clmNamePaid.DataPropertyName = "NamePaid";
            this.clmNamePaid.HeaderText = "الدفعة";
            this.clmNamePaid.Name = "clmNamePaid";
            this.clmNamePaid.ReadOnly = true;
            // 
            // clmPaidDefult
            // 
            this.clmPaidDefult.DataPropertyName = "PaidDefult";
            this.clmPaidDefult.HeaderText = "قيمة الدفعة";
            this.clmPaidDefult.Name = "clmPaidDefult";
            this.clmPaidDefult.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PaidAmount";
            this.Column1.HeaderText = "المدفوع";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rest";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "الباقي";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PhoneDAD";
            this.Column3.HeaderText = "رقم هاتف الأب";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "class";
            this.Column4.HeaderText = "الصف الدراسي";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // clmSumm
            // 
            this.clmSumm.DataPropertyName = "PaidTotal";
            this.clmSumm.HeaderText = "إجمالي الأقساط";
            this.clmSumm.Name = "clmSumm";
            this.clmSumm.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AmountPaid2";
            this.Column5.HeaderText = "إجمالي المدفوع";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SCHOOL_DEV.Properties.Resources.search_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(957, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 33);
            this.button2.TabIndex = 37;
            this.button2.Text = "بحث        ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combo_Student
            // 
            this.combo_Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Student.FormattingEnabled = true;
            this.combo_Student.Location = new System.Drawing.Point(452, 19);
            this.combo_Student.Name = "combo_Student";
            this.combo_Student.Size = new System.Drawing.Size(579, 27);
            this.combo_Student.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1037, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "اسم الطالب :";
            // 
            // checkStudent
            // 
            this.checkStudent.AutoSize = true;
            this.checkStudent.Checked = true;
            this.checkStudent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkStudent.Location = new System.Drawing.Point(336, 21);
            this.checkStudent.Name = "checkStudent";
            this.checkStudent.Size = new System.Drawing.Size(94, 23);
            this.checkStudent.TabIndex = 46;
            this.checkStudent.Text = "جميع الطلاب";
            this.checkStudent.UseVisualStyleBackColor = true;
            this.checkStudent.CheckedChanged += new System.EventHandler(this.checkStudent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkStudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_Student);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 59);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(3, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1133, 58);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // AP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Name = "AP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.AP_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaidDefult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.ComboBox combo_To;
        public System.Windows.Forms.ComboBox combo_From;
        public System.Windows.Forms.ComboBox combo_Student;
    }
}
