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
    public partial class PrintNamePaid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public static PrintNamePaid PrintNamePaid1;

        public PrintNamePaid()
        {
            PrintNamePaid1 = this;
            InitializeComponent();
        }

        private void PrintNamePaid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from student where YaerSemesterID="+Program.ID_Year+"", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;
            }
            catch(Exception ex)
            {

            }
        }
        private void TotalSumStudent(int ID_Student)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select PaidTotal as TotalSumStudent from student where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", ID_Student);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox_s.Text = dr["TotalSumStudent"].ToString();
                }
            }
            catch (Exception ex)
            {
                textBox_s.Text = "0";
            }
            finally
            {
                con.Close();
            }
        }
        private void TotalAmount(int ID_Student)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(AmountPaid) as TotalAmount  from Paid where ID_Student=@ID_Student", con);
                cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox_K.Text = dr["TotalAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                textBox_K.Text = "0";
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
                Report_PrintNamePaid report = new Report_PrintNamePaid();
                report.Show();
            }
            //if (comboBox1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("يرجى تحديد اسم الطالب للطباعة", "تعبئة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else
            //{
            //    DGVPrinter printer = new DGVPrinter();
            //    printer.Title = "  كشف رسوم الطالب  " + comboBox1.SelectedValue.ToString();
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
        private void RestAmount()
        {
            try
            {
                if (textBox_s.Text != string.Empty && textBox_K.Text != string.Empty)
                {
                    double TotalSumStudent = Convert.ToDouble(textBox_s.Text);
                    double TotalAmount = Convert.ToDouble(textBox_K.Text);
                    double RestAmount = TotalSumStudent - TotalAmount;
                    textBox_B.Text = RestAmount.ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    SqlCommand cmd = con.CreateCommand();

                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_PrintName1";
                    cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();
                    TotalSumStudent(Convert.ToInt32(comboBox1.SelectedValue));
                    TotalAmount(Convert.ToInt32(comboBox1.SelectedValue));
                    RestAmount();
                }
            }
            catch(Exception ex)
            {
                con.Close();
            }
            finally
            {

            }
            
        }
    }
}
