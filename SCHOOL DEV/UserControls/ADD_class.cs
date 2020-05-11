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
    public partial class ADD_class : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        int count = 0;
        string IDClass;
        public ADD_class()
        {
            InitializeComponent();
        }

        private void ADD_class_Load(object sender, EventArgs e)
        {
            Load1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("(يرجى ادخال (اسم الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into class values (@Name,@YaerSemesterID)";
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    con.Close();

                   

                    MessageBox.Show("تم إضافة الصف الدراسي بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Text = string.Empty;

                    Load1();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    
                    
                }
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from class where YaerSemesterID=@YaerSemesterID";
            cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                textBox1.Text = string.Empty;
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
            if(dataGridView1.Rows.Count >0)
            {
                IDClass = dataGridView1.CurrentRow.Cells["clmID"].Value.ToString();
                textBox1.Text= dataGridView1.CurrentRow.Cells["clmName"].Value.ToString();
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
            }
            
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from class where Name like @Name and YaerSemesterID=@YaerSemesterID";
            cmd.Parameters.AddWithValue("@Name","%"+textBox9.Text+"%");
            cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (IDClass != string.Empty)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from class where ID=@ID and YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@ID", IDClass);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حذف الصف الدراسي بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        textBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد الصف الدراسي لعملية الحذف","بيانات",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }


                Load1();

                

            }
        }
        private void Load1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from class where YaerSemesterID=@YaerSemesterID";
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
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDClass != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE class SET  Name=@Name where ID=@ID and YaerSemesterID=@YaerSemesterID";
                    cmd.Parameters.AddWithValue("@ID", IDClass);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعديل بيانات الصف الدراسي بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox1.Text = string.Empty;
                    button2.Visible = false;
                    button3.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    MessageBox.Show("يرجى تحديد الصف الدراسي لعملية التعديل", "بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from class where YaerSemesterID=@YaerSemesterID";
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
    }
}
