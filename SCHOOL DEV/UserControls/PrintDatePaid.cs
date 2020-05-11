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

    public partial class PrintDatePaid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public static PrintDatePaid printDatePaid;
        public PrintDatePaid()
        {
            printDatePaid = this;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Report_PrintDatePaid report = new Report_PrintDatePaid();
            report.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PrintDatePaid";
                cmd.Parameters.AddWithValue("@Date1", dateTimePicker1.Value.ToString("MM-dd-yyyy"));
                cmd.Parameters.AddWithValue("@Date2", dateTimePicker2.Value.ToString("MM-dd-yyyy"));
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                if(dt.Rows.Count <= 0)
                {
                    msg.Alert("لا يوجد بيانات خلال هذه الفترة",Form_Alert.enumType.Info);
                }
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
