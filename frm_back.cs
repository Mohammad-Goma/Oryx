using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oryx
{
    public partial class frm_back : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");

        //SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog = Mobile_Charger; Persist Security Info=True;User ID = sa; Password=6321");
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        SqlCommand cmd;
        public frm_back()
        {
            InitializeComponent();
        }
      

        private void btnBrowse_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                //string database = @"Data Source=DESKTOP-G2CDA6M\SQLEXPRESS;";
                if (txtFileName.Text == "")
                {
                    MessageBox.Show("يجب أختيار المسار أولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string filename = @txtFileName.Text + "\\Mobile_Charger" + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string querey = " backup database Mobile_Charger to Disk ='" + filename + ".bak' ";
                cmd = new SqlCommand(querey, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية النسخ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);  }
            finally {  con.Close();  }
        }
    
    }
}
