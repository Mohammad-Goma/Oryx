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
    public partial class frm_Restore : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog = Mobile_Charger; Persist Security Info=True;User ID = sa; Password=6321");
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");

        public frm_Restore()
        {
            InitializeComponent();
        }
        

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text == "")
                {
                    MessageBox.Show("يجب اختيار المسار اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                con.Open();
                string query2 = "ALTER DATABASE Mobile_Charger SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Mobile_Charger from Disk='" + txtFileName.Text + "' ";
                SqlCommand cmd = new SqlCommand(query2 , con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" تمت عملية الإستعادة بنجاح " , " تأكيد " , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(" رسالة خطأ " + ex , "تنبيه" , MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { con.Close(); }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }


    }
}
