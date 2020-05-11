using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SCHOOL_DEV.UserControls
{
    public partial class UCRevenueName : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string IDRevenue;
        public UCRevenueName()
        {
            InitializeComponent();
        }

        private void UCRevenueName_Load(object sender, EventArgs e)
        {
            Load1();
        }
        private void Load1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from RevenueName where YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                textBox1.Text = string.Empty;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("(يرجى ادخال (اسم الإيراد", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into RevenueName values (@Name,@YaerSemesterID)";
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();




                    MessageBox.Show("تم إضافة الإيراد بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Text = string.Empty;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    con.Close();
                    Load1();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDRevenue != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE RevenueName SET  Name=@Name where ID=@ID and YaerSemesterID=@YaerSemesterID";
                    cmd.Parameters.AddWithValue("@ID", IDRevenue);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعديل بيانات الإيراد بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Text = string.Empty;
                    button2.Visible = false;
                    button3.Visible = false;
                    button1.Visible = true;
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى تحديد الإيراد لعملية التعديل", "بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
                Load1();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (IDRevenue != string.Empty)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from RevenueName where ID=@ID and YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@ID", IDRevenue);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حذف الإيراد بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        textBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد الإيراد لعملية الحذف", "بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                    Load1();
                }               

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load1();
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from RevenueName where Name like @Name and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@Name", "%" + textBox9.Text + "%");
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                IDRevenue = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[clmName.Name].Value.ToString();
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
            }
        }
    }
}
