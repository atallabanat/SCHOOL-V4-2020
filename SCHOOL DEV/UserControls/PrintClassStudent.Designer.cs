﻿namespace SCHOOL_DEV.UserControls
{
    partial class PrintClassStudent
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1110, 62);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الصف الدراسي (يرجى ادخال الصف الدراسي)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(565, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(539, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 530);
            this.dataGridView1.TabIndex = 22;
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
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "الجنس";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // clmDate_Registration
            // 
            this.clmDate_Registration.DataPropertyName = "Date_Registration";
            this.clmDate_Registration.HeaderText = "تاريخ التسجيل";
            this.clmDate_Registration.Name = "clmDate_Registration";
            this.clmDate_Registration.ReadOnly = true;
            // 
            // clmclass
            // 
            this.clmclass.DataPropertyName = "class";
            this.clmclass.HeaderText = "الصف الدراسي";
            this.clmclass.Name = "clmclass";
            this.clmclass.ReadOnly = true;
            // 
            // clmIDNumber
            // 
            this.clmIDNumber.DataPropertyName = "IDNumber";
            this.clmIDNumber.HeaderText = "الرقم الوطني";
            this.clmIDNumber.Name = "clmIDNumber";
            this.clmIDNumber.ReadOnly = true;
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
            // 
            // clmNote
            // 
            this.clmNote.DataPropertyName = "Note";
            this.clmNote.HeaderText = "الملاحظات";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            // 
            // PrintClassStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Name = "PrintClassStudent";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.PrintClassStudent_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
