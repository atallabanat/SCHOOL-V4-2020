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
using DGVPrinterHelper;
using System.Configuration;
using SCHOOL_DEV.Report;

namespace SCHOOL_DEV.UserControls
{
    public partial class PrintNameStudent : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public static PrintNameStudent printNameStudent;

        public PrintNameStudent()
        {
            printNameStudent = this;
            InitializeComponent();
        }

        private void PrintNameStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,name from student where YaerSemesterID="+Program.ID_Year+"", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_PrintNameStudent report = new Report_PrintNameStudent();
            report.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PrintNameStudent";
                cmd.Parameters.AddWithValue("@ID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
        }
    }
}
