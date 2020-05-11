namespace SCHOOL_DEV.UserControls
{
    partial class quary_student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate_Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneMAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaidTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.name,
            this.gender,
            this.clmDate_Registration,
            this.clmclass,
            this.clmIDNumber,
            this.clmPhoneDAD,
            this.clmPhoneMAM,
            this.clmPaidTotal,
            this.clmNote});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 482);
            this.dataGridView1.TabIndex = 8;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "اسم الطالب";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "الجنس";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 120;
            // 
            // clmDate_Registration
            // 
            this.clmDate_Registration.DataPropertyName = "Date_Registration";
            this.clmDate_Registration.HeaderText = "تاريخ التسجيل";
            this.clmDate_Registration.Name = "clmDate_Registration";
            this.clmDate_Registration.ReadOnly = true;
            this.clmDate_Registration.Width = 120;
            // 
            // clmclass
            // 
            this.clmclass.DataPropertyName = "class";
            this.clmclass.HeaderText = "الصف الدراسي";
            this.clmclass.Name = "clmclass";
            this.clmclass.ReadOnly = true;
            this.clmclass.Width = 175;
            // 
            // clmIDNumber
            // 
            this.clmIDNumber.DataPropertyName = "IDNumber";
            this.clmIDNumber.HeaderText = "الرقم الوطني";
            this.clmIDNumber.Name = "clmIDNumber";
            this.clmIDNumber.ReadOnly = true;
            this.clmIDNumber.Width = 150;
            // 
            // clmPhoneDAD
            // 
            this.clmPhoneDAD.DataPropertyName = "PhoneDAD";
            this.clmPhoneDAD.HeaderText = "هاتف الأب";
            this.clmPhoneDAD.Name = "clmPhoneDAD";
            this.clmPhoneDAD.ReadOnly = true;
            // 
            // clmPhoneMAM
            // 
            this.clmPhoneMAM.DataPropertyName = "PhoneMAM";
            this.clmPhoneMAM.HeaderText = "هاتف الأم";
            this.clmPhoneMAM.Name = "clmPhoneMAM";
            this.clmPhoneMAM.ReadOnly = true;
            // 
            // clmPaidTotal
            // 
            this.clmPaidTotal.DataPropertyName = "PaidTotal";
            this.clmPaidTotal.HeaderText = "إجمالي الاقساط";
            this.clmPaidTotal.Name = "clmPaidTotal";
            this.clmPaidTotal.ReadOnly = true;
            this.clmPaidTotal.Width = 110;
            // 
            // clmNote
            // 
            this.clmNote.DataPropertyName = "Note";
            this.clmNote.HeaderText = "الملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 300;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1110, 73);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اسم الطالب (يرجى ادخال اسم الطالب)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(474, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث الصف الدراسي";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 28);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(801, 27);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(303, 28);
            this.textBox9.TabIndex = 1;
            this.textBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyUp);
            // 
            // quary_student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Name = "quary_student";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.quary_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate_Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneMAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaidTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
    }
}
