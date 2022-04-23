using CrystalDecisions.CrystalReports.Engine;
using Oryx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SALES
{
    public partial class frm_Billing : Form
    {

        ResizeTools resiz = new ResizeTools();
        Boolean Test_Size = false;
        frm_Billing billing;
        Fill_Cbo fill_Cbo = new Fill_Cbo();

        public decimal QTY_From_TBl_1 = 0;
        //Tbl_Billing Billing = new Tbl_Billing();

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        SqlCommand cmd;
        public frm_Billing()

        {
            InitializeComponent();
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
            catch (Exception) { }
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

        public void Close_Invoice()
        {
            try
            {
                decimal Finish2 = 0;
                if (txt_id.Text == Convert.ToString(maxid()))
                {
                    if (MessageBox.Show("انتبة ربما تحذف الفاتورة", "تنبيه بالحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        object prod_PARCODE = "";
                        object Qty_ = "";

                        for (int i = 0; i < DGV_Billing.Rows.Count; i++)
                        {
                            DGV_Billing.ClearSelection();
                            DGV_Billing.Rows[0].Selected = true;
                            while (DGV_Billing.Rows.Count > 0)
                            {
                                Finish2 = 0;

                                prod_PARCODE = Convert.ToString(DGV_Billing.Rows[i].Cells["Parcode"].Value);
                                Qty_ = Convert.ToString(DGV_Billing.Rows[i].Cells["Qty"].Value);

                                decimal DECQty = Convert.ToDecimal(Qty_);
                                QTY_From_TBl_1 = 0;                                  // تصفير الكميات قبل اعطائها قيمة
                                Select_QTY_From_Table(prod_PARCODE);

                                Finish2 = QTY_From_TBl_1 - DECQty;
                                /// Now Update Tbl
                                UPDATE_QUANTITY((Finish2).ToString(), prod_PARCODE);

                                int row_ = DGV_Billing.CurrentCell.RowIndex;
                                DGV_Billing.Rows.RemoveAt(row_);
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close_Invoice();
            //try
            //{
            //    if (txt_id.Text == Convert.ToString( maxid() ) )
            //    {
            //        if (MessageBox.Show("انتبة ربما تحذف الفاتورة", "تنبيه بالحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //        {
            //            DGV_Billing.Rows[0].Selected = true;
            //            for (int i = 0; i < DGV_Billing.Rows.Count; i++)
            //            {
            //                chk_fill.Checked = false;
            //                btn_Delete_Billing.Enabled = false;
            //                while (DGV_Billing.Rows.Count > 0)
            //                {
            //                    DGV_Billing.Rows[0].Selected = true;
            //                    txt_parcode.Text = Convert.ToString(DGV_Billing.Rows[i].Cells["Parcode"].Value);
            //                    txt_qty.Text = Convert.ToString(DGV_Billing.Rows[i].Cells["Qty"].Value);
            //                    Delete_Row();
            //                }
            //            }
            //            this.Close();
            //            //ClearAll();
            //        }
            //    }
            //    else { this.Close(); }
            //}
            //catch (Exception) { }
            //finally { chk_fill.Checked = false; }
        }

        private void chk_percent_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DISCOUNT_MONEY.Text = " ";
                chk_Money.Checked = false;
                DISCOUNT_PERCENT.ReadOnly = false;
                //DISCOUNT_PERCENT.SelectAll();
                DISCOUNT_MONEY.ReadOnly = true;
                TOTAL_DISCOUNT.Text = "  ";
                TOTAL_AFTER_DISCOUNT.Text = TOTAL_BEFORE_DISCOUNT.Text.Trim();
            }
            catch (Exception) { }
        }

        private void chk_Money_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chk_percent.Checked = false;
                DISCOUNT_MONEY.ReadOnly = false;
                DISCOUNT_PERCENT.ReadOnly = true;
                DISCOUNT_PERCENT.Text = " ";
                TOTAL_DISCOUNT.Text = "";
                //DISCOUNT_MONEY.SelectAll();
            }
            catch (Exception) { }
        }

        private void txt_total_Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TOTAL_BEFORE_DISCOUNT.Text.Trim() == "" || TOTAL_BEFORE_DISCOUNT.Text.Trim() == null || TOTAL_BEFORE_DISCOUNT.Text.Trim() == "0")
                {
                    TOTAL_AFTER_DISCOUNT.Text = TOTAL_BEFORE_DISCOUNT.Text.Trim();
                }
                else
                {
                    decimal totalbefore = Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text.Trim());
                    decimal total_disccount = Convert.ToDecimal(TOTAL_DISCOUNT.Text.Trim());
                    decimal total_After_disccount = totalbefore - total_disccount;

                    TOTAL_AFTER_DISCOUNT.Text = Convert.ToString(total_After_disccount);
                }
            }
            catch (Exception) { };
        }

        private void txt_Discount_percent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DISCOUNT_PERCENT.Text.Trim() == "" || DISCOUNT_PERCENT.Text.Trim() == null) { TOTAL_DISCOUNT.Text = "0"; }
                else
                {
                    decimal totalbefore = Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text.Trim());
                    decimal discount_percent = Convert.ToDecimal(DISCOUNT_PERCENT.Text.Trim());
                    if (DISCOUNT_PERCENT.Text.Trim() == " ") { TOTAL_DISCOUNT.Text = "0"; }
                    decimal total_disccount = (discount_percent * totalbefore) / 100;

                    TOTAL_DISCOUNT.Text = Convert.ToString(total_disccount);
                    TOTAL_AFTER_DISCOUNT.Text = Convert.ToString(totalbefore - total_disccount);
                }
            }
            catch (Exception) { };
        }

        private void txt_Discount_Money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DISCOUNT_MONEY.Text.Trim() == "")
                {
                    DISCOUNT_MONEY.Text = " ";
                    TOTAL_DISCOUNT.Text = " ";
                };
                decimal totalbefore = 0;
                totalbefore = Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text.Trim());
                decimal discount_money = 0;
                if (DISCOUNT_MONEY.Text.Trim() == "") { DISCOUNT_MONEY.Text = " "; }
                else
                {
                    discount_money = Convert.ToDecimal(DISCOUNT_MONEY.Text.Trim());
                }

                if (DISCOUNT_MONEY.Text.Trim() == "") { TOTAL_DISCOUNT.Text = "0"; }
                else { TOTAL_DISCOUNT.Text = DISCOUNT_MONEY.Text.Trim(); }
            }
            catch (Exception) { };
        }


        public Int32 maxid()
        {
            int id = 0;
            con.Close();
            cmd = new SqlCommand("Select max(ID) as fds From TBL_BILLING ", con);
            con.Open();
            cmd.ExecuteNonQuery();

            DataSet dsS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(dsS);

            DataRow drS;
            drS = dsS.Tables[0].Rows[0];
            id = Convert.ToInt32(drS["fds"].ToString());

            id++;
            con.Close();
            return id;
        }

        private void frm_Billing_Load(object sender, EventArgs e)
        {
            resiz.Container = Group_1_Billing;
            resiz.FullRatioTable();

            //USER_NAME.Text = Main_Form.USER_NAME_STRING.Trim();
            //fill_Cbo.Fill_Branches(BRANCH_NAME);
            //fill_Cbo.fill_stores_Data(STORE_NAME);
            //fill_Cbo.Fill_Customers(CUSTOMER_RECIVE_BILLING);
            //fill_Cbo.Fill_Deleget(DELEGET_NAME);
            //fill_Cbo.Fill_Currency(CURENCY);
            fill_Cbo.fill_2product_tblByID(txt_parcode);
            fill_Cbo.fill_2product_tblByName(txt_product_name);
            txt_id.Text = Convert.ToString(maxid());
            Search_Billing_Num(search);
            btn_Save_billing.Visible = true;
            //fill_Cbo.Fill_Billing(txt_parcode, txt_product_name);
            //DGV_Billing.Columns[9].DefaultCellStyle.BackColor = Color.YellowGreen;
            //DGV_Billing.Columns[9].DefaultCellStyle.ForeColor = Color.Blue;
            DATE_TIME_NOW.Value = DateTime.Now;
            DELEGET_BILLING_DATE.Value = DateTime.Now;
        }

        public void lvl_permessions()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string Query = "Select Billing_open_screen,Billing_save,Billing_new From USERS_PERMESSIONS Where USER_NAME = N'" + USER_NAME.Text.Trim() + "' ";
                SqlCommand cmd22 = new SqlCommand(Query, con);
                SqlDataReader dr2 = cmd22.ExecuteReader();
                if (dr2.Read())
                {
                    if (dr2["Billing_open_screen"].ToString() == "True") { } else { this.Close(); return; }
                    if (dr2["Billing_save"].ToString() == "True") { btn_Save_billing.Enabled = true; } else { btn_Save_billing.Enabled = false; }
                    if (dr2["Billing_new"].ToString() == "True") { btn_new_billing.Enabled = true; } else { btn_new_billing.Enabled = false; }
                }
                dr2.Close();
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void frm_Billing_Shown(object sender, EventArgs e)
        {
            Test_Size = true;
            lvl_permessions();
        }

        private void frm_Billing_Resize(object sender, EventArgs e)
        {
            if (Test_Size)
            { resiz.ResizeControls(); }
        }

        private void txt_Total_Brfore_Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal txt_qunt = Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text.Trim());
                decimal Total_discount = Convert.ToDecimal(TOTAL_DISCOUNT.Text.Trim());

                TOTAL_AFTER_DISCOUNT.Text = Convert.ToString(txt_qunt - Total_discount);
                if (chk_percent.Checked) { txt_Discount_percent_TextChanged(sender, e); }
                else if (chk_Money.Checked) { txt_Discount_Money_TextChanged(sender, e); }
            }
            catch (Exception) { };
        }

        private void Total_After_Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TOTAL_AFTER_DISCOUNT.Text.Trim() == "0" || TOTAL_AFTER_DISCOUNT.Text.Trim() == null || TOTAL_AFTER_DISCOUNT.Text.Trim() == "")
                {
                    txt_Total_Last.Text = TOTAL_BEFORE_DISCOUNT.Text.Trim();
                }
                else
                {
                    txt_Total_Last.Text = TOTAL_AFTER_DISCOUNT.Text.Trim();
                }
            }
            catch (Exception) { };

        }

        private void txt_Discount_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Discount_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Down_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Delget_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_new_invoice_Click(object sender, EventArgs e)
        {
            Close_Invoice();
            billing = new frm_Billing(); billing.Show();
            billing.WindowState = FormWindowState.Maximized;
        }

        public void parcode_to_boxes()
        {
            try
            {
                //ID.Text = "";
                //txt_qty.Text = "";
                //finish_qty.Text = "";
                if (txt_parcode.Text.Trim() == "") { txt_par.Text = ""; txt_name.Text = ""; txt_unit.Text = ""; txt_first_price.Text = ""; txt_Price.Text = ""; txt_quantity_store.Text = ""; FINISH_PRICE.Text = ""; txt_qty.Text = "1"; }
                else
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID, PARCODE ,PRODUCT_NAME ,UNIT ,CURRENCY ,INITIAL_COAST ,PRICE ,LESS_PRICE ,FINISH_PRICE ,FINISH_PRICE ,QTY FROM PRODUCTS WHERE PARCODE = N'"+txt_parcode.Text.Trim()+"' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txt_par.Text = dr["PARCODE"].ToString();
                        txt_name.Text = dr["PRODUCT_NAME"].ToString();
                        txt_unit.Text = dr["UNIT"].ToString();
                        CURRENCY.Text = dr["CURRENCY"].ToString();
                        txt_first_price.Text = dr["INITIAL_COAST"].ToString();
                        txt_Price.Text = dr["PRICE"].ToString();
                        txt_qty.Text = "1";
                        //order.Text = dr["Items_Number"].ToString();
                        ID.Text = dr["ID"].ToString();
                        txt_quantity_store.Text = dr["QTY"].ToString();
                        txt_lessprice.Text = dr["LESS_PRICE"].ToString();
                        FINISH_PRICE.Text = dr["FINISH_PRICE"].ToString();
                        //txt_qty.Text = "1";
                        ID_FK.Text = "";
                    }
                    dr.Close();
                }
                btn_Delete_Billing.Enabled = false;
                btn_Delete_Billing.BackColor = Color.White;
                txt_first_price.ReadOnly = true;
                txt_qty.ReadOnly = false;
                btn_Add_Billing.Enabled = true;
                //decimal qty = Convert.ToDecimal(txt_qty.Text.Trim());
                //decimal Price = Convert.ToDecimal(txt_Price.Text.Trim());
                //txt_total_Above.Text = Convert.ToString(qty * Price);
            }
            catch (Exception) {  }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        private void txt_parcode_TextChanged(object sender, EventArgs e)
        {
            if (txt_parcode.Text.Trim() == "") { ClearTExAboveDGV_Billing(); return; }
            parcode_to_boxes();

            if (chk_fill.Checked && txt_par.Text.Trim() != "" && txt_name.Text.Trim() != "")
            {
                ADD();
            }
            
            btn_Save_billing.Visible = true;
        }

        public void insertintoDGV()
        {
            //try
            //{
            if (finish_qty.Text.Trim() == "") { finish_qty.Text = "0"; }
                decimal qty_finish = Convert.ToDecimal(finish_qty.Text.Trim());
                string parcode = txt_par.Text.Trim();
                string product_name = txt_name.Text.Trim();
                string unit = txt_unit.Text.Trim();
                if (txt_first_price.Text.Trim() == "") { txt_first_price.Text = "0"; }
                string Cur = CURRENCY.Text.Trim();
                decimal first_price = Convert.ToDecimal(txt_first_price.Text.Trim());
                if (txt_Price.Text.Trim() == "") { txt_Price.Text = "0"; }
                decimal price = Convert.ToDecimal(txt_Price.Text.Trim());
                if (txt_lessprice.Text.Trim() == "") { txt_lessprice.Text = "0"; }
                decimal less_price = Convert.ToDecimal(txt_lessprice.Text.Trim());
                decimal FINISHPRICE;
                if (FINISH_PRICE.Text.Trim() == "") { FINISH_PRICE.Text = "0"; }
                FINISHPRICE = Convert.ToDecimal(FINISH_PRICE.Text.Trim());
                decimal qty = Convert.ToDecimal(txt_qty.Text.Trim());
                decimal qty_store = Convert.ToDecimal(txt_quantity_store.Text.Trim());
                //decimal Total_All = qty * price;
                decimal total = Convert.ToDecimal(txt_total_Above.Text.Trim());
                //string DeleteRow = "حذف الصنف";

                object[] row = { parcode, product_name, unit, Cur, first_price, price, less_price, FINISHPRICE, qty, total };

                DGV_Billing.Rows.Add(row);

                if (TOTAL_AMOUNT.Text.Trim() == "" || TOTAL_AMOUNT.Text.Trim() == null) { TOTAL_AMOUNT.Text = "0"; }
                else if (TOTAL_BEFORE_DISCOUNT.Text.Trim() == "" || TOTAL_BEFORE_DISCOUNT.Text.Trim() == null) { TOTAL_BEFORE_DISCOUNT.Text = "0"; }
                TOTAL_AMOUNT.Text = (Convert.ToDecimal(TOTAL_AMOUNT.Text) + qty).ToString();
                TOTAL_BEFORE_DISCOUNT.Text = (Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text) + total).ToString();

                //decimal doubleqty = qty_store + qty_finish;
                //string Finish = Convert.ToString(doubleqty);
                
                //fill_Cbo.UpdateP1_Parcode(Finish, txt_par);
                                                                  //  تحديث الكمية الموجودة في المخزن
                ClearTExAboveDGV_Billing();
            //}
            //catch (Exception)
            //{

            //}
        }
        public void Update_QTY()
        {
            try
            {
                if (txt_qty.Text == "") { txt_qty.Text = "1"; }
                if (txt_quantity_store.Text == "") { txt_quantity_store.Text = "1"; }

                decimal Qty_ord = Convert.ToDecimal(txt_qty.Text.Trim());
                decimal txt_qua = Convert.ToDecimal(txt_quantity_store.Text.Trim());

                decimal Finish_QTY = txt_qua + Qty_ord;
                string Finish = Convert.ToString(Finish_QTY);
                con.Open();
                string s = "Update Products Set QTY = '" + Finish + "' where PARCODE = N'" + txt_parcode.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@QTY", Finish);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { con.Close(); }

        }
        public void ADD()
        {
            try
            {
                //if (finish_qty.Text.Trim() == "") { txt_qty.Text = "0"; }
                //decimal qty_finish = Convert.ToDecimal(txt_qty.Text.Trim());                 //
                if (txt_qty.Text.Trim() == "") { txt_qty.Text = "0"; }
                decimal qty_ord = Convert.ToDecimal(txt_qty.Text.Trim());                       //
                if (txt_quantity_store.Text.Trim() == "") { txt_quantity_store.Text = "0"; }
                decimal qty_store = Convert.ToDecimal(txt_quantity_store.Text.Trim());          //
                if (txt_total_Above.Text.Trim() == "") { txt_total_Above.Text = "0"; }
                decimal total = Convert.ToDecimal( txt_total_Above.Text.Trim() );
                //if (txt_par.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_unit.Text.Trim() == "" || txt_first_price.Text.Trim() == "" || txt_Price.Text.Trim() == "" || txt_quantity_store.Text.Trim() == "" || txt_tax.Text.Trim() == "" || txt_qty.Text.Trim() == "" || txt_total_Above.Text.Trim() == "") { txt_msg_Billing.Text="من فضلك املأ كامل البيانات";return; }
                bool found = false;
                if (DGV_Billing.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dtrow in DGV_Billing.Rows)
                    {
                        if (Convert.ToString(dtrow.Cells["Parcode"].Value) == txt_par.Text.Trim() && Convert.ToString(dtrow.Cells["Product_Name"].Value) == txt_name.Text.Trim())
                        {
                            dtrow.Cells["Qty"].Value = Convert.ToString(qty_ord + Convert.ToDecimal(dtrow.Cells["Qty"].Value)); // 
                            dtrow.Cells["Total"].Value = Convert.ToString(total + Convert.ToDecimal(dtrow.Cells["Total"].Value));
                            found = true;

                            //decimal doubleqty = qty_store + qty_ord;
                            //string Finish = Convert.ToString(doubleqty);
                            //Update_QTY(Finish , txt_par);
                            //fill_Cbo.UpdateP1_Parcode(Finish, txt_par);

                            TOTAL_AMOUNT.Text = (Convert.ToDecimal(TOTAL_AMOUNT.Text) + qty_ord).ToString();
                            TOTAL_BEFORE_DISCOUNT.Text = (Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text) + total).ToString();
                            ClearTExAboveDGV_Billing();
                            found = true;              //
                        }
                    }
                    if (!found)
                    {
                        insertintoDGV();
                    }
                } else { insertintoDGV(); }
            }
            catch (Exception) { }
            finally
            {
                if (finish_qty.Text.Trim() == "") { finish_qty.Text = "1"; }
            ID.Text = "";
            txt_qty.Text = "";
            finish_qty.Text = "";
            btn_Delete_Billing.Enabled = false;
            }
        }
        private void btn_Add_Billing_Click(object sender, EventArgs e)
        {
            ADD();
        }

        public void ClearTExAboveDGV_Billing()
        {
            //txt_parcode.Text = "";
            //txt_product_name.Text = "";
            txt_par.Text = "";
            txt_name.Text = "";
            txt_unit.Text = "";
            txt_first_price.Text = "";
            txt_Price.Text = "";
            CURRENCY.Text = "";
            txt_quantity_store.Text = "";
            FINISH_PRICE.Text = "";
            txt_qty.Text = "1";
            btn_Delete_Billing.Enabled = false;
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (FINISH_PRICE.Text.Trim() == "") { FINISH_PRICE.Text = "1"; txt_total_Above.Text = "1"; } else if (txt_qty.Text.Trim() == "") { txt_total_Above.Text = FINISH_PRICE.Text.Trim(); } else { decimal price = Convert.ToDecimal(FINISH_PRICE.Text.Trim()); decimal qty = Convert.ToDecimal(txt_qty.Text.Trim()); decimal Suptotal = price * qty; txt_total_Above.Text = Convert.ToString(Suptotal); }
            //}
            //catch (Exception)
            //{
            //}
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            QTY();
        }

        public void QTY()
        {
            try
            {
                if (txt_qty.Text.Trim() == "") { txt_qty.Text = "1"; txt_qty.SelectAll(); }
                if (FINISH_PRICE.Text.Trim() == "") { FINISH_PRICE.Text = "0"; } 
                decimal price = Convert.ToDecimal(FINISH_PRICE.Text.Trim()); 
                decimal qty = Convert.ToDecimal(txt_qty.Text.Trim()); 
                decimal Suptotal = price * qty; 
                txt_total_Above.Text = Convert.ToString(Suptotal);
            }
            //if (txt_qty.Text.Trim() == "") { txt_total_Above.Text = txt_first_price.Text.Trim(); } 
            catch (Exception) { }
        }
        private void txt_Total_Last_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txt_Total_Last.Text.Trim() == "") { txt_The_rest.Text = ""; }
            //    else
            //if (txt_Down_payment.Text.Trim() == "" || txt_Down_payment.Text.Trim() == null) { txt_The_rest.Text = txt_Total_Last.Text.Trim(); }
            //    decimal txt_last = Convert.ToDecimal(txt_Total_Last.Text.Trim());
            //    decimal pay = Convert.ToDecimal(txt_Down_payment.Text.Trim());
            //    decimal rest = txt_last - pay;
            //    txt_The_rest.Text = Convert.ToString(rest);
            //}
            //catch(Exception EXC) { }
        }

        public void txt_name_product()
        {
            try
            {
                //ID.Text = "";
                //txt_qty.Text = "";
                //finish_qty.Text = "";
                if (txt_product_name.Text.Trim() == "") { txt_par.Text = ""; txt_name.Text = ""; txt_unit.Text = ""; txt_first_price.Text = ""; txt_Price.Text = ""; txt_quantity_store.Text = ""; FINISH_PRICE.Text = ""; txt_qty.Text = "1"; }
                else
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID, PARCODE ,PRODUCT_NAME ,UNIT ,CURRENCY ,INITIAL_COAST ,PRICE ,LESS_PRICE ,FINISH_PRICE ,FINISH_PRICE ,QTY FROM PRODUCTS WHERE PRODUCT_NAME = N'" + txt_product_name.Text.Trim() + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txt_par.Text = dr["PARCODE"].ToString();
                        txt_name.Text = dr["PRODUCT_NAME"].ToString();
                        txt_unit.Text = dr["UNIT"].ToString();
                        CURRENCY.Text = dr["CURRENCY"].ToString();
                        txt_first_price.Text = dr["INITIAL_COAST"].ToString();
                        txt_Price.Text = dr["PRICE"].ToString();
                        ID.Text = dr["ID"].ToString();
                        txt_quantity_store.Text = dr["QTY"].ToString();
                        txt_lessprice.Text = dr["LESS_PRICE"].ToString();
                        FINISH_PRICE.Text = dr["FINISH_PRICE"].ToString();
                        ID_FK.Text = ""; 
                        txt_qty.Text = "1";
                        //txt_total_Above.Text = dr[" "].ToString();
                    }
                    dr.Close();
                }
                btn_Delete_Billing.Enabled = false;
                btn_Delete_Billing.BackColor = Color.White;
                txt_first_price.ReadOnly = true;
                txt_qty.ReadOnly = false;
                btn_Add_Billing.Enabled = true;
                //decimal qty = Convert.ToDecimal(txt_qty.Text.Trim());
                //decimal Price = Convert.ToDecimal(txt_Price.Text.Trim());
                //txt_total_Above.Text = Convert.ToString(qty * Price);
            } catch (Exception) { }
            finally { if (con.State == ConnectionState.Open) { con.Close(); } }
        }
        private void txt_product_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_product_name.Text.Trim() == "") { ClearTExAboveDGV_Billing(); return; }
            txt_name_product();

            if (chk_fill.Checked && txt_par.Text.Trim() != "" && txt_name.Text.Trim() != "")
            {
                ADD();
            }

            btn_Save_billing.Visible = true;
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void SaveWithOutPrint()
        {
            try
            {
                if (DGV_Billing.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى ملئ الفاتورة بالبيانات");
                }
                else
                {
                    Insert_billing();
                    Insert_billing_Details();
                    txt_msg_Billing.Text = "تم الحفظ بنجاح";
                    ClearAll();
                    chk_fill.Checked = true;
                }
            }
            catch (Exception)
            {
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveWithOutPrint();
        }

        public void Insert_billing()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                string query = "Insert Into TBL_BILLING Values('" + txt_id.Text.Trim() + "',N'" + USER_NAME.Text.Trim() + "'," +
                    "N'" + BRANCH_NAME.Text.Trim() + "',N'" + STORE_NAME.Text.Trim() + "',N'" + BOX_NAME.Text.Trim() + "'," +
                    "N'" + CUSTOMER_RECIVE_BILLING.Text.Trim() + "',N'" + BILLING_DELEGET_NUM.Text.Trim() + "',N'" + Cbo_CURENCY.Text.Trim() + "'," +
                    "N'" + Exchange_bill_number.Text.Trim() + "',N'" + METHOD_OF_TAX.Text.Trim() + "'," +
                    "N'" + DELEGET_NAME.Text.Trim() + "',N'" + TYPE_BILLING.Text.Trim() + "',N'" + TOTAL_DELEGET_BILLING.Text.Trim() + "'," +
                    "N'" + DELEGET_BILLING_DATE.Text.Trim() + "',N'" + TOTAL_AMOUNT.Text.Trim() + "',N'" + DISCOUNT_PERCENT.Text.Trim() + "'," +
                    "N'" + DISCOUNT_MONEY.Text.Trim() + "',N'" + TOTAL_BEFORE_DISCOUNT.Text.Trim() + "',N'" + TOTAL_DISCOUNT.Text.Trim() + "'," +
                    "N'" + TOTAL_AFTER_DISCOUNT.Text.Trim() + "',N'" + PAY_FIRST.Text.Trim() + "',N'" + THE_REST.Text.Trim().Replace("-", "") + "'," +
                    "N'" + DATE_TIME_NOW.Text.Trim() + "',N'" + txt_Billing_last_Edits_date.Text.Trim() + "',N'" + txt_Billing_insert_name.Text.Trim() + "'," +
                    "N'" + txt_Billing_Edite_Name.Text.Trim() + "') ";
                con.Open();
                cmd = new SqlCommand(query , con);
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@ID", txt_id);
                cmd.Parameters.AddWithValue("@USER_NAME", USER_NAME);
                cmd.Parameters.AddWithValue("@BRANCH_NAME", BRANCH_NAME);
                cmd.Parameters.AddWithValue("@STORE_NAME", STORE_NAME);
                cmd.Parameters.AddWithValue("@BOX_NAME", BOX_NAME);
                cmd.Parameters.AddWithValue("@CUSTOMER_RECIVE_BILLING", CUSTOMER_RECIVE_BILLING);
                cmd.Parameters.AddWithValue("@BILLING_DELEGET_NUM", BILLING_DELEGET_NUM);
                cmd.Parameters.AddWithValue("@CURENCY", Cbo_CURENCY);
                cmd.Parameters.AddWithValue("@Exchange_bill_number", Exchange_bill_number);
                cmd.Parameters.AddWithValue("@METHOD_OF_TAX", METHOD_OF_TAX);
                cmd.Parameters.AddWithValue("@DELEGET_NAME", DELEGET_NAME);
                cmd.Parameters.AddWithValue("@TYPE_BILLING", TYPE_BILLING);
                cmd.Parameters.AddWithValue("@TOTAL_DELEGET_BILLING", TOTAL_DELEGET_BILLING);
                cmd.Parameters.AddWithValue("@DELEGET_BILLING_DATE", DELEGET_BILLING_DATE);
                cmd.Parameters.AddWithValue("@TOTAL_AMOUNT", TOTAL_AMOUNT);
                cmd.Parameters.AddWithValue("@DISCOUNT_PERCENT", DISCOUNT_PERCENT);
                cmd.Parameters.AddWithValue("@DISCOUNT_MONEY", DISCOUNT_MONEY);
                cmd.Parameters.AddWithValue("@TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT);
                cmd.Parameters.AddWithValue("@TOTAL_DISCOUNT", TOTAL_DISCOUNT);
                cmd.Parameters.AddWithValue("@TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT);
                cmd.Parameters.AddWithValue("@PAY_FIRST", PAY_FIRST);
                cmd.Parameters.AddWithValue("@THE_REST", THE_REST);
                cmd.Parameters.AddWithValue("@DATE_TIME_NOW", DATE_TIME_NOW);
                cmd.Parameters.AddWithValue("@DATE_EDITS", txt_Billing_last_Edits_date);
                cmd.Parameters.AddWithValue("@Billing_insert_name", txt_Billing_insert_name);
                cmd.Parameters.AddWithValue("@Billing_Edite_name", txt_Billing_Edite_Name);
                //Comandos(query);
            }
            catch (Exception) { }
            finally { if (con.State == ConnectionState.Open) { con.Close(); } }
        }

        public void Insert_billing_Details()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                string Query = "INSERT INTO BILLING_DETAILS (PARCODE,PRODUCT_NAME,UNIT,FIRST_COAST,PRICE,LESS_PRICE,SHIPPING_COAST,QTY,TOTAL,ID_BILLING) " +
                                                        "VALUES(@PARCODE,@PRODUCT_NAME,@UNIT,@FIRST_COAST,@PRICE,@LESS_PRICE,@SHIPPING_COAST,@QTY,@TOTAL,@ID_BILLING)";
                con.Open();
                for (int i = 0; i < DGV_Billing.Rows.Count; i++)
                {
                    cmd = new SqlCommand(Query , con);
                    cmd.Parameters.AddWithValue("@PARCODE", DGV_Billing.Rows[i].Cells["PARCODE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@PRODUCT_NAME", DGV_Billing.Rows[i].Cells["PRODUCT_NAME"].Value.ToString());
                    cmd.Parameters.AddWithValue("@UNIT", DGV_Billing.Rows[i].Cells["Unit"].Value.ToString());
                    cmd.Parameters.AddWithValue("@FIRST_COAST", DGV_Billing.Rows[i].Cells["FIRST_COAST"].Value.ToString());
                    cmd.Parameters.AddWithValue("@PRICE", DGV_Billing.Rows[i].Cells["PRICE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@LESS_PRICE", DGV_Billing.Rows[i].Cells["LESS_PRICE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@SHIPPING_COAST", DGV_Billing.Rows[i].Cells["SHIPPING_COAST"].Value.ToString());
                    //cmd.Parameters.AddWithValue("@CUSTOMS", DGV_Billing.Rows[i].Cells["CUSTOMS"].Value.ToString());
                    //cmd.Parameters.AddWithValue("@FINISH_PRICE", DGV_Billing.Rows[i].Cells["FINISH_PRICE"].Value.ToString());
                    cmd.Parameters.AddWithValue("@QTY", DGV_Billing.Rows[i].Cells["QTY"].Value.ToString());
                    cmd.Parameters.AddWithValue("@TOTAL", DGV_Billing.Rows[i].Cells["TOTAL"].Value.ToString());
                    cmd.Parameters.AddWithValue("@ID_BILLING", txt_id.Text.Trim()); 
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void DGV_Billing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGV_Billing.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    DGV_Billing.Rows[e.RowIndex].Selected = true;
                    chk_fill.Checked = false;
                    txt_parcode.Text = " ";
                    txt_product_name.Text = " ";
                    //txt_parcode.Text = DGV_Billing.SelectedRows[0].Cells["PARCODE"].Value.ToString();   //txt_par
                    //txt_par.Text = DGV_Billing.SelectedRows[0].Cells["PARCODE"].Value.ToString();
                    txt_product_name.Text = DGV_Billing.SelectedRows[0].Cells["Product_Name"].Value.ToString();
                    //txt_unit.Text = DGV_Billing.SelectedRows[0].Cells["Unit"].Value.ToString();
                    //txt_first_price.Text = DGV_Billing.SelectedRows[0].Cells["First_Price"].Value.ToString();
                    //txt_Price.Text = DGV_Billing.SelectedRows[0].Cells["Price"].Value.ToString();
                    //txt_quantity_store.Text = DGV_Billing.SelectedRows[0].Cells["QTY"].Value.ToString();
                    txt_qty.Text = DGV_Billing.SelectedRows[0].Cells["Qty"].Value.ToString();
                    txt_total_Above.Text = DGV_Billing.SelectedRows[0].Cells["Total"].Value.ToString();

                    btn_Delete_Billing.Enabled = true;
                    btn_Delete_Billing.BackColor = Color.Firebrick;
                    txt_first_price.ReadOnly = true;
                    txt_qty.ReadOnly = true;
                }
            } catch (Exception) { }
        }

        private void DGV_Billing_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DGV_Billing.Rows[e.RowIndex].Selected = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Print();
        }

        public void Print()
        {
            try
            {
                frm_Crystal_Billing frm = new frm_Crystal_Billing(BRANCH_NAME.Text.Trim(), STORE_NAME.Text.Trim(), BOX_NAME.Text.Trim(),
                    CUSTOMER_RECIVE_BILLING.Text.Trim(), BILLING_DELEGET_NUM.Text.Trim(), Cbo_CURENCY.Text.Trim(),
                    Exchange_bill_number.Text.Trim(), METHOD_OF_TAX.Text.Trim(), DELEGET_NAME.Text.Trim(), TYPE_BILLING.Text.Trim(),
                    TOTAL_DELEGET_BILLING.Text.Trim(), DELEGET_BILLING_DATE.Text.Trim(), TOTAL_AMOUNT.Text.Trim(),
                    TOTAL_BEFORE_DISCOUNT.Text.Trim(), DISCOUNT_PERCENT.Text.Trim(), TOTAL_DISCOUNT.Text.Trim(), DISCOUNT_MONEY.Text.Trim(),
                    TOTAL_AFTER_DISCOUNT.Text.Trim(), txt_Total_Last.Text.Trim(), PAY_FIRST.Text.Trim(),
                    THE_REST.Text.Trim(), txt_Billing_insert_date.Text.Trim(), txt_Billing_last_Edits_date.Text.Trim(),
                    txt_Billing_insert_name.Text.Trim(), txt_Billing_Edite_Name.Text.Trim());
                Billing_Crystal cr = new Billing_Crystal();
                Data_Set_billing Ds_Billing = new Data_Set_billing();

                foreach (DataGridViewRow dgv in DGV_Billing.Rows)
                {
                        Ds_Billing.Tbl_Billing_Set.Rows.Add(dgv.Cells["Parcode"].Value, dgv.Cells["Product_Name"].Value,
                                                            dgv.Cells["Unit"].Value, dgv.Cells["Currencey"].Value,
                                                            dgv.Cells["FIRST_COAST"].Value, dgv.Cells["Price"].Value, 
                                                            dgv.Cells["LESS_PRICE"].Value, dgv.Cells["SHIPPING_COAST"].Value, 
                                                            dgv.Cells["Qty"].Value, dgv.Cells["Total"].Value);
                }
                DataView dv = new DataView(Ds_Billing.Tables["Tbl_Billing_Set"]);
                cr.SetDataSource(dv);

                if (BRANCH_NAME.Text.Trim() == "") { BRANCH_NAME.Text = "0"; }
                cr.SetParameterValue("BRANCH_NAME", BRANCH_NAME.Text.Trim());
                if (STORE_NAME.Text.Trim() == "") { STORE_NAME.Text = "0"; }
                cr.SetParameterValue("STORE_NAME", STORE_NAME.Text.Trim());

                cr.SetParameterValue("BOX_NAME", BOX_NAME.Text.Trim());
                cr.SetParameterValue("RECIVING_BILL", CUSTOMER_RECIVE_BILLING.Text.Trim());
                cr.SetParameterValue("DELGET_BILL_NUMBER", BILLING_DELEGET_NUM.Text.Trim());
                cr.SetParameterValue("PAY_RECIPT_NUMBER", Exchange_bill_number.Text.Trim());
                cr.SetParameterValue("TAX_WAY", METHOD_OF_TAX.Text.Trim());
                
                cr.SetParameterValue("CURRENCY", Cbo_CURENCY.Text.Trim());
                cr.SetParameterValue("DELEGET_NAME", DELEGET_NAME.Text.Trim());
                cr.SetParameterValue("BILLING_TYPE", TYPE_BILLING.Text.Trim());
                cr.SetParameterValue("TOTAL_OF_DELEGET_BILING", TOTAL_DELEGET_BILLING.Text.Trim());
                cr.SetParameterValue("DELEGET_BILLING_DATE", DELEGET_BILLING_DATE.Text.Trim());
                cr.SetParameterValue("TOTAL_OF_PRODUCTS", TOTAL_AMOUNT.Text.Trim());
                cr.SetParameterValue("TOTAL", TOTAL_BEFORE_DISCOUNT.Text.Trim());
                cr.SetParameterValue("DISCOUNT_PERCENT", DISCOUNT_PERCENT.Text.Trim());
                cr.SetParameterValue("TOTAL_DISCOUNT", TOTAL_DISCOUNT.Text.Trim());
                cr.SetParameterValue("DISCOUNT_CURRENCEY", DISCOUNT_MONEY.Text.Trim());
                cr.SetParameterValue("TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());
                cr.SetParameterValue("TOTAL_FINISH", txt_Total_Last.Text.Trim());
                cr.SetParameterValue("PAY_FIRST", PAY_FIRST.Text.Trim());
                cr.SetParameterValue("THE_REST", THE_REST.Text.Trim());
                cr.SetParameterValue("DATE_INSERT", txt_Billing_insert_date.Text.Trim());
                cr.SetParameterValue("DATE_EDITE", txt_Billing_last_Edits_date.Text.Trim());
                cr.SetParameterValue("USER_INSERT", txt_Billing_insert_name.Text.Trim());
                cr.SetParameterValue("USER_EDIT", txt_Billing_Edite_Name.Text.Trim());


                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
                //cr.PrintToPrinter(1, false, 0, 0);
                //PrintAuto();
            }
            catch (Exception) { }
        }
        public void PrintAuto()
        {
            try
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    ReportDocument reportDocument = new ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\Billing_Crystal.rpt");
                    reportDocument.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                    reportDocument.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage);
                }
            }
            catch (Exception) { }
        }

        public void ClearAll()
        {
            try
            {
                txt_id.Text = "";
                CUSTOMER_RECIVE_BILLING.Text = "";
                BILLING_DELEGET_NUM.Text = "";
                Exchange_bill_number.Text = "";
                METHOD_OF_TAX.Text = "";
                DELEGET_NAME.Text = "";
                TYPE_BILLING.Text = "";
                TOTAL_DELEGET_BILLING.Text = "";
                txt_parcode.Text = "";
                txt_product_name.Text = "";
                txt_par.Text = "";
                txt_name.Text = "";
                txt_unit.Text = "";
                txt_first_price.Text = "";
                txt_quantity_store.Text = "";
                txt_qty.Text = "";
                txt_total_Above.Text = "";
                TOTAL_AMOUNT.Text = "0";
                TOTAL_BEFORE_DISCOUNT.Text = "0";
                DISCOUNT_PERCENT.Text = "0";
                DISCOUNT_MONEY.Text = "0";
                TOTAL_AFTER_DISCOUNT.Text = "0";
                TOTAL_DISCOUNT.Text = "0";
                txt_Total_Last.Text = "0";
                PAY_FIRST.Text = "0";
                THE_REST.Text = "0";
                txt_Billing_insert_date.Text = "";
                txt_Billing_last_Edits_date.Text = "";
                txt_Billing_insert_name.Text = "";
                //Date_Of_Invoice_Deleget.Text = "";
                search.Text = "";
                txt_id.Text = Convert.ToString(maxid());
                while (DGV_Billing.Rows.Count > 0)
                {
                    DGV_Billing.Rows.Clear();
                    //DGV_Billing.Rows.RemoveAt(0);
                }
            }
            catch (Exception) { }
        }

        private void btn_Delete_Billing_Click(object sender, EventArgs e)
        {
            Delete_Row();
            ID.Text = "";
            txt_qty.Text = "";
            finish_qty.Text = "";
        }
        //try
        //{
        //    if (txt_par.Text.Trim() == "" && txt_name.Text.Trim() == "") { MessageBox.Show("يرجى اختيار الصنف المراد حذفه"); }
        //    else if (txt_par.Text.Trim() != "" && txt_name.Text.Trim() != "")
        //    {
        //        decimal qty_store = Convert.ToDecimal(txt_quantity_store.Text.Trim());  //  تحديث الكمية الموجودة في المخزن
        //        decimal qty_ord = Convert.ToDecimal(txt_qty.Text.Trim());
        //        decimal doubleqty = qty_store - qty_ord;
        //        string Finish = Convert.ToString(doubleqty);
        //        if (qty_store >= qty_ord)
        //        {
        //            UPDATE_QUANTITY(Finish);

        //            foreach (DataGridViewRow r in DGV_Billing.Rows)
        //            {
        //                if (r.Selected == true)
        //                {
        //                    int rowindex = DGV_Billing.CurrentCell.RowIndex;
        //                    DGV_Billing.Rows.RemoveAt(rowindex);
        //                }
        //            }
        //            ClearTExAboveDGV_Billing();
        //        }
        //        else { MessageBox.Show(" عفواً لا توجد كمية متوفرة لإرجاعها "); }                                           //  تحديث الكمية الموجودة في المخزن
        //    }
        //}
        //catch (Exception EXC) { }


        public void UPDATE_QUANTITY(string Finish)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                string sql = "UPDATE TBL_PRODUCTS set Quantity = N'" + Finish + "' where PARCODE = N'" + txt_par.Text.Trim() + "' ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@Quantity", Finish);
            }
            catch (Exception) { }
            finally { con.Close(); }
            //cbo_parcode_invoice.Items.Clear();
            //Fill_cbo_parcode();
            //cbo_product_name_invoice.Items.Clear();
            //Fill_cbo_PRODUCT_NAME();
        }

        private void txt_The_rest_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal rest = Convert.ToDecimal(txt_The_rest.Text.Trim());
            //    decimal last = Convert.ToDecimal(txt_Total_Last.Text.Trim());
            //    decimal pay = Convert.ToDecimal(txt_Down_payment.Text.Trim());
            //    if (rest <= last){txt_The_rest.BackColor = Color.Yellow;}
            //    else if(txt_The_rest.Text.Trim() =="0" || txt_The_rest.Text.Trim() == null) { txt_The_rest.BackColor = Color.White; }
            //    else if(txt_Down_payment.Text.Trim() == "" || txt_Down_payment.Text.Trim() == null){txt_The_rest.Text = txt_Total_Last.Text.Trim(); }
            //} catch(Exception EXC) { }
        }

        private void txt_Down_payment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal lasttotal = Convert.ToDecimal(txt_Total_Last.Text.Trim()); if (PAY_FIRST.Text.Trim() == null || PAY_FIRST.Text.Trim() == "") { PAY_FIRST.Text = "0"; PAY_FIRST.SelectAll(); THE_REST.Text = Convert.ToString(lasttotal * -1); THE_REST.BackColor = Color.Yellow; }
                decimal pay = Convert.ToDecimal(PAY_FIRST.Text.Trim()); decimal minus = lasttotal * -1; THE_REST.Text = Convert.ToString(pay - lasttotal); if (lasttotal > pay) { THE_REST.BackColor = Color.Yellow; } else if (pay == lasttotal) { THE_REST.BackColor = Color.White; } else if (pay > lasttotal) { THE_REST.BackColor = Color.Green; }
            }
            catch (Exception) { }
        }

        private void txt_Down_payment_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                decimal lasttotal = Convert.ToDecimal(txt_Total_Last.Text.Trim()); if (PAY_FIRST.Text.Trim() == null || PAY_FIRST.Text.Trim() == "") { PAY_FIRST.Text = "0"; PAY_FIRST.SelectAll(); THE_REST.Text = Convert.ToString(lasttotal * -1); THE_REST.BackColor = Color.Yellow; }
                decimal pay = Convert.ToDecimal(PAY_FIRST.Text.Trim()); decimal minus = lasttotal * -1; THE_REST.Text = Convert.ToString(pay - lasttotal); if (lasttotal > pay) { THE_REST.BackColor = Color.Yellow; } else if (pay == lasttotal) { THE_REST.BackColor = Color.White; } else if (pay > lasttotal) { THE_REST.BackColor = Color.Green; }
            }
            catch (Exception) { }
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal lasttotal = Convert.ToDecimal(txt_Total_Last.Text.Trim()); if (PAY_FIRST.Text.Trim() == null || PAY_FIRST.Text.Trim() == "") { PAY_FIRST.Text = "0"; PAY_FIRST.SelectAll(); THE_REST.Text = Convert.ToString(lasttotal * -1); THE_REST.BackColor = Color.Yellow; }
                decimal pay = Convert.ToDecimal(PAY_FIRST.Text.Trim()); decimal minus = lasttotal * -1; THE_REST.Text = Convert.ToString(pay - lasttotal); if (lasttotal > pay) { THE_REST.BackColor = Color.Yellow; } else if (pay == lasttotal) { THE_REST.BackColor = Color.White; } else if (pay > lasttotal) { THE_REST.BackColor = Color.Green; }
            }
            catch (Exception) { }
        }

        private void payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void Delete_Row()
        {
            try
            {
                decimal qty_store = Convert.ToDecimal(txt_quantity_store.Text.Trim());     //  تحديث الكمية الموجودة في المخزن
                decimal qty_ord = Convert.ToDecimal(txt_qty.Text.Trim());
                if (txt_par.Text.Trim() == "" && txt_name.Text.Trim() == "") { MessageBox.Show("من فضلك أختر العنصر الذي تريد حذفه"); }
                else if (txt_par.Text.Trim() != "" && txt_name.Text.Trim() != "" && qty_store >= qty_ord)
                {
                    decimal doubleqty = qty_store - qty_ord;
                    string Finish = Convert.ToString(doubleqty);

                    if (qty_store >= qty_ord)
                    {
                        fill_Cbo.UpdateP1_Parcode(Finish , txt_par);
                        
                        decimal mountqty = Convert.ToDecimal(TOTAL_AMOUNT.Text.Trim());
                        TOTAL_AMOUNT.Text = Convert.ToString(mountqty - 1);

                        decimal totalAbove = Convert.ToDecimal(txt_total_Above.Text.Trim());
                        decimal totalbefore = Convert.ToDecimal(TOTAL_BEFORE_DISCOUNT.Text.Trim());
                        decimal lasttotal = totalbefore - totalAbove;
                        TOTAL_BEFORE_DISCOUNT.Text = Convert.ToString(lasttotal);

                        var rowindex = DGV_Billing.CurrentCell.RowIndex;
                        DGV_Billing.Rows.RemoveAt(rowindex);

                        ClearTExAboveDGV_Billing();
                    }
                    else { txt_msg_Billing.Text = " عفواً لا توجد كمية متوفرة للإرجاع "; }
                }
                else if (qty_store <= 0 || txt_quantity_store.Text.Trim() == null) { txt_msg_Billing.Text = " عفواً لا توجد كمية متوفرة للإرجاع "; }                                           //  تحديث الكمية الموجودة في المخزن
            }
            catch (Exception) {  }
            finally { btn_Delete_Billing.Enabled = false; }
        }

        private void btn_Delete_Billing_MouseHover(object sender, EventArgs e)
        {

        }

        private void txt_first_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch (Exception) { }
        }

        private void txt_first_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void finish_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void Search_Billing_Num(TextBox txt)
        {
            try
            {
                AutoCompleteStringCollection col3 = new AutoCompleteStringCollection();
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string Sql = "Select ID from TBL_BILLING ";
                SqlCommand cmd = new SqlCommand(Sql, con);
                SqlDataReader dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {
                    col3.Add(dr3.GetValue(0).ToString());
                }
                txt.AutoCompleteCustomSource = col3;
                dr3.Close();
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Trim() == "") { ClearAll(); btn_Save_billing.Visible = true; while (DGV_Billing.Rows.Count > 0) { DGV_Billing.Rows.RemoveAt(0); } } else { Search_tbl_billing(); Search_Billing_Details(); btn_Save_billing.Visible = false; }
        }

        public void Search_tbl_billing()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string Sql = "Select * from TBL_BILLING where ID = N'" + search.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(Sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txt_id.Text = dt.Rows[0]["ID"].ToString();
                    USER_NAME.Text = dt.Rows[0]["USER_NAME"].ToString();
                    BRANCH_NAME.Text = dt.Rows[0]["BRANCH_NAME"].ToString();
                    STORE_NAME.Text = dt.Rows[0]["STORE_NAME"].ToString();
                    BOX_NAME.Text = dt.Rows[0]["BOX_NAME"].ToString();
                    CUSTOMER_RECIVE_BILLING.Text = dt.Rows[0]["CUSTOMER_RECIVE_BILLING"].ToString();
                    BILLING_DELEGET_NUM.Text = dt.Rows[0]["BILLING_DELEGET_NUM"].ToString();
                    Cbo_CURENCY.Text = dt.Rows[0]["CURENCY"].ToString();
                    Exchange_bill_number.Text = dt.Rows[0]["Exchange_bill_number"].ToString();
                    METHOD_OF_TAX.Text = dt.Rows[0]["METHOD_OF_TAX"].ToString();
                    DELEGET_NAME.Text = dt.Rows[0]["DELEGET_NAME"].ToString();
                    TYPE_BILLING.Text = dt.Rows[0]["TYPE_BILLING"].ToString();
                    TOTAL_DELEGET_BILLING.Text = dt.Rows[0]["TOTAL_DELEGET_BILLING"].ToString();
                    DELEGET_BILLING_DATE.Text = dt.Rows[0]["DELEGET_BILLING_DATE"].ToString();
                    TOTAL_AMOUNT.Text = dt.Rows[0]["TOTAL_AMOUNT"].ToString();
                    DISCOUNT_PERCENT.Text = dt.Rows[0]["DISCOUNT_PERCENT"].ToString();
                    DISCOUNT_MONEY.Text = dt.Rows[0]["DISCOUNT_MONEY"].ToString();
                    TOTAL_BEFORE_DISCOUNT.Text = dt.Rows[0]["TOTAL_BEFORE_DISCOUNT"].ToString();
                    TOTAL_DISCOUNT.Text = dt.Rows[0]["TOTAL_DISCOUNT"].ToString();
                    TOTAL_AFTER_DISCOUNT.Text = dt.Rows[0]["TOTAL_AFTER_DISCOUNT"].ToString();
                    PAY_FIRST.Text = dt.Rows[0]["PAY_FIRST"].ToString();
                    THE_REST.Text = dt.Rows[0]["THE_REST"].ToString();
                    DATE_TIME_NOW.Text = dt.Rows[0]["DATE_TIME_NOW"].ToString();
                    txt_Billing_last_Edits_date.Text = dt.Rows[0]["DATE_EDITS"].ToString();
                    txt_Billing_insert_name.Text = dt.Rows[0]["Billing_insert_name"].ToString();
                    txt_Billing_Edite_Name.Text = dt.Rows[0]["Billing_Edite_name"].ToString();
                }
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        public void Search_Billing_Details()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string Sql = "Select * from BILLING_DETAILS where ID_BILLING = N'" + search.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(Sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DGV_Billing.DataSource = dt;
                }
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void frm_Billing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SaveWithOutPrint();
            }
            else if (e.KeyCode == Keys.F9)
            {
                PrintAuto();
            }
            else if (e.KeyCode == Keys.F10)
            {
                //Print();
            }
        }

        private void btn_Add_Billing_Click_1(object sender, EventArgs e)
        {
            Update_QTY();
            ADD();
            //QTY();
        }
    }
}
