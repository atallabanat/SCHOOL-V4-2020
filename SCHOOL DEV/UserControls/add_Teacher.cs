using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SCHOOL_DEV.UserControls
{
    public partial class add_Teacher : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID_Teacher;


        public add_Teacher()
        {
            InitializeComponent();
        }

        private void add_Teacher_Load(object sender, EventArgs e)
        {
            
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text == string.Empty)
                {
                    MessageBox.Show("(يرجى ادخال (اسم الموظف", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textSalary.Text == string.Empty)
                {
                    MessageBox.Show("(يرجى ادخال (الراتب الاساسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Teacher
                         (name, ID_number, date, gender, Phone_number, JobName, salary, YaerSemesterID)
                         VALUES        (@name, @ID_number, @date, @gender, @Phone_number, @JobName, @salary, @YaerSemesterID)";
                    cmd.Parameters.AddWithValue("@name", textName.Text);
                    cmd.Parameters.AddWithValue("@ID_number", textID_number.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@Phone_number", textPhone.Text);
                    cmd.Parameters.AddWithValue("@JobName", textJob.Text);
                    cmd.Parameters.AddWithValue("@salary", textSalary.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();



                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from Teacher where YaerSemesterID=@YaerSemesterID";
                    cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("تم إضافة الموظف بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearScreen();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                ClearScreen();
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Teacher where YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select * from gendera", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboGender.DataSource = ds.Tables[0];
                comboGender.DisplayMember = "genderNumber";
                comboGender.ValueMember = "genderName";
                comboGender.SelectedIndex = -1;
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (MessageBox.Show("هل انت متاكد من عملية الحذف سيؤدي ذلك الى حذف السجل المالي للموظف !", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (ID_Teacher != string.Empty)
                    {
             
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Teacher where ID=@ID and YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@ID",ID_Teacher);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();


                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "delete from PaidKA where ID_Teacher=@ID_Teacher and YaerSemesterID=@YaerSemesterID";
                        cmd2.Parameters.AddWithValue("@ID_Teacher", ID_Teacher);
                        cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd2.ExecuteNonQuery();




                        SqlCommand cmd3 = con.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "select * from Teacher where YaerSemesterID=@YaerSemesterID";
                        cmd3.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd3.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd3);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;


                        MessageBox.Show("تم حذف الموظف بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearScreen();
                        button2.Visible = false;
                        textName.Enabled = true;
                        button1.Visible = true;
                        button3.Visible = false;

                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void ClearScreen()
        {

            textName.Text = string.Empty;
            textID_number.Text = string.Empty;
            textPhone.Text = string.Empty;
            textJob.Text = string.Empty;
            textSalary.Text = string.Empty;
            comboGender.SelectedIndex = -1;

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                ID_Teacher = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                textName.Text = dataGridView1.CurrentRow.Cells[clmname.Name].Value.ToString();
                textID_number.Text = dataGridView1.CurrentRow.Cells[clmID_number.Name].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[clmdate.Name].Value.ToString();
                comboGender.Text = dataGridView1.CurrentRow.Cells[clmgender.Name].Value.ToString();
                textPhone.Text = dataGridView1.CurrentRow.Cells[clmPhone_number.Name].Value.ToString();
                textJob.Text = dataGridView1.CurrentRow.Cells[clmJobName.Name].Value.ToString();
                textSalary.Text = dataGridView1.CurrentRow.Cells[clmsalary.Name].Value.ToString();
                button2.Visible = true;
                button3.Visible = true;
                button1.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboGender.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تعبئة الجنس", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textSalary.Text == string.Empty)
                {
                    MessageBox.Show("يرجى تعبئة الراتب الاساسي للموظف", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE       Teacher
                                    SET          name =@name, ID_number =@ID_number, date =@date, gender =@gender, Phone_number =@Phone_number, JobName =@JobName, salary =@salary where YaerSemesterID =@YaerSemesterID";
                cmd.Parameters.AddWithValue("@name",textName.Text);
                cmd.Parameters.AddWithValue("@ID_number", textID_number.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                cmd.Parameters.AddWithValue("@Phone_number", textPhone.Text);
                cmd.Parameters.AddWithValue("@JobName", textJob.Text);
                cmd.Parameters.AddWithValue("@salary", textSalary.Text);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();             


                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from Teacher where YaerSemesterID=@YaerSemesterID";
                cmd3.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd3.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                MessageBox.Show("تم التعديل بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                ClearScreen();
                button1.Visible = true;
                button3.Visible = false;
                textName.Enabled = true;
                button2.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Teacher where name like @name and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@name", "%" + textBox9.Text + "%");
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }

        }
    }
}
