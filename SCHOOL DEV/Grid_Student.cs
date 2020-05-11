using SCHOOL_DEV.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DEV
{
    public partial class Grid_Student : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID;
        string Name;
        public Grid_Student()
        {
            InitializeComponent();
        }

        private void Grid_Student_Load(object sender, EventArgs e)
        {
            try
            {
                var dataTable = new DataTable();
                using (SqlCommand Cmd = con.CreateCommand())
                {
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "select ID,Name from student where YaerSemesterID=@YaerSemesterID";
                    Cmd.Parameters.AddWithValue("@YaerSemesterID",Program.ID_Year);
                    SqlDataAdapter da = new SqlDataAdapter(Cmd);
                    da.Fill(dataTable);


                }
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ee)
            {
               
               // MessageBox.Show("يرجى تصوير الخطأ ومراجعة مدير النظام ، شكرا" + ee.Message, "ERROR 1001 Grid_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    ID = dataGridView1.CurrentRow.Cells["clm_ID"].Value.ToString();
                    Name = dataGridView1.CurrentRow.Cells["clmName"].Value.ToString();

                    add_student.add_Student.text_Name.Text = Name;
                    add_student.add_Student.ID = ID;
                    add_student.add_Student.selectGrid();
                    add_student.add_Student.button1.Visible = false;
                    add_student.add_Student.button2.Visible = true;
                    add_student.add_Student.button3.Visible = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void textBox_search_OnValueChanged(object sender, EventArgs e)
        {
            try
            {

                var dataTable2 = new DataTable();
                using (SqlCommand Cmd = con.CreateCommand())
                {
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "select ID,name from student where name like @Name and YaerSemesterID=@YaerSemesterID";
                    Cmd.Parameters.AddWithValue("@Name", "%" + textBox_search.Text + "%");
                    Cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    SqlDataAdapter da2 = new SqlDataAdapter(Cmd);
                    da2.Fill(dataTable2);


                }
                dataGridView1.DataSource = dataTable2;
            }
            catch (Exception ee)
            {
                con.Close();
                //MessageBox.Show("يرجى تصوير الخطأ ومراجعة مدير النظام ، شكرا" + ee.Message, "ERROR 1003 Grid_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
