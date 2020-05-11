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
    public partial class quary_student : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string IDStudent;
        int count = 0;

        public quary_student()
        {
            InitializeComponent();
        }

        private void quary_student_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID,name,gender,Date_Registration,class,IDNumber,PhoneDAD,PhoneMAM,PaidTotal,Note from student where name like @name and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@name", "%" + textBox9.Text + "%");
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف سؤدي ذلك الى حذف السجل المالي", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {





                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from student where ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", IDStudent);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Paid where ID_Student=@ID_Student";
                    cmd.Parameters.AddWithValue("@ID_Student", IDStudent);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
                    MessageBox.Show("تم حذف الطالب بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
              

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                IDStudent = dataGridView1.CurrentRow.Cells["clmID"].Value.ToString();
                button2.Visible = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID,name,gender,Date_Registration,class,IDNumber,PhoneDAD,PhoneMAM,PaidTotal,Note from student where class like @class and YaerSemesterID=@YaerSemesterID ";
                cmd.Parameters.AddWithValue("@class", "%" + textBox1.Text + "%");
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
        

                
       
    }
}
