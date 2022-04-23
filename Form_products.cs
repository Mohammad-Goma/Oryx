using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oryx
{
    public partial class Form_products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Charger;Integrated Security=True");
        Boolean found = false;
        public Form_products()
        {
            InitializeComponent();
        }

        public Int64 Max_ID()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
            int id = 0;
            con.Open();
            SqlCommand cmd_max = new SqlCommand("Select max(ID) as fds From products", con);
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

        public void Save()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string sql_save = "INSERT INTO PRODUCTS(PARCODE, PRODUCT_NAME,Date_Buy, UNIT, CURRENCY, INITIAL_COAST, LESS_PRICE, PRICE,SHIPPING_COAST, CUSTOMS, FINISH_PRICE, QTY, ID_STORE, DETAILS_1, DETAILS_2, DETAILS_3) VALUES(N'" + PARCODE.Text.Trim() + "', N'" + PRODUCT_NAME.Text.Trim() + "',N'"+ Date_Buy.Text.Trim() + "', N'" + UNIT.Text.Trim()+"',N'"+ CURRENCY.Text.Trim() + "', N'" + INITIAL_COAST.Text.Trim() + "', N'" + LESS_PRICE.Text.Trim() + "',N'" + PRICE.Text.Trim() + "',N'" + SHIPPING_COAST.Text.Trim() + "',N'" + CUSTOMS.Text.Trim() + "', N'" + FINISH_PRICE.Text.Trim() + "',N'" + QTY.Text.Trim() + "', @ID_STORE,N'" + DETAILS_1.Text.Trim() + "', N'" + DETAILS_2.Text.Trim() + "', N'" + DETAILS_3.Text.Trim() + "')";
                SqlCommand cmd_Save = new SqlCommand(sql_save , con);
                cmd_Save.Parameters.AddWithValue("@PARCODE ", PARCODE.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@PRODUCT_NAME ", PRODUCT_NAME.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@Date_Buy ", Date_Buy.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@UNIT ", UNIT.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@CURRENCY ", CURRENCY.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@INITIAL_COAST ", INITIAL_COAST.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@LESS_PRICE ", LESS_PRICE.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@PRICE ", PRICE.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@SHIPPING_COAST ", SHIPPING_COAST.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@CUSTOMS ", CUSTOMS.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@FINISH_PRICE ", FINISH_PRICE.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@QTY ", QTY.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@ID_STORE ", 1);
                cmd_Save.Parameters.AddWithValue("@DETAILS_1 ", DETAILS_1.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@DETAILS_2 ", DETAILS_2.Text.Trim());
                cmd_Save.Parameters.AddWithValue("@DETAILS_3 ", DETAILS_3.Text.Trim());
                cmd_Save.ExecuteNonQuery();
            
                MessageBox.Show("تم الحفظ بنجاح","رسالة حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  catch (Exception) { }
            finally { con.Close(); }
        }

        public void Edite()
        {
            try
            {

            
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            string sql_Edite = "UPDATE PRODUCTS SET PARCODE = N'" + PARCODE.Text.Trim() + "'," +
                " PRODUCT_NAME=N'" + PRODUCT_NAME.Text.Trim() + "',Date_Buy=N'" + Date_Buy.Text.Trim() + "'," +
                "UNIT=N'" + UNIT.Text.Trim() + "',CURRENCY=N'" + CURRENCY.Text.Trim() + "'," +
                "INITIAL_COAST=N'" + INITIAL_COAST.Text.Trim() + "',LESS_PRICE=N'" + LESS_PRICE.Text.Trim() + "'," +
                "PRICE = N'" + PRICE.Text.Trim() + "',SHIPPING_COAST=N'" + SHIPPING_COAST.Text.Trim() + "'," +
                "CUSTOMS = N'" + CUSTOMS.Text.Trim() + "',FINISH_PRICE=N'" + FINISH_PRICE.Text.Trim() + "'," +
                "QTY=N'" + QTY.Text.Trim() + "',ID_STORE=N'" + ID_STORE.Text.Trim()+"'," +
                "DETAILS_1=N'" + DETAILS_1.Text.Trim() + "', DETAILS_2=N'" + DETAILS_2.Text.Trim() + "'," +
                " DETAILS_3=N'" + DETAILS_3.Text.Trim() + "' WHERE ID=N'"+ID.Text.Trim()+"' ";
            SqlCommand cmd_Edite = new SqlCommand(sql_Edite, con);

            cmd_Edite.ExecuteNonQuery();
            cmd_Edite.Parameters.AddWithValue("@PARCODE ", PARCODE.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@PRODUCT_NAME ", PRODUCT_NAME.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@Date_Buy ", Date_Buy.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@UNIT ", UNIT.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@CURRENCY ", CURRENCY.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@INITIAL_COAST ", INITIAL_COAST.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@LESS_PRICE ", LESS_PRICE.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@PRICE ", PRICE.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@SHIPPING_COAST ", SHIPPING_COAST.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@CUSTOMS ", CUSTOMS.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@FINISH_PRICE ", FINISH_PRICE.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@QTY ", QTY.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@ID_STORE ", 1);
            cmd_Edite.Parameters.AddWithValue("@DETAILS_1 ", DETAILS_1.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@DETAILS_2 ", DETAILS_2.Text.Trim());
            cmd_Edite.Parameters.AddWithValue("@DETAILS_3 ", DETAILS_3.Text.Trim());
            
            MessageBox.Show("تم التعديل بنجاح", "رسالة حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
            finally { con.Close(); }
        }

        public void Delete(TextBox txt)
        {
            
        }

        public void Select_ID()
        {
            found = false;
            if (con.State == ConnectionState.Open) { con.Close(); }
            con.Open();
            SqlCommand cmd_max = new SqlCommand("Select ID From products", con);
            SqlDataReader dr = cmd_max.ExecuteReader();
            while (dr.Read())
            {
                if (ID.Text.Trim() == dr[0].ToString())
                {
                    found = true;
                    break;
                }
            }
            dr.Close();
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //try
            //{
                //    Select_ID();
                //if (!found)
                //{
            if (ID.Text.Trim() == "")
            {
                Save();
                txt_search.Text = string.Empty;
                txt_search.Clear();
                AutoCompleteTextBox();
            }
            else 
            { 
                Edite(); 
                txt_search.Text = string.Empty; 
                txt_search.Clear();
                AutoCompleteTextBox();
            }
                ClearAll();
            //}
            //catch (Exception) { }
        }


        private void button1_Click(object sender, EventArgs e)   // زر الحذف
        {
            try
            {
                con.Open();
                string sql = " DELETE FROM PRODUCTS where ID ='"+ID.Text.Trim()+"' ";
                SqlCommand cmd_delete = new SqlCommand(sql, con);
                cmd_delete.ExecuteNonQuery();
                con.Close();
                txt_search.Text = string.Empty;
                AutoCompleteTextBox();
                MessageBox.Show("تم الحذف بنجاح", "شاشة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception) { }
        }


        public void AutoCompleteTextBox()
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                string Query = "Select PRODUCT_NAME from PRODUCTS ";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));
                }
                dr.Close();
                txt_search.AutoCompleteCustomSource = col;
            } catch (Exception) { }
            finally
            {
                con.Close();
            }
        }


        private void Form_products_Load(object sender, EventArgs e)
        {
            AutoCompleteTextBox();
            //ID.Text = Convert.ToString(Max_ID());
            Date_Buy.Value = DateTime.Now;
        }

        
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
                string s = "SELECT * FROM PRODUCTS WHERE PRODUCT_NAME = N'" + txt_search.Text.Trim() + "' ";
                SqlCommand cmd = new SqlCommand(s , con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ID.Text = dr[0].ToString();
                    PARCODE.Text = dr[1].ToString();
                    PRODUCT_NAME.Text = dr[2].ToString(); 
                    Date_Buy.Text = dr[3].ToString();
                    UNIT.Text = dr[4].ToString();
                    CURRENCY.Text = dr[5].ToString();
                    INITIAL_COAST.Text = dr[6].ToString();
                    LESS_PRICE.Text = dr[7].ToString();
                    PRICE.Text = dr[8].ToString();
                    SHIPPING_COAST.Text = dr[9].ToString();
                    CUSTOMS.Text = dr[10].ToString();
                    FINISH_PRICE.Text = dr[11].ToString();
                    QTY.Text = dr[12].ToString();
                    ID_STORE.Text = dr[13].ToString();
                    DETAILS_1.Text = dr[14].ToString();
                    DETAILS_2.Text = dr[15].ToString();
                    DETAILS_3.Text = dr[16].ToString();
                }
                dr.Close();
            }
            catch (Exception) { }
            finally { con.Close(); All_Qty(); }
        }


        public void ClearAll()
        {
            ID.Text = "";
            PARCODE.Text = "";
            PRODUCT_NAME.Text = "";
            UNIT.Text = "";
            CURRENCY.Text = "";
            INITIAL_COAST.Text = "";
            LESS_PRICE.Text = "";
            PRICE.Text = "";
            SHIPPING_COAST.Text = "";
            CUSTOMS.Text = "";
            FINISH_PRICE.Text = "";
            QTY.Text = "";
            ID_STORE.Text = "";
            DETAILS_1.Text = "";
            DETAILS_2.Text = "";
            DETAILS_3.Text = "";
            txt_search.Text = "";
            //ID.Text = Convert.ToString(Max_ID());
            txt_search.Clear();
            AutoCompleteTextBox();
            Date_Buy.Value = DateTime.Now;
        }


        private void btn_New_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void INITIAL_COAST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (INITIAL_COAST.Text.Trim()  == "") { INITIAL_COAST.Text = "0"; } 
                if (SHIPPING_COAST.Text.Trim() == "") { SHIPPING_COAST.Text = "0"; } 
                if (SHIPPING_COAST.Text.Trim() == "") { SHIPPING_COAST.Text = "0"; } 
                if (CUSTOMS.Text.Trim() == "") { CUSTOMS.Text = "0"; } 

                decimal c1 = Convert.ToDecimal(INITIAL_COAST.Text.Trim()); 
                decimal c2 = Convert.ToDecimal(SHIPPING_COAST.Text.Trim()); 
                decimal c3 = Convert.ToDecimal(CUSTOMS.Text.Trim()); 
                decimal c4 = Convert.ToDecimal(DETAILS_1.Text.Trim());
                decimal c5 = c1 + c2 + c3+c4; FINISH_PRICE.Text = (c5).ToString();
            } catch (Exception) { }
        }


        private void FINISH_PRICE_TextChanged(object sender, EventArgs e)
        {
            All_Qty();
        }

        public void All_Qty()
        {
            try
            {
                if (FINISH_PRICE.Text == "") { FINISH_PRICE.Text = "0"; }
                if (QTY.Text == "") { QTY.Text = "0"; }

                decimal c1 = Convert.ToDecimal(FINISH_PRICE.Text.Trim());
                decimal c2 = Convert.ToDecimal(QTY.Text.Trim());
                decimal c3 = c1 * c2;
                DETAILS_2.Text = c3.ToString();
            }  catch (Exception) { }
        }

    }
}
