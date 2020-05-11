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
    public partial class Quary_UCExpancess : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public Quary_UCExpancess()
        {
            InitializeComponent();
        }


        private void Quary_UCExpancess_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from ExpensesName where YaerSemesterID=" + Program.ID_Year + " ", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                combo_E.DataSource = ds.Tables[0];
                combo_E.DisplayMember = "Name";
                combo_E.ValueMember = "ID";
                combo_E.SelectedIndex = -1;
                Load1();
            }
            catch
            {

            }
        }
        private void Load1()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UCExpancess where YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                combo_E.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UCExpancess where IDName=@IDName and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@IDName",combo_E.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                combo_E.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UCExpancess where convert(nvarchar(10), Date,110)=@Date and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("MM-dd-yyyy"));
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                combo_E.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}
