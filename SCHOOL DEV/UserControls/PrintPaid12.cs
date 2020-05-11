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
    public partial class PrintPaid12 : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public PrintPaid12()
        {
            InitializeComponent();
        }

        private void PrintPaid12_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select name from Paid ", con);
            DataSet ds = new DataSet();
            ds = new DataSet();
            da.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
            comboBox1.SelectedIndex = -1;

            label7.Text = DateTime.Now.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand na = new SqlCommand();
            na = new SqlCommand("select Paid12,summ,agg,balancee from Paid where name= '" + comboBox1.SelectedValue + "' ", con);
            con.Open();
            na.ExecuteNonQuery();
            SqlDataReader dr;

            dr = na.ExecuteReader();
            while (dr.Read())
            {
                string Paid12 = (string)dr["Paid12"].ToString();
                textBox1.Text = Paid12;

                string summ = (string)dr["summ"].ToString();
                textBox2.Text = summ;


                string agg = (string)dr["agg"].ToString();
                textBox3.Text = agg;


                string balancee = (string)dr["balancee"].ToString();
                textBox4.Text = balancee;

            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.s1;
            Image newimage = bmp;
            e.Graphics.DrawImage(newimage, 220, 0, newimage.Width, newimage.Height);


            e.Graphics.DrawString("سند قبض رسوم طالب", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(310, 200));


            e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 220));

            e.Graphics.DrawString(label7.Text + " : تاريخ الدفع", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 260));

            e.Graphics.DrawString("وصلني من ولي أمر الطالب :  " + comboBox1.SelectedValue, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 260));

            e.Graphics.DrawString("مبلغ وقدره :  " + textBox1.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(590, 290));

            e.Graphics.DrawString(label4.Text + "  " + textBox1.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 300));

            e.Graphics.DrawString(label2.Text + "  " + textBox2.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 330));

            e.Graphics.DrawString(label1.Text + "  " + textBox3.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 360));

            e.Graphics.DrawString(label3.Text + "  " + textBox4.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 390));



            e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 430));


            e.Graphics.DrawString(" : توقيع الإدارة", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, 460));

            e.Graphics.DrawString(" : توقيع ولي أمر الطالب", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(175, 460));







            e.Graphics.DrawImage(newimage, 220, 510, newimage.Width, newimage.Height);


            e.Graphics.DrawString("سند قبض رسوم طالب", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(310, 710));


            e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 740));

            e.Graphics.DrawString(label7.Text + " : تاريخ الدفع", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 770));

            e.Graphics.DrawString("وصلني من ولي أمر الطالب :  " + comboBox1.SelectedValue, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 770));

            e.Graphics.DrawString("مبلغ وقدره :  " + textBox1.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(590, 810));

            e.Graphics.DrawString(label4.Text + "  " + textBox1.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 850));

            e.Graphics.DrawString(label2.Text + "  " + textBox2.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 890));

            e.Graphics.DrawString(label1.Text + "  " + textBox3.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 930));

            e.Graphics.DrawString(label3.Text + "  " + textBox4.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(50, 970));



            e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 990));


            e.Graphics.DrawString(" : توقيع الإدارة", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, 1020));

            e.Graphics.DrawString(" : توقيع ولي أمر الطالب", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(175, 1020));
        }
    }
}
