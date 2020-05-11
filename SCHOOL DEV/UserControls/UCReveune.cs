using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SCHOOL_DEV.UserControls
{
    public partial class UCReveune : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID;
        public UCReveune()
        {
            InitializeComponent();
        }

        private void UCReveune_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from RevenueName where YaerSemesterID=" + Program.ID_Year + " ", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                combo_R.DataSource = ds.Tables[0];
                combo_R.DisplayMember = "Name";
                combo_R.ValueMember = "ID";
                combo_R.SelectedIndex = -1;
                Load1();
            }
            catch(Exception ex)
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
                cmd.CommandText = "select * from UCReveune where YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                combo_R.SelectedIndex = -1;
                text_Amount.Text = string.Empty;
                textNote.Text = string.Empty;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (combo_R.SelectedIndex == -1)
            {
                MessageBox.Show("(يرجى ادخال (نوع الإيراد", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text_Amount.Text == string.Empty)
            {
                MessageBox.Show("(يرجى ادخال (القيمة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into UCReveune values (@IDName,@Name,@Date,@Amount,@Note,@YaerSemesterID)";
                cmd.Parameters.AddWithValue("@IDName", combo_R.SelectedValue);
                cmd.Parameters.AddWithValue("@Name", combo_R.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Amount", text_Amount.Text);
                cmd.Parameters.AddWithValue("@Note", textNote.Text);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();




                MessageBox.Show("تم إضافة الإيرادات بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                text_Amount.Text = string.Empty;
                textNote.Text = string.Empty;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
                Load1();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != string.Empty)
                {
                    if (combo_R.SelectedIndex == -1)
                    {
                        MessageBox.Show("(يرجى ادخال (نوع الإيراد", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (text_Amount.Text == string.Empty)
                    {
                        MessageBox.Show("(يرجى ادخال (القيمة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE       UCReveune
                                        SET IDName =@IDName, Name =@Name, Date =@Date, Amount =@Amount, Note =@Note where ID=@ID and YaerSemesterID=@YaerSemesterID";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@IDName", combo_R.SelectedValue);
                    cmd.Parameters.AddWithValue("@Name", combo_R.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Amount", text_Amount.Text);
                    cmd.Parameters.AddWithValue("@Note", textNote.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعديل بيانات الإيراد بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    text_Amount.Text = string.Empty;
                    textNote.Text = string.Empty;
                    button2.Visible = false;
                    button3.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    MessageBox.Show("(يرجى تحديد (نوع الإيراد", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى تحديد الإيراد لعملية التعديل", "بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
                Load1();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    if (ID != string.Empty)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from UCReveune where ID=@ID and YaerSemesterID=@YaerSemesterID";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حذف الإيراد بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        text_Amount.Text = string.Empty;
                        textNote.Text = string.Empty;
                        button2.Visible = false;
                        button3.Visible = false;
                        button1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("يرجى تحديد الإيراد لعملية الحذف", "بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                    Load1();
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load1();
            text_Amount.Text = string.Empty;
            textNote.Text = string.Empty;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ID = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                textNote.Text = dataGridView1.CurrentRow.Cells[clmNote.Name].Value.ToString();
                text_Amount.Text = dataGridView1.CurrentRow.Cells[clmAmount.Name].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[clmDate.Name].Value.ToString();
                combo_R.SelectedValue = dataGridView1.CurrentRow.Cells[clmIDName.Name].Value.ToString();
                button2.Visible = true;
                button3.Visible = true;
                button1.Visible = false;
            }
        }
    }
}
