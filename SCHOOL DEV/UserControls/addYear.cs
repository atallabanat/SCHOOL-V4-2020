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
    public partial class addYear : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public addYear()
        {
            InitializeComponent();
        }

        private void addYear_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("(يرجى ادخال (اسم العام الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into addyear values ('" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();





                MessageBox.Show("تم إضافة العام الدراسي بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                con.Close();
                textBox1.Text = "";
            }
        }
    }
}
