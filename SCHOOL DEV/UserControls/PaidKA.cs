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
    public partial class PaidKA : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        string ID;

        public PaidKA()
        {
            InitializeComponent();
        }

        private void PaidKA_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,name from Teacher where YaerSemesterID=" + Program.ID_Year + "", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                comboNameEmp.DataSource = ds.Tables[0];
                comboNameEmp.DisplayMember = "name";
                comboNameEmp.ValueMember = "ID";
                comboNameEmp.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboNameEmp.SelectedIndex==-1)
                {
                    MessageBox.Show("يرجى تحديد الموظف لعملية الحفظ","بيانات غير مكتملة",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    comboNameEmp.Focus();
                    return;
                }
                if (textAmountOnAccount.Text==string.Empty && textAmountMonthlyGuarantee.Text==string.Empty)
                {
                    MessageBox.Show("يرجى تحديد قيمة السلفة أو قيمة الضمان لعملية الحفظ", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textAmountOnAccount.Focus();
                    return;
                }
                if (textAmountOnAccount.Text != string.Empty)
                {
                    if(textAmountMonthly.Text==string.Empty)
                    {
                        MessageBox.Show("يرجى تحديد قيمة الاقتطاع الشهرية للسلفة لعملية الحفظ", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textAmountMonthly.Focus();
                        return;
                    }                    
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO PaidKA
                         (IDTeacher, StartDateOnAccount, AmountOnAccount, AmountMonthly, AmountMonthlyGuarantee, YaerSemesterID)
                            VALUES        (@IDTeacher, @StartDateOnAccount, @AmountOnAccount, @AmountMonthly, @AmountMonthlyGuarantee, @YaerSemesterID)";
                cmd.Parameters.AddWithValue("@IDTeacher",comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@StartDateOnAccount", dateTimePicker1.Value);
                if(textAmountOnAccount.Text==string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountOnAccount", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountOnAccount", textAmountOnAccount.Text);
                }
                if(textAmountMonthly.Text==string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountMonthly", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountMonthly", textAmountMonthly.Text);
                }
                if(textAmountMonthlyGuarantee.Text==string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountMonthlyGuarantee", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountMonthlyGuarantee", textAmountMonthlyGuarantee.Text);
                }                
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();                
                MessageBox.Show("تمت الإضافة بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearScreen();

            }
            catch(Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ !!"+ex.Message,"عملية خاطئة",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                SelectJobEmp();
                selectGridDataEmp();
            }

         
        }    
        private void ClearScreen()
        {
            textAmountMonthly.Text = string.Empty;
            textAmountOnAccount.Text = string.Empty;
            textAmountMonthlyGuarantee.Text = string.Empty;
            textJobName.Text = string.Empty;
            textSalary.Text = string.Empty;
            textAmountSalary.Text = string.Empty;
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearScreen();
            SelectJobEmp();
            selectGridDataEmp();
            btnEdit.Visible = false;
            btnSave.Visible = true;
            button1.Visible = false;
           
        }
        private void TotalAmountSalary()
        {
            try
            {

                double Salary=0;
                if(textSalary.Text!=string.Empty)
                {
                    Salary = Convert.ToDouble(textSalary.Text);
                }
                double AmountMonthly = 0;
                double AmountMonthlyGuarantee = 0;
                try
                {


                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            AmountMonthly += Convert.ToDouble(dataGridView1.Rows[i].Cells[clmAmountMonthly.Name].Value);
                            AmountMonthlyGuarantee += Convert.ToDouble(dataGridView1.Rows[i].Cells[clmAmountMonthlyGuarantee.Name].Value);
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    double Total = 0;
                    Total = Salary - AmountMonthly - AmountMonthlyGuarantee;
                    textAmountSalary.Text = Total.ToString();
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void SelectJobEmp()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select JobName,salary from Teacher where ID=@ID and  YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@ID", comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textJobName.Text = dr["JobName"].ToString();
                    textSalary.Text = dr["salary"].ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
        private void selectGridDataEmp()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT        PaidKA.ID, PaidKA.IDTeacher, Teacher.name, PaidKA.StartDateOnAccount, PaidKA.AmountOnAccount, PaidKA.AmountMonthly, PaidKA.AmountMonthlyGuarantee,  Teacher.salary
                                    FROM            Teacher INNER JOIN
                                    PaidKA ON Teacher.ID = PaidKA.IDTeacher where PaidKA.IDTeacher=@IDTeacher and PaidKA.YaerSemesterID=@YaerSemesterID order by PaidKA.ID";
                cmd.Parameters.AddWithValue("@IDTeacher", comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID",Program.ID_Year);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                TotalAmountSalary();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboNameEmp.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى تحديد اسم الموظف قبل طباعة السند", "حقل اجباري", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bmp = Properties.Resources.s1;
            //Image newimage = bmp;
            //e.Graphics.DrawImage(newimage, 220, 0, newimage.Width, newimage.Height);


            //e.Graphics.DrawString("سند صرف ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(360, 200));


            //e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 220));

            //e.Graphics.DrawString(textBox7.Text + " : تاريخ الصرف", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 250));

            //e.Graphics.DrawString("اصرفو الى السيد /ة  :  " + comboNameEmp.SelectedValue, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 250));

            //e.Graphics.DrawString("مبلغ وقدره :  " + textAmountOnAccount.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(590, 290));

            //e.Graphics.DrawString("......................................................................  وذلك عــن ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(300, 370));





            //e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 430));


            //e.Graphics.DrawString(" : توقيع الإدارة", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, 460));

            //e.Graphics.DrawString(" : توقيع المستلم", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(175, 460));







            //e.Graphics.DrawImage(newimage, 220, 510, newimage.Width, newimage.Height);


            //e.Graphics.DrawString("سند صرف ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(360, 710));


            //e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 740));

            //e.Graphics.DrawString(textBox7.Text + " : تاريخ الصرف", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 770));

            //e.Graphics.DrawString("اصرفو الى السيد /ة  :  " + comboNameEmp.SelectedValue, new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(520, 770));

            //e.Graphics.DrawString("مبلغ وقدره :  " + textAmountOnAccount.Text + "   دينار", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(590, 810));

            //e.Graphics.DrawString("......................................................................  وذلك عــن ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(300, 900));



            //e.Graphics.DrawString(label9.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 990));


            //e.Graphics.DrawString(" : توقيع الإدارة", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(600, 1020));

            //e.Graphics.DrawString(" : توقيع المستلم", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(175, 1020));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboNameEmp.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد الموظف لعملية الحفظ", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboNameEmp.Focus();
                    return;
                }
                if (textAmountOnAccount.Text == string.Empty && textAmountMonthlyGuarantee.Text == string.Empty)
                {
                    MessageBox.Show("يرجى تحديد قيمة السلفة أو قيمة الضمان لعملية الحفظ", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textAmountOnAccount.Focus();
                    return;
                }
                if (textAmountOnAccount.Text != string.Empty)
                {
                    if (textAmountMonthly.Text == string.Empty)
                    {
                        MessageBox.Show("يرجى تحديد قيمة الاقتطاع الشهرية للسلفة لعملية الحفظ", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textAmountMonthly.Focus();
                        return;
                    }
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE       PaidKA
                                    SET          StartDateOnAccount =@StartDateOnAccount, AmountOnAccount =@AmountOnAccount, AmountMonthly =@AmountMonthly, AmountMonthlyGuarantee =@AmountMonthlyGuarantee  where ID=@ID and IDTeacher =@IDTeacher and YaerSemesterID=@YaerSemesterID ";
                cmd.Parameters.AddWithValue("@ID",ID);
                cmd.Parameters.AddWithValue("@IDTeacher", comboNameEmp.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.Parameters.AddWithValue("@StartDateOnAccount", dateTimePicker1.Value);
                if (textAmountOnAccount.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountOnAccount", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountOnAccount", textAmountOnAccount.Text);
                }
                if (textAmountMonthly.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountMonthly", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountMonthly", textAmountMonthly.Text);
                }
                if (textAmountMonthlyGuarantee.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@AmountMonthlyGuarantee", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AmountMonthlyGuarantee", textAmountMonthlyGuarantee.Text);
                }                
                cmd.ExecuteNonQuery();

                MessageBox.Show("تمت التعديل بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearScreen();
                btnEdit.Visible = false;
                btnSave.Visible = true;
                button1.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ !!" + ex.Message, "عملية خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                SelectJobEmp();
                selectGridDataEmp();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ID == string.Empty)
                {
                    MessageBox.Show("يرجى تحديد الموظف لعملية الحذف", "بيانات غير مكتملة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboNameEmp.Focus();
                    return;
                }
               
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE FROM PaidKA WHERE ID=@ID and YaerSemesterID=@YaerSemesterID";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                cmd.ExecuteNonQuery();

                MessageBox.Show("تم الحذف بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearScreen();
                btnEdit.Visible = false;
                btnSave.Visible = true;
                button1.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحذف !!" + ex.Message, "عملية خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                SelectJobEmp();
                selectGridDataEmp();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    ID = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                    comboNameEmp.Text = dataGridView1.CurrentRow.Cells[clmNameEmp.Name].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[clmStartDateOnAccount.Name].Value);
                    textAmountMonthly.Text = dataGridView1.CurrentRow.Cells[clmAmountMonthly.Name].Value.ToString();
                    textAmountOnAccount.Text = dataGridView1.CurrentRow.Cells[clmAmountOnAccount.Name].Value.ToString();
                    textAmountMonthlyGuarantee.Text = dataGridView1.CurrentRow.Cells[clmAmountMonthlyGuarantee.Name].Value.ToString();

                    btnEdit.Visible = true;
                    btnSave.Visible = false;
                    button1.Visible = true;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}

