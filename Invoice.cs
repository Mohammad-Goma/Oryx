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
    public partial class Invoice : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        Boolean Test_Size = false;
        ResizeTools resiz = new ResizeTools(); 
        Boolean found = false;

        public decimal QTY_From_TBl_1 = 0;
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            txt_id.Text = Convert.ToString(max_id_TBL_ORDER());
            resiz.Container = groupBox1;
            resiz.FullRatioTable();
            Select_Parcode(txt_parcode);
            Select_Product_Name(txt_product_name);
            date_invoice.Value = DateTime.Now;
        }

        public void Select_Parcode(TextBox txt_parcode)
        {
            try
            {
                string sql = "SELECT PARCODE FROM PRODUCTS ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col1.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                txt_parcode.AutoCompleteCustomSource = col1;
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

        private void txt_parcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from products where parcode = N'"+txt_parcode.Text.Trim()+"' ";
                SqlCommand cmd = new SqlCommand(s,con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    PARCODE.Text = dr["PARCODE"].ToString();
                    PRODUCT_NAME.Text = dr["PRODUCT_NAME"].ToString();
                    UNIT.Text = dr["UNIT"].ToString();
                    CURRENCY.Text= dr["CURRENCY"].ToString();
                    PRICE.Text = dr["PRICE"].ToString();
                    QTY.Text = dr["QTY"].ToString();
                }
                dr.Close();
                if (chk_fill.Checked) { InsertToDGV(); }
            } catch (Exception) { }
            finally {  con.Close(); }
        }

        private void Order_Qty_TextChanged(object sender, EventArgs e)
        {
            if (Order_Qty.Text == "") { Order_Qty.Text = "1"; } if (PRICE.Text == "") { PRICE.Text = "1"; } decimal c1 = Convert.ToDecimal( Order_Qty.Text.Trim()); decimal c2 = Convert.ToDecimal(PRICE.Text.Trim()); decimal c3 = c1 * c2; txt_Total_Above.Text = c3.ToString();
        }

        private void txt_product_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string s = "select * from products where PRODUCT_NAME = N'" + txt_product_name.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(s, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    PARCODE.Text = dr["PARCODE"].ToString();
                    PRODUCT_NAME.Text = dr["PRODUCT_NAME"].ToString();
                    UNIT.Text = dr["UNIT"].ToString();
                    CURRENCY.Text = dr["CURRENCY"].ToString();
                    PRICE.Text = dr["PRICE"].ToString();
                    QTY.Text = dr["QTY"].ToString();
                }
                dr.Close();
                if (chk_fill.Checked) { InsertToDGV(); }
            } catch (Exception)  { }
            finally { con.Close();   }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            Update_QTY();
            InsertToDGV();
            ClearAbove();
            Balance1();
        }
       
        public void ClearAbove()
        {
            PARCODE.Text = "";
            PRODUCT_NAME.Text = "";
            UNIT.Text = "";
            Order_Qty.Text = "";
            CURRENCY.Text = "";
            PRICE.Text = "";
            txt_Total_Above.Text = "";
            QTY.Text = "";
        }

        public void InsertToDGV()
        {
            try
            {
                string parc = Convert.ToString(PARCODE.Text.Trim());
                string name = PRODUCT_NAME.Text.Trim();
                decimal Qty = Convert.ToDecimal(Order_Qty.Text.Trim());
                string curn = CURRENCY.Text.Trim();
                string unit = UNIT.Text.Trim();
                decimal price = Convert.ToDecimal(PRICE.Text.Trim());
                decimal subtotal = Convert.ToDecimal(txt_Total_Above.Text.Trim());
                string ID = txt_id.Text.Trim();

                if (txt_amount_of_product.Text == "") { txt_amount_of_product.Text = "0"; }
                if (Total_Before.Text == "") { Total_Before.Text = "0"; }
                txt_amount_of_product.Text = (Convert.ToDecimal(txt_amount_of_product.Text) + Qty).ToString();
                Total_Before.Text = (Convert.ToDecimal(Total_Before.Text) + subtotal).ToString();
                found = false;
                if (DGV_INVOCE.Rows.Count > 0)
                {
                    //foreach (DataGridViewRow dtgr in DGV_INVOCE.Rows)   // كود زيادة الكمية فقط
                    //{
                    for(int i=0;i< DGV_INVOCE.Rows.Count; i++)
                    {
                        while (DGV_INVOCE.Rows[i].Cells["col_PARCODE"].Value.ToString() == PARCODE.Text.Trim())
                        {
                            DGV_INVOCE.Rows[i].Cells["col_QTY"].Value = Qty + Convert.ToDecimal(DGV_INVOCE.Rows[i].Cells["col_QTY"].Value);
                            DGV_INVOCE.Rows[i].Cells["col_TOTAL"].Value = subtotal + Convert.ToDecimal(DGV_INVOCE.Rows[i].Cells["col_TOTAL"].Value);
                            found = true;
                            break;
                        }
                    }
                            
                            if(!found) 
                            {
                                object[] row = { parc, name, unit, Qty, curn, price, subtotal, ID };
                                DGV_INVOCE.Rows.Add(row);
                                //break;
                            }
                    //}
                }
                else 
                {
                    object[] row = { parc, name, unit, Qty, curn, price, subtotal, ID };
                    DGV_INVOCE.Rows.Add(row);
                }
            } catch (Exception) { }
        }

        public void Update_QTY()
        {
            try
            {
                if (Order_Qty.Text == "") { Order_Qty.Text = "1"; }
                if (QTY.Text == "") { QTY.Text = "1"; }
                decimal Qty_ord = Convert.ToDecimal(Order_Qty.Text.Trim());
                decimal txt_qua = Convert.ToDecimal(QTY.Text.Trim());
                decimal Finish_QTY = txt_qua - Qty_ord;
                string Finish = Convert.ToString(Finish_QTY);
                con.Open();
                string s = "update products set QTY = '" + Finish + "' where PARCODE = N'"+ PARCODE.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@QTY", Finish);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { con.Close(); }
            
        }

        private void Total_Before_TextChanged(object sender, EventArgs e)
        {
            if (Total_Before.Text == "") { Total_Before.Text = "0"; }
            if (txt_Discount_value.Text == "") { txt_Discount_value.Text = "0"; }
            decimal c1 = Convert.ToDecimal(Total_Before.Text.Trim());
            decimal c2 = Convert.ToDecimal(txt_Discount_value.Text.Trim());
            decimal c3 = c1 - c2;
            c3 = Math.Abs(c3);
            Total_.Text = c3.ToString();
        }

        private void Total__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Total_.Text == "") { Total_.Text = "0"; }
                if (txt_pay.Text == "") { txt_pay.Text = "0"; txt_pay.SelectAll(); }
                decimal c1 = Convert.ToDecimal(Total_.Text.Trim());
                decimal c2 = Convert.ToDecimal(txt_pay.Text.Trim());
                decimal c3 = c1 - c2;
                c3 = Math.Abs(c3);
                The_rest.Text = (c3).ToString();
                //txt_pay.SelectAll();
            } catch (Exception) { }
        }

        private void Discount_percent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Discount_percent.Text.Trim() == "") { Total_.Text = Total_Before.Text.Trim();  txt_Discount_value.Text = "0"; return; }
                decimal txt_qunt = Convert.ToDecimal(Total_Before.Text.Trim());
                decimal percent = Convert.ToDecimal(Discount_percent.Text.Trim());
                decimal Discount_value = Convert.ToDecimal(txt_Discount_value.Text.Trim());
                decimal percent_txt_qunt = (percent * txt_qunt) / 100;
                txt_Discount_value.Text = Convert.ToString(percent_txt_qunt); 
                //Discount_Money.Text = "0";
            } catch (Exception) {  }
        }

        private void Discount_Money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Discount_Money.Text.Trim() == "")
                {   Total_.Text = Total_Before.Text.Trim(); 
                    txt_Discount_value.Text = "0"; return; 
                }
                decimal c1 = Convert.ToDecimal(Total_Before.Text.Trim());
                decimal c2 = Convert.ToDecimal(Discount_Money.Text.Trim());
                txt_Discount_value.Text = Discount_Money.Text.Trim();
                decimal c3 = c1 - c2;
                Total_.Text = c3.ToString();
                //Discount_percent.Text = "0";  
            }
            catch (Exception)
            {

            }
        }

        private void chk_percent_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_percent.Checked)
                {
                    chk_money.Checked = false; 
                }
                Discount_Money.ReadOnly = true;
                Discount_percent.ReadOnly = false;
                Discount_Money.Text = "";    // Total_Discount.Text = "0";
            }
            catch (Exception)
            {

            }
        }

        private void chk_money_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_money.Checked) { chk_percent.Checked = false; chk_money.Checked = true; }
                 Discount_Money.ReadOnly = false;
                 Discount_percent.ReadOnly = true; 
                 Discount_percent.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Invoice_Shown(object sender, EventArgs e)
        {
            Test_Size = true;
        }

        private void Invoice_Resize(object sender, EventArgs e)
        {
            if (Test_Size)
            { resiz.ResizeControls(); }
        }

        private void btn_close_invoice_Click(object sender, EventArgs e)
        {
            Close_Invoice();
        }
        
        public void Close_Invoice()
        {
            try
            {
                decimal Finish2 = 0;
                if (txt_id.Text == Convert.ToString(max_id_TBL_ORDER()))
                {
                    if (MessageBox.Show("انتبة ربما تحذف الفاتورة", "تنبيه بالحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        object prod_PARCODE = "";
                        object Qty_ = "";

                        for (int i = 0; i < DGV_INVOCE.Rows.Count; i++)
                        {
                            DGV_INVOCE.ClearSelection();
                            DGV_INVOCE.Rows[0].Selected = true;
                            while (DGV_INVOCE.Rows.Count > 0 )
                            {
                                Finish2 = 0;

                                prod_PARCODE = Convert.ToString(DGV_INVOCE.Rows[i].Cells["col_PARCODE"].Value);
                                Qty_ = Convert.ToString(DGV_INVOCE.Rows[i].Cells["col_QTY"].Value);

                                decimal DECQty = Convert.ToDecimal(Qty_);
                                QTY_From_TBl_1 = 0;                                  // تصفير الكميات قبل اعطائها قيمة
                                Select_QTY_From_Table(prod_PARCODE);

                                Finish2 = QTY_From_TBl_1 + DECQty;
                                /// Now Update Tbl
                                UPDATE_QUANTITY((Finish2).ToString(), prod_PARCODE);

                                int row_ = DGV_INVOCE.CurrentCell.RowIndex;
                                DGV_INVOCE.Rows.RemoveAt(row_);
                            }
                        }
                        this.Close();
                    }
                    else { return; }
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }   

        public void Select_QTY_From_Table(object prod_PARCODE)
        {
            try
            {
                QTY_From_TBl_1 = 0;

                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string query = "SELECT QTY FROM PRODUCTS WHERE PARCODE = N'" + prod_PARCODE + "' ";
                SqlCommand cmdTbl = new SqlCommand(query, con);
                SqlDataReader dr = cmdTbl.ExecuteReader();
                if (dr.Read())
                {
                    QTY_From_TBl_1 = Convert.ToDecimal(dr["QTY"].ToString());
                    dr.Close();
                    con.Close();
                }
            }
            catch (Exception) {  }
        }

        public void UPDATE_QUANTITY(object Finish, object txt_par)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                string sql = "UPDATE products set QTY = N'" + Finish + "' Where PARCODE = N'" + txt_par + "' ";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@QTY", Finish); 
            
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        public void Save()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string selectID = "Select ID from INVOICE ";
                SqlCommand cmd = new SqlCommand(selectID, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (txt_id.Text.Trim() == dr["ID"].ToString())
                    {
                        MessageBox.Show("يرجى اختيار فاتورة جديدة", "تنبيه الفاتورة مدخلة من قبل");
                        dr.Close();
                        con.Close();
                        return;
                    }
                }
                dr.Close();
                con.Close();

                if (DGV_INVOCE.Rows.Count <= 0)
                {
                    MessageBox.Show(" يرجى ملئ الفاتورة بالبيانات ");
                }
                else
                {
                    Save_Order();
                    Save_Order_Details();
                    msg_invoice.Text = "  تمت عملية الحفظ بنجاح  ";
                }
            } catch (Exception) { }
        }

        private void btn_Save_Without_Print_Click(object sender, EventArgs e)
        {
            Save();
            txt_id.Text = max_id_TBL_ORDER().ToString();
        }

        public void Save_Order_Details()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                for (int i = 0; i < DGV_INVOCE.Rows.Count; i++)
                {
                    string sqlquerry = "Insert into [dbo].[INVOICE_DETAILS] (PARCODE,PRODUCT_NAME,UNIT,QTY,CURRENCY,PRICE,TOTAL,ID_ORDER,HAND_ID)" +
                    " Values (@PARCODE,@PRODUCT_NAME,@UNIT,@QTY,@CURRENCY,@PRICE,@TOTAL,@ID_ORDER,@HAND_ID) ";
                    SqlCommand cmd = new SqlCommand(sqlquerry, con);
                    cmd.Parameters.AddWithValue("@PARCODE", DGV_INVOCE.Rows[i].Cells["col_PARCODE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@PRODUCT_NAME", DGV_INVOCE.Rows[i].Cells["col_PRODUCT_NAME"].Value.ToString());
                    cmd.Parameters.AddWithValue("@UNIT", DGV_INVOCE.Rows[i].Cells["col_UNIT"].Value.ToString());
                    cmd.Parameters.AddWithValue("@QTY", DGV_INVOCE.Rows[i].Cells["col_QTY"].Value.ToString());
                    cmd.Parameters.AddWithValue("@CURRENCY", DGV_INVOCE.Rows[i].Cells["col_CURRENCY"].Value.ToString());
                    cmd.Parameters.AddWithValue("@PRICE", DGV_INVOCE.Rows[i].Cells["col_PRICE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@TOTAL", DGV_INVOCE.Rows[i].Cells["col_TOTAL"].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID_ORDER", txt_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@HAND_ID", txt_id.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                DGV_INVOCE.Rows.Clear();
                con.Close();
            } catch (Exception) { }
        }

        public void Save_Order()
        {
            string id = Convert.ToString(max_id_TBL_ORDER());
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            string sqlcon = " Insert into [dbo].[INVOICE] Values(N'" + txt_id.Text.Trim() + "'," +
                "N'" + cbo_store.Text.Trim() + "',N'" + date_invoice.Text.Trim() + "',N'" + txt_amount_of_product.Text.Trim() + "'," +
                "N'" + txt_amount_of_product.Text.Trim() + "',N'" + txt_Discount_value.Text.Trim() + "',N'" + Total_.Text.Trim() + "'," +
                "N'" + txt_pay.Text.Trim() + "',N'" + The_rest.Text.Trim() + "',N'" + 1 + "' ) ";
            SqlCommand cmd = new SqlCommand(sqlcon, con);
            cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ID_Order_Invoice", txt_id.Text.Trim());
            cmd.Parameters.AddWithValue("@STORE_NAME", cbo_store.Text.Trim());
            cmd.Parameters.AddWithValue("@DATE", date_invoice.Text.Trim());
            cmd.Parameters.AddWithValue("@AMOUNT_ITEMS", txt_amount_of_product.Text.Trim());
            cmd.Parameters.AddWithValue("@TOTAL_BEFORE_DISCOUNT", Total_Before.Text.Trim());
            cmd.Parameters.AddWithValue("@DISCOUNT", txt_Discount_value.Text.Trim());
            cmd.Parameters.AddWithValue("@TOTAL", Total_.Text.Trim());
            cmd.Parameters.AddWithValue("@PAYING", txt_pay.Text.Trim());
            cmd.Parameters.AddWithValue("@REST", The_rest.Text.Trim());
            cmd.Parameters.AddWithValue("@ID_STORE", 1);
            con.Close();
        }

        public Int64 max_id_TBL_ORDER()
        {
           if (con.State == ConnectionState.Open) { con.Close(); }
            int id = 0;
            con.Open();
            SqlCommand cmd_max = new SqlCommand("SELECT MAX(ID) AS fds FROM INVOICE", con);
            cmd_max.ExecuteNonQuery();

            DataSet dts = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd_max);
            da.Fill(dts);
            DataRow drS;
            drS = dts.Tables[0].Rows[0];
            id = Convert.ToInt32(drS["fds"].ToString());
            id++;
            con.Close();
            return id;
        }

        private void Invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10 && DGV_INVOCE.Rows.Count > 0)
            {
                Print_key();           // طباعة الفاتورة الصغيرة
            }
            else if (e.KeyCode == Keys.F9 && DGV_INVOCE.Rows.Count > 0)
            {
                //PrintAuto();         //الطباعة مع ظهور الاعدادات
            }
            else
            if (e.KeyCode == Keys.F1 && DGV_INVOCE.Rows.Count > 0)
            {
                Save();               //حفظ 
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                Close_Invoice();
            }
            else
            if (e.KeyCode == Keys.F7 && DGV_INVOCE.Rows.Count > 0)
            {
                //Print_key_BigformF7();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Print_key();
        }

        public void Print_key()
        {
            try
            {
                frm_crystal_invoice frm = new frm_crystal_invoice( date_invoice.Text.Trim(),
                                    txt_id.Text.Trim(), txt_amount_of_product.Text.Trim(),
                                    txt_Discount_value.Text.Trim(), txt_pay.Text.Trim(),
                                    The_rest.Text.Trim(), Total_.Text.Trim());
                CrystalReport1 rp = new CrystalReport1();
                DataSet1 myds = new DataSet1();

                foreach (DataGridViewRow dgv in DGV_INVOCE.Rows)
                {
                    myds.Debt.Rows.Add( dgv.Cells["col_PRODUCT_NAME"].Value, dgv.Cells["col_QTY"].Value,
                                        dgv.Cells["col_PRICE"].Value);
                }
                DataView dv = new DataView(myds.Tables["Debt"]);
                rp.SetDataSource(dv);
                rp.SetParameterValue("date_invoice", date_invoice.Text.Trim());
                rp.SetParameterValue("txt_id", txt_id.Text.Trim());
                rp.SetParameterValue("txt_amount_of_product", txt_amount_of_product.Text.Trim());
                rp.SetParameterValue("Total_", txt_Discount_value.Text.Trim());
                rp.SetParameterValue("txt_pay", txt_pay.Text.Trim());
                rp.SetParameterValue("txt_The_rest", The_rest.Text.Trim());
                rp.SetParameterValue("Total_2", Total_.Text.Trim()); 
                
                frm.crystalReportViewer.ReportSource = rp;
                frm.crystalReportViewer.Refresh();
                frm.Show();
                // rp.PrintToPrinter(1, false, 0, 0);
                // labeltrue();
            }
            catch (Exception) { }
        }

        private void btn_show_invoice_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txt_search.Text.Trim() == ""  )
                {
                    MessageBox.Show("من فضلك إختر رقم الفاتورة المراد البحث عنه");
                }
                else
                {
                    //labelfalse();
                    txt_parcode.Text = "";
                    //labelfalse_2();
                    Show_invoice("'+ID+'", txt_search);
                    Show_invoice_Details("'+ID_ORDER+'", txt_search);
                }
            //}
            //catch (Exception EXC) { MessageBox.Show(EXC.Message); }
            //finally { btn_Save_Without_Print.Visible = false; }
        }

        public void Show_invoice(string fld, TextBox txt)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,STORE_NAME,DATE,AMOUNT_ITEMS,TOTAL_BEFORE_DISCOUNT,DISCOUNT,TOTAL,PAYING,REST from INVOICE Where '"+fld+"' = N'"+txt.Text.Trim()+"' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_id.Text = dr["ID"].ToString();
                cbo_store.Text = dr["STORE_NAME"].ToString();
                //string Datestring = dr["DATE"].ToString();
                date_invoice.Value = Convert.ToDateTime(dr["DATE"].ToString());
                txt_amount_of_product.Text = dr["AMOUNT_ITEMS"].ToString();
                Total_Before.Text = dr["TOTAL_BEFORE_DISCOUNT"].ToString();
                txt_Discount_value.Text = dr["DISCOUNT"].ToString();
                Total_.Text = dr["TOTAL"].ToString();
                txt_pay.Text = dr["PAYING"].ToString();
                The_rest.Text = dr["REST"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void Show_invoice_Details(string fld, TextBox txt)
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PARCODE,PRODUCT_NAME,UNIT,QTY,PRICE,TOTAL From INVOICE_DETAILS Where '" + fld + "' = N'" + txt.Text.Trim() + "' ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV_INVOCE.DataSource = dt; 
            con.Close();
        }

        private void txt_pay_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pay.SelectAll();
        }

        private void btn_new_invoice_Click(object sender, EventArgs e)
        {
            decimal Finish3 = 0;
            //if (MessageBox.Show("انتبة ربما تحذف الفاتورة", "تنبيه بالحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //{
            object prod_PARCODE = "";
            object Qty_ = "";
            if (txt_id.Text == Convert.ToString(max_id_TBL_ORDER()) && DGV_INVOCE.HasChildren)
            {
                for (int i = 0; i < DGV_INVOCE.Rows.Count; i++)
                {
                    DGV_INVOCE.ClearSelection();
                    DGV_INVOCE.Rows[0].Selected = true;
                    while (DGV_INVOCE.Rows.Count > 0)
                    {
                        Finish3 = 0;

                        prod_PARCODE = Convert.ToString(DGV_INVOCE.Rows[i].Cells["col_PARCODE"].Value);
                        Qty_ = Convert.ToString(DGV_INVOCE.Rows[i].Cells["col_QTY"].Value);

                        decimal DECQty = Convert.ToDecimal(Qty_);
                        QTY_From_TBl_1 = 0;                                  // تصفير الكميات قبل اعطائها قيمة
                        Select_QTY_From_Table(prod_PARCODE);

                        Finish3 = QTY_From_TBl_1 + DECQty;
                        /// Now Update Tbl
                        UPDATE_QUANTITY((Finish3).ToString(), prod_PARCODE);

                        int row_ = DGV_INVOCE.CurrentCell.RowIndex;
                        DGV_INVOCE.Rows.RemoveAt(row_);
                    }
                }
                
            }
            this.Close();
            Invoice inv = new Invoice();
            inv.Show();
        }

        private void btn_delete_row_Click(object sender, EventArgs e)
        {
            Delete_Row();
        }

        public void Delete_Row()
        {
            int rowindex = DGV_INVOCE.CurrentCell.RowIndex;
            try
            {
                //if (txt_parcode_invoice.Text == "" && txt_product_name_invoice.Text == "") { MessageBox.Show("من فضلك أختر الصنف المراد حذفه من  فاتورة المبيعات"); }
                //else
                //{
                decimal Qty_Ord = Convert.ToDecimal(Order_Qty.Text.Trim());
                //decimal qty2 = Convert.ToDecimal(back_qty.Text.Trim());
                //decimal qt_3 = Convert.ToDecimal(qty3.Text.Trim());
                decimal qty_ = Convert.ToDecimal(QTY.Text.Trim());
                //   قراءة الصف الحالي      
                decimal txt_qunt = Convert.ToDecimal(Total_Before.Text.Trim());         //   تحويل قيمة خلية المجموع الاولي الي ديسميل   
                decimal dec_item = Convert.ToDecimal(txt_Total_Above.Text.Trim());  //   تحويل خلية المجموع الى ديسيميل
                Total_Before.Text = Convert.ToString(txt_qunt - dec_item);              //   اعطاء قيمة جديدة لخلية المجموع

                //int amount = Convert.ToInt32(txt_amount_of_product.Text.Trim());    //   حذف الكمية المحذوفة من بوكس مجموع الكميات
                //txt_amount_of_product.Text = Convert.ToString(amount - qty_);       //   حذف الكمية المحذوفة من بوكس مجموع الكميات

                decimal txt_qua = Convert.ToDecimal(QTY.Text.Trim());
                //Order_Qty.Text = Convert.ToString(Qty_Ord);
                decimal qua_Qty = txt_qua + Qty_Ord;                                //   زيادة قيمة الكمية المتوفرة  
                
                string Finish = Convert.ToString(qua_Qty);
               
                UPDATE_QUANTITY(Finish, PARCODE.Text.Trim());

                DGV_INVOCE.Rows.RemoveAt(rowindex);                      // حذف الصف الحالي
                                                                         //if (qty2 <= qt_3) { } else { Qty_Qty2(); fill_2product_tblByID(); fill_2product_tblByName(); }
                ClearAbove();

                fill_product_tblByID(txt_parcode);
                fill_product_tblByID(txt_search);
                fill_2product_tblByName(txt_product_name);
                //Clear();
                //}
            }
            catch (Exception) { DGV_INVOCE.Rows.RemoveAt(rowindex); }
            finally { btn_delete_row.Enabled = false; Balance1(); }
        }
        public void Balance1()
        {
            txt_amount_of_product.Text = "";
            decimal A = 0;
            try
            {
                for (int i = 0; i < DGV_INVOCE.Rows.Count; i++)
                {
                    A += Convert.ToDecimal(DGV_INVOCE.Rows[i].Cells["col_QTY"].Value.ToString());
                }
            }
            catch { }
            finally
            {
                txt_amount_of_product.Text = A.ToString();
            }
        }
        public void fill_product_tblByID(TextBox txt_parcode)
        {
            try
            {
                string sql = "SELECT PARCODE FROM PRODUCTS";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col1.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                txt_parcode.AutoCompleteCustomSource = col1;
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        public void fill_2product_tblByName(TextBox txt_product_name)
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
                txt_product_name.AutoCompleteCustomSource = col1;
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void DGV_INVOCE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGV_INVOCE.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    //Select_Rows_From_DGVToBoxesAbove();
                    chk_fill.Checked = false; 
                    //PARCODE.Text = DGV_INVOCE.SelectedRows[0].Cells["col_PARCODE"].Value.ToString();
                    PARCODE.Text = DGV_INVOCE.SelectedRows[0].Cells["col_PARCODE"].Value.ToString();
                    PRODUCT_NAME.Text = DGV_INVOCE.SelectedRows[0].Cells["col_PRODUCT_NAME"].Value.ToString();
                    UNIT.Text = DGV_INVOCE.SelectedRows[0].Cells["COL_UNIT"].Value.ToString();
                    Order_Qty.Text = DGV_INVOCE.SelectedRows[0].Cells["col_QTY"].Value.ToString();
                    CURRENCY.Text = DGV_INVOCE.SelectedRows[0].Cells["col_CURRENCY"].Value.ToString();
                    PRICE.Text = DGV_INVOCE.SelectedRows[0].Cells["col_PRICE"].Value.ToString();
                    Total_.Text = DGV_INVOCE.SelectedRows[0].Cells["col_TOTAL"].Value.ToString();
                    Select_Quantity(PARCODE);
                    btn_delete_row.Enabled = true;
                    btn_delete_row.BackColor = Color.MediumVioletRed;
                }
            }
            catch (Exception)
            {

            }

        }

        public void Select_Quantity(TextBox PARCODE)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string query = "SELECT QTY FROM PRODUCTS WHERE PARCODE = N'" + PARCODE.Text.Trim() + "' ";
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    QTY.Text = dr["QTY"].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {

            }
        }

    }
}
