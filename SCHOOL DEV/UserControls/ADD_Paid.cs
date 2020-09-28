using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCHOOL_DEV.UserControls
{
    public partial class ADD_Paid : UserControl
    {
        static string constring = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        int count = 0;
        string ID;
        Boolean FlagMessge;
        //-------------------------------------------//

        double ALLPaid1;
        double Paid2;
        double Paid3;
        double Paid4;
        double Paid5;
        double Paid6;
        double Paid7;
        double Paid8;
        double Paid9;

        double SumALLPaid1;
        double SumPaid2;
        double SumPaid3;
        double SumPaid4;
        double SumPaid5;
        double SumPaid6;
        double SumPaid7;
        double SumPaid8;
        double SumPaid9;
        //-------------------------------------------//
        public ADD_Paid()
        {
            InitializeComponent();
        }
        private bool PaidStudentData()
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT        ALLPaid1, Paid2, Paid3, Paid4, Paid5, Paid6, Paid7, Paid8, Paid9
                                                    FROM            student
                                                    where ID=@ID and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@ID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    ALLPaid1 = Convert.ToDouble(dr["ALLPaid1"].ToString());
                    Paid2 = Convert.ToDouble(dr["Paid2"].ToString());
                    Paid3 = Convert.ToDouble(dr["Paid3"].ToString());
                    Paid4 = Convert.ToDouble(dr["Paid4"].ToString());
                    Paid5 = Convert.ToDouble(dr["Paid5"].ToString());
                    Paid6 = Convert.ToDouble(dr["Paid6"].ToString());
                    Paid7 = Convert.ToDouble(dr["Paid7"].ToString());
                    Paid8 = Convert.ToDouble(dr["Paid8"].ToString());
                    Paid9 = Convert.ToDouble(dr["Paid9"].ToString());
                    return true;
                }
                return false;
            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool SumPaidStudentData()
        {

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(@"select isnull(SUM(CASE WHEN IDPaid = 1 THEN AmountPaid ELSE 0 END),0) AS ALLPaid1, 
                                                  isnull(SUM(CASE WHEN IDPaid = 2 THEN AmountPaid ELSE 0 END),0) AS Paid2
                                                  ,isnull(SUM(CASE WHEN IDPaid = 3 THEN AmountPaid ELSE 0 END),0) AS Paid3
                                                  ,isnull(SUM(CASE WHEN IDPaid = 4 THEN AmountPaid ELSE 0 END),0) AS Paid4
                                                  ,isnull(SUM(CASE WHEN IDPaid = 5 THEN AmountPaid ELSE 0 END),0) AS Paid5
                                                  ,isnull(SUM(CASE WHEN IDPaid = 6 THEN AmountPaid ELSE 0 END),0) AS Paid6
                                                  ,isnull(SUM(CASE WHEN IDPaid = 7 THEN AmountPaid ELSE 0 END),0) AS Paid7
                                                  ,isnull(SUM(CASE WHEN IDPaid = 8 THEN AmountPaid ELSE 0 END),0) AS Paid8
                                                  ,isnull(SUM(CASE WHEN IDPaid = 9 THEN AmountPaid ELSE 0 END),0) AS Paid9
                                                  from Paid where ID_Student=@ID_Student and YaerSemesterID=@YaerSemesterID", con);
                cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    SumALLPaid1 = Convert.ToDouble(dr["ALLPaid1"].ToString());
                    SumPaid2 = Convert.ToDouble(dr["Paid2"].ToString());
                    SumPaid3 = Convert.ToDouble(dr["Paid3"].ToString());
                    SumPaid4 = Convert.ToDouble(dr["Paid4"].ToString());
                    SumPaid5 = Convert.ToDouble(dr["Paid5"].ToString());
                    SumPaid6 = Convert.ToDouble(dr["Paid6"].ToString());
                    SumPaid7 = Convert.ToDouble(dr["Paid7"].ToString());
                    SumPaid8 = Convert.ToDouble(dr["Paid8"].ToString());
                    SumPaid9 = Convert.ToDouble(dr["Paid9"].ToString());
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ADD_Paid_Load(object sender, EventArgs e)
        {
            try
            {

                checkDefultPaid.Checked = true;
                comboBox2.Enabled = false;

                SqlCommand cmd = con.CreateCommand();

                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select ID,name from student where YaerSemesterID=" + Program.ID_Year + " order by name", con);
                DataSet ds = new DataSet();
                ds = new DataSet();
                da.Fill(ds);
                count = 1;
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = -1;
                count = 0;




                SqlCommand cmd2 = con.CreateCommand();

                SqlDataAdapter da2 = new SqlDataAdapter();
                da2 = new SqlDataAdapter("select ID,name from PaidName where ID <> 0  order by ID ", con);
                DataSet ds2 = new DataSet();
                ds2 = new DataSet();
                da2.Fill(ds2);
                comboBox2.DataSource = ds2.Tables[0];
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "ID";
                comboBox2.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FlagMessge = false;
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد اسم الطالب", "عملية غير مكتملة ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkDefultPaid.Checked == false)
                {
                    if (comboBox2.SelectedIndex == -1)
                    {
                        MessageBox.Show("يرجى تحديد الدفعة", "عملية غير مكتملة ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (textBox19.Text == "")
                {
                    MessageBox.Show("يرجى تحديد قيمة الدفعة ", "عملية غير مكتملة ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkDefultPaid.Checked == true)
                {
                    if (PaidStudentData() == true)
                    {
                        if (SumPaidStudentData() == true)
                        {

                            AddPaid();
                            if (FlagMessge == false)
                            {
                                MessageBox.Show("تم الدفع بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            textBox19.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("فشل عملية الحفظ التلقائي ، يرجى تحديد الدفعة يدويا للحفظ", "لم تتم عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checkDefultPaid.Checked = false;
                            checkDefultPaid.Enabled = false;
                            comboBox2.Enabled = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("فشل عملية الحفظ التلقائي ، يرجى تحديد الدفعة يدويا للحفظ", "لم تتم عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkDefultPaid.Checked = false;
                        checkDefultPaid.Enabled = false;
                        comboBox2.Enabled = true;
                        return;
                    }
                }
                else
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                    cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                    cmd.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@IDPaid", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@NamePaid", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@AmountPaid", textBox19.Text);
                    cmd.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم الدفع بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox19.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تتم عملية الحفظ الرجاء إعادة المحاولة مرة اخرى", "عملية غير صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void AddPaid()
        {
            if (textBox19.Text != string.Empty)
            {
                double P1 = ALLPaid1 - SumALLPaid1;

                if (Convert.ToDouble(textBox19.Text) > (P1))
                {
                    if (ALLPaid1 != SumALLPaid1)
                    {
                        con.Open();

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                        cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                        cmd.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@IDPaid", "1");
                        cmd.Parameters.AddWithValue("@NamePaid", "الدفعة الأولى");
                        cmd.Parameters.AddWithValue("@AmountPaid", P1);
                        cmd.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                        cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    double D2 = (Convert.ToDouble(textBox19.Text) - P1);
                    double P2 = Paid2 - SumPaid2;
                    if (D2 > P2)
                    {
                        if (Paid2 != SumPaid2)
                        {
                            con.Open();

                            SqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                            cmd2.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                            cmd2.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                            cmd2.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                            cmd2.Parameters.AddWithValue("@IDPaid", "2");
                            cmd2.Parameters.AddWithValue("@NamePaid", "الدفعة الثانية");
                            cmd2.Parameters.AddWithValue("@AmountPaid", P2);
                            cmd2.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                            cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                        double D3 = (D2 - P2);
                        double P3 = Paid3 - SumPaid3;
                        if (D3 > P3)
                        {
                            if (Paid3 != SumPaid3)
                            {
                                con.Open();

                                SqlCommand cmd3 = con.CreateCommand();
                                cmd3.CommandType = CommandType.Text;
                                cmd3.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                cmd3.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                cmd3.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                cmd3.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                cmd3.Parameters.AddWithValue("@IDPaid", "3");
                                cmd3.Parameters.AddWithValue("@NamePaid", "الدفعة الثالثة");
                                cmd3.Parameters.AddWithValue("@AmountPaid", P3);
                                cmd3.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                cmd3.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                cmd3.ExecuteNonQuery();
                                con.Close();
                            }
                            double D4 = (D3 - P3);
                            double P4 = Paid4 - SumPaid4;
                            if (D4 > P4)
                            {
                                if (Paid4 != SumPaid4)
                                {
                                    con.Open();

                                    SqlCommand cmd4 = con.CreateCommand();
                                    cmd4.CommandType = CommandType.Text;
                                    cmd4.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                    cmd4.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                    cmd4.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                    cmd4.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                    cmd4.Parameters.AddWithValue("@IDPaid", "4");
                                    cmd4.Parameters.AddWithValue("@NamePaid", "الدفعة الرابعة");
                                    cmd4.Parameters.AddWithValue("@AmountPaid", P4);
                                    cmd4.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                    cmd4.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                    cmd4.ExecuteNonQuery();
                                    con.Close();
                                }
                                double D5 = (D4 - P4);
                                double P5 = Paid5 - SumPaid5;
                                if (D5 > P5)
                                {
                                    if (Paid5 != SumPaid5)
                                    {
                                        con.Open();

                                        SqlCommand cmd5 = con.CreateCommand();
                                        cmd5.CommandType = CommandType.Text;
                                        cmd5.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                        cmd5.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                        cmd5.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                        cmd5.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                        cmd5.Parameters.AddWithValue("@IDPaid", "5");
                                        cmd5.Parameters.AddWithValue("@NamePaid", "الدفعة الخامسة");
                                        cmd5.Parameters.AddWithValue("@AmountPaid", P5);
                                        cmd5.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                        cmd5.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                        cmd5.ExecuteNonQuery();
                                        con.Close();
                                    }

                                    double D6 = (D5 - P5);
                                    double P6 = Paid6 - SumPaid6;
                                    if (D6 > P6)
                                    {
                                        if (Paid6 != SumPaid6)
                                        {
                                            con.Open();

                                            SqlCommand cmd6 = con.CreateCommand();
                                            cmd6.CommandType = CommandType.Text;
                                            cmd6.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                            cmd6.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                            cmd6.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                            cmd6.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                            cmd6.Parameters.AddWithValue("@IDPaid", "6");
                                            cmd6.Parameters.AddWithValue("@NamePaid", "الدفعة السادسة");
                                            cmd6.Parameters.AddWithValue("@AmountPaid", P6);
                                            cmd6.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                            cmd6.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                            cmd6.ExecuteNonQuery();
                                            con.Close();
                                        }
                                        double D7 = (D6 - P6);
                                        double P7 = Paid7 - SumPaid7;
                                        if (D7 > P7)
                                        {
                                            if (Paid7 != SumPaid7)
                                            {
                                                con.Open();

                                                SqlCommand cmd7 = con.CreateCommand();
                                                cmd7.CommandType = CommandType.Text;
                                                cmd7.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                                cmd7.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                                cmd7.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                                cmd7.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                                cmd7.Parameters.AddWithValue("@IDPaid", "7");
                                                cmd7.Parameters.AddWithValue("@NamePaid", "الدفعة السابعة");
                                                cmd7.Parameters.AddWithValue("@AmountPaid", P7);
                                                cmd7.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                                cmd7.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                                cmd7.ExecuteNonQuery();
                                                con.Close();
                                            }
                                            double D8 = (D7 - P7);
                                            double P8 = Paid8 - SumPaid8;
                                            if (D8 > P8)
                                            {
                                                if (Paid8 != SumPaid8)
                                                {
                                                    con.Open();

                                                    SqlCommand cmd8 = con.CreateCommand();
                                                    cmd8.CommandType = CommandType.Text;
                                                    cmd8.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                                    cmd8.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                                    cmd8.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                                    cmd8.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                                    cmd8.Parameters.AddWithValue("@IDPaid", "8");
                                                    cmd8.Parameters.AddWithValue("@NamePaid", "الدفعة الثامنة");
                                                    cmd8.Parameters.AddWithValue("@AmountPaid", P8);
                                                    cmd8.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                                    cmd8.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                                    cmd8.ExecuteNonQuery();
                                                    con.Close();

                                                }

                                                double D9 = (D8 - P8);
                                                double P9 = Paid8 - SumPaid9;
                                                if (D9 > P9)
                                                {
                                                    if (Paid9 != SumPaid9)
                                                    {
                                                        con.Open();

                                                        SqlCommand cmd9 = con.CreateCommand();
                                                        cmd9.CommandType = CommandType.Text;
                                                        cmd9.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                                        cmd9.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                                        cmd9.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                                        cmd9.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                                        cmd9.Parameters.AddWithValue("@IDPaid", "9");
                                                        cmd9.Parameters.AddWithValue("@NamePaid", "الدفعة التاسعة");
                                                        cmd9.Parameters.AddWithValue("@AmountPaid", P9);
                                                        cmd9.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                                        cmd9.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                                        cmd9.ExecuteNonQuery();
                                                        con.Close();
                                                    }
                                                    else if (ALLPaid1 == SumALLPaid1 && Paid2 == SumPaid2 && Paid3 == SumPaid3 && Paid4 == SumPaid4 && Paid5 == SumPaid5 && Paid6 == SumPaid6 && Paid7 == SumPaid7 && Paid8 == SumPaid8 && Paid9 == SumPaid9)
                                                    {

                                                        MessageBox.Show("عذرا أقساط هذا الطالب مكتملة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        FlagMessge = true;
                                                        return;
                                                    }
                                                    if (Convert.ToDouble(textBox19.Text) - P9 > 0)
                                                    {
                                                        MessageBox.Show("ملاحظة : أقساط هذا الطالب اكتملت ويوجد فائق بقيمة" + "  " + (Convert.ToDouble(textBox19.Text) - P9) + "  لم يتم تسجيلها", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        FlagMessge = true;
                                                        return;
                                                    }
                                                }
                                                else if (D9 <= (Paid9 - SumPaid9))
                                                {
                                                    if (D9 > 0)
                                                        con.Open();

                                                    SqlCommand cmd9 = con.CreateCommand();
                                                    cmd9.CommandType = CommandType.Text;
                                                    cmd9.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                                    cmd9.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                                    cmd9.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                                    cmd9.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                                    cmd9.Parameters.AddWithValue("@IDPaid", "9");
                                                    cmd9.Parameters.AddWithValue("@NamePaid", "الدفعة التاسعة");
                                                    cmd9.Parameters.AddWithValue("@AmountPaid", D9);
                                                    cmd9.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                                    cmd9.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                                    cmd9.ExecuteNonQuery();
                                                    con.Close();

                                                }


                                            }
                                            else if (D8 <= (Paid8 - SumPaid8))
                                            {
                                                if (D8 > 0)
                                                    con.Open();

                                                SqlCommand cmd8 = con.CreateCommand();
                                                cmd8.CommandType = CommandType.Text;
                                                cmd8.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                                cmd8.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                                cmd8.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                                cmd8.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                                cmd8.Parameters.AddWithValue("@IDPaid", "8");
                                                cmd8.Parameters.AddWithValue("@NamePaid", "الدفعة الثامنة");
                                                cmd8.Parameters.AddWithValue("@AmountPaid", D8);
                                                cmd8.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                                cmd8.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                                cmd8.ExecuteNonQuery();
                                                con.Close();

                                            }

                                        }
                                        else if (D7 <= (Paid7 - SumPaid7))
                                        {
                                            if (D7 > 0)
                                                con.Open();

                                            SqlCommand cmd7 = con.CreateCommand();
                                            cmd7.CommandType = CommandType.Text;
                                            cmd7.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                            cmd7.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                            cmd7.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                            cmd7.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                            cmd7.Parameters.AddWithValue("@IDPaid", "7");
                                            cmd7.Parameters.AddWithValue("@NamePaid", "الدفعة السابعة");
                                            cmd7.Parameters.AddWithValue("@AmountPaid", D7);
                                            cmd7.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                            cmd7.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                            cmd7.ExecuteNonQuery();
                                            con.Close();

                                        }


                                    }
                                    else if (D6 <= (Paid6 - SumPaid6))
                                    {
                                        if (D6 > 0)
                                            con.Open();

                                        SqlCommand cmd6 = con.CreateCommand();
                                        cmd6.CommandType = CommandType.Text;
                                        cmd6.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                        cmd6.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                        cmd6.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                        cmd6.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                        cmd6.Parameters.AddWithValue("@IDPaid", "6");
                                        cmd6.Parameters.AddWithValue("@NamePaid", "الدفعة السادسة");
                                        cmd6.Parameters.AddWithValue("@AmountPaid", D6);
                                        cmd6.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                        cmd6.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                        cmd6.ExecuteNonQuery();
                                        con.Close();

                                    }

                                }
                                else if (D5 <= (Paid5 - SumPaid5))
                                {
                                    if (D5 > 0)
                                        con.Open();

                                    SqlCommand cmd5 = con.CreateCommand();
                                    cmd5.CommandType = CommandType.Text;
                                    cmd5.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                    cmd5.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                    cmd5.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                    cmd5.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                    cmd5.Parameters.AddWithValue("@IDPaid", "5");
                                    cmd5.Parameters.AddWithValue("@NamePaid", "الدفعة الخامسة");
                                    cmd5.Parameters.AddWithValue("@AmountPaid", D5);
                                    cmd5.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                    cmd5.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                    cmd5.ExecuteNonQuery();
                                    con.Close();

                                }


                            }
                            else if (D4 <= (Paid4 - SumPaid4))
                            {
                                if (D4 > 0)
                                    con.Open();

                                SqlCommand cmd4 = con.CreateCommand();
                                cmd4.CommandType = CommandType.Text;
                                cmd4.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                                cmd4.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                                cmd4.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                                cmd4.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                                cmd4.Parameters.AddWithValue("@IDPaid", "4");
                                cmd4.Parameters.AddWithValue("@NamePaid", "الدفعة الرابعة");
                                cmd4.Parameters.AddWithValue("@AmountPaid", D4);
                                cmd4.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                                cmd4.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                                cmd4.ExecuteNonQuery();
                                con.Close();

                            }


                        }
                        else if (D3 <= (Paid3 - SumPaid3))
                        {
                            if (D3 > 0)
                                con.Open();

                            SqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                            cmd3.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                            cmd3.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                            cmd3.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                            cmd3.Parameters.AddWithValue("@IDPaid", "3");
                            cmd3.Parameters.AddWithValue("@NamePaid", "الدفعة الثالثة");
                            cmd3.Parameters.AddWithValue("@AmountPaid", D3);
                            cmd3.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                            cmd3.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                            cmd3.ExecuteNonQuery();
                            con.Close();

                        }

                    }
                    else if (D2 <= (Paid2 - SumPaid2))
                    {
                        if (D2 > 0)
                            con.Open();

                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                        cmd2.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                        cmd2.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                        cmd2.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                        cmd2.Parameters.AddWithValue("@IDPaid", "2");
                        cmd2.Parameters.AddWithValue("@NamePaid", "الدفعة الثانية");
                        cmd2.Parameters.AddWithValue("@AmountPaid", D2);
                        cmd2.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                        cmd2.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                        cmd2.ExecuteNonQuery();
                        con.Close();

                    }
                }
                else if (Convert.ToDouble(textBox19.Text) <= (ALLPaid1 - SumALLPaid1))
                {
                    if (Convert.ToDouble(textBox19.Text) > 0)
                        con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Paid
                         (BondNo,ID_Student, Name_Student, IDPaid, NamePaid, AmountPaid, DateAmount , YaerSemesterID)
                            VALUES        (@BondNo,@ID_Student, @Name_Student, @IDPaid, @NamePaid, @AmountPaid, @DateAmount , @YaerSemesterID)";
                    cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@BondNo", txtBondNo.Text);
                    cmd.Parameters.AddWithValue("@Name_Student", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@IDPaid", "1");
                    cmd.Parameters.AddWithValue("@NamePaid", "الدفعة الأولى");
                    cmd.Parameters.AddWithValue("@AmountPaid", textBox19.Text);
                    cmd.Parameters.AddWithValue("@DateAmount", textBox20.Text);
                    cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Paid_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex > -1 && count != 1)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"select ID,IDPaid,NamePaid,AmountPaid,DateAmount,BondNo from Paid where ID_Student=@ID_Student order by IDPaid";

                    cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    TotalSumStudent(Convert.ToInt32(comboBox1.SelectedValue));
                    TotalAmount(Convert.ToInt32(comboBox1.SelectedValue));
                    RestAmount();
                }



            }
            catch (Exception ex)
            {

            }
            finally
            {

            }


        }
        private void RestAmount()
        {
            try
            {
                if (textBox_s.Text != string.Empty && textBox_K.Text != string.Empty)
                {
                    double TotalSumStudent = Convert.ToDouble(textBox_s.Text);
                    double TotalAmount = Convert.ToDouble(textBox_K.Text);
                    double RestAmount = TotalSumStudent - TotalAmount;
                    textBox_B.Text = RestAmount.ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        private void TotalAmount(int ID_Student)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(AmountPaid) as TotalAmount  from Paid where ID_Student=@ID_Student", con);
                cmd.Parameters.AddWithValue("@ID_Student", ID_Student);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox_K.Text = dr["TotalAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                textBox_K.Text = "0";
            }
            finally
            {
                con.Close();
            }
        }
        private void TotalSumStudent(int ID_Student)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select PaidTotal as TotalSumStudent from student where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", ID_Student);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox_s.Text = dr["TotalSumStudent"].ToString();
                }
            }
            catch (Exception ex)
            {
                textBox_s.Text = "0";
            }
            finally
            {
                con.Close();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid9 ssa = new PrintPaid9();
            addControlsTopanel(ssa);
        }

        private void addControlsTopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid10 ssa = new PrintPaid10();
            addControlsTopanel(ssa);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid11 ssa = new PrintPaid11();
            addControlsTopanel(ssa);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid12 ssa = new PrintPaid12();
            addControlsTopanel(ssa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid1 ssa = new PrintPaid1();
            addControlsTopanel(ssa);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid2 ssa = new PrintPaid2();
            addControlsTopanel(ssa);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid3 ssa = new PrintPaid3();
            addControlsTopanel(ssa);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid4 ssa = new PrintPaid4();
            addControlsTopanel(ssa);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid5 ssa = new PrintPaid5();
            addControlsTopanel(ssa);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid6 ssa = new PrintPaid6();
            addControlsTopanel(ssa);
        }


        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid7 ssa = new PrintPaid7();
            addControlsTopanel(ssa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelControls.Visible = true;
            PrintPaid8 ssa = new PrintPaid8();
            addControlsTopanel(ssa);
        }

        private void textBox20_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = @"select A.*,(A.TotalSumStudent-A.TotalAmount) as RestAmount
            //                        from
            //                        (select ID,IDPaid,NamePaid,AmountPaid,DateAmount,(select sum(AmountPaid)  from Paid where  ID_Student=@ID_Student)as TotalAmount,(select PaidTotal from student where ID=@ID_Student) as TotalSumStudent
            //                        from Paid 
            //                        where ID_Student=@ID_Student and IDPaid=@IDPaid)A";

            //    cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
            //    cmd.Parameters.AddWithValue("@IDPaid", comboBox2.SelectedValue);
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    if(dataGridView1.Rows.Count>0)
            //    {
            //        addTotalRow();

            //    }

            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}
        }


        private void addTotalRow()
        {

            double TableTotal = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                TableTotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[clmAmountPaid.Name].Value);
            }
            //dataGridView1.Rows.("","","المجموع",TableTotal,"","","","");
            this.dataGridView1.Rows.Add("", "", "المجموع", TableTotal, "", "", "", "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkDefultPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDefultPaid.Checked == true)
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد اسم الطالب", "عملية غير مكتملة ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ID == string.Empty)
                {
                    MessageBox.Show("يرجى تحديد الطالب", "عملية غير مكتملة ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Delete from Paid
                                            where ID=@ID and ID_Student=@ID_Student and YaerSemesterID=@YaerSemesterID ";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@ID_Student", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@YaerSemesterID", Program.ID_Year);

                cmd.ExecuteNonQuery();

                MessageBox.Show("تم الحذف بنجاح", "عملية صحيحة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox19.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "لم تتم عملية الحذف", "عملية خاطئة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    ID = dataGridView1.CurrentRow.Cells[clmID.Name].Value.ToString();
                }
            }
            catch
            {

            }
        }
    }
}

