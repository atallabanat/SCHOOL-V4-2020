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
    public partial class PrintClassPaid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public static PrintClassPaid printClassPaid;
        public PrintClassPaid()
        {
            printClassPaid = this;
            InitializeComponent();
        }

        private void PrintClassPaid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID="+Program.ID_Year+"", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PrintClassPaid";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.Parameters.AddWithValue("@IDClass", comboBox1.SelectedValue);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
               //msg.Alert("حدث خطأ بسيط يرجى إعادة المحاولة" + ex.Message, Form_Alert.enumType.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Report_PrintClassPaid report = new Report_PrintClassPaid();
                report.Show();
            }
            //if (comboBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("يرجى تحديد الصف الدراسي للطباعة", "تعبئة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    DGVPrinter printer = new DGVPrinter();
            //    printer.Title = "  كشف رسوم طلاب الصف " + comboBox1.SelectedValue.ToString();
            //    printer.SubTitle = string.Format("date:{0}", DateTime.Now.Date);
            //    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //    printer.PageNumbers = true;
            //    printer.PageNumberInHeader = false;
            //    printer.PorportionalColumns = true;
            //    printer.HeaderCellAlignment = StringAlignment.Near;
            //    printer.Footer = Program.School_Name;
            //    printer.FooterSpacing = 15;
            //    printer.PrintDataGridView(dataGridView1);
            //}
        }
    }
}
