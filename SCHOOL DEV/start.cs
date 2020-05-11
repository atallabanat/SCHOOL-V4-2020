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

namespace SCHOOL_DEV
{
    public partial class start : Form
    {
        int move=2;
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select School_Name from comf where id=1 ", con);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    Program.School_Name = dr2["School_Name"].ToString();
                    label6.Text = Program.School_Name;
                }
                con.Close();
            }
            catch(Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                panel2.Width += 2;

                if (panel2.Width > 400)
                {
                    panel2.Width = 0;

                }

                if (panel2.Width < 0)
                {
                    move = 0;

                }
            }
            catch
            {

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
