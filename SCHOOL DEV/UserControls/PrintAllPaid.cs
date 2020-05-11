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
    public partial class PrintAllPaid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        msgShow msg = new msgShow();

        public PrintAllPaid()
        {
            InitializeComponent();
        }

        private void PrintAllPaid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PrintAllPaid";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                msg.Alert("حدث خطأ بسيط يرجى إعادة المحاولة"+ex.Message,Form_Alert.enumType.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DGVPrinter printer = new DGVPrinter();
            //printer.Title = "كشف رسوم جميع الطلاب";
            //printer.SubTitle = string.Format("date:{0}", DateTime.Now.Date);
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = Program.School_Name;
            //printer.FooterSpacing = 15;
            //printer.PrintDataGridView(dataGridView1);
            Report_PrintAllStudent report = new Report_PrintAllStudent();
            report.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintAllPaid_Load(sender, e);
        }
    }
}
