using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Oryx
{
    public partial class Profits : Form
    {
        object Quantity = 1;
        int clicked_1 = 0;
        decimal AllCoast = 0;

        object ThisCoast = 0;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        public Profits()
        {
            InitializeComponent();
        }

        public void Balance1()
        {
            decimal A = 0;
            try
            {
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    A += Convert.ToDecimal(DGV1.Rows[i].Cells["TOTAL"].Value.ToString());
                }
            }
            catch { }
            finally
            {
                Invoice.Text = A.ToString();
            }
        }

        public void Balance2()
        {
            decimal A = 0;
            try
            {
                for (int i = 0; i < DGV2.Rows.Count; i++)
                {
                    A += Convert.ToDecimal(DGV2.Rows[i].Cells["Cash"].Value.ToString());
                }
            }
            catch { }
            finally
            {
                Recipt.Text = A.ToString();
            }
        }

        public void Balance3()
        {
            decimal A = 0;
            try
            {
                for (int i = 0; i < DGV3.Rows.Count; i++)
                {
                    A += Convert.ToDecimal(DGV3.Rows[i].Cells["PAY_FIRST"].Value.ToString());
                }
            } catch { }
            finally
            {
                Billing.Text = A.ToString();
            }
        }

        public void ClearDGV(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Value = "";
                    }
                }
                dataGridView.Refresh();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                txt_last_Coast.Text = "";
                Qty_Coast.Text = "";
                if (clicked_1 == 1) { AllCoast = 0; }
                clicked_1 = 1;
                if (DGV1.Rows.Count > 0) { ClearDGV(DGV1); }
                if (DGV2.Rows.Count > 0) { ClearDGV(DGV1); }
                if (DGV3.Rows.Count > 0) { ClearDGV(DGV1); }
                SelectDGV1();
                SelectDGV2();
                SelectDGV3();
                Balance1();
                Balance2();
                Balance3();
                Select_Invoice_Number();
            }
            catch 
            {

                
            }
          
        }

        public void Select_Invoice_Number()
        {
            //for (int i = 0; i < DGV1.Rows.Count; i++)
            //{
                foreach(DataGridViewRow row in DGV1.Rows)
                {
                    object objparcode = 0;
                    objparcode = row.Cells["ID_ORDER"].Value;
                    Select_Invoice(objparcode);
                }
            //}
        }

        public void Select_Invoice(object invoiceNumber)
        {
            DGV4.DataSource = null;
            object invoice_Parcode = 0;
            string s = "Select Parcode,QTY From INVOICE_DETAILS Where ID_ORDER = N'" + invoiceNumber + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con) ;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV4.DataSource = dt;
            con.Close();
            foreach (DataGridViewRow row in DGV4.Rows)
            {
                Quantity = 1;
                Quantity = row.Cells["QTY"].Value;
                invoice_Parcode = row.Cells["Parcode"].Value;
                Select_FINISH_PRICE(invoice_Parcode);
            }
        }

        public void Select_FINISH_PRICE(object coast)
        {
            ThisCoast = 0;
            string querry = "Select FINISH_PRICE From PRODUCTS Where Parcode = '" + coast + "' ";
            con.Open(); 
            SqlCommand cmd = new SqlCommand(querry,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ThisCoast = dr["FINISH_PRICE"].ToString();
            }
            dr.Close();
            con.Close();
            decimal c = Convert.ToDecimal(ThisCoast);
            decimal q = Convert.ToDecimal(Quantity);
            c = c * q;
            AllCoast = AllCoast + c;
            Qty_Coast.Text = " ";
            Qty_Coast.Text = AllCoast.ToString();

            //decimal Total_Profits_ = Convert.ToDecimal(Total_Profits.Text.Trim());
            //decimal lastCoast = Total_Profits_ - AllCoast;
            //txt_last_Coast.Text = lastCoast.ToString();
            Quantity = 1;
        }

        public void SelectDGV1()
        {
            con.Open();
            string S = " Select ID_ORDER,DATE,AMOUNT_ITEMS,TOTAL From Invoice Where Date Between N'" + dt_1.Text.Trim() + "' And N'" + dt_2.Text.Trim() + "' ";
            SqlCommand cmd3 = new SqlCommand(S, con);
            cmd3.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV1.DataSource = dt;
            con.Close();
        }

        public void SelectDGV2()     //  TBL_PAY_RECEIPT
        {
            con.Open();
            string S = " Select ID_ORDER_AUTO,DATE_NOW,Cash From TBL_PAY_RECEIPT Where DATE_NOW Between N'" + dt_1.Text.Trim() + "' And N'" + dt_2.Text.Trim() + "' ";
            SqlCommand cmd2 = new SqlCommand(S, con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV2.DataSource = dt;
            con.Close();
        }

        public void SelectDGV3()
        {
            con.Open();
            string S = " SELECT ID,CURENCY,DATE_TIME_NOW,TOTAL_AMOUNT,TOTAL_DISCOUNT,PAY_FIRST,THE_REST FROM TBL_BILLING Where DATE_TIME_NOW Between N'" + dt_1.Text.Trim() + "' And N'" + dt_2.Text.Trim() + "' ";
            SqlCommand cmd = new SqlCommand(S , con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV3.DataSource = dt;
            con.Close();
        }

        private void Invoice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Invoice.Text == "") { Invoice.Text = "0"; }
                if (Recipt.Text  == "") { Recipt.Text  = "0"; }
                if (Billing.Text == "") { Billing.Text = "0"; }
                if (Qty_Coast.Text == "") { Qty_Coast.Text = "0"; }
                if (txt_last_Coast.Text == "") { txt_last_Coast.Text = "0"; }

                decimal c1 = Convert.ToDecimal(Invoice.Text.Trim());

                decimal c2 = Convert.ToDecimal(Recipt.Text.Trim());
                decimal c3 = Convert.ToDecimal(Billing.Text.Trim());
                decimal c4 = Convert.ToDecimal(Qty_Coast.Text.Trim()); 
                decimal c5 = c2 + c3 + c4;
                txt_last_Coast.Text = ( c1 - c5 ).ToString();

                //int prof = Convert.ToInt32(Total_Profits.Text.Trim());
                //if (prof < 0) { Total_Profits.BackColor = Color.Yellow; }
                //else { Total_Profits.BackColor = Color.White; }
            } catch { }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_Profits_Report frm_Profits = new frm_Profits_Report(Invoice.Text.Trim(), Recipt.Text.Trim(),
                Billing.Text.Trim(), Total_Profits.Text.Trim(), dt_1.Text.Trim(),dt_2.Text.Trim());
            Crystal_Profits _Profits = new Crystal_Profits();

            _Profits.SetParameterValue("Invoice", Invoice.Text.Trim());
            _Profits.SetParameterValue("Recipt", Recipt.Text.Trim());
            _Profits.SetParameterValue("Billing", Billing.Text.Trim());
            _Profits.SetParameterValue("Total_Profits", txt_last_Coast.Text.Trim());
            _Profits.SetParameterValue("From Date", dt_1.Text.Trim());
            _Profits.SetParameterValue("To Date", dt_2.Text.Trim());

            frm_Profits.crystalViewer1.ReportSource = _Profits;
            frm_Profits.crystalViewer1.Refresh();
            frm_Profits.Show();
        }

        private void Profits_Load(object sender, EventArgs e)
        {
            dt_1.Value = DateTime.Now; dt_2.Value = DateTime.Now;
        }

    }
}
