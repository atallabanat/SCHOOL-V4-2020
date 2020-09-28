namespace SCHOOL_DEV.UserControls
{
    partial class ADD_Paid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox20 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_s = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkDefultPaid = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.txtBondNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNamePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBondNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox14.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox20
            // 
            this.textBox20.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBox20.Location = new System.Drawing.Point(520, 191);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(264, 21);
            this.textBox20.TabIndex = 45;
            this.textBox20.ValueChanged += new System.EventHandler(this.textBox20_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(792, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "تاريخ الدفع  :";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.Control;
            this.textBox19.Location = new System.Drawing.Point(520, 157);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(264, 21);
            this.textBox19.TabIndex = 3;
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox19_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(792, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "قيمة الدفعة :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(467, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "طباعة سند قبض";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(734, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "دفع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(520, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 23);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(792, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "اسم الطالب :";
            // 
            // textBox_K
            // 
            this.textBox_K.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_K.Enabled = false;
            this.textBox_K.Location = new System.Drawing.Point(234, 20);
            this.textBox_K.Multiline = true;
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(95, 28);
            this.textBox_K.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(565, 26);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "إجمالي الاقساط :";
            // 
            // textBox_s
            // 
            this.textBox_s.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_s.Enabled = false;
            this.textBox_s.Location = new System.Drawing.Point(480, 20);
            this.textBox_s.Multiline = true;
            this.textBox_s.Name = "textBox_s";
            this.textBox_s.Size = new System.Drawing.Size(82, 28);
            this.textBox_s.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(332, 26);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "مجموع المدفوع :";
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_B.Enabled = false;
            this.textBox_B.Location = new System.Drawing.Point(22, 20);
            this.textBox_B.Multiline = true;
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(91, 28);
            this.textBox_B.TabIndex = 27;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBox_K);
            this.groupBox14.Controls.Add(this.label13);
            this.groupBox14.Controls.Add(this.textBox_s);
            this.groupBox14.Controls.Add(this.label12);
            this.groupBox14.Controls.Add(this.textBox_B);
            this.groupBox14.Controls.Add(this.label15);
            this.groupBox14.Location = new System.Drawing.Point(319, 483);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox14.Size = new System.Drawing.Size(687, 57);
            this.groupBox14.TabIndex = 39;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "المالية";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(115, 26);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "الباقي :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBondNo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.checkDefultPaid);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.groupBox14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox19);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(-129, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1253, 611);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "معلومات الدفع";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(601, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 33);
            this.button3.TabIndex = 50;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // checkDefultPaid
            // 
            this.checkDefultPaid.AutoSize = true;
            this.checkDefultPaid.ForeColor = System.Drawing.Color.Maroon;
            this.checkDefultPaid.Location = new System.Drawing.Point(414, 122);
            this.checkDefultPaid.Name = "checkDefultPaid";
            this.checkDefultPaid.Size = new System.Drawing.Size(85, 19);
            this.checkDefultPaid.TabIndex = 49;
            this.checkDefultPaid.Text = "تحديد تلقائي";
            this.checkDefultPaid.UseVisualStyleBackColor = true;
            this.checkDefultPaid.CheckedChanged += new System.EventHandler(this.checkDefultPaid_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmIDPaid,
            this.clmNamePaid,
            this.clmAmountPaid,
            this.clmDateAmount,
            this.clmBondNo});
            this.dataGridView1.Location = new System.Drawing.Point(319, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 238);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(520, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(264, 23);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "تحديد الدفعة :";
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Location = new System.Drawing.Point(3, 526);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(135, 92);
            this.panelControls.TabIndex = 40;
            this.panelControls.Visible = false;
            // 
            // txtBondNo
            // 
            this.txtBondNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtBondNo.Location = new System.Drawing.Point(520, 81);
            this.txtBondNo.Name = "txtBondNo";
            this.txtBondNo.Size = new System.Drawing.Size(264, 21);
            this.txtBondNo.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(792, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "رقم السند :";
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmIDPaid
            // 
            this.clmIDPaid.DataPropertyName = "IDPaid";
            this.clmIDPaid.HeaderText = "IDPaid";
            this.clmIDPaid.Name = "clmIDPaid";
            this.clmIDPaid.ReadOnly = true;
            this.clmIDPaid.Visible = false;
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.clmDateAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDateAmount.HeaderText = "تاريخ الدفع";
            this.clmDateAmount.Name = "clmDateAmount";
            this.clmDateAmount.ReadOnly = true;
            // 
            // clmBondNo
            // 
            this.clmBondNo.DataPropertyName = "BondNo";
            this.clmBondNo.HeaderText = "رقم السند";
            this.clmBondNo.Name = "clmBondNo";
            this.clmBondNo.ReadOnly = true;
            // 
            // ADD_Paid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.groupBox3);
            this.Name = "ADD_Paid";
            this.Size = new System.Drawing.Size(1136, 631);
            this.Load += new System.EventHandler(this.ADD_Paid_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ADD_Paid_MouseClick);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_s;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker textBox20;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDefultPaid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBondNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNamePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBondNo;
    }
}
