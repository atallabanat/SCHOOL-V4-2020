using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SCHOOL_DEV.UserControls
{
    public partial class add_student : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        int count = 0;
        Boolean Flag_uniform;
        Boolean Flag_Bock;
        Boolean Flag_transport;
        public static add_student add_Student;
        public string ID;
        msgShow msg = new msgShow();

        public add_student()
        {
            add_Student = this;
            InitializeComponent();
        }
        public void selectGrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student where ID=@ID and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    combo_gender.SelectedValue = dr["gender"].ToString();
                    date_registration.Value = Convert.ToDateTime(dr["Date_Registration"].ToString());
                    combo_Class.SelectedValue = dr["IDclass"].ToString();
                    text_IDNumber.Text = dr["IDNumber"].ToString();
                    txtContractNumber.Text = dr["ContractNumber"].ToString();
                    text_Status.Text = dr["Status"].ToString();
                    text_PhoneDAD.Text = dr["PhoneDAD"].ToString();
                    text_PhoneMAM.Text = dr["PhoneMAM"].ToString();
                    int Social = Convert.ToInt32(dr["Social"].ToString());
                    if (Social == 1)
                    {
                        radio_married_1.Checked = true;
                    }
                    else if (Social == 2)
                    {
                        radio_separate_2.Checked = true;
                    }
                    else if (Social == 3)
                    {
                        radio_orphan_3.Checked = true;
                    }
                    text_Profession_DAD.Text = dr["Profession_DAD"].ToString();
                    text_Profession_MAM.Text = dr["Profession_MAM"].ToString();
                    text_Paid1.Text = dr["Paid1"].ToString();
                    textALLPaid1.Text = dr["ALLPaid1"].ToString();
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
                    textPaidAll.Text = dr["PaidAll"].ToString();
                    textPaidTotal.Text = dr["PaidTotal"].ToString();
                    Boolean Flag_uniform1 = Convert.ToBoolean(dr["Flag_uniform"].ToString());
                    if (Flag_uniform1 == true)
                    {
                        check_uniform.Checked = true;
                    }
                    else
                    {
                        check_uniform.Checked = false;
                    }

                    Boolean Flag_Bock1 = Convert.ToBoolean(dr["Flag_Bock"].ToString());
                    if (Flag_Bock == true)
                    {
                        check_Bock.Checked = true;
                    }
                    else
                    {
                        check_Bock.Checked = false;
                    }

                    Boolean Flag_transport1 = Convert.ToBoolean(dr["Flag_transport"].ToString());
                    if (Flag_transport1 == true)
                    {
                        check_transport.Checked = true;
                    }
                    else
                    {
                        check_transport.Checked = false;
                    }
                    text_Region.Text = dr["Region"].ToString();
                    text_place.Text = dr["place"].ToString();
                    text_Street.Text = dr["Street"].ToString();
                    text_Note.Text = dr["Note"].ToString();
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
        private void add_student_Load(object sender, EventArgs e)
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



                da = new SqlDataAdapter("select * from gendera", con);

                ds = new DataSet();
                da.Fill(ds);
                combo_gender.DataSource = ds.Tables[0];
                combo_gender.DisplayMember = "genderNumber";
                combo_gender.ValueMember = "genderName";
                combo_gender.SelectedIndex = -1;
            }
            catch
            {

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select name from student where name=@name and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@name", text_Name.Text);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;

                }
                if (count == 1)
                {
                    MessageBox.Show("الطالب  " + text_Name.Text.Trim() + "  موجود  ", "تكرار البيانات الطالب موجود !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    return;
                }
                con.Close();
                if (text_Name.Text == "")
                {
                    msg.Alert("يرجى ادخال اسم الطالب", Form_Alert.enumType.Warning);
                    return;
                }

                if (combo_Class.SelectedIndex == -1)
                {
                    msg.Alert("يرجى ادخال الصف الدراسي", Form_Alert.enumType.Warning);
                    return;
                }
                if (combo_gender.SelectedIndex == -1)
                {
                    msg.Alert("يرجى ادخال الجنس", Form_Alert.enumType.Warning);
                    return;
                }
                if (textALLPaid1.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الأولى", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid2.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثانية", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid3.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثالثة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid4.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الرابعة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid5.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الخامسة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid6.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة السادسة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid7.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة السابعة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid8.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثامنة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid9.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة التاسعة", Form_Alert.enumType.Warning);
                    return;
                }
                else
                {
                    con.Open();


                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into student values (@ContractNumber,@name, @gender, @Date_Registration,@IDClass ,@class, @IDNumber, @Status, @PhoneDAD, @PhoneMAM, @Social, @Profession_DAD, @Profession_MAM, @Paid1, @ALLPaid1, @Paid_uniform, @Paid_Bock, @Paid_transport, @Paid2, @Paid3, @Paid4, @Paid5, @Paid6, @Paid7, @Paid8, @Paid9, @PaidAll, @PaidTotal, @Flag_uniform, @Flag_Bock, @Flag_transport, @Region, @place, @Street, @Note, @YaerSemesterID)  ";
                    cmd1.Parameters.AddWithValue("@ContractNumber", txtContractNumber.Text);
                    cmd1.Parameters.AddWithValue("@name", text_Name.Text);
                    cmd1.Parameters.AddWithValue("@gender", combo_gender.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Date_Registration", date_registration.Value);
                    cmd1.Parameters.AddWithValue("@IDClass", combo_Class.SelectedValue);
                    cmd1.Parameters.AddWithValue("@class", combo_Class.Text);
                    cmd1.Parameters.AddWithValue("@IDNumber", text_IDNumber.Text);
                    cmd1.Parameters.AddWithValue("@Status", text_Status.Text);
                    cmd1.Parameters.AddWithValue("@PhoneDAD", text_PhoneDAD.Text);
                    cmd1.Parameters.AddWithValue("@PhoneMAM", text_PhoneMAM.Text);
                    if (radio_married_1.Checked == true)
                    {
                        cmd1.Parameters.AddWithValue("@Social", 1);
                    }
                    else if (radio_separate_2.Checked == true)
                    {
                        cmd1.Parameters.AddWithValue("@Social", 2);
                    }
                    else if (radio_orphan_3.Checked == true)
                    {
                        cmd1.Parameters.AddWithValue("@Social", 3);
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@Social", 0);
                    }
                    cmd1.Parameters.AddWithValue("@Profession_DAD", text_Profession_DAD.Text);
                    cmd1.Parameters.AddWithValue("@Profession_MAM", text_Profession_MAM.Text);
                    cmd1.Parameters.AddWithValue("@Paid1", text_Paid1.Text);
                    cmd1.Parameters.AddWithValue("@ALLPaid1", textALLPaid1.Text);
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
                    cmd1.Parameters.AddWithValue("@PaidAll", textPaidAll.Text);
                    cmd1.Parameters.AddWithValue("@PaidTotal", textPaidTotal.Text);
                    cmd1.Parameters.AddWithValue("@Flag_uniform", Flag_uniform);
                    cmd1.Parameters.AddWithValue("@Flag_Bock", Flag_Bock);
                    cmd1.Parameters.AddWithValue("@Flag_transport", Flag_transport);
                    cmd1.Parameters.AddWithValue("@Region", text_Region.Text);
                    cmd1.Parameters.AddWithValue("@place", text_place.Text);
                    cmd1.Parameters.AddWithValue("@Street", text_Street.Text);
                    cmd1.Parameters.AddWithValue("@Note", text_Note.Text);
                    cmd1.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd1.ExecuteNonQuery();



                    msg.Alert("تم إضافة الطالب بنجاح", Form_Alert.enumType.Success);
                    ClearScreen();


                }
            }
            catch (Exception ex)
            {
                msg.Alert("لم تتم عملية الحفظ" + ex.Message, Form_Alert.enumType.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void ClearScreen()
        {
            text_Name.Text = "";
            combo_gender.SelectedValue = -1;
            combo_Class.SelectedValue = -1;
            text_IDNumber.Text = "";
            text_Status.Text = "";
            text_PhoneDAD.Text = "";
            text_PhoneMAM.Text = "";
            radio_married_1.Checked = true;
            radio_separate_2.Checked = false;
            radio_orphan_3.Checked = false;
            text_Profession_DAD.Text = "";
            text_Profession_MAM.Text = "";
            text_Paid1.Text = "";
            text_uniform.Text = "";
            text_Bock.Text = "";
            text_transport.Text = "";
            txtContractNumber.Text = "";
            text_Paid1.Text = "";
            text_Paid2.Text = "";
            text_Paid3.Text = "";
            text_Paid4.Text = "";
            text_Paid5.Text = "";
            text_Paid6.Text = "";
            text_Paid7.Text = "";
            text_Paid8.Text = "";
            text_Paid9.Text = "";
            textPaidAll.Text = "";
            textPaidTotal.Text = "";
            check_uniform.Checked = false;
            check_Bock.Checked = false;
            check_transport.Checked = false;
            Flag_uniform = false;
            Flag_Bock = false;
            Flag_transport = false;
            text_Region.Text = "";
            text_place.Text = "";
            text_Street.Text = "";
            text_Note.Text = "";
            textALLPaid1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل أنت متأكد من عملية الحذف ، سيؤدي حذف ملف المالي الخاص بطالب", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(ID) >= 1)
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from student where ID=@ID and YaerSemesterID=@YaerSemesterID ";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "delete from Paid where ID_Student=@ID_Student and YaerSemesterID=@YaerSemesterID";
                        cmd2.Parameters.AddWithValue("@ID_Student", ID);
                        cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd2.ExecuteNonQuery();

                        msg.Alert("تم حذف الطالب بنجاح", Form_Alert.enumType.Success);
                        button4_Click(sender, e);
                    }
                    else
                    {
                        msg.Alert("يرجى تحديد الطالب لعملية الحذف", Form_Alert.enumType.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                msg.Alert("لم تتم عملية حذف الطالب ، الرجاء المحاولة مره اخرى" + ex.Message, Form_Alert.enumType.Error);
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
                if (Convert.ToInt32(ID) < 1)
                {
                    msg.Alert("يرجى تحديد اسم الطالب لعملية التعديل", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Name.Text == "")
                {
                    msg.Alert("يرجى ادخال اسم الطالب", Form_Alert.enumType.Warning);
                    return;
                }

                if (combo_Class.SelectedIndex == -1)
                {
                    msg.Alert("يرجى ادخال الصف الدراسي", Form_Alert.enumType.Warning);
                    return;
                }
                if (combo_gender.SelectedIndex == -1)
                {
                    msg.Alert("يرجى ادخال الجنس", Form_Alert.enumType.Warning);
                    return;
                }
                if (textALLPaid1.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الأولى", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid2.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثانية", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid3.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثالثة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid4.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الرابعة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid5.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الخامسة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid6.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة السادسة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid7.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة السابعة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid8.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة الثامنة", Form_Alert.enumType.Warning);
                    return;
                }
                if (text_Paid9.Text == "")
                {
                    msg.Alert("يرجى ادخال الدفعة التاسعة", Form_Alert.enumType.Warning);
                    return;
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE       student
                                   SET   ContractNumber=@ContractNumber   ,     name =@name, gender =@gender, Date_Registration =@Date_Registration,IDClass=@IDClass, class =@class, IDNumber =@IDNumber, Status =@Status, PhoneDAD =@PhoneDAD, PhoneMAM =@PhoneMAM, Social =@Social, Profession_DAD =@Profession_DAD, Profession_MAM =@Profession_MAM, Paid1 =@Paid1, ALLPaid1 =@ALLPaid1, Paid_uniform =@Paid_uniform, Paid_Bock =@Paid_Bock, Paid_transport =@Paid_transport, 
                                                Paid2 =@Paid2, Paid3 =@Paid3, Paid4 =@Paid4, Paid5 =@Paid5, Paid6 =@Paid6, Paid7 =@Paid7, Paid8 =@Paid8, Paid9 =@Paid9, PaidAll =@PaidAll, PaidTotal =@PaidTotal, Flag_uniform =@Flag_uniform, Flag_Bock =@Flag_Bock, Flag_transport =@Flag_transport, Region =@Region, place =@place, Street =@Street, Note =@Note where ID=@ID ";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ContractNumber", txtContractNumber.Text);
                cmd.Parameters.AddWithValue("@name", text_Name.Text);
                cmd.Parameters.AddWithValue("@gender", combo_gender.SelectedValue);
                cmd.Parameters.AddWithValue("@Date_Registration", date_registration.Value);
                cmd.Parameters.AddWithValue("@IDClass", combo_Class.SelectedValue);
                cmd.Parameters.AddWithValue("@class", combo_Class.Text);
                cmd.Parameters.AddWithValue("@IDNumber", text_IDNumber.Text);
                cmd.Parameters.AddWithValue("@Status", text_Status.Text);
                cmd.Parameters.AddWithValue("@PhoneDAD", text_PhoneDAD.Text);
                cmd.Parameters.AddWithValue("@PhoneMAM", text_PhoneMAM.Text);
                if (radio_married_1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Social", 1);
                }
                else if (radio_separate_2.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Social", 2);
                }
                else if (radio_orphan_3.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Social", 3);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Social", 0);
                }
                cmd.Parameters.AddWithValue("@Profession_DAD", text_Profession_DAD.Text);
                cmd.Parameters.AddWithValue("@Profession_MAM", text_Profession_MAM.Text);
                cmd.Parameters.AddWithValue("@Paid1", text_Paid1.Text);
                cmd.Parameters.AddWithValue("@ALLPaid1", textALLPaid1.Text);
                if (text_uniform.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Paid_uniform", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Paid_uniform", text_uniform.Text);
                }

                if (text_Bock.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Paid_Bock", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Paid_Bock", text_Bock.Text);
                }


                if (text_transport.Text == string.Empty)
                {
                    cmd.Parameters.AddWithValue("@Paid_transport", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Paid_transport", text_transport.Text);
                }
                cmd.Parameters.AddWithValue("@Paid2", text_Paid2.Text);
                cmd.Parameters.AddWithValue("@Paid3", text_Paid3.Text);
                cmd.Parameters.AddWithValue("@Paid4", text_Paid4.Text);
                cmd.Parameters.AddWithValue("@Paid5", text_Paid5.Text);
                cmd.Parameters.AddWithValue("@Paid6", text_Paid6.Text);
                cmd.Parameters.AddWithValue("@Paid7", text_Paid7.Text);
                cmd.Parameters.AddWithValue("@Paid8", text_Paid8.Text);
                cmd.Parameters.AddWithValue("@Paid9", text_Paid9.Text);
                cmd.Parameters.AddWithValue("@PaidAll", textPaidAll.Text);
                cmd.Parameters.AddWithValue("@PaidTotal", textPaidTotal.Text);
                cmd.Parameters.AddWithValue("@Flag_uniform", Flag_uniform);
                cmd.Parameters.AddWithValue("@Flag_Bock", Flag_Bock);
                cmd.Parameters.AddWithValue("@Flag_transport", Flag_transport);
                cmd.Parameters.AddWithValue("@Region", text_Region.Text);
                cmd.Parameters.AddWithValue("@place", text_place.Text);
                cmd.Parameters.AddWithValue("@Street", text_Street.Text);
                cmd.Parameters.AddWithValue("@Note", text_Note.Text);
                cmd.ExecuteNonQuery();
                msg.Alert("تم تعديل بيانات الطالب بنجاح", Form_Alert.enumType.Success);
                button4_Click(sender, e);
            }
            catch (Exception ex)
            {
                msg.Alert("لم تتم عملية التعديل" + ex.Message, Form_Alert.enumType.Error);
            }
            finally
            {
                con.Close();
            }


        }



        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void check_uniform_CheckedChanged(object sender, EventArgs e)
        {
            if (check_uniform.Checked == true)
            {
                Flag_uniform = true;

                text_uniform.Enabled = true;
            }
            else
            {
                Flag_uniform = false;
                text_uniform.Text = "";
                text_uniform.Enabled = false;
            }
        }

        private void check_Bock_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Bock.Checked == true)
            {
                Flag_Bock = true;
                text_Bock.Enabled = true;
            }
            else
            {
                Flag_Bock = false;
                text_Bock.Text = "";
                text_Bock.Enabled = false;
            }
        }

        private void check_transport_CheckedChanged(object sender, EventArgs e)
        {
            if (check_transport.Checked == true)
            {
                Flag_transport = true;
                text_transport.Enabled = true;
            }
            else
            {
                Flag_transport = false;
                text_transport.Text = "";
                text_transport.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void text_Paid2_Leave(object sender, EventArgs e)
        {
            if (text_Paid2.Text == string.Empty)
            {
                text_Paid2.Text = "0";
            }
        }

        private void text_Paid3_Leave(object sender, EventArgs e)
        {
            if (text_Paid3.Text == string.Empty)
            {
                text_Paid3.Text = "0";
            }
        }

        private void text_Paid4_Leave(object sender, EventArgs e)
        {
            if (text_Paid4.Text == string.Empty)
            {
                text_Paid4.Text = "0";
            }
        }

        private void text_Paid5_Leave(object sender, EventArgs e)
        {
            if (text_Paid5.Text == string.Empty)
            {
                text_Paid5.Text = "0";
            }
        }

        private void text_Paid6_Leave(object sender, EventArgs e)
        {
            if (text_Paid6.Text == string.Empty)
            {
                text_Paid6.Text = "0";
            }
        }

        private void text_Paid7_Leave(object sender, EventArgs e)
        {
            if (text_Paid7.Text == string.Empty)
            {
                text_Paid7.Text = "0";
            }
        }

        private void text_Paid8_Leave(object sender, EventArgs e)
        {
            if (text_Paid8.Text == string.Empty)
            {
                text_Paid8.Text = "0";
            }
        }


        private void SumPaidALL1()
        {
            double Paid1 = 0;
            double uniform = 0;
            double Bock = 0;
            double transport = 0;
            double PaidALL1 = 0;
            try
            {


                if (text_Paid1.Text != "")
                {
                    Paid1 = Convert.ToDouble(text_Paid1.Text);
                }
                if (text_uniform.Text != "")
                {
                    uniform = Convert.ToDouble(text_uniform.Text);
                }
                if (text_Bock.Text != "")
                {
                    Bock = Convert.ToDouble(text_Bock.Text);
                }
                if (text_transport.Text != "")
                {
                    transport = Convert.ToDouble(text_transport.Text);
                }

            }
            catch (Exception ex)
            {
                Paid1 = 0;
                uniform = 0;
                Bock = 0;
                transport = 0;
                PaidALL1 = 0;
            }
            finally
            {
                PaidALL1 = Paid1 + uniform + Bock + transport;
                textALLPaid1.Text = PaidALL1.ToString();
            }
        }

        private void text_Paid1_TextChanged(object sender, EventArgs e)
        {
            SumPaidALL1();
        }

        private void text_uniform_TextChanged(object sender, EventArgs e)
        {
            SumPaidALL1();
        }

        private void text_Bock_TextChanged(object sender, EventArgs e)
        {
            SumPaidALL1();
        }

        private void text_transport_TextChanged(object sender, EventArgs e)
        {
            SumPaidALL1();
        }
        private void PaidAll()
        {
            double Paid1 = 0;
            double Paid2 = 0;
            double Paid3 = 0;
            double Paid4 = 0;
            double Paid5 = 0;
            double Paid6 = 0;
            double Paid7 = 0;
            double Paid8 = 0;
            double Paid9 = 0;
            try
            {


                if (textALLPaid1.Text != string.Empty)
                {
                    Paid1 = Convert.ToDouble(textALLPaid1.Text);
                }
                if (text_Paid2.Text != string.Empty)
                {
                    Paid2 = Convert.ToDouble(text_Paid2.Text);
                }
                if (text_Paid3.Text != string.Empty)
                {
                    Paid3 = Convert.ToDouble(text_Paid3.Text);
                }
                if (text_Paid4.Text != string.Empty)
                {
                    Paid4 = Convert.ToDouble(text_Paid4.Text);
                }
                if (text_Paid5.Text != string.Empty)
                {
                    Paid5 = Convert.ToDouble(text_Paid5.Text);
                }
                if (text_Paid6.Text != string.Empty)
                {
                    Paid6 = Convert.ToDouble(text_Paid6.Text);
                }
                if (text_Paid7.Text != string.Empty)
                {
                    Paid7 = Convert.ToDouble(text_Paid7.Text);
                }
                if (text_Paid8.Text != string.Empty)
                {
                    Paid8 = Convert.ToDouble(text_Paid8.Text);
                }
                if (text_Paid9.Text != string.Empty)
                {
                    Paid9 = Convert.ToDouble(text_Paid9.Text);
                }
            }
            catch (Exception ex)
            {
                Paid1 = 0;
                Paid2 = 0;
                Paid3 = 0;
                Paid4 = 0;
                Paid5 = 0;
                Paid6 = 0;
                Paid7 = 0;
                Paid8 = 0;
                Paid9 = 0;
            }
            finally
            {
                textPaidAll.Text = (Paid1 + Paid2 + Paid3 + Paid4 + Paid5 + Paid6 + Paid7 + Paid8 + Paid9).ToString();
                textPaidTotal.Text = textPaidAll.Text;
            }
        }

        private void textALLPaid1_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid2_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid3_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid4_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid5_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid6_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid7_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid8_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid9_TextChanged(object sender, EventArgs e)
        {
            PaidAll();
        }

        private void text_Paid9_Leave(object sender, EventArgs e)
        {
            if (text_Paid9.Text == "")
            {
                text_Paid9.Text = "0";
            }
        }

        private void btn_View_Invoice_No_Click(object sender, EventArgs e)
        {
            Grid_Student ss = new Grid_Student();
            ss.ShowDialog();
        }

        private void date_registration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            add_student.add_Student.button1.Visible = true;
            add_student.add_Student.button2.Visible = false;
            add_student.add_Student.button3.Visible = false;
            ClearScreen();
        }

        private void text_uniform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Bock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_transport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textALLPaid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void text_Paid6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_Paid8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPaidTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_Calculation_Click(object sender, EventArgs e)
        {
            try
            {
                if (combo_Class.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد الصف الدراسي للطالب أولا ", "الصف الدراسي", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combo_Class.Focus();
                    return;
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from DefultPaid where IDClass=@IDClass and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@IDClass", combo_Class.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    check_uniform.Checked = true;
                    check_Bock.Checked = true;
                    check_transport.Checked = true;
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
                    SumPaidALL1();
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

    }
}
