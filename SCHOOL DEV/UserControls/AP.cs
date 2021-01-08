using SCHOOL_DEV.Report;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCHOOL_DEV.UserControls
{
    public partial class AP : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public static AP aP;
        public int FlagPaid;
        public int FlagStudent;
        public AP()
        {
            aP = this;
            InitializeComponent();
        }
        private void VFlagStudent()
        {
            try
            {
                if (checkStudent.Checked == true)
                {
                    FlagStudent = 1;
                    combo_Student.Enabled = false;
                }
                else
                {
                    FlagStudent = 0;
                    combo_Student.Enabled = true;
                }
            }
            catch
            {
                FlagStudent = 1;
            }
        }
        private void VFlagPaid()
        {
            try
            {
                if (checkPaid.Checked == true)
                {
                    FlagPaid = 0;
                    combo_From.Enabled = false;
                    combo_To.Enabled = false;
                }
                else
                {
                    FlagPaid = 1;
                    combo_From.Enabled = true;
                    combo_To.Enabled = true;
                }
            }
            catch
            {
                FlagPaid = 0;
            }
        }
        void LoadClass()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID=" + Program.ID_Year + "", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                cmbClass.DataSource = ds.Tables[0];
                cmbClass.DisplayMember = "Name";
                cmbClass.ValueMember = "ID";
                cmbClass.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void AP_Load(object sender, EventArgs e)
        {
            try
            {
                VFlagPaid();
                VFlagStudent();
                LoadClass();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select * from PaidName where ID <> 0 ", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                combo_From.DataSource = ds.Tables[0];
                combo_From.DisplayMember = "Name";
                combo_From.ValueMember = "ID";
                combo_From.SelectedIndex = -1;


                SqlDataAdapter da2 = new SqlDataAdapter();
                da2 = new SqlDataAdapter("select * from PaidName where ID <> 0 ", con);
                DataSet ds2 = new DataSet();
                ds2 = new DataSet();
                da2.Fill(ds2);
                combo_To.DataSource = ds2.Tables[0];
                combo_To.DisplayMember = "Name";
                combo_To.ValueMember = "ID";
                combo_To.SelectedIndex = -1;

                SqlDataAdapter da3 = new SqlDataAdapter();
                da3 = new SqlDataAdapter("select ID,Name from student where YaerSemesterID=" + Program.ID_Year + " ", con);
                DataSet ds3 = new DataSet();
                ds3 = new DataSet();
                da3.Fill(ds3);
                combo_Student.DataSource = ds3.Tables[0];
                combo_Student.DisplayMember = "Name";
                combo_Student.ValueMember = "ID";
                combo_Student.SelectedIndex = -1;

            }
            catch
            {

            }

        }

        private void checkPaid_CheckedChanged(object sender, EventArgs e)
        {
            VFlagPaid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VFlagPaid();
            VFlagStudent();
            Search();
        }
        private void Search()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPAccountPaypal";
                cmd.Parameters.AddWithValue("@Flag", FlagStudent);
                if (FlagPaid == 0)
                {
                    cmd.Parameters.AddWithValue("@IDPaidFrom", "1");
                    cmd.Parameters.AddWithValue("@IDPaidTo", "9");
                    if (combo_Student.SelectedValue != null)
                    {
                        cmd.Parameters.AddWithValue("@IDStudent", combo_Student.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDStudent", "0");
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDPaidFrom", combo_From.SelectedValue);
                    cmd.Parameters.AddWithValue("@IDPaidTo", combo_To.SelectedValue);
                    if (combo_Student.SelectedValue != null)
                    {
                        cmd.Parameters.AddWithValue("@IDStudent", combo_Student.SelectedValue);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDStudent", "0");
                    }
                }
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                if (!checkBox1.Checked)
                {
                    cmd.Parameters.AddWithValue("@DateFrom", DateTime.Now.AddYears( - 200));
                    cmd.Parameters.AddWithValue("@DateTo", DateTime.Now);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateFrom", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@DateTo", dateTimePicker2.Value);
                }
                if (!checkBox2.Checked)
                {
                    cmd.Parameters.AddWithValue("@IDClass", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IDClass", cmbClass.SelectedValue);
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;


            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
        private void checkStudent_CheckedChanged(object sender, EventArgs e)
        {
            VFlagStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_AP report = new Report_AP();
            report.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                }
                else
                {
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked)
                {
                    cmbClass.Enabled = true;
                }
                else
                {
                    cmbClass.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
