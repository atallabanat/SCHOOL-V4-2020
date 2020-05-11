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
    public partial class UC_Home : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from class where YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);

                Int32 rows_count1 = Convert.ToInt32(cmd.ExecuteScalar());
                label5.Text = "" + rows_count1.ToString();
                bunifuCircleProgressbar3.Value = rows_count1 ;

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select count(*) from student where YaerSemesterID=@YaerSemesterID";
                cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);

                Int32 rows_count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                label2.Text = rows_count2.ToString() + "";
                bunifuCircleProgressbar1.Value = rows_count2 / 5;


                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select count(*) from Teacher where YaerSemesterID=@YaerSemesterID";
                cmd3.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
     
                Int32 rows_count3 = Convert.ToInt32(cmd3.ExecuteScalar());
                label32.Text = "" + rows_count3.ToString();
                bunifuCircleProgressbar2.Value = rows_count3;

            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }                      

        }
    }
}
