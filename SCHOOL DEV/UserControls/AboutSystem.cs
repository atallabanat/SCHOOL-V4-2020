using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SCHOOL_DEV.UserControls
{
    public partial class AboutSystem : UserControl
    {
        public AboutSystem()
        {
            InitializeComponent();
        }

        //private void AboutSystem_Load(object sender, EventArgs e)
        //{
        //    txtProductID.Text = ComputerInfo.GetComputerId();
        //    KeyManager km = new KeyManager(txtProductID.Text);
        //    LicenseInfo lic = new LicenseInfo();
        //    int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Path.GetPathRoot(Environment.SystemDirectory)), ref lic);
        //    string ProductKey = lic.ProductKey;
        //    if(km.ValidKey(ref ProductKey))
        //    {
        //        KeyValuesClass kv = new KeyValuesClass();
        //        if(km.DisassembleKey(ProductKey,ref kv))
        //        {
        //            txtProductName.Text = Program.School_Name;
        //            txtProductKey.Text = ProductKey;
        //            if (kv.Type == LicenseType.TRIAL)
        //                textBox4.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
        //            else
        //                textBox4.Text = "مفعل دائم";
        //        }
        //    }


        //}
    }
}
