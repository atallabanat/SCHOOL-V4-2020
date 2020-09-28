
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Collections;
namespace SCHOOL_DEV
{
    public partial class ActivationKey : Form
    {
        const int ProductCode = 1;
        msgShow msg = new msgShow();
        string ModelHDD;
        string TypeHDD;
        string SerialHDD;
        public ActivationKey()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivationKey_Load(object sender, EventArgs e)
        {
            //txtExperience.Enabled = false;
            //cboLicenseType.SelectedIndex = 0;
            //txtProdectID.Text = ComputerInfo.GetComputerId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //KeyManager km = new KeyManager(txtProdectID.Text);
            //KeyValuesClass kv;
            //string ProdcutKey=string.Empty;
            //if(cboLicenseType.SelectedIndex==0)
            //{
            //    kv = new KeyValuesClass()
            //    {
            //        Type = LicenseType.FULL,
            //        Header = Convert.ToByte(2),
            //        Footer=Convert.ToByte(2),
            //        ProductCode=(byte)ProductCode,
            //        Edition=Edition.ENTERPRISE,
            //        Version=1
            //    };
            //    if (!km.GenerateKey(kv, ref ProdcutKey))
            //        txtProdectKey.Text = "ERRoR";
            //}
            //else
            //{
            //    if (txtExperience.Text == string.Empty)
            //    {
            //        msg.Alert("يرجى تحديد مدة التفعيل",Form_Alert.enumType.Warning);
            //    }
            //    else
            //    {
            //        kv = new KeyValuesClass()
            //        {
            //            Type = LicenseType.TRIAL,
            //            Header = Convert.ToByte(9),
            //            Footer = Convert.ToByte(6),
            //            ProductCode = (byte)ProductCode,
            //            Edition = Edition.ENTERPRISE,
            //            Version = 1,
            //            Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtExperience.Text))

            //    };

            //        if (!km.GenerateKey(kv, ref ProdcutKey))
            //            txtProdectKey.Text = "ERRoR";
            //    }
                
            }
            //sendToEmail(ProdcutKey);

        }
        //ArrayList hardDriveDetails = new ArrayList();
        //private void sendToEmail(string ProdcutKey)
        //{
        //    try
        //    {
        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;
        //        client.Timeout = 20000;
        //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        //client.UseDefaultCredentials = false;
        //        client.Credentials = new NetworkCredential("aboiyad02@gmail.com", "cvtjqxduidggizyc");
        //        MailMessage mail = new MailMessage();
        //        mail.To.Add("aboiyad02@gmail.com");
        //        mail.From = new MailAddress("aboiyad02@gmail.com");
        //        mail.Subject = "KeyZone ActivationKey School";

        //        ManagementObjectSearcher moSearcher = new
        //        ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

        //        foreach (ManagementObject wmi_HD in moSearcher.Get())
        //        {
        //            HardDrive hd = new HardDrive();  // User Defined Class
        //            hd.Model = wmi_HD["Model"].ToString();  //Model Number
        //            hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
        //            hd.SerialNo = wmi_HD["SerialNumber"].ToString(); 
        //            hardDriveDetails.Add(hd);
        //            ModelHDD = "Model : " + hd.Model;
        //            TypeHDD = "Type : " + hd.Type;
        //            SerialHDD = "Serial Number :" + hd.SerialNo;
        //        }
                
        //        string mssg= ProdcutKey + "\r\n" + "\r\n" + "ComputerName : " + System.Environment.MachineName + "\r\n" + "\r\n"  + ModelHDD + "\r\n" + "\r\n" + TypeHDD + "\r\n" + "\r\n" + SerialHDD + "\r\n" + "\r\n" +cboLicenseType.Text ;
        //        mssg = mssg.Replace("@","@"+Environment.NewLine);
        //        mail.Body = mssg;
        //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //        client.Send(mail);
        //        msg.Alert("تم طلب النسخة",Form_Alert.enumType.Success);
        //        button2.Enabled = false;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        msg.Alert("فشلة عملية الطلب"+ex.Message, Form_Alert.enumType.Error);
        //    }
        //}
        //class HardDrive
        //{
        //    private string model = null;
        //    private string type = null;
        //    private string serialNo = null;
        //    public string Model
        //    {
        //        get { return model; }
        //        set { model = value; }
        //    }
        //    public string Type
        //    {
        //        get { return type; }
        //        set { type = value; }
        //    }
        //    public string SerialNo
        //    {
        //        get { return serialNo; }
        //        set { serialNo = value; }
        //    }
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    KeyManager km = new KeyManager(txtProdectID.Text);
        //    string ProdcutKey = txtProdectKey.Text;
        //    if (km.ValidKey(ref ProdcutKey))
        //    {
        //        KeyValuesClass kv = new KeyValuesClass();
        //        if(km.DisassembleKey(ProdcutKey, ref kv))
        //        {
        //            LicenseInfo lic = new LicenseInfo();
        //            lic.ProductKey = ProdcutKey;
        //            lic.FullName = "School";
        //            if(kv.Type==LicenseType.TRIAL)
        //            {
        //                lic.Day = kv.Expiration.Day;
        //                lic.Month = kv.Expiration.Month;
        //                lic.Year = kv.Expiration.Year;
        //            }
                    
        //            km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Path.GetPathRoot(Environment.SystemDirectory)), lic);
        //            msg.Alert("تم تسجيل النسخة بنجاح",Form_Alert.enumType.Success);
        //            this.Hide();
        //            Login ss = new Login();
        //            ss.Show();

        //        }
        //        else
        //        {
        //            msg.Alert("كود التفعيل غير صحيحة ، يرجى إعادة المحاولة",Form_Alert.enumType.Error);
        //        }
        //    }
            
        //}

        //private void cboLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(cboLicenseType.SelectedIndex==0)
        //    {
        //        txtExperience.Enabled = false;
        //    }
        //    else
        //    {
        //        txtExperience.Enabled = true;
        //    }
        //}
    //}
}
