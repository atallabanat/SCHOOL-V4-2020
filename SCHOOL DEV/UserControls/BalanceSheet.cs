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
    public partial class BalanceSheet : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void BalanceSheet_Load(object sender, EventArgs e)
        {
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox26.Text = "0";
            textBox29.Text = "0";
            textBox32.Text = "0";
            textBox35.Text = "0";
            textBox38.Text = "0";
            textBox41.Text = "0";
            textBox44.Text = "0";
            textBox47.Text = "0";
            textBox20.Text = "0";
            textBox52.Text = "0";
            textBox11.Text = "0";
            textBox3.Text = "0";
            textBox14.Text = "0";

            SqlDataAdapter dar = new SqlDataAdapter();
            dar = new SqlDataAdapter("select nnayear from addyear", con);
            DataSet dsr = new DataSet();
            dsr = new DataSet();
            dar.Fill(dsr);
            comboBox1.DataSource = dsr.Tables[0];
            comboBox1.DisplayMember = "nnayear";
            comboBox1.ValueMember = "nnayear";
            comboBox1.SelectedIndex = -1;







            //-----------------------------------------------------------------



            //------------------------------------------------------------

            con.Open();
            SqlCommand cmd3 = con.CreateCommand();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select summ from Paid ";
            cmd3.ExecuteNonQuery();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            con.Close();








            //----------------------------------------------------------------

            //------------------------------------------------------------

            con.Open();
            SqlCommand cmd4 = con.CreateCommand();
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select balancee from Paid where balancee>0";
            cmd4.ExecuteNonQuery();
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
            con.Close();








            //----------------------------------------------------------------
            //------------------------------------------------------------

            con.Open();
            SqlCommand cmd5 = con.CreateCommand();
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select salaryyear from Teacher ";
            cmd5.ExecuteNonQuery();
            da5.Fill(dt5);
            dataGridView5.DataSource = dt5;
            con.Close();








            //----------------------------------------------------------------

            int AD = 0;
            double a = 0, b = 0, c = 0, d = 0, ee = 0, g = 0, h = 0, f = 0;
            for (AD = 0; AD < dataGridView1.Rows.Count; ++AD)

            {
                a += Convert.ToDouble(dataGridView1.Rows[AD].Cells[0].Value);

                b += Convert.ToDouble(dataGridView1.Rows[AD].Cells[1].Value);

                c += Convert.ToDouble(dataGridView1.Rows[AD].Cells[2].Value);

                d += Convert.ToDouble(dataGridView1.Rows[AD].Cells[3].Value);

                ee += Convert.ToDouble(dataGridView1.Rows[AD].Cells[4].Value);

                g += Convert.ToDouble(dataGridView1.Rows[AD].Cells[5].Value);

                h += Convert.ToDouble(dataGridView1.Rows[AD].Cells[6].Value);

                f += Convert.ToDouble(dataGridView1.Rows[AD].Cells[7].Value);


            }
            textBox6.Text = a.ToString();
            textBox7.Text = b.ToString();
            textBox26.Text = c.ToString();
            textBox29.Text = d.ToString();
            textBox32.Text = ee.ToString();
            textBox35.Text = h.ToString();
            textBox38.Text = f.ToString();
            textBox41.Text = g.ToString();

            //-----------------------------------------------------------------------------------------

            int AS = 0;
            double ar = 0, br = 0;
            for (AS = 0; AS < dataGridView2.Rows.Count; ++AS)

            {
                ar += Convert.ToDouble(dataGridView2.Rows[AS].Cells[0].Value);

                br += Convert.ToDouble(dataGridView2.Rows[AS].Cells[1].Value);


            }
            textBox44.Text = ar.ToString();
            textBox47.Text = br.ToString();

            //---------------------------------------------------------------------------------------------


            int ASS = 0;
            double arr = 0;
            for (ASS = 0; ASS < dataGridView3.Rows.Count; ++ASS)

            {
                arr += Convert.ToDouble(dataGridView3.Rows[ASS].Cells[0].Value);


            }
            textBox3.Text = arr.ToString();


            //-----------------------------------------------------------------------------------------


            //---------------------------------------------------------------------------------------------

            //-----------------------------------------------------------------------------------------

            int ASSd = 0;
            double arrd = 0;
            for (ASSd = 0; ASSd < dataGridView4.Rows.Count; ++ASSd)

            {


                arrd += Convert.ToDouble(dataGridView4.Rows[ASSd].Cells[0].Value);


            }
            textBox14.Text = arrd.ToString();

            //---------------------------------------------------------------------------------------------


            int ASSdt = 0;
            double arrdt = 0;
            for (ASSdt = 0; ASSdt < dataGridView5.Rows.Count; ++ASSdt)

            {
                arrdt += Convert.ToDouble(dataGridView5.Rows[ASSdt].Cells[0].Value);


            }
            textBox11.Text = arrdt.ToString();

            //---------------------------------------------------------------------------------------------
            qwez();
            qwezqqq();
            aqwezqqq();
            aqwezqqq1();
            aqwezqqq2();

        }


        //------------------------- الجمع للنفقات الشهرية ---------------------------
        float a9 = 0;
        float a10 = 0;
        float a11 = 0;
        float a12 = 0;
        float a1 = 0;
        float a2 = 0;
        float a3 = 0;
        float a4 = 0;
        float t = 0;

        private void qwez()
        {

            a9 = float.Parse(textBox6.Text);
            a10 = float.Parse(textBox7.Text);
            a11 = float.Parse(textBox26.Text);
            a12 = float.Parse(textBox29.Text);
            a1 = float.Parse(textBox32.Text);
            a2 = float.Parse(textBox35.Text);
            a3 = float.Parse(textBox38.Text);
            a4 = float.Parse(textBox41.Text);


            t = a9 + a10 + a11 + a12 + a1 + a2 + a3 + a4;

            textBox50.Text = t.ToString();
        }
        float a = 0;
        float ab = 0;
        float ac = 0;

        private void qwezqqq()
        {

            a = float.Parse(textBox44.Text);
            ab = float.Parse(textBox47.Text);


            ac = a + ab;

            textBox4.Text = ac.ToString();
        }
        //------------------------------------------------------------------------------

        //------------------------- الطرح لليرادات الكاملة ---------------------------
        float xx = 0;
        float ax = 0;
        float axd = 0;

        private void aqwezqqq()
        {

            xx = float.Parse(textBox3.Text);
            ax = float.Parse(textBox14.Text);


            axd = xx - ax;

            textBox20.Text = axd.ToString();
        }
        //------------------------------------------------------------------------------
        //------------------------- مجموع نفقات  ---------------------------
        float xx1 = 0;
        float ax1 = 0;
        float ax2 = 0;
        float axd1 = 0;

        private void aqwezqqq1()
        {

            xx1 = float.Parse(textBox50.Text);
            ax1 = float.Parse(textBox4.Text);
            ax2 = float.Parse(textBox11.Text);

            axd1 = xx1 + ax1 + ax2;

            textBox52.Text = axd1.ToString();
        }
        //------------------------------------------------------------------------------
        //------------------------- صافي الدخل  ---------------------------
        float t5 = 0;
        float tt5 = 0;
        float ttt5 = 0;

        private void aqwezqqq2()
        {

            t5 = float.Parse(textBox20.Text);
            tt5 = float.Parse(textBox52.Text);

            ttt5 = t5 - tt5;

            textBox17.Text = ttt5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى تحديد العام للنفقات قبل الطباعة", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.s1;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 230, 0, newimage.Width, newimage.Height);


            e.Graphics.DrawString("قائمة صافي دخل المدرسة", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(310, 200));


            e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 220));


            e.Graphics.DrawString("ايرادات المدرسة :  " + textBox3.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 290));

            e.Graphics.DrawString("مجموع الذمم المدينة للطلاب :  " + textBox14.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 330));

            e.Graphics.DrawString("مجموع إيرادات المدرسة :  " + textBox20.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Red, new Point(520, 370));

            e.Graphics.DrawString("مجموع النفقات الشهرية :  " + textBox50.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 440));

            e.Graphics.DrawString("مجموع النفقات السنوية :  " + textBox4.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 480));

            e.Graphics.DrawString("رواتب الموظفين السنوية :  " + textBox11.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 520));

            e.Graphics.DrawString("المجموع العام للنفقات :  " + textBox52.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Red, new Point(520, 560));

            e.Graphics.DrawString("منظفات :  " + textBox6.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 290));

            e.Graphics.DrawString("محروقات :  " + textBox7.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 320));

            e.Graphics.DrawString("قرطاسية :  " + textBox26.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 350));

            e.Graphics.DrawString("صيانة :  " + textBox29.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 380));

            e.Graphics.DrawString("ضيافة :  " + textBox32.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 410));

            e.Graphics.DrawString("ماء :  " + textBox35.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 440));

            e.Graphics.DrawString("كهرباء :  " + textBox38.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 470));

            e.Graphics.DrawString("نثرية :  " + textBox41.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 500));

            e.Graphics.DrawString("تراخيص :  " + textBox44.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 550));

            e.Graphics.DrawString("تدفئة :  " + textBox47.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(90, 590));

            e.Graphics.DrawString("صافي دخل المدرسة :  " + textBox17.Text + "   دينار", new Font("Arial", 20, FontStyle.Bold), Brushes.Blue, new Point(220, 730));

            e.Graphics.DrawImage(newimage, 230, 830, newimage.Width, newimage.Height);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd122 = con.CreateCommand();
            DataTable dt122 = new DataTable();
            SqlDataAdapter da122 = new SqlDataAdapter(cmd122);
            cmd122.CommandType = CommandType.Text;
            cmd122.CommandText = "select a,b,c,d,e,f,g,h from exp where year='" + comboBox1.SelectedValue + "' ";
            cmd122.ExecuteNonQuery();
            da122.Fill(dt122);
            dataGridView1.DataSource = dt122;
            con.Close();




            //----------------------------------------------------------------

            //------------------------------------------------------------

            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select trk,tdf from expyear where datetdff='" + comboBox1.SelectedValue + "' ";
            cmd2.ExecuteNonQuery();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            con.Close();








            //----------------------------------------------------------------

            int AD = 0;
            double a = 0, b = 0, c = 0, d = 0, ee = 0, g = 0, h = 0, f = 0;
            for (AD = 0; AD < dataGridView1.Rows.Count; ++AD)

            {
                a += Convert.ToDouble(dataGridView1.Rows[AD].Cells[0].Value);

                b += Convert.ToDouble(dataGridView1.Rows[AD].Cells[1].Value);

                c += Convert.ToDouble(dataGridView1.Rows[AD].Cells[2].Value);

                d += Convert.ToDouble(dataGridView1.Rows[AD].Cells[3].Value);

                ee += Convert.ToDouble(dataGridView1.Rows[AD].Cells[4].Value);

                g += Convert.ToDouble(dataGridView1.Rows[AD].Cells[5].Value);

                h += Convert.ToDouble(dataGridView1.Rows[AD].Cells[6].Value);

                f += Convert.ToDouble(dataGridView1.Rows[AD].Cells[7].Value);


            }
            textBox6.Text = a.ToString();
            textBox7.Text = b.ToString();
            textBox26.Text = c.ToString();
            textBox29.Text = d.ToString();
            textBox32.Text = ee.ToString();
            textBox35.Text = h.ToString();
            textBox38.Text = f.ToString();
            textBox41.Text = g.ToString();


            qwez();
            //-----------------------------------------------------------------------------------------

            //-----------------------------------------------------------------------------------------

            int AS = 0;
            double ar = 0, br = 0;
            for (AS = 0; AS < dataGridView2.Rows.Count; ++AS)

            {
                ar += Convert.ToDouble(dataGridView2.Rows[AS].Cells[0].Value);

                br += Convert.ToDouble(dataGridView2.Rows[AS].Cells[1].Value);


            }
            textBox44.Text = ar.ToString();
            textBox47.Text = br.ToString();
            qwezqqq();
            aqwezqqq2();
            aqwezqqq1();
            aqwezqqq();
            //---------------------------------------------------------------------------------------------
        }
        //------------------------------------------------------------------------------

    }


}
