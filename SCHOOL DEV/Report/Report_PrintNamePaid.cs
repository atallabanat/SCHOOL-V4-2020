using Microsoft.Reporting.WinForms;
using SCHOOL_DEV.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DEV.Report
{
    public partial class Report_PrintNamePaid : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public Report_PrintNamePaid()
        {
            InitializeComponent();
        }

        private void Report_PrintNamePaid_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                DataSet1 m = new DataSet1();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SP_PrintName1";
                cmd.Parameters.AddWithValue("@ID_Student", PrintNamePaid.PrintNamePaid1.comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(m, m.Tables[0].TableName);

                ReportDataSource reportDataSource = new ReportDataSource("DS_SP_PrintName1", m.Tables[0]);



                //--------------------------------------------------------------------------------------------------------


                //SP_PictureCompany ms2 = new SP_PictureCompany();
                DataSet1 m2 = new DataSet1();
                con.Close();
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.CommandText = "SP_PictureCompany";
                cmd2.Parameters.AddWithValue("@ID", 1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(m2, m2.Tables[0].TableName);




                
                
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                ReportDataSource reportDataSource2 = new ReportDataSource("DS_img", m2.Tables[0]);
                //-------------------------------------------------------------------------------
                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new ReportParameter("NameStudent",PrintNamePaid.PrintNamePaid1.comboBox1.Text),
                    new ReportParameter("SumPaid",PrintNamePaid.PrintNamePaid1.textBox_K.Text),
                    new ReportParameter("SumStudent",PrintNamePaid.PrintNamePaid1.textBox_s.Text),
                    new ReportParameter("RestAmount",PrintNamePaid.PrintNamePaid1.textBox_B.Text)
                };
                this.reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);

                this.reportViewer1.RefreshReport();
                con.Close();
            }
            catch (Exception ex)

            {

            }

        }
    }
}
