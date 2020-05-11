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
    public partial class newSemester : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public newSemester()
        {
            InitializeComponent();
        }
        private void Load1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT         Tbl_Semester.Name_Semester, Tbl_Year.YearName
                         FROM            YaerSemester INNER JOIN
                         Tbl_Year ON YaerSemester.ID_Year = Tbl_Year.ID INNER JOIN
                         Tbl_Semester ON YaerSemester.ID_Semester = Tbl_Semester.ID_Semester";
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


        private void newSemester_Load(object sender, EventArgs e)
        {
            try
            {
                Load1();
                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                string sql = @"select ID,YearName from Tbl_Year";
                da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "YearName";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;


                SqlCommand cmd2 = con.CreateCommand();

                SqlDataAdapter da2 = new SqlDataAdapter();
                string sql2 = @"select * from Tbl_Semester";
                da2 = new SqlDataAdapter(sql2, con);
                DataSet ds2 = new DataSet();
                ds2 = new DataSet();
                da2.Fill(ds2);
                comboBox2.DataSource = ds2.Tables[0];
                comboBox2.DisplayMember = "Name_Semester";
                comboBox2.ValueMember = "ID_Semester";
                comboBox2.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into YaerSemester values (@ID_Year,@ID_Semester)";
                cmd.Parameters.AddWithValue("@ID_Year", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@ID_Semester", comboBox2.SelectedValue);
                cmd.ExecuteNonQuery();

                msg.Alert("تم إضافة عام جديد", Form_Alert.enumType.Success);
            }
            catch (Exception ex)
            {
                msg.Alert("لم تتم عملية الحفظ", Form_Alert.enumType.Error);
            }
            finally
            {

                con.Close();
                Load1();
            }
        }
    }
}
