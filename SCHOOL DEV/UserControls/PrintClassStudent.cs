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
    public partial class PrintClassStudent : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public static PrintClassStudent printClassStudent;
        public PrintClassStudent()
        {
            printClassStudent = this;
            InitializeComponent();
        }

        private void PrintClassStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID=" + Program.ID_Year + "", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_PrintClassStudent report = new Report_PrintClassStudent();
            report.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PrintClassStudent";
                cmd.Parameters.AddWithValue("@IDClass", comboBox1.SelectedValue);
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
