namespace SCHOOL_DEV.UserControls
{
    partial class quary_Teacher
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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYaerSemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(20, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1100, 62);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اسم الموظف (يرجى ادخال اسم الموظف )";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::SCHOOL_DEV.Properties.Resources.search_32px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(431, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 33);
            this.button5.TabIndex = 38;
            this.button5.Text = "بحث       ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(548, 25);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(546, 28);
            this.textBox9.TabIndex = 1;
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
            this.clmname,
            this.clmID_number,
            this.clmgender,
            this.clmdate,
            this.clmJobName,
            this.clmPhone_number,
            this.clmsalary,
            this.clmYaerSemesterID});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(20, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 487);
            this.dataGridView1.TabIndex = 16;
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
            // clmname
            // 
            this.clmname.DataPropertyName = "name";
            this.clmname.HeaderText = "اسم الموظف";
            this.clmname.Name = "clmname";
            this.clmname.ReadOnly = true;
            // 
            // clmID_number
            // 
            this.clmID_number.DataPropertyName = "ID_number";
            this.clmID_number.HeaderText = "الرقم الوطني";
            this.clmID_number.Name = "clmID_number";
            this.clmID_number.ReadOnly = true;
            // 
            // clmgender
            // 
            this.clmgender.DataPropertyName = "gender";
            this.clmgender.HeaderText = "الجنس";
            this.clmgender.Name = "clmgender";
            this.clmgender.ReadOnly = true;
            // 
            // clmdate
            // 
            this.clmdate.DataPropertyName = "date";
            this.clmdate.HeaderText = "تاريخ التعيين";
            this.clmdate.Name = "clmdate";
            this.clmdate.ReadOnly = true;
            // 
            // clmJobName
            // 
            this.clmJobName.DataPropertyName = "JobName";
            this.clmJobName.HeaderText = "الوظيفة";
            this.clmJobName.Name = "clmJobName";
            this.clmJobName.ReadOnly = true;
            // 
            // clmPhone_number
            // 
            this.clmPhone_number.DataPropertyName = "Phone_number";
            this.clmPhone_number.HeaderText = "هاتف الموظف";
            this.clmPhone_number.Name = "clmPhone_number";
            this.clmPhone_number.ReadOnly = true;
            // 
            // clmsalary
            // 
            this.clmsalary.DataPropertyName = "salary";
            this.clmsalary.HeaderText = "الراتب الاساسي";
            this.clmsalary.Name = "clmsalary";
            this.clmsalary.ReadOnly = true;
            // 
            // clmYaerSemesterID
            // 
            this.clmYaerSemesterID.DataPropertyName = "YaerSemesterID";
            this.clmYaerSemesterID.HeaderText = "YaerSemesterID";
            this.clmYaerSemesterID.Name = "clmYaerSemesterID";
            this.clmYaerSemesterID.ReadOnly = true;
            this.clmYaerSemesterID.Visible = false;
            // 
            // quary_Teacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Name = "quary_Teacher";
            this.Size = new System.Drawing.Size(1136, 631);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYaerSemesterID;
        private System.Windows.Forms.Button button5;
    }
}
