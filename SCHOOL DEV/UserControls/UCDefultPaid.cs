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
    public partial class UCDefultPaid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID;
        public UCDefultPaid()
        {
            InitializeComponent();
        }

        private void UCDefultPaid_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,Name from class where YaerSemesterID=" + Program.ID_Year + " ", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                combo_Class.DataSource = ds.Tables[0];
                combo_Class.DisplayMember = "Name";
                combo_Class.ValueMember = "ID";
                combo_Class.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
               
                if (combo_Class.SelectedIndex == -1)
                {
                    MessageBox.Show("(يرجى ادخال (الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_uniform.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم الزي المدرسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Bock.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم الكتب", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_transport.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم المواصلات", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (text_Paid1.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الأولى", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid2.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثانية", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid3.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثالثة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid4.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الرابعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid5.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الخامسة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid6.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة السادسة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid7.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة السابعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid8.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثامنة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid9.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة التاسعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    con.Open();


                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = @"INSERT INTO DefultPaid
                         (IDClass, NameClass, Paid1, Paid_uniform, Paid_Bock, Paid_transport, Paid2, Paid3, Paid4, Paid5, Paid6, Paid7, Paid8, Paid9, YaerSemesterID)
                            VALUES        (@IDClass, @NameClass, @Paid1, @Paid_uniform, @Paid_Bock, @Paid_transport, @Paid2, @Paid3, @Paid4, @Paid5, @Paid6, @Paid7, @Paid8, @Paid9, @YaerSemesterID)";

                    cmd1.Parameters.AddWithValue("@IDClass", combo_Class.SelectedValue);
                    cmd1.Parameters.AddWithValue("@NameClass", combo_Class.Text);

                    cmd1.Parameters.AddWithValue("@Paid1", text_Paid1.Text);
                    if (text_uniform.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_uniform", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_uniform", text_uniform.Text);
                    }

                    if (text_Bock.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_Bock", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_Bock", text_Bock.Text);
                    }


                    if (text_transport.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_transport", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_transport", text_transport.Text);
                    }

                    cmd1.Parameters.AddWithValue("@Paid2", text_Paid2.Text);
                    cmd1.Parameters.AddWithValue("@Paid3", text_Paid3.Text);
                    cmd1.Parameters.AddWithValue("@Paid4", text_Paid4.Text);
                    cmd1.Parameters.AddWithValue("@Paid5", text_Paid5.Text);
                    cmd1.Parameters.AddWithValue("@Paid6", text_Paid6.Text);
                    cmd1.Parameters.AddWithValue("@Paid7", text_Paid7.Text);
                    cmd1.Parameters.AddWithValue("@Paid8", text_Paid8.Text);
                    cmd1.Parameters.AddWithValue("@Paid9", text_Paid9.Text);                   
                    cmd1.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd1.ExecuteNonQuery();




                    MessageBox.Show("تم الإضافة بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    combo_Class.SelectedIndex = -1;
                    ClearScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void combo_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearScreen();
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from DefultPaid where IDClass=@IDClass and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@IDClass", combo_Class.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    ID = dr["ID"].ToString();
                    text_Paid1.Text = dr["Paid1"].ToString();
                    text_uniform.Text = dr["Paid_uniform"].ToString();
                    text_Bock.Text = dr["Paid_Bock"].ToString();
                    text_transport.Text = dr["Paid_transport"].ToString();
                    text_Paid2.Text = dr["Paid2"].ToString();
                    text_Paid3.Text = dr["Paid3"].ToString();
                    text_Paid4.Text = dr["Paid4"].ToString();
                    text_Paid5.Text = dr["Paid5"].ToString();
                    text_Paid6.Text = dr["Paid6"].ToString();
                    text_Paid7.Text = dr["Paid7"].ToString();
                    text_Paid8.Text = dr["Paid8"].ToString();
                    text_Paid9.Text = dr["Paid9"].ToString();
                    button1.Visible = false;
                    button2.Visible = true;
                    button3.Visible = true;
                }
                
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
        }

        private void text_Paid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_uniform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ClearScreen()
        {
            text_Bock.Text = string.Empty;
            text_transport.Text = string.Empty;
            text_uniform.Text = string.Empty;
            text_Paid1.Text = string.Empty;
            text_Paid2.Text = string.Empty;
            text_Paid3.Text = string.Empty;
            text_Paid4.Text = string.Empty;
            text_Paid5.Text = string.Empty;
            text_Paid6.Text = string.Empty;
            text_Paid7.Text = string.Empty;
            text_Paid8.Text = string.Empty;
            text_Paid9.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if(ID==string.Empty)
                {
                    MessageBox.Show("(يرجى تحديد (الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (combo_Class.SelectedIndex == -1)
                {
                    MessageBox.Show("(يرجى ادخال (الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                else
                {
                    con.Open();


                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = @"DELETE FROM DefultPaid WHERE ID=@ID and YaerSemesterID=@YaerSemesterID";

                    cmd1.Parameters.AddWithValue("@ID", ID);                   
                    cmd1.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd1.ExecuteNonQuery();


                    MessageBox.Show("تمت عملية الحذف  بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    ClearScreen();
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (ID == string.Empty)
                {
                    MessageBox.Show("(يرجى تحديد (الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (combo_Class.SelectedIndex == -1)
                {
                    MessageBox.Show("(يرجى ادخال (الصف الدراسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_uniform.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم الزي المدرسي", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Bock.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم الكتب", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_transport.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (رسوم المواصلات", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (text_Paid1.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الأولى", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid2.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثانية", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid3.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثالثة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid4.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الرابعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid5.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الخامسة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid6.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة السادسة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid7.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة السابعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid8.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة الثامنة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text_Paid9.Text == "")
                {
                    MessageBox.Show("(يرجى ادخال (الدفعة التاسعة", "يرجى ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    con.Open();


                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = @"UPDATE       DefultPaid
                                         SET      Paid1 =@Paid1, Paid_uniform =@Paid_uniform, Paid_Bock =@Paid_Bock, Paid_transport =@Paid_transport, Paid2 =@Paid2, Paid3 =@Paid3, Paid4 =@Paid4, Paid5 =@Paid5, Paid6 =@Paid6, Paid7 =@Paid7, Paid8 =@Paid8, Paid9 =@Paid9 where ID=@ID and YaerSemesterID=@YaerSemesterID";

                    cmd1.Parameters.AddWithValue("@ID",ID);
                    cmd1.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd1.Parameters.AddWithValue("@Paid1", text_Paid1.Text);
                    if (text_uniform.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_uniform", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_uniform", text_uniform.Text);
                    }

                    if (text_Bock.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_Bock", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_Bock", text_Bock.Text);
                    }


                    if (text_transport.Text == string.Empty)
                    {
                        cmd1.Parameters.AddWithValue("@Paid_transport", "0");
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Paid_transport", text_transport.Text);
                    }

                    cmd1.Parameters.AddWithValue("@Paid2", text_Paid2.Text);
                    cmd1.Parameters.AddWithValue("@Paid3", text_Paid3.Text);
                    cmd1.Parameters.AddWithValue("@Paid4", text_Paid4.Text);
                    cmd1.Parameters.AddWithValue("@Paid5", text_Paid5.Text);
                    cmd1.Parameters.AddWithValue("@Paid6", text_Paid6.Text);
                    cmd1.Parameters.AddWithValue("@Paid7", text_Paid7.Text);
                    cmd1.Parameters.AddWithValue("@Paid8", text_Paid8.Text);
                    cmd1.Parameters.AddWithValue("@Paid9", text_Paid9.Text);
                    cmd1.ExecuteNonQuery();


                    MessageBox.Show("تم التعديل بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    combo_Class.SelectedIndex = -1;
                    ClearScreen();
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
