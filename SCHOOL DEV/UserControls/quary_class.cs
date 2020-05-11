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
    public partial class quary_class : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string IDClass;
        public quary_class()
        {
            InitializeComponent();
        }

        private void quary_class_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من عملية الحذف", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                try
                { 
                   con.Open();
                   SqlCommand cmd = con.CreateCommand();
                   cmd.CommandType = CommandType.Text;
                   cmd.CommandText = "delete from class where ID=@ID and YaerSemesterID=@YaerSemesterID";
                   cmd.Parameters.AddWithValue("@ID",IDClass);
                   cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("تم حذف الصف الدراسي بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            try
            { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from class where Name like @Name and YaerSemesterID=@YaerSemesterID ";
            cmd.Parameters.AddWithValue("@Name","%"+textBox9.Text+"%");
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

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                IDClass = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[clmName.Name].Value.ToString();
                button2.Visible = true;
            }
        }
    }
}
