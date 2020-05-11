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

namespace SCHOOL_DEV
{
    public partial class home : Form
    {
        int panelWidth;
        bool isCollapsed;
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public static home home2;

        public home()
        {
            home2 =this ;
            InitializeComponent();
            panelWidth = panel1.Width;
            isCollapsed = false;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width = panel1.Width + 10;

                if (panel1.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btn_Side_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //------------ الشريط المتحرك بجانب الزر ---------------------//
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;



        }
        //---------------------------------------------------------------//
        //--------------------------الصفحات المتنقلة ------------------------//
        public void addControlsTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);

        }

        //public void addControlsTopanel2(Form c)
        //{
        //    c.Dock = DockStyle.Fill;
        //    c.TopLevel = false;
        //    c.FormBorderStyle = FormBorderStyle.None;
        //    panel5.Controls.Clear();
        //    panel5.Controls.Add( c);

        //}
        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);

            UC_Home ssa = new UC_Home();
            addControlsTopanel(ssa);
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_student);
            panelstud.Visible = true;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_emp);
            paneltech.Visible = true;
        }

        private void btn_class_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_class);
            panelclass.Visible = true;
        }

        private void btn_dollar_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_dollar);
            paneldollar.Visible = true;

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_print);
            panel_printer.Visible = true;

        }

        private void btn_cell_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_cell);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_help);
            AboutSystem ssa = new AboutSystem();
            addControlsTopanel(ssa);
        }

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    //DateTime dt = DateTime.Now;
        //    //lbl_date.Text = DateTime.Now.ToShortDateString();

        //    //lbl_time.Text = dt.ToString("HH:MM:ss");

        //}

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
        }

        private void btn_student_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_student);
        }

        private void btn_emp_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_emp);
        }

        private void btn_class_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_class);
        }

        private void btn_dollar_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_dollar);
        }

        private void btn_print_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_print);
        }

        private void btn_cell_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_cell);
        }

        private void btn_help_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_help);
        }
        private void home_MouseHover(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            paneltech.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelstud.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelclass.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            paneldollar.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;
        }

        private void student_dollar_Click(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel_teach_salary.Visible = false;
        }

        private void teach_dollar_Click(object sender, EventArgs e)
        {
            panel_teach_salary.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel_add_exp_year.Visible = false;
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            panel_add_exp_year.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel_printer.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel_mune_paid.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel_mune_paid.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel_mune_student.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_mune_student.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel_ss.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel_ss.Visible = true;
        }

        private void panel_Paid_quary_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel_Paid_quary_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel_Paid_quary_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel_Paid_quary_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void panel_Paid_quary_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panelControls_MouseHover(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;

        }

        private void panelstud_MouseHover(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;

        }

        private void paneldollar_MouseHover(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            panel_teach_salary.Visible = false;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            panel_mune_paid.Visible = false;
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            panel_mune_student.Visible = false;
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            panel_ss.Visible = false;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            panel_add_exp_year.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            paneltech.Visible = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            panelclass.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panelstud.Visible = false;
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            paneltech.Visible = false;
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            panelclass.Visible = false;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            panel_printer.Visible = false;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            paneldollar.Visible = false;
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;
        }

        private void pictureBox6_Click_3(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;
        }

        private void pictureBox7_Click_2(object sender, EventArgs e)
        {
            panel_teach_salary.Visible = false;
        }

        private void student_dollar_Click_1(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=11", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_Paid_quary.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 11", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------
            
        }

        private void pictureBox6_Click_4(object sender, EventArgs e)
        {
            panel_Paid_quary.Visible = false;
        }

        private void teach_dollar_Click_1(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=12", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_teach_salary.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 12", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void pictureBox7_Click_3(object sender, EventArgs e)
        {
            panel_teach_salary.Visible = false;
        }

        private void btn_exp_Click_1(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=14", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_add_exp_year.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 14", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------
            
        }

        private void pictureBox8_Click_2(object sender, EventArgs e)
        {
            panel_add_exp_year.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=15", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_mune_paid.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 15", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

            
        }

        private void pictureBox10_Click_2(object sender, EventArgs e)
        {
            panel_mune_paid.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=16", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_mune_student.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 16", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

            
        }

        private void pictureBox11_Click_2(object sender, EventArgs e)
        {
            panel_mune_student.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=19", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    panel_ss.Visible = true;
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 19", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------
           
        }

        private void pictureBox12_Click_2(object sender, EventArgs e)
        {
            panel_ss.Visible = false;
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {

            //---------------------------- -----اضافة طالب-------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=2", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    add_student ssa = new add_student();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة","الصلاحيات 2",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------



        }

        private void btn_quary_student_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=3", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    quary_student ssa = new quary_student();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_all_student_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=4", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    ALLStudent ssa = new ALLStudent();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_add_tech_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=5", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    add_Teacher ssa = new add_Teacher();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 5", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_quary_tech_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=6", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    quary_Teacher ssa = new quary_Teacher();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 6", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------



        }

        private void btn_all_tech_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=7", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    ALL_Teacher ssa = new ALL_Teacher();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 7", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD_Paid ssa = new ADD_Paid();
            addControlsTopanel(ssa);
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=8", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    ADD_class ssa = new ADD_class();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 8", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_quary_class_Click(object sender, EventArgs e)
        {


            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=9", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    quary_class ssa = new quary_class();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 9", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_all_class_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=10", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    ALL_class ssa = new ALL_class();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 10", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void button1_Click(object sender, EventArgs e)
        {
            quary_paid ssa = new quary_paid();
            addControlsTopanel(ssa);
        }

        private void btn_salay_daman_Click(object sender, EventArgs e)
        {
            PaidKA ssa = new PaidKA();
            addControlsTopanel(ssa);
        }

        private void btn_quary_salary_Click(object sender, EventArgs e)
        {
            quary_salary ssa = new quary_salary();
            addControlsTopanel(ssa);
        }

        private void btn_reveune_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=13", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    reveuneSChool ssa = new reveuneSChool();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 13", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void btn_add_exp_month_Click(object sender, EventArgs e)
        {
            UCReveune ssa = new UCReveune();
            addControlsTopanel(ssa);
        }

        private void btn_add_exp_year_Click(object sender, EventArgs e)
        {
            UCExpancess ssa = new UCExpancess();
            addControlsTopanel(ssa);
        }

        private void btn_qury_month_Click(object sender, EventArgs e)
        {
            Quary_UCRevenue ssa = new Quary_UCRevenue();
            addControlsTopanel(ssa);
        }

        private void btn_quary_year_Click(object sender, EventArgs e)
        {
            Quary_UCExpancess ssa = new Quary_UCExpancess();
            addControlsTopanel(ssa);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=17", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    AP ssa = new AP();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 17", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=18", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    quary_salary ssa = new quary_salary();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 18", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Quary_UCRevenue ssa = new Quary_UCRevenue();
            addControlsTopanel(ssa);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Quary_UCExpancess ssa = new Quary_UCExpancess();
            addControlsTopanel(ssa);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=20", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    EndSalary ssa = new EndSalary();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 20", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------


        }

        private void button12_Click(object sender, EventArgs e)
        {
            PrintAllPaid ssa = new PrintAllPaid();
            addControlsTopanel(ssa);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PrintNamePaid ssa = new PrintNamePaid();
            addControlsTopanel(ssa);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintClassPaid ssa = new PrintClassPaid();
            addControlsTopanel(ssa);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PrintDatePaid ssa = new PrintDatePaid();
            addControlsTopanel(ssa);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PrintAllStudent ssa = new PrintAllStudent();
            addControlsTopanel(ssa);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PrintNameStudent ssa = new PrintNameStudent();
            addControlsTopanel(ssa);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PrintClassStudent ssa = new PrintClassStudent();
            addControlsTopanel(ssa);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=23", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    addYear ssa = new addYear();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 23", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


            
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=22", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {
                    //-------------------------------------------------------------------------------------------------------------------------------------------

                    
                    SqlCommand cmd2 = new SqlCommand("select * from Paid where balancee>0", con);
                    SqlDataReader dr2;
                    dr2 = cmd2.ExecuteReader();
                    int count2 = 0;
                    while (dr2.Read())
                    {
                        count2 += 1;

                    }
                    if (count2 == 1)
                    {
                        if (MessageBox.Show("يوجد ذمم مدينة ! هل أنت متأكد من تجديد السنة المالية", "سنة مالية جديدة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {




                    
                            cmd2.CommandType = CommandType.Text;

                            cmd2.CommandText = "update Paid set  Paid9=0 , PaidDate9=0 ,Paid10=0,PaidDate10=0,Paid11=0,PaidDate11=0,Paid12=0,PaidDate12=0,Paid1=0,PaidDate1=0,Paid2=0,PaidDate2=0,Paid3=0,PaidDate3=0,Paid4=0,PaidDate4=0,Paid5=0,PaidDate5=0,Paid6=0,PaidDate6=0,balancee=summ  ";
                            cmd2.ExecuteNonQuery();
                            


                            MessageBox.Show("تم تجديد سنة مالية جديدة بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else if (count2 > 0)
                    {
                        if (MessageBox.Show("يوجد ذمم مدينة ! هل أنت متأكد من تجديد السنة المالية ", "سنة مالية جديدة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {




                            
                            cmd2.CommandType = CommandType.Text;

                            cmd2.CommandText = "update Paid set  Paid9=0 , PaidDate9=0 ,Paid10=0,PaidDate10=0,Paid11=0,PaidDate11=0,Paid12=0,PaidDate12=0,Paid1=0,PaidDate1=0,Paid2=0,PaidDate2=0,Paid3=0,PaidDate3=0,Paid4=0,PaidDate4=0,Paid5=0,PaidDate5=0,Paid6=0,PaidDate6=0,balancee=summ  ";
                            cmd2.ExecuteNonQuery();
                            


                            MessageBox.Show("تم تجديد سنة مالية جديدة بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                    }
                    else
                    {
                        
                        cmd2.CommandType = CommandType.Text;

                        cmd2.CommandText = "update Paid set  Paid9=0 , PaidDate9=0 ,Paid10=0,PaidDate10=0,Paid11=0,PaidDate11=0,Paid12=0,PaidDate12=0,Paid1=0,PaidDate1=0,Paid2=0,PaidDate2=0,Paid3=0,PaidDate3=0,Paid4=0,PaidDate4=0,Paid5=0,PaidDate5=0,Paid6=0,PaidDate6=0,balancee=summ  ";
                        cmd2.ExecuteNonQuery();
                        


                        MessageBox.Show("لا يوجد ذمم مدينة تم تجديد سنة مالية جديدة بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 22", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------



        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {


            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=21", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {

                    UP ssa = new UP();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 21", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------
        }

        private void home_Load(object sender, EventArgs e)
        {
            label7.Text = Login.Recby;
      

            UC_Home ssa = new UC_Home();
            addControlsTopanel(ssa);


            label3.Text =Program.School_Name;
            label5.Text = Program.School_Name;

        }


        private void button13_Click(object sender, EventArgs e)
        {
            Login ss = new Login();
            this.Close();
            ss.Show();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            //---------------------------- ---------------------------------------------------------
            SqlDataReader ddr;
            SqlCommand ccmd = new SqlCommand("select Priv_Display from TB_Priv where Priv_User_ID=" + Convert.ToInt32(Program.user_ID) + " and Priv_Screen_ID=1", con);
            con.Open();
            ddr = ccmd.ExecuteReader();
            if (ddr.Read())
            {
                if (ddr["Priv_Display"].ToString() == "True")
                {


                    UCSettings ssa = new UCSettings();
                    addControlsTopanel(ssa);
                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد لديك صلاحية للدخول الى هذه الشاشة", "الصلاحيات 1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            ddr.Close();
            con.Close();

            //---------------------------------------------------------------------------------------


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_date.Text = DateTime.Now.ToShortDateString();

            lbl_time.Text = dt.ToString("HH:MM:ss");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //---------------------------------------------------------------//



    }
}
