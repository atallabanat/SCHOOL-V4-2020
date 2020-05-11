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
    public partial class UP : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public UP()
        {
            InitializeComponent();
        }

        private void UP_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID=" + Program.ID_Year + "", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;

                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID=" + Program.ID_Year + "", con);
                ds = new DataSet();
                da.Fill(ds);
                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "ID";
                comboBox2.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
                {
                    msg.Alert("يرجى تحديد حقل الترفيع من و الى",Form_Alert.enumType.Error);                    
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update student set  IDClass=@IDClass2  ,Class=@Class where IDClass=@IDClass and YaerSemesterID=@YaerSemesterID";
                    cmd.Parameters.AddWithValue("@IDClass",comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@IDClass2", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@Class", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();

                    msg.Alert("تم الترفيع بنجاح",Form_Alert.enumType.Success);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
