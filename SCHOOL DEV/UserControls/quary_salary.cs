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
    public partial class quary_salary : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);


        public quary_salary()
        {
            InitializeComponent();
        }
        private void SelectJobEmp()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select JobName,salary from Teacher where ID=@ID and  YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@ID", comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textJobName.Text = dr["JobName"].ToString();
                    textSalary.Text = dr["salary"].ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
        private void selectGridDataEmp()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT        PaidKA.ID, PaidKA.IDTeacher, Teacher.name, PaidKA.StartDateOnAccount, PaidKA.AmountOnAccount, PaidKA.AmountMonthly, PaidKA.AmountMonthlyGuarantee,  Teacher.salary
                                    FROM            Teacher INNER JOIN
                                    PaidKA ON Teacher.ID = PaidKA.IDTeacher where PaidKA.IDTeacher=@IDTeacher and PaidKA.YaerSemesterID=@YaerSemesterID order by PaidKA.ID";
                cmd.Parameters.AddWithValue("@IDTeacher", comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                TotalAmountSalary();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

        }
        private void TotalAmountSalary()
        {
            try
            {

                double Salary = 0;
                if (textSalary.Text != string.Empty)
                {
                    Salary = Convert.ToDouble(textSalary.Text);
                }
                double AmountMonthly = 0;
                double AmountMonthlyGuarantee = 0;
                try
                {


                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            AmountMonthly += Convert.ToDouble(dataGridView1.Rows[i].Cells[clmAmountMonthly.Name].Value);
                            AmountMonthlyGuarantee += Convert.ToDouble(dataGridView1.Rows[i].Cells[clmAmountMonthlyGuarantee.Name].Value);
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    double Total = 0;
                    Total = Salary - AmountMonthly - AmountMonthlyGuarantee;
                    textAmountSalary.Text = Total.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void comboNameEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectJobEmp();
            selectGridDataEmp();
        }

        private void quary_salary_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,name from Teacher where YaerSemesterID=" + Program.ID_Year + "", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboNameEmp.DataSource = ds.Tables[0];
                comboNameEmp.DisplayMember = "name";
                comboNameEmp.ValueMember = "ID";
                comboNameEmp.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
