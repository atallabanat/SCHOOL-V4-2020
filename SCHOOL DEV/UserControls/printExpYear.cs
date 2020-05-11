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

namespace SCHOOL_DEV.UserControls
{
    public partial class printExpYear : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public printExpYear()
        {
            InitializeComponent();
        }

        private void printExpYear_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select nnayear from addyear", con);
            ds = new DataSet();
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nnayear";
            comboBox1.ValueMember = "nnayear";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select trk,tdf from expyear where datetdff='" + comboBox1.SelectedValue + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى تحديد العام للطباعة", "تعبئة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "  كشف النفقات السنوية  " + comboBox1.SelectedValue.ToString();
                printer.SubTitle = string.Format("date:{0}", DateTime.Now.Date);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = Program.School_Name;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
            }
        }
    }
}
