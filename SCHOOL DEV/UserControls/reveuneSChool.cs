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
    public partial class reveuneSChool : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public reveuneSChool()
        {
            InitializeComponent();
        }

        private void reveuneSChool_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(AmountPaid) as TotalAmount  from Paid where YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label3.Text = dr["TotalAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                label3.Text = "0";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
