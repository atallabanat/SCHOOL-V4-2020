namespace SCHOOL_DEV.UserControls
{
    partial class ALL_Teacher
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
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYaerSemesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.clmname,
            this.clmID_number,
            this.clmgender,
            this.clmdate,
            this.clmJobName,
            this.clmPhone_number,
            this.clmsalary,
            this.clmYaerSemesterID});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(18, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 518);
            this.dataGridView1.TabIndex = 17;
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
            // ALL_Teacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALL_Teacher";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.ALL_Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}
