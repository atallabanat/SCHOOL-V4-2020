
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DEV
{
    public partial class Login : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        msgShow msg = new msgShow();
        public Login()
        {
            this.KeyPreview = true;

            try
            {
                //Thread trd = new Thread(new ThreadStart(formRun));
                //trd.Start();
                //Thread.Sleep(5000);

                InitializeComponent();
                //trd.Abort();
            }
            catch(Exception ex)
            {

            }
        }
        private void formRun()
        {
            //Application.Run(new start());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public static string username;
        public static string Recby
        {
            get { return username; }
            set { username = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_User where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                    Program.user_ID = dr[0].ToString();
                }
                if (count == 1)
                {
                    Program.ID_Year =Convert.ToInt32( comboBox2.SelectedValue);
                    Recby = textBox1.Text;
                    this.Hide();
                    home fm = new home();
                    fm.Show();

                }
                else if (count > 0)
                {
                    MessageBox.Show("err");

                }
                else
                {
                    msg.Alert("اسم المستخدم وكلمة المرور غير صحيحه", Form_Alert.enumType.Error);

                }
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch(Exception)
            {
                msg.Alert("لا يوجد إتصال بالانترنت الرجاء التأكد من إتصال الإنترنت ",Form_Alert.enumType.Error);
            }
            finally
            {
                con.Close();
            }
        }
        //private void register()
        //{
        //    string id = ComputerInfo.GetComputerId();
        //    KeyManager km = new KeyManager(id);
        //    LicenseInfo lic = new LicenseInfo();
        //    int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Path.GetPathRoot(Environment.SystemDirectory)), ref lic);
        //    string ProductKey = lic.ProductKey;
        //    if (km.ValidKey(ref ProductKey))
        //    {
        //        KeyValuesClass kv = new KeyValuesClass();
        //        if (km.DisassembleKey(ProductKey, ref kv))
        //        {
                    
        //        }
        //        else
        //        {
        //            this.Hide();
        //            ActivationKey activationKey = new ActivationKey();
        //            activationKey.Show();
        //        }
        //    }
        //    else
        //    {
        //        this.Hide();
        //        ActivationKey activationKey = new ActivationKey();
        //        activationKey.Show();
        //    }
        //}
        private void Login_Load(object sender, EventArgs e)
        {

            //register();
            label6.Text = Program.School_Name;
            Year();
            Semester();

            try
            {

                con.Open();
                SqlCommand cmd2 = new SqlCommand("select School_Name from comf where id=1 ", con);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    Program.School_Name = dr2["School_Name"].ToString();
                    label6.Text = Program.School_Name;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Year()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                string sql = @"select ID,YearName from Tbl_Year order by ID Desc";
                da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "YearName";
                comboBox1.ValueMember = "ID";



             
            }
            catch(Exception ex)
            {

            }
        }
        private void Semester()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                string sql = "SELECT  YaerSemester.ID, YaerSemester.ID_Year, YaerSemester.ID_Semester, Tbl_Semester.Name_Semester  FROM  YaerSemester INNER JOIN Tbl_Year ON YaerSemester.ID_Year = Tbl_Year.ID INNER JOIN Tbl_Semester ON YaerSemester.ID_Semester = Tbl_Semester.ID_Semester where YaerSemester.ID_Year="+comboBox1.SelectedValue+" ORDER BY YaerSemester.ID asc";
                da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "Name_Semester";
                comboBox2.ValueMember = "ID";




            }
            catch (Exception ex)
            {

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Semester();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
