namespace SCHOOL_DEV.UserControls
{
    partial class PrintAllStudent
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 555);
            this.dataGridView1.TabIndex = 21;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1111, 52);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(256, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PrintAllStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintAllStudent";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.PrintAllStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}
