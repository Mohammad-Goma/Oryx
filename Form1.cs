using SALES;
using System;
using System.Management;
using System.Windows.Forms;

namespace Oryx
{
    public partial class Oryx : Form
    {
        Form_products _Products;
        Form_Store _Store;
        Invoice Invoice;
        frm_Billing _Billing;
        frm_Restore _Restore;
        frm_back _Back;
        Catch_Money _Money;
        frm_Pay_Money _Invoice;
        Profits prof;
        Boolean hdid = false;
        Boolean biosNum = false;
        public Oryx()
        {
            InitializeComponent();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            if (_Products == null)
            {
                _Products = new Form_products();
                _Products.Show();
            }
            else if (_Products.Visible == true)
            {
                _Products.BringToFront();
                _Products.Focus();
            }
            else { _Products.Close(); _Products = new Form_products(); _Products.Show(); }

            _Products.WindowState = FormWindowState.Normal;
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            if (_Store == null)
            {
                _Store = new Form_Store();
                _Store.Show();
            }
            else if (_Store.Visible == true)
            {
                _Store.BringToFront();
                _Store.Focus();
            }
            else { _Store.Close(); _Store = new Form_Store(); _Store.Show(); }

            _Store.WindowState = FormWindowState.Maximized;
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            if (Invoice == null)
            {
                Invoice = new Invoice();
                Invoice.Show();
            }
            else if (Invoice.Visible == true)
            {
                Invoice.BringToFront();
                Invoice.Focus();
            }
            else { Invoice.Close(); Invoice = new Invoice(); Invoice.Show(); }
            Invoice.WindowState = FormWindowState.Maximized;
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            if (_Billing == null)
            {
                _Billing = new frm_Billing();
                _Billing.Show();
            }
            else if (_Billing.Visible == true)
            {
                _Billing.BringToFront();
                _Billing.Focus();
            }
            else { _Billing.Close(); _Billing = new frm_Billing(); _Billing.Show(); }
            _Billing.WindowState = FormWindowState.Maximized;
        }

        private void btn_restore_Data_Click(object sender, EventArgs e)
        {
            if (_Restore == null)
            {
                _Restore = new frm_Restore();
                _Restore.Show();
            }
            else if (_Restore.Visible == true)
            {
                _Restore.BringToFront();
                _Restore.Focus();
            }
            else { _Restore.Close(); _Restore = new frm_Restore(); _Restore.Show(); }
            _Restore.WindowState = FormWindowState.Normal;
        }

        private void btn_frm_back_Click(object sender, EventArgs e)
        {
            if (_Back == null)
            {
                _Back = new frm_back();
                _Back.Show();
            }
            else if (_Back.Visible == true)
            {
                _Back.BringToFront();
                _Back.Focus();
            }
            else { _Back.Close(); _Back = new frm_back(); _Back.Show(); }
            _Back.WindowState = FormWindowState.Normal;
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            if (_Money == null)
            {
                _Money = new Catch_Money();
                _Money.Show();
            }
            else if (_Money.Visible == true)
            {
                _Money.BringToFront();
                _Money.Focus();
            }
            else { _Money.Close(); _Money = new Catch_Money(); _Money.Show(); }
            _Money.WindowState = FormWindowState.Normal;
        }

        private void btn_Catch_Receipt_Click(object sender, EventArgs e)
        {
            if (_Invoice == null)
            {
                _Invoice = new frm_Pay_Money();
                _Invoice.Show();
            }
            else if (_Invoice.Visible == true)
            {
                _Invoice.BringToFront();
                _Invoice.Focus();
            }
            else { _Invoice.Close(); _Invoice = new frm_Pay_Money(); _Invoice.Show(); }
            _Invoice.WindowState = FormWindowState.Normal;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            if (prof == null)
            {
                prof = new Profits();
                prof.Show();
            }
            else if (prof.Visible == true)
            {
                prof.BringToFront();
                prof.Focus();
            }
            else { prof.Close(); prof = new Profits(); prof.Show(); }
            prof.WindowState = FormWindowState.Normal;
        }

        private void Oryx_Load(object sender, EventArgs e)
        {
            Boolean MyComputer = true;
            GetAllDiskDrivesID();
            if (biosNum || hdid || MyComputer) { } 
            else { MessageBox.Show(" Board Number Is Invaild "," Attention "); Application.Exit(); }
        }
        public void GetAllDiskDrivesID()
        {
            var searcher = new ManagementObjectSearcher(" SELECT SerialNumber FROM Win32_DiskDrive ");
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString(); //get the serailNumber of diskdrive
                if (hd.SerialNo == "7PX07LN7")      //            S3YBNB0M302486M                    // wmic diskdrive get serialnumber     cmd  ايجاد رقم الهارد من     //  cmd    تغيير رقم الهارد من
                {
                    hdid = true;
                }
            }
            var search = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");
            foreach (ManagementObject wmi_HD in search.Get())
            {
                bios_v bis = new bios_v();
                bis.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString(); //get the serailNumber of diskdrive
                if (bis.SerialNo == "R9YKV2VM")                                                 //    تغيير رقم البورد              //  wmic bios get serialnumber  cmd  ايجاد رقم البورد من  
                {
                    biosNum = true;
                }
            }
        }

        public class HardDrive
        {
            public string SerialNo { get; set; }
        }
        public class bios_v
        {
            public string SerialNo { get; set; }
        }
    }
}
