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
    public partial class quary_Teacher : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID_Teacher;
        public quary_Teacher()
        {
            InitializeComponent();
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
                        cmd.Parameters.AddWithValue("@ID", ID_Teacher);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();


                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "delete from PaidKA where ID_Teacher=@ID_Teacher and YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@ID_Teacher", ID_Teacher);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd2.ExecuteNonQuery();




                        SqlCommand cmd3 = con.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "select * from Teacher where YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd3.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd3);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;


                        MessageBox.Show("تم حذف الموظف بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
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
                cmd.Parameters.AddWithValue("@name","%"+textBox9.Text +"%");
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
            try
            {
                ID_Teacher = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
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
}
