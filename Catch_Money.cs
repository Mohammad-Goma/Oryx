using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Oryx
{
    public partial class Catch_Money : Form
    {
        Fill_Cbo fill = new Fill_Cbo();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        public Catch_Money()
        {
            InitializeComponent();
        }

        private void Catch_Money_Load(object sender, EventArgs e)
        {
            id.Text = Convert.ToString(max());
            fill.Select_TBL_CATCH_RECEIPT(txt_search);
            //fill.Fill_Currency(txt_currency);
            DATE_NOW.Value = DateTime.Now;
            CUSTOMER_INVOICE_DATE.Value = DateTime.Now;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Max = Convert.ToString(max()); if (id.Text.Trim() == Max) { Save(); } else if (id.Text.Trim() != Max) { UPDATE(); }
        }

        public void ClearAll()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) { ctrl.Text = string.Empty; }
            }
            txt_currency.Text = "";
            id.Text = Convert.ToString(max());
            fill.Select_TBL_PAY_RECEIPT(txt_search);
        }

        public void Save()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string SQL = "Insert into TBL_CATCH_RECEIPT  Values(N'" + ID_ORDER_AUTO.Text.Trim() +"',N'" + ID_ORDER_HAND.Text.Trim() + "'," +
                "N'" + CUSTOMER_NAME.Text.Trim() + "',N'" + TO_COUNT.Text.Trim() + "',N'" + CUSTOMER_INVOICE_DATE.Text.Trim() + "'," +
                "N'" + ID_PAY_RECEIPT.Text.Trim() + "'," +
                "N'" + USER_NAME.Text.Trim() + "',N'" + DATE_NOW.Text.Trim() + "',N'" + AMOUNT.Text.Trim() + "',N'" + TOTAL_BEFORE_DISCOUNT.Text.Trim() + "'," +
                "N'" + DISCOUNT.Text.Trim() + "',N'" + TOTAL_AFTER_DISCOUNT.Text.Trim() + "',N'" + Cash.Text.Trim() + "'," +
                "N'" + Cheek_Total.Text.Trim() + "'," +
                "N'" + cheek_num.Text.Trim() + "',N'" + txt_total_rest.Text.Trim() + "',N'" + txt_currency.Text.Trim() + "'," +
                "N'" + Date_Update.Text.Trim() + "',N'" + User_Update.Text.Trim() + "',N'" + Details.Text.Trim() + "') ";
                SqlCommand cmd = new SqlCommand(SQL , con);
                cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue(@"CUSTOMER_NAME", CUSTOMER_NAME.Text.Trim());                   
                cmd.Parameters.AddWithValue(@"TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT.Text.Trim());   
                cmd.Parameters.AddWithValue(@"TO_COUNT", TO_COUNT.Text.Trim());                              
                cmd.Parameters.AddWithValue(@"DISCOUNT", DISCOUNT.Text.Trim());                              
                cmd.Parameters.AddWithValue(@"Cash", Cash.Text.Trim());                                      
                cmd.Parameters.AddWithValue(@"TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());     
                cmd.Parameters.AddWithValue(@"currency", txt_currency.Text.Trim());                      
                cmd.Parameters.AddWithValue(@"Cheek_Total", Cheek_Total.Text.Trim());                       
                cmd.Parameters.AddWithValue(@"total_rest", txt_total_rest.Text.Trim());                 
                cmd.Parameters.AddWithValue(@"CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());       
                cmd.Parameters.AddWithValue(@"ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());                 
                cmd.Parameters.AddWithValue(@"AMOUNT", AMOUNT.Text.Trim());                                 
                cmd.Parameters.AddWithValue(@"ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());                    
                cmd.Parameters.AddWithValue(@"ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());                    
                cmd.Parameters.AddWithValue(@"cheek_num", cheek_num.Text.Trim());                             
                cmd.Parameters.AddWithValue(@"Details", Details.Text.Trim());                                 
                cmd.Parameters.AddWithValue(@"DATE_NOW", DATE_NOW.Text.Trim());                             
                cmd.Parameters.AddWithValue(@"USER_NAME", USER_NAME.Text.Trim());                                                                                                
                //cmd.Parameters.AddWithValue(@"Date_Update", Date_Update.Text.Trim());
                //cmd.Parameters.AddWithValue(@"User_Update", User_Update.Text.Trim());   
                con.Close();
                ClearAll();
                msg.Text = "تم الحفظ بنجاح ";
            } catch (Exception) {  }
            finally { con.Close(); }
        }

        public void UPDATE()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string sql ="UPDATE TBL_CATCH_RECEIPT SET CUSTOMER_NAME = N'" + CUSTOMER_NAME.Text.Trim() + "', TOTAL_BEFORE_DISCOUNT = N'" + TOTAL_BEFORE_DISCOUNT.Text.Trim() + "'," +
                            "From_COUNT=N'" + TO_COUNT.Text.Trim() + "', DISCOUNT=N'" + DISCOUNT.Text.Trim() + "',Cash=N'" + Cash.Text.Trim() + "'," +
                            "TOTAL_AFTER_DISCOUNT=N'" + TOTAL_AFTER_DISCOUNT.Text.Trim() + "',currency=N'" + txt_currency.Text.Trim() + "'," +
                            "Cheek_Total=N'" + Cheek_Total.Text.Trim() + "',total_rest=N'" + txt_total_rest.Text.Trim() + "'," +
                            "CUSTOMER_INVOICE_DATE=N'" + CUSTOMER_INVOICE_DATE.Text.Trim() + "',ID_PAY_RECEIPT=N'" + ID_PAY_RECEIPT.Text.Trim() + "'," +
                            "AMOUNT=N'" + AMOUNT.Text.Trim() + "',ID_ORDER_HAND=N'" + ID_ORDER_HAND.Text.Trim() + "'," +
                            "ID_ORDER_AUTO=N'" + ID_ORDER_AUTO.Text.Trim() + "',cheek_num=N'" + cheek_num.Text.Trim() + "'," +
                            "Details=N'" + Details.Text.Trim() + "',DATE_NOW=N'" + txt_insert_date.Text.Trim() + "'," +
                            "USER_NAME=N'" + txt_insert_name.Text.Trim()+ "',Date_Update=N'" + DATE_NOW.Text.Trim() + "', User_Update=N'" + USER_NAME.Text.Trim() + "' Where ID = N'" + id.Text.Trim() + "'";

                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue(@"CUSTOMER_NAME", CUSTOMER_NAME.Text.Trim());                   
                cmd.Parameters.AddWithValue(@"TOTAL_BEFORE_DISCOUNT", TOTAL_BEFORE_DISCOUNT.Text.Trim());                    
                cmd.Parameters.AddWithValue(@"TO_COUNT", TO_COUNT.Text.Trim());                    
                cmd.Parameters.AddWithValue(@"DISCOUNT", DISCOUNT.Text.Trim());                    
                cmd.Parameters.AddWithValue(@"Cash", Cash.Text.Trim());   
                cmd.Parameters.AddWithValue(@"TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());                           
                cmd.Parameters.AddWithValue(@"txt_currency", txt_currency.Text.Trim());                                  
                cmd.Parameters.AddWithValue(@"Cheek_Total", Cheek_Total.Text.Trim());    
                cmd.Parameters.AddWithValue(@"txt_total_rest", txt_total_rest.Text.Trim());                             
                cmd.Parameters.AddWithValue(@"CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());     
                cmd.Parameters.AddWithValue(@"ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());                                     
                cmd.Parameters.AddWithValue(@"AMOUNT", AMOUNT.Text.Trim());                        
                cmd.Parameters.AddWithValue(@"ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());                            
                cmd.Parameters.AddWithValue(@"ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());                      
                cmd.Parameters.AddWithValue(@"cheek_num", cheek_num.Text.Trim());                          
                cmd.Parameters.AddWithValue(@"Details", Details.Text.Trim());
                cmd.Parameters.AddWithValue(@"DATE_NOW", txt_insert_date.Text.Trim());
                cmd.Parameters.AddWithValue(@"USER_NAME", txt_insert_name.Text.Trim());
                cmd.Parameters.AddWithValue(@"Date_Update", DATE_NOW.Text.Trim());
                cmd.Parameters.AddWithValue(@"User_Update", USER_NAME.Text.Trim());
                ClearAll();
                msg.Text = "تم التعديل بنجاح";
            }catch (Exception) {  }
            finally { con.Close(); }
        }

        public Int64 max()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            int id = 0;
            con.Open();
            cmd = new SqlCommand("Select max(ID) AS fds From TBL_CATCH_RECEIPT", con);
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
            }
            catch (Exception) { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string Delete = " Delete from TBL_CATCH_RECEIPT Where ID = N'" + id.Text.Trim() + "' ";
                cmd = new SqlCommand( Delete , con);
                cmd.ExecuteNonQuery();
                ClearAll();
                msg.Text = " تم الحذف بنجاح ";
            } catch (Exception) { }
            finally { con.Close(); }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string sql = "Select * From TBL_CATCH_RECEIPT WHERE ID = N'" + txt_search.Text.Trim() + "' ";
                cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id.Text = dr["ID"].ToString();
                    CUSTOMER_NAME.Text = dr["CUSTOMER_NAME"].ToString();
                    TOTAL_BEFORE_DISCOUNT.Text = dr["TOTAL_BEFORE_DISCOUNT"].ToString();
                    TO_COUNT.Text = dr["FROM_COUNT"].ToString();
                    DISCOUNT.Text = dr["DISCOUNT"].ToString();
                    Cash.Text = dr["Cash"].ToString();
                    TOTAL_AFTER_DISCOUNT.Text = dr["TOTAL_AFTER_DISCOUNT"].ToString();
                    txt_currency.Text = dr["currency"].ToString();
                    Cheek_Total.Text = dr["Cheek_Total"].ToString();
                    txt_total_rest.Text = dr["total_rest"].ToString();
                    try
                    {
                        DateTime dt = Convert.ToDateTime(dr["CUSTOMER_INVOICE_DATE"]);
                        CUSTOMER_INVOICE_DATE.Value = dt;
                    } catch (Exception) { }
                    ID_PAY_RECEIPT.Text = dr["ID_PAY_RECEIPT"].ToString();
                    AMOUNT.Text = dr["AMOUNT"].ToString();
                    ID_ORDER_HAND.Text = dr["ID_ORDER_HAND"].ToString();
                    ID_ORDER_AUTO.Text = dr["ID_ORDER_AUTO"].ToString();
                    cheek_num.Text = dr["cheek_num"].ToString();
                    Details.Text = dr["Details"].ToString();
                    //DateTime dt2 = Convert.ToDateTime(dr["DATE_NOW"]);
                    //txt_insert_date.Value = dt2;
                    txt_insert_date.Text = dr["DATE_NOW"].ToString();
                    txt_insert_name.Text = dr["USER_NAME"].ToString();
                    Date_Update.Text = dr["Date_Update"].ToString();
                    User_Update.Text = dr["User_Update"].ToString();
                }
                dr.Close(); 
            //con.Close();
            }
            catch (Exception) { }
            finally { con.Close(); }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_Catch_Report frm = new frm_Catch_Report(USER_NAME.Text.Trim(), DATE_NOW.Text.Trim(),
                id.Text.Trim(), TO_COUNT.Text.Trim(), TOTAL_BEFORE_DISCOUNT.Text.Trim(),
                TOTAL_AFTER_DISCOUNT.Text.Trim(), Cash.Text.Trim(), txt_currency.Text.Trim(),
                Cheek_Total.Text.Trim(), CUSTOMER_INVOICE_DATE.Text.Trim(), AMOUNT.Text.Trim(),
                ID_PAY_RECEIPT.Text.Trim(), ID_ORDER_HAND.Text.Trim(), ID_ORDER_AUTO.Text.Trim(),
                Details.Text.Trim(), User_Update.Text.Trim(), Date_Update.Text.Trim(),
                txt_insert_date.Text.Trim(), Date_Update.Text.Trim(),cheek_num.Text.Trim(),txt_insert_name.Text.Trim());

            CrystalCatch crystal = new CrystalCatch();
            if (USER_NAME.Text.Trim() == "") { USER_NAME.Text = "0"; }
            crystal.SetParameterValue("USER_NAME", USER_NAME.Text.Trim());
            if (DATE_NOW.Text.Trim() == "") { DATE_NOW.Text = "0"; }
            crystal.SetParameterValue("DATE_NOW", DATE_NOW.Text.Trim());
            if (id.Text.Trim() == "") { id.Text = "0"; }
            crystal.SetParameterValue("id", id.Text.Trim());
            if (TO_COUNT.Text.Trim() == "") { TO_COUNT.Text = "0"; }
            crystal.SetParameterValue("TO_COUNT", TO_COUNT.Text.Trim());
            if (TOTAL_BEFORE_DISCOUNT.Text.Trim() == "") { TOTAL_BEFORE_DISCOUNT.Text = "0"; }
            crystal.SetParameterValue("Total_Before_Discount", TOTAL_BEFORE_DISCOUNT.Text.Trim());
            if (TOTAL_AFTER_DISCOUNT.Text.Trim() == "") { TOTAL_AFTER_DISCOUNT.Text = "0"; }
            crystal.SetParameterValue("TOTAL_AFTER_DISCOUNT", TOTAL_AFTER_DISCOUNT.Text.Trim());
            if (Cash.Text.Trim() == "") { Cash.Text = "0"; }
            crystal.SetParameterValue("Cash", Cash.Text.Trim());
            if (txt_currency.Text.Trim() == "") { txt_currency.Text = "0"; }
            crystal.SetParameterValue("txt_currency", txt_currency.Text.Trim());
            if (Cheek_Total.Text.Trim() == "") { Cheek_Total.Text = "0"; }
            crystal.SetParameterValue("Cheek_Total", Cheek_Total.Text.Trim());
            if (CUSTOMER_INVOICE_DATE.Text.Trim() == "") { CUSTOMER_INVOICE_DATE.Text = "0"; }
            crystal.SetParameterValue("CUSTOMER_INVOICE_DATE", CUSTOMER_INVOICE_DATE.Text.Trim());
            if (AMOUNT.Text.Trim() == "") { AMOUNT.Text = "0"; }
            crystal.SetParameterValue("AMOUNT", AMOUNT.Text.Trim());
            if (ID_PAY_RECEIPT.Text.Trim() == "") { ID_PAY_RECEIPT.Text = "0"; }
            crystal.SetParameterValue("ID_PAY_RECEIPT", ID_PAY_RECEIPT.Text.Trim());
            if (ID_ORDER_HAND.Text.Trim() == "") { ID_ORDER_HAND.Text = "0"; }
            crystal.SetParameterValue("ID_ORDER_HAND", ID_ORDER_HAND.Text.Trim());
            if (ID_ORDER_AUTO.Text.Trim() == "") { ID_ORDER_AUTO.Text = "0"; }
            crystal.SetParameterValue("ID_ORDER_AUTO", ID_ORDER_AUTO.Text.Trim());
            if (Details.Text.Trim() == "") { Details.Text = "0"; }
            crystal.SetParameterValue("Details", Details.Text.Trim());
            if (Date_Update.Text.Trim() == "") { Date_Update.Text = "0"; }
            crystal.SetParameterValue("User_Update", Date_Update.Text.Trim());
            if (txt_insert_date.Text.Trim() == "") { txt_insert_date.Text = "0"; }
            crystal.SetParameterValue("txt_insert_date", txt_insert_date.Text.Trim()); 
            if (Date_Update.Text.Trim() == "") { Date_Update.Text = "0"; }
            crystal.SetParameterValue("Date_Update", Date_Update.Text.Trim());
            crystal.SetParameterValue("cheek_num", cheek_num.Text.Trim());
            crystal.SetParameterValue("txt_insert_name", txt_insert_name.Text.Trim());
            frm.crystalViewerCatch.ReportSource = crystal;
            frm.crystalViewerCatch.Refresh();
            frm.Show();
        }
    }
}
