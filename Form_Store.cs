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
    public partial class Form_Store : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        public Form_Store()
        {
            InitializeComponent();
        }

        private void Form_Store_Load(object sender, EventArgs e)
        {

            Select_All_Product(); 
            Select_Parcode();
            Balance();
            Price_Items();
            Finish_Price_Items();
        }

        public void Select_Parcode()
        {
            try
            {
                string sql = "SELECT PRODUCT_NAME FROM PRODUCTS ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col1.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                txt_search.AutoCompleteCustomSource = col1;
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        public void Select_Product_Name(TextBox txt_product_name)
        {
            try
            {
                string sql = "SELECT product_name FROM PRODUCTS ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col1.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                txt_product_name.AutoCompleteCustomSource = col1;
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        public void Select_All_Product()
        {
            con.Open();
            string s = "Select PARCODE,PRODUCT_NAME,UNIT,CURRENCY,INITIAL_COAST,LESS_PRICE,PRICE,SHIPPING_COAST,CUSTOMS,FINISH_PRICE,QTY,DETAILS_1 From products";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            con.Close();
        }

        public void Select_Product()
        {
            con.Open();
            string S = "Select PARCODE,PRODUCT_NAME,UNIT,CURRENCY,INITIAL_COAST,LESS_PRICE,PRICE,SHIPPING_COAST,CUSTOMS,FINISH_PRICE,QTY,DETAILS_1 From products where PRODUCT_NAME = N'" + txt_search.Text.Trim() + "' ";
            SqlCommand cmd = new SqlCommand(S , con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Amount.Text = "0";            First_price.Text = "0";              Secound_price.Text = "0";
            if(txt_search.Text.Trim() !="") { Select_Product();     Balance();   Price_Items(); Finish_Price_Items(); }
            else if (txt_search.Text.Trim() == "All") { Select_All_Product(); Balance(); Price_Items(); Finish_Price_Items(); }
            else { }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Amount.Text = "0"; First_price.Text = "0"; Secound_price.Text = "0";
            Select_All_Product();  Balance();  Price_Items();  Finish_Price_Items();
        }

        public void Balance()
        {
            decimal A = 0;
            decimal B = 0;
            decimal C = 0;
            try
            {
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    A += Convert.ToDecimal( DGV.Rows[i].Cells["QTY"].Value.ToString() );
                    B += Convert.ToDecimal( DGV.Rows[i].Cells["PRICE"].Value.ToString() );
                    C += Convert.ToDecimal( DGV.Rows[i].Cells["FINISH_PRICE"].Value.ToString() );
                }
            } catch (Exception) { }
            finally
            {
                Amount.Text = A.ToString().Replace("-", "");
                First_price.Text = B.ToString().Replace("-", "");
                Secound_price.Text = C.ToString().Replace("-", "");
            }
        }

        public void Price_Items()
        {
            try
            {
                if ( Amount.Text.Trim() == " ") { Amount.Text = "0";}
                decimal c = Convert.ToDecimal( Amount.Text.Trim() );
                decimal c2 = Convert.ToDecimal( First_price.Text.Trim());
                decimal c3 = c * c2;
                First_price.Text = c3.ToString();
            } catch (Exception)  {  }
        }

        public void Finish_Price_Items()
        {
            try
            {
                if (Amount.Text.Trim() == " ") { Amount.Text = "0"; }
                decimal c  = Convert.ToDecimal( Amount.Text.Trim());
                decimal c2 = Convert.ToDecimal( Secound_price.Text.Trim());
                decimal c3 = c * c2;
                Secound_price.Text = c3.ToString();

            } catch (Exception) { }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_Report_Store frm = new frm_Report_Store(Amount.Text.Trim(), Secound_price.Text.Trim(), First_price.Text.Trim());
            Crystal_Store crystal = new Crystal_Store();
            DS_Store dS = new DS_Store();
            foreach (DataGridViewRow dgv in DGV.Rows)
            {
               dS.DT_STORE.Rows.Add(dgv.Cells["PARCODE"].Value, dgv.Cells["PRODUCT_NAME"].Value,
                                    dgv.Cells["UNIT"].Value, dgv.Cells["CURRENCY"].Value,
                                    dgv.Cells["INITIAL_COAST"].Value, dgv.Cells["LESS_PRICE"].Value,
                                    dgv.Cells["PRICE"].Value, dgv.Cells["SHIPPING_COAST"].Value,
                                    dgv.Cells["CUSTOMS"].Value, dgv.Cells["FINISH_PRICE"].Value,
                                    dgv.Cells["QTY"].Value);
            }
            DataView dv = new DataView(dS.Tables["DT_STORE"]);
            crystal.SetDataSource(dv);
            if (Amount.Text.Trim() == "") { Amount.Text = "0"; }
            crystal.SetParameterValue("Amount", Amount.Text.Trim());
            if (Secound_price.Text.Trim() == "") { Secound_price.Text = "0"; }
            crystal.SetParameterValue("First_price", Secound_price.Text.Trim());
            if (First_price.Text.Trim() == "") { First_price.Text = "0"; }
            crystal.SetParameterValue("Secound_price", First_price.Text.Trim());
            frm.crystalViewerStore.ReportSource = crystal;
            frm.crystalViewerStore.Refresh();
            frm.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
