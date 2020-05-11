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
    public partial class quary_paid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        int count = 0;

        public quary_paid()
        {
            InitializeComponent();
        }

        private void quary_paid_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = con.CreateCommand();

            //con.Open();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Paid";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            //con.Close();
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select name,Paid7,PaidDate7,Paid8,PaidDate8,Paid9,PaidDate9,Paid10,PaidDate10,Paid11,PaidDate11,Paid12,PaidDate12,Paid1,PaidDate1,Paid2,PaidDate2,Paid3,PaidDate3,Paid4,PaidDate4,Paid5,PaidDate5,Paid6,PaidDate6 from Paid where name like'%" + textBox9.Text + "%'";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //count = Convert.ToInt32(dt.Rows.Count.ToString());
            //dataGridView1.DataSource = dt;
            //con.Close();
        }



//        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
//        {
//            con.Open();
//            SqlCommand cmd = con.CreateCommand();
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandText = "set DATEFORMAT ymd select name,Paid7,PaidDate7,Paid8,PaidDate8,Paid9,PaidDate9,Paid10,PaidDate10,Paid11,PaidDate11,Paid12,PaidDate12,Paid1,PaidDate1,Paid2,PaidDate2,Paid3,PaidDate3,Paid4,PaidDate4,Paid5,PaidDate5,Paid6,PaidDate6,summ,balancee,agg,class from Paid"
//+ " where  cast(convert(nvarchar(10),  PaidDate1,111) as datetime)  =     cast(convert(nvarchar(10),'" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate2,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ " or cast(convert(nvarchar(10),  PaidDate3,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate4,111) as datetime)  =     cast(convert(nvarchar(10),'" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate5,111) as datetime)  =     cast(convert(nvarchar(10),'" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate6,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate7,111) as datetime)  =     cast(convert(nvarchar(10),'" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate8,111) as datetime)  =     cast(convert(nvarchar(10),  '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate9,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate10,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate11,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) "
//+ "or cast(convert(nvarchar(10),  PaidDate12,111) as datetime)  =     cast(convert(nvarchar(10), '" + dateTimePicker1.Value + "',111) as datetime) ";


//            cmd.ExecuteNonQuery();
//            DataTable dt = new DataTable();
//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            da.Fill(dt);
//            count = Convert.ToInt32(dt.Rows.Count.ToString());
//            dataGridView1.DataSource = dt;



//            con.Close();
//        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select B.*,(B.TotalSumStudent-B.TotalAmount) as RestAmount,(select class from student where ID=B.ID_Student) as NameClass
                                from
                                (										
                                select A.*,(select sum(AmountPaid)  from Paid where  ID_Student=A.ID_Student)as TotalAmount,(select PaidTotal from student where ID=A.ID_Student) as TotalSumStudent
                                from
                                (										
                                select IDPaid,ID_Student,Name_Student,NamePaid,AmountPaid,DateAmount 
                                from paid
                                where DateAmount= '" + dateTimePicker1.Value.ToShortDateString()+ "' and YaerSemesterID=" + Program.ID_Year + ")A)B order by IDPaid";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch(Exception ex)
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
                SqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select B.*,(B.TotalSumStudent-B.TotalAmount) as RestAmount,(select class from student where ID=B.ID_Student) as NameClass
                                from
                                (										
                                select A.*,(select sum(AmountPaid)  from Paid where  ID_Student=A.ID_Student)as TotalAmount,(select PaidTotal from student where ID=A.ID_Student) as TotalSumStudent
                                from
                                (										
                                select IDPaid,ID_Student,Name_Student,NamePaid,AmountPaid,DateAmount 
                                from paid
                                where Name_Student like '%" + textBox9.Text + "%' and YaerSemesterID="+Program.ID_Year+ ")A)B order by IDPaid";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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
