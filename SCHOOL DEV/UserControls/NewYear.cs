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
    public partial class NewYear : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public NewYear()
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
                cmd.CommandText = "select YearName from Tbl_Year ";                
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

        private void NewYear_Load(object sender, EventArgs e)
        {
            Load1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Tbl_Year values (@YearName)";                
                cmd.Parameters.AddWithValue("@YearName", dateTimePicker2.Value.ToString("yyyy")+"-"+dateTimePicker1.Value.ToString("yyyy"));
                cmd.ExecuteNonQuery();

                msg.Alert("تم إضافة عام جديد",Form_Alert.enumType.Success);
            }
            catch (Exception ex)
            {
                msg.Alert("لم تتم عملية الحفظ",Form_Alert.enumType.Error);
            }
            finally
            {

                con.Close();
                Load1();
            }

        }
    }


}
