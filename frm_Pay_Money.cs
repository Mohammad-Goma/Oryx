using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Oryx
{
    public partial class frm_Pay_Money : Form
    {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Mobile_Charger; Integrated Security=True");
            Fill_Cbo fill = new Fill_Cbo();
            public frm_Pay_Money()
            {
                InitializeComponent();
            }

            private void frm_Pay_Money_Load(object sender, EventArgs e)
            {
                id.Text = Convert.ToString(max());
                fill.Select_TBL_PAY_RECEIPT(txt_search);
                //fill.Fill_Currency(txt_currency);
                DATE_NOW.Value = DateTime.Now;
                CUSTOMER_INVOICE_DATE.Value = DateTime.Now;
            }

            private void btn_save_Click(object sender, EventArgs e)
            {
                string Max = Convert.ToString(max()); 
                if (id.Text.Trim() == Max) { Save(); } 
                else if (id.Text.Trim() != Max) { UPDATE(); }
            }

            public void ClearAll()
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox) { ctrl.Text = string.Empty; }
                }
                txt_currency.Text = "";
                //USER_NAME.Text = Main_Form.USER_NAME_STRING.Trim();
                id.Text = Convert.ToString(max());
                fill.Select_TBL_PAY_RECEIPT(txt_search);
            }

            public void Save()
            {
                try
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    string SQL = "insert into TBL_PAY_RECEIPT  Values(N'" + ID_ORDER_AUTO.Text.Trim() + "',N'" + ID_ORDER_HAND.Text.Trim() + "'," +
                        "N'" + CUSTOMER_NAME.Text.Trim() + "',N'" + FROM_COUNT.Text.Trim() + "',N'" + CUSTOMER_INVOICE_DATE.Text.Trim() + "'," +
                        "N'" + ID_PAY_RECEIPT.Text.Trim() + "',N'" + USER_NAME.Text.Trim() + "',N'" + DATE_NOW.Text.Trim() + "'," +
                        "N'" + AMOUNT.Text.Trim() + "',N'" + TOTAL_BEFORE_DISCOUNT.Text.Trim() + "',N'" + DISCOUNT.Text.Trim() + "'," +
                        "N'" + TOTAL_AFTER_DISCOUNT.Text.Trim() + "',N'" + Cash.Text.Trim() + "',N'" + Cheek_Total.Text.Trim() + "'," +
                        "N'" + cheek_num.Text.Trim() + "',N'" + txt_total_rest.Text.Trim() + "',N'" + txt_currency.Text.Trim() + "'," +
                        "N'" + Date_Update.Text.Trim() + "',N'" + User_Update.Text.Trim() + "',N'" + Details.Text.Trim() + "' ) ";
                    cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.AddWithValue(@"ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());                    //الرقم الآلى للفاتورة
                    cmd.Parameters.AddWithValue(@"ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());                    //الرقم اليدوي للفاتورة
                    cmd.Parameters.AddWithValue(@"CUSTOMER_NAME", CUSTOMER_NAME.Text.Trim());                    // أسم العميل
                    cmd.Parameters.AddWithValue(@"FROM_COUNT", FROM_COUNT.Text.Trim());                    // 
                    cmd.Parameters.AddWithValue(@"CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());    // تاريخ فاتورة المستخدم
                    cmd.Parameters.AddWithValue(@"ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());                  // الرقم اليدوي للسند
                    cmd.Parameters.AddWithValue(@"USER_NAME", USER_NAME.Text.Trim());                            // أسم المدخل
                    cmd.Parameters.AddWithValue(@"DATE_NOW", DATE_NOW.Text.Trim());                              // تاريخ اليوم
                    cmd.Parameters.AddWithValue(@"AMOUNT", AMOUNT.Text.Trim());                                  // مجموع الكميات
                    cmd.Parameters.AddWithValue(@"TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT.Text.Trim());    //المبلغ المستحق 
                    cmd.Parameters.AddWithValue(@"DISCOUNT", DISCOUNT.Text.Trim());                              // الخصم المسترجع
                    cmd.Parameters.AddWithValue(@"TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());      // الصافي
                    cmd.Parameters.AddWithValue(@"Cash", Cash.Text.Trim());                                      //المدفوع نقدا 
                    cmd.Parameters.AddWithValue(@"Cheek_Total", Cheek_Total.Text.Trim());                        //مبلغ الشيك 
                    cmd.Parameters.AddWithValue(@"cheek_num", cheek_num.Text.Trim());                            //رقم الشيك
                    cmd.Parameters.AddWithValue(@"total_rest", txt_total_rest.Text.Trim());                      //الاجل 
                    cmd.Parameters.AddWithValue(@"currency", txt_currency.Text.Trim());                          // العملة
                    //cmd.Parameters.AddWithValue(@"Date_Update", Date_Update.Text.Trim()); 
                    //cmd.Parameters.AddWithValue(@"User_Update", User_Update.Text.Trim());
                    cmd.Parameters.AddWithValue(@"Details", Details.Text.Trim());                                                                                            //cmd.Parameters.AddWithValue(@"Date_Update", Date_Update.Text.Trim()); 
                    con.Close();
                    ClearAll();
                    msg.Text = "Save Successfully";
                } catch (Exception) { }
                finally { con.Close(); }
            }

            public void UPDATE()
            {
                try
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    string sql = "UPDATE TBL_PAY_RECEIPT SET ID_ORDER_AUTO = N'" + ID_ORDER_AUTO.Text.Trim() + "', ID_ORDER_HAND = N'" + ID_ORDER_HAND.Text.Trim() + "'," +
                                 "CUSTOMER_NAME =N'" + CUSTOMER_NAME.Text.Trim() + "', FROM_COUNT =N'" + FROM_COUNT.Text.Trim() + "',CUSTOMER_INVOICE_DATE =N'" + CUSTOMER_INVOICE_DATE.Text.Trim() + "'," +
                                 "ID_PAY_RECEIPT =N'" + ID_PAY_RECEIPT.Text.Trim() + "',USER_NAME =N'" + txt_insert_name.Text.Trim() + "'," +
                                 "DATE_NOW =N'" + DATE_NOW.Text.Trim() + "',AMOUNT =N'" + AMOUNT.Text.Trim() + "'," +
                                 "TOTAL_BEFORE_DISCOUNT =N'" + TOTAL_BEFORE_DISCOUNT.Text.Trim() + "',DISCOUNT =N'" + DISCOUNT.Text.Trim() + "'," +
                                 "TOTAL_AFTER_DISCOUNT =N'" + TOTAL_AFTER_DISCOUNT.Text.Trim() + "',Cash =N'" + Cash.Text.Trim() + "'," +
                                 "Cheek_Total =N'" + Cheek_Total.Text.Trim() + "',cheek_num =N'" + cheek_num.Text.Trim() + "'," +
                                 "total_rest =N'" + txt_total_rest.Text.Trim() + "',currency =N'" + txt_currency.Text.Trim() + "'," +
                                 "Date_Update =N'" + DATE_NOW.Text.Trim() + "', User_Update =N'" + USER_NAME.Text.Trim() + "',Details =N'" + Details.Text.Trim() + "' Where ID = N'"+id.Text.Trim()+"' ";

                    cmd = new SqlCommand(sql , con);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.AddWithValue(@"ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());                    //الرقم الآلى للفاتورة
                    cmd.Parameters.AddWithValue(@"ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());                    //الرقم اليدوي للفاتورة
                    cmd.Parameters.AddWithValue(@"CUSTOMER_NAME", CUSTOMER_NAME.Text.Trim());                    // أسم العميل
                    cmd.Parameters.AddWithValue(@"FROM_COUNT", FROM_COUNT.Text.Trim());                         // أسم العميل
                    cmd.Parameters.AddWithValue(@"CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());    // تاريخ فاتورة المستخدم
                    cmd.Parameters.AddWithValue(@"ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());                  // الرقم اليدوي للسند
                    cmd.Parameters.AddWithValue(@"USER_NAME", txt_insert_name.Text.Trim());                            // أسم المدخل
                    //cmd.Parameters.AddWithValue(@"DATE_NOW", DATE_NOW.Text.Trim());                              // تاريخ اليوم
                    cmd.Parameters.AddWithValue(@"AMOUNT", AMOUNT.Text.Trim());                                  // مجموع الكميات
                    cmd.Parameters.AddWithValue(@"TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT.Text.Trim());    //المبلغ المستحق 
                    cmd.Parameters.AddWithValue(@"DISCOUNT", DISCOUNT.Text.Trim());                              // الخصم المسترجع
                    cmd.Parameters.AddWithValue(@"TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());      // الصافي
                    cmd.Parameters.AddWithValue(@"Cash", Cash.Text.Trim());                                      //المدفوع نقدا 
                    cmd.Parameters.AddWithValue(@"Cheek_Total", Cheek_Total.Text.Trim());                        //مبلغ الشيك 
                    cmd.Parameters.AddWithValue(@"cheek_num", cheek_num.Text.Trim());                            //رقم الشيك
                    cmd.Parameters.AddWithValue(@"total_rest", txt_total_rest.Text.Trim());                      //الاجل 
                    cmd.Parameters.AddWithValue(@"currency", txt_currency.Text.Trim());                          // العملة
                    cmd.Parameters.AddWithValue(@"Date_Update", DATE_NOW.Text.Trim());
                    cmd.Parameters.AddWithValue(@"User_Update", USER_NAME.Text.Trim());
                    cmd.Parameters.AddWithValue(@"Details", Details.Text.Trim());
                    ClearAll();
                    msg.Text = " Edited Successfully ";
                }
                catch (Exception) {  }
                finally { con.Close(); }
            }

            public Int64 max()
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                int id = 0;
                con.Open();
                cmd = new SqlCommand("Select max(ID) AS fds From TBL_PAY_RECEIPT", con);
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

            private void btn_new_Click(object sender, EventArgs e)
            {
                try
                {
                    ClearAll();
                } catch (Exception) { }
            }

            private void btn_delete_Click(object sender, EventArgs e)
            {
                try
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    string Delete = "Delete from TBL_PAY_RECEIPT WShere id = N'" + id.Text.Trim() + "' ";
                    cmd = new SqlCommand(Delete, con);
                    cmd.ExecuteNonQuery();
                    ClearAll();
                    msg.Text = " Save Successfully ";
                }
                catch (Exception) { }
                finally { con.Close(); }

            }

            private void txt_search_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                    con.Open();
                    string sql = "Select * from TBL_PAY_RECEIPT WHERE ID = N'" + txt_search.Text.Trim() + "' ";
                    cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        id.Text = dr["ID"].ToString();
                        txt_insert_date.Text = dr["DATE_NOW"].ToString();
                        txt_insert_name.Text = dr["USER_NAME"].ToString();
                        CUSTOMER_NAME.Text = dr["CUSTOMER_NAME"].ToString();
                        FROM_COUNT.Text = dr["FROM_COUNT"].ToString();
                        TOTAL_BEFORE_DISCOUNT.Text = dr["TOTAL_BEFORE_DISCOUNT"].ToString();
                        DISCOUNT.Text = dr["DISCOUNT"].ToString();
                        TOTAL_AFTER_DISCOUNT.Text = dr["TOTAL_AFTER_DISCOUNT"].ToString();
                        Cash.Text = dr["Cash"].ToString();
                        Cheek_Total.Text = dr["Cheek_Total"].ToString();
                        txt_total_rest.Text = dr["total_rest"].ToString();
                        txt_currency.Text = dr["currency"].ToString();
                        AMOUNT.Text = dr["AMOUNT"].ToString();
                        cheek_num.Text = dr["cheek_num"].ToString();
                        DateTime dt = Convert.ToDateTime(dr["CUSTOMER_INVOICE_DATE"]);
                        CUSTOMER_INVOICE_DATE.Value = dt;
                        ID_PAY_RECEIPT.Text = dr["ID_PAY_RECEIPT"].ToString();
                        ID_ORDER_AUTO.Text = dr["ID_ORDER_AUTO"].ToString();
                        ID_ORDER_HAND.Text = dr["ID_ORDER_HAND"].ToString();
                        Date_Update.Text = dr["Date_Update"].ToString();
                        User_Update.Text = dr["User_Update"].ToString();
                        Details.Text= dr["Details"].ToString();
                    }
                    dr.Close();
                } catch (Exception) {  }
                finally { con.Close(); }
            }

            private void btn_print_Click(object sender, EventArgs e)
        {
            frm_crystal_pay frm = new frm_crystal_pay(USER_NAME.Text.Trim(), DATE_NOW.Text.Trim(),
                id.Text.Trim(), CUSTOMER_NAME.Text.Trim(), TOTAL_BEFORE_DISCOUNT.Text.Trim(),
                TOTAL_AFTER_DISCOUNT.Text.Trim(), txt_currency.Text.Trim(), Cash.Text.Trim(),
                txt_total_rest.Text.Trim(), Cheek_Total.Text.Trim(), txt_total_rest.Text.Trim(),
                cheek_num.Text.Trim(), AMOUNT.Text.Trim(), CUSTOMER_INVOICE_DATE.Text.Trim(),
                ID_PAY_RECEIPT.Text.Trim(), ID_ORDER_AUTO.Text.Trim(),ID_ORDER_HAND.Text.Trim(),
                Details.Text.Trim(), txt_insert_name.Text.Trim(),
                User_Update.Text.Trim(), txt_insert_date.Text.Trim(), Date_Update.Text.Trim());
            Crystal_Pay crystal = new Crystal_Pay();

            crystal.SetParameterValue("USER", USER_NAME.Text.Trim());
            crystal.SetParameterValue("DATE_NOW", DATE_NOW.Text.Trim());
            crystal.SetParameterValue("id", id.Text.Trim());
            crystal.SetParameterValue("CUSTOMER_NAME", CUSTOMER_NAME.Text.Trim());
            crystal.SetParameterValue("TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT.Text.Trim());
            crystal.SetParameterValue("TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());
            crystal.SetParameterValue("txt_currency", txt_currency.Text.Trim());
            crystal.SetParameterValue("Cash", Cash.Text.Trim());
            crystal.SetParameterValue("txt_total_rest", txt_total_rest.Text.Trim());
            crystal.SetParameterValue("cheek_num", cheek_num.Text.Trim());
            crystal.SetParameterValue("AMOUNT", AMOUNT.Text.Trim());
            crystal.SetParameterValue("CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());
            crystal.SetParameterValue("ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());
            crystal.SetParameterValue("ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());
            crystal.SetParameterValue("ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());
            crystal.SetParameterValue("Details", Details.Text.Trim());
            crystal.SetParameterValue("txt_insert_name", txt_insert_name.Text.Trim());
            crystal.SetParameterValue("User_Update", User_Update.Text.Trim());
            crystal.SetParameterValue("txt_insert_date", txt_insert_date.Text.Trim());
            crystal.SetParameterValue("Date_Update", Date_Update.Text.Trim());

            frm.crystal_Viwer_Pay.ReportSource = crystal;
            frm.crystal_Viwer_Pay.Refresh();
            frm.Show();
        }
    
    }
}
