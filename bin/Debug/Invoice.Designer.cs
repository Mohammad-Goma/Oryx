namespace Oryx
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_store = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.date_invoice = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_INVOCE = new System.Windows.Forms.DataGridView();
            this.col_PARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CURRENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_show_invoice = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.CURRENCY = new System.Windows.Forms.ComboBox();
            this.UNIT = new System.Windows.Forms.TextBox();
            this.chk_fill = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_parcode = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Total_Above = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PRODUCT_NAME = new System.Windows.Forms.TextBox();
            this.PARCODE = new System.Windows.Forms.TextBox();
            this.QTY = new System.Windows.Forms.TextBox();
            this.PRICE = new System.Windows.Forms.TextBox();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_delete_row = new System.Windows.Forms.Button();
            this.Order_Qty = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chk_percent = new System.Windows.Forms.CheckBox();
            this.txt_amount_of_product = new System.Windows.Forms.TextBox();
            this.msg_invoice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_money = new System.Windows.Forms.CheckBox();
            this.btn_Save_Without_Print = new System.Windows.Forms.Button();
            this.Discount_percent = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_new_invoice = new System.Windows.Forms.Button();
            this.btn_close_invoice = new System.Windows.Forms.Button();
            this.Discount_Money = new System.Windows.Forms.TextBox();
            this.Total_ = new System.Windows.Forms.TextBox();
            this.The_rest = new System.Windows.Forms.TextBox();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.txt_Discount_value = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Total_Before = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVOCE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_store
            // 
            this.cbo_store.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_store.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_store.FormattingEnabled = true;
            this.cbo_store.Location = new System.Drawing.Point(602, 20);
            this.cbo_store.Name = "cbo_store";
            this.cbo_store.Size = new System.Drawing.Size(127, 28);
            this.cbo_store.TabIndex = 69;
            this.cbo_store.Text = " الرئيسي";
            this.cbo_store.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "أسم المخزن";
            this.label5.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(1141, 17);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(122, 26);
            this.txt_id.TabIndex = 65;
            // 
            // date_invoice
            // 
            this.date_invoice.CustomFormat = "yyyy-MM-dd";
            this.date_invoice.Enabled = false;
            this.date_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_invoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_invoice.Location = new System.Drawing.Point(12, 15);
            this.date_invoice.Margin = new System.Windows.Forms.Padding(4);
            this.date_invoice.Name = "date_invoice";
            this.date_invoice.Size = new System.Drawing.Size(293, 26);
            this.date_invoice.TabIndex = 59;
            this.date_invoice.Value = new System.DateTime(2020, 6, 30, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1273, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 20);
            this.label19.TabIndex = 130;
            this.label19.Text = "الرقم المرجعي";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 17);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 154;
            this.label9.Text = "تاريخ اليوم";
            // 
            // DGV_INVOCE
            // 
            this.DGV_INVOCE.AllowUserToAddRows = false;
            this.DGV_INVOCE.AllowUserToDeleteRows = false;
            this.DGV_INVOCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_INVOCE.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.DGV_INVOCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_INVOCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_PARCODE,
            this.col_PRODUCT_NAME,
            this.col_UNIT,
            this.col_QTY,
            this.col_CURRENCY,
            this.col_PRICE,
            this.col_TOTAL,
            this.col_Order_id});
            this.DGV_INVOCE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_INVOCE.Location = new System.Drawing.Point(2, 219);
            this.DGV_INVOCE.MultiSelect = false;
            this.DGV_INVOCE.Name = "DGV_INVOCE";
            this.DGV_INVOCE.ReadOnly = true;
            this.DGV_INVOCE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV_INVOCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_INVOCE.Size = new System.Drawing.Size(1356, 288);
            this.DGV_INVOCE.TabIndex = 156;
            this.DGV_INVOCE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_INVOCE_CellClick);
            // 
            // col_PARCODE
            // 
            this.col_PARCODE.DataPropertyName = "PARCODE";
            this.col_PARCODE.HeaderText = "الباركود";
            this.col_PARCODE.Name = "col_PARCODE";
            this.col_PARCODE.ReadOnly = true;
            this.col_PARCODE.Width = 256;
            // 
            // col_PRODUCT_NAME
            // 
            this.col_PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.col_PRODUCT_NAME.HeaderText = "أسم الصنف";
            this.col_PRODUCT_NAME.Name = "col_PRODUCT_NAME";
            this.col_PRODUCT_NAME.ReadOnly = true;
            this.col_PRODUCT_NAME.Width = 299;
            // 
            // col_UNIT
            // 
            this.col_UNIT.DataPropertyName = "UNIT";
            this.col_UNIT.HeaderText = "الوحدة";
            this.col_UNIT.Name = "col_UNIT";
            this.col_UNIT.ReadOnly = true;
            this.col_UNIT.Width = 92;
            // 
            // col_QTY
            // 
            this.col_QTY.DataPropertyName = "QTY";
            this.col_QTY.HeaderText = "الكمية";
            this.col_QTY.Name = "col_QTY";
            this.col_QTY.ReadOnly = true;
            this.col_QTY.Width = 88;
            // 
            // col_CURRENCY
            // 
            this.col_CURRENCY.DataPropertyName = "CURRENCY";
            this.col_CURRENCY.HeaderText = "العملة";
            this.col_CURRENCY.Name = "col_CURRENCY";
            this.col_CURRENCY.ReadOnly = true;
            this.col_CURRENCY.Width = 105;
            // 
            // col_PRICE
            // 
            this.col_PRICE.DataPropertyName = "PRICE";
            this.col_PRICE.HeaderText = "السعر";
            this.col_PRICE.Name = "col_PRICE";
            this.col_PRICE.ReadOnly = true;
            this.col_PRICE.Width = 95;
            // 
            // col_TOTAL
            // 
            this.col_TOTAL.DataPropertyName = "TOTAL";
            this.col_TOTAL.HeaderText = "الإجمالي";
            this.col_TOTAL.Name = "col_TOTAL";
            this.col_TOTAL.ReadOnly = true;
            this.col_TOTAL.Width = 111;
            // 
            // col_Order_id
            // 
            this.col_Order_id.DataPropertyName = "Order_id";
            this.col_Order_id.HeaderText = "Order Id";
            this.col_Order_id.Name = "col_Order_id";
            this.col_Order_id.ReadOnly = true;
            this.col_Order_id.Visible = false;
            this.col_Order_id.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_show_invoice);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.CURRENCY);
            this.groupBox1.Controls.Add(this.UNIT);
            this.groupBox1.Controls.Add(this.chk_fill);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.txt_parcode);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_Total_Above);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PRODUCT_NAME);
            this.groupBox1.Controls.Add(this.PARCODE);
            this.groupBox1.Controls.Add(this.QTY);
            this.groupBox1.Controls.Add(this.PRICE);
            this.groupBox1.Controls.Add(this.btn_add_product);
            this.groupBox1.Controls.Add(this.btn_delete_row);
            this.groupBox1.Controls.Add(this.Order_Qty);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.chk_percent);
            this.groupBox1.Controls.Add(this.txt_amount_of_product);
            this.groupBox1.Controls.Add(this.msg_invoice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chk_money);
            this.groupBox1.Controls.Add(this.btn_Save_Without_Print);
            this.groupBox1.Controls.Add(this.Discount_percent);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.btn_new_invoice);
            this.groupBox1.Controls.Add(this.btn_close_invoice);
            this.groupBox1.Controls.Add(this.Discount_Money);
            this.groupBox1.Controls.Add(this.Total_);
            this.groupBox1.Controls.Add(this.The_rest);
            this.groupBox1.Controls.Add(this.txt_pay);
            this.groupBox1.Controls.Add(this.txt_Discount_value);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Total_Before);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DGV_INVOCE);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbo_store);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.date_invoice);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1369, 707);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_show_invoice
            // 
            this.btn_show_invoice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_show_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_invoice.Location = new System.Drawing.Point(322, 80);
            this.btn_show_invoice.Name = "btn_show_invoice";
            this.btn_show_invoice.Size = new System.Drawing.Size(116, 36);
            this.btn_show_invoice.TabIndex = 205;
            this.btn_show_invoice.Text = "عرض الفاتورة ";
            this.btn_show_invoice.UseVisualStyleBackColor = false;
            this.btn_show_invoice.Click += new System.EventHandler(this.btn_show_invoice_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.Location = new System.Drawing.Point(12, 87);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(293, 26);
            this.txt_search.TabIndex = 206;
            this.txt_search.Tag = "";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CURRENCY
            // 
            this.CURRENCY.FormattingEnabled = true;
            this.CURRENCY.Items.AddRange(new object[] {
            "ريال قطري",
            "دولار أمريكي"});
            this.CURRENCY.Location = new System.Drawing.Point(498, 191);
            this.CURRENCY.Name = "CURRENCY";
            this.CURRENCY.Size = new System.Drawing.Size(84, 28);
            this.CURRENCY.TabIndex = 204;
            // 
            // UNIT
            // 
            this.UNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNIT.Location = new System.Drawing.Point(669, 192);
            this.UNIT.Name = "UNIT";
            this.UNIT.Size = new System.Drawing.Size(94, 26);
            this.UNIT.TabIndex = 203;
            this.UNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_fill
            // 
            this.chk_fill.AutoSize = true;
            this.chk_fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_fill.Location = new System.Drawing.Point(827, 92);
            this.chk_fill.Name = "chk_fill";
            this.chk_fill.Size = new System.Drawing.Size(15, 14);
            this.chk_fill.TabIndex = 202;
            this.chk_fill.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 201;
            this.label8.Text = "ملئ تلقائي";
            // 
            // txt_product_name
            // 
            this.txt_product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_product_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(970, 126);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(293, 26);
            this.txt_product_name.TabIndex = 182;
            this.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_product_name.TextChanged += new System.EventHandler(this.txt_product_name_TextChanged);
            // 
            // txt_parcode
            // 
            this.txt_parcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_parcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_parcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_parcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcode.Location = new System.Drawing.Point(970, 85);
            this.txt_parcode.Name = "txt_parcode";
            this.txt_parcode.Size = new System.Drawing.Size(293, 26);
            this.txt_parcode.TabIndex = 181;
            this.txt_parcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_parcode.TextChanged += new System.EventHandler(this.txt_parcode_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox8.Location = new System.Drawing.Point(498, 167);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 25);
            this.textBox8.TabIndex = 200;
            this.textBox8.Text = "العملة";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox7.Location = new System.Drawing.Point(159, 167);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(112, 26);
            this.textBox7.TabIndex = 199;
            this.textBox7.Text = "الكمية المتوفره";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox6.Location = new System.Drawing.Point(270, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(113, 26);
            this.textBox6.TabIndex = 198;
            this.textBox6.Text = "المجموع";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox5.Location = new System.Drawing.Point(382, 167);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(116, 26);
            this.textBox5.TabIndex = 197;
            this.textBox5.Text = "السعر";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox4.Location = new System.Drawing.Point(582, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(88, 26);
            this.textBox4.TabIndex = 196;
            this.textBox4.Text = "الكمية المطلوية";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox3.Location = new System.Drawing.Point(669, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(94, 26);
            this.textBox3.TabIndex = 195;
            this.textBox3.Text = "الوحدة";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox2.Location = new System.Drawing.Point(762, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(299, 26);
            this.textBox2.TabIndex = 194;
            this.textBox2.Text = "أسم الصنف";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Location = new System.Drawing.Point(1060, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 26);
            this.textBox1.TabIndex = 193;
            this.textBox1.Text = "الباركود";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Total_Above
            // 
            this.txt_Total_Above.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Above.Location = new System.Drawing.Point(270, 192);
            this.txt_Total_Above.Name = "txt_Total_Above";
            this.txt_Total_Above.ReadOnly = true;
            this.txt_Total_Above.Size = new System.Drawing.Size(113, 26);
            this.txt_Total_Above.TabIndex = 192;
            this.txt_Total_Above.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1289, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 20);
            this.label20.TabIndex = 191;
            this.label20.Text = "بحث بالسم";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1273, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 189;
            this.label18.Text = "بحث بالباركود";
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCT_NAME.Location = new System.Drawing.Point(762, 192);
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Size = new System.Drawing.Size(299, 26);
            this.PRODUCT_NAME.TabIndex = 190;
            this.PRODUCT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PARCODE
            // 
            this.PARCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PARCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PARCODE.Location = new System.Drawing.Point(1060, 192);
            this.PARCODE.Name = "PARCODE";
            this.PARCODE.ReadOnly = true;
            this.PARCODE.Size = new System.Drawing.Size(297, 26);
            this.PARCODE.TabIndex = 188;
            this.PARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QTY
            // 
            this.QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTY.Location = new System.Drawing.Point(159, 192);
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Size = new System.Drawing.Size(112, 26);
            this.QTY.TabIndex = 185;
            this.QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PRICE
            // 
            this.PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE.Location = new System.Drawing.Point(382, 192);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(116, 26);
            this.PRICE.TabIndex = 186;
            this.PRICE.Text = "1";
            this.PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PRICE.TextChanged += new System.EventHandler(this.Order_Qty_TextChanged);
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.Location = new System.Drawing.Point(798, 123);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(132, 33);
            this.btn_add_product.TabIndex = 183;
            this.btn_add_product.Text = "إضافة صنف";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.TextChanged += new System.EventHandler(this.btn_add_product_Click);
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_delete_row
            // 
            this.btn_delete_row.BackColor = System.Drawing.Color.White;
            this.btn_delete_row.Enabled = false;
            this.btn_delete_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_row.Location = new System.Drawing.Point(10, 168);
            this.btn_delete_row.Name = "btn_delete_row";
            this.btn_delete_row.Size = new System.Drawing.Size(143, 45);
            this.btn_delete_row.TabIndex = 184;
            this.btn_delete_row.Text = "حذف الصنف";
            this.btn_delete_row.UseVisualStyleBackColor = false;
            this.btn_delete_row.Click += new System.EventHandler(this.btn_delete_row_Click);
            // 
            // Order_Qty
            // 
            this.Order_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Qty.Location = new System.Drawing.Point(582, 192);
            this.Order_Qty.Name = "Order_Qty";
            this.Order_Qty.Size = new System.Drawing.Size(88, 26);
            this.Order_Qty.TabIndex = 187;
            this.Order_Qty.Text = "1";
            this.Order_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Order_Qty.TextChanged += new System.EventHandler(this.Order_Qty_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(202, 520);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 31);
            this.label22.TabIndex = 167;
            this.label22.Text = "المدفوع";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(56, 520);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 31);
            this.label21.TabIndex = 168;
            this.label21.Text = "الباقي";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(357, 520);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 31);
            this.label16.TabIndex = 160;
            this.label16.Text = "الإجمالي";
            // 
            // chk_percent
            // 
            this.chk_percent.AutoSize = true;
            this.chk_percent.Location = new System.Drawing.Point(962, 525);
            this.chk_percent.Name = "chk_percent";
            this.chk_percent.Size = new System.Drawing.Size(90, 24);
            this.chk_percent.TabIndex = 176;
            this.chk_percent.Text = "خصم بالمائة";
            this.chk_percent.UseVisualStyleBackColor = true;
            this.chk_percent.CheckedChanged += new System.EventHandler(this.chk_percent_CheckedChanged);
            // 
            // txt_amount_of_product
            // 
            this.txt_amount_of_product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_amount_of_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount_of_product.Location = new System.Drawing.Point(1108, 525);
            this.txt_amount_of_product.Name = "txt_amount_of_product";
            this.txt_amount_of_product.ReadOnly = true;
            this.txt_amount_of_product.Size = new System.Drawing.Size(128, 26);
            this.txt_amount_of_product.TabIndex = 158;
            this.txt_amount_of_product.Text = "0";
            this.txt_amount_of_product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msg_invoice
            // 
            this.msg_invoice.BackColor = System.Drawing.Color.DarkOrchid;
            this.msg_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msg_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_invoice.ForeColor = System.Drawing.Color.Red;
            this.msg_invoice.Location = new System.Drawing.Point(159, 630);
            this.msg_invoice.Multiline = true;
            this.msg_invoice.Name = "msg_invoice";
            this.msg_invoice.Size = new System.Drawing.Size(689, 63);
            this.msg_invoice.TabIndex = 179;
            this.msg_invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1269, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 159;
            this.label12.Text = "كمية الصناف ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label13.Location = new System.Drawing.Point(570, 557);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(784, 20);
            this.label13.TabIndex = 178;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------";
            // 
            // chk_money
            // 
            this.chk_money.AutoSize = true;
            this.chk_money.Location = new System.Drawing.Point(970, 578);
            this.chk_money.Name = "chk_money";
            this.chk_money.Size = new System.Drawing.Size(91, 24);
            this.chk_money.TabIndex = 177;
            this.chk_money.Text = "خصم بالعملة";
            this.chk_money.UseVisualStyleBackColor = true;
            this.chk_money.CheckedChanged += new System.EventHandler(this.chk_money_CheckedChanged);
            // 
            // btn_Save_Without_Print
            // 
            this.btn_Save_Without_Print.BackColor = System.Drawing.Color.Blue;
            this.btn_Save_Without_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_Without_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Without_Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save_Without_Print.Location = new System.Drawing.Point(1222, 644);
            this.btn_Save_Without_Print.Name = "btn_Save_Without_Print";
            this.btn_Save_Without_Print.Size = new System.Drawing.Size(114, 42);
            this.btn_Save_Without_Print.TabIndex = 180;
            this.btn_Save_Without_Print.Text = "حفظ";
            this.btn_Save_Without_Print.UseVisualStyleBackColor = false;
            this.btn_Save_Without_Print.Click += new System.EventHandler(this.btn_Save_Without_Print_Click);
            // 
            // Discount_percent
            // 
            this.Discount_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_percent.Location = new System.Drawing.Point(827, 528);
            this.Discount_percent.Name = "Discount_percent";
            this.Discount_percent.Size = new System.Drawing.Size(128, 26);
            this.Discount_percent.TabIndex = 164;
            this.Discount_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount_percent.TextChanged += new System.EventHandler(this.Discount_percent_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(866, 644);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(114, 42);
            this.btn_print.TabIndex = 172;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_new_invoice
            // 
            this.btn_new_invoice.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_new_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_invoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new_invoice.Location = new System.Drawing.Point(1044, 644);
            this.btn_new_invoice.Name = "btn_new_invoice";
            this.btn_new_invoice.Size = new System.Drawing.Size(114, 42);
            this.btn_new_invoice.TabIndex = 171;
            this.btn_new_invoice.Text = "جديد";
            this.btn_new_invoice.UseVisualStyleBackColor = false;
            this.btn_new_invoice.Click += new System.EventHandler(this.btn_new_invoice_Click);
            // 
            // btn_close_invoice
            // 
            this.btn_close_invoice.BackColor = System.Drawing.Color.Crimson;
            this.btn_close_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_invoice.ForeColor = System.Drawing.Color.Navy;
            this.btn_close_invoice.Location = new System.Drawing.Point(25, 644);
            this.btn_close_invoice.Name = "btn_close_invoice";
            this.btn_close_invoice.Size = new System.Drawing.Size(116, 49);
            this.btn_close_invoice.TabIndex = 173;
            this.btn_close_invoice.Text = "خروج";
            this.btn_close_invoice.UseVisualStyleBackColor = false;
            this.btn_close_invoice.Click += new System.EventHandler(this.btn_close_invoice_Click);
            // 
            // Discount_Money
            // 
            this.Discount_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_Money.Location = new System.Drawing.Point(827, 576);
            this.Discount_Money.Name = "Discount_Money";
            this.Discount_Money.Size = new System.Drawing.Size(129, 26);
            this.Discount_Money.TabIndex = 170;
            this.Discount_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount_Money.TextChanged += new System.EventHandler(this.Discount_Money_TextChanged);
            // 
            // Total_
            // 
            this.Total_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Total_.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Total_.Location = new System.Drawing.Point(340, 554);
            this.Total_.Name = "Total_";
            this.Total_.ReadOnly = true;
            this.Total_.Size = new System.Drawing.Size(123, 50);
            this.Total_.TabIndex = 161;
            this.Total_.Text = "0";
            this.Total_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_.TextChanged += new System.EventHandler(this.Total__TextChanged);
            // 
            // The_rest
            // 
            this.The_rest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.The_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_rest.ForeColor = System.Drawing.Color.Black;
            this.The_rest.Location = new System.Drawing.Point(25, 554);
            this.The_rest.Name = "The_rest";
            this.The_rest.ReadOnly = true;
            this.The_rest.Size = new System.Drawing.Size(123, 50);
            this.The_rest.TabIndex = 169;
            this.The_rest.Text = "0";
            this.The_rest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pay
            // 
            this.txt_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pay.Location = new System.Drawing.Point(182, 554);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pay.Size = new System.Drawing.Size(123, 50);
            this.txt_pay.TabIndex = 157;
            this.txt_pay.Text = "0";
            this.txt_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pay.TextChanged += new System.EventHandler(this.Total__TextChanged);
            this.txt_pay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_pay_MouseDown);
            // 
            // txt_Discount_value
            // 
            this.txt_Discount_value.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Discount_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount_value.Location = new System.Drawing.Point(613, 576);
            this.txt_Discount_value.Name = "txt_Discount_value";
            this.txt_Discount_value.Size = new System.Drawing.Size(116, 26);
            this.txt_Discount_value.TabIndex = 166;
            this.txt_Discount_value.Text = "0";
            this.txt_Discount_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Discount_value.TextChanged += new System.EventHandler(this.Total_Before_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(646, 537);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 20);
            this.label17.TabIndex = 165;
            this.label17.Text = "قيمة الخصم";
            // 
            // Total_Before
            // 
            this.Total_Before.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Total_Before.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Before.Location = new System.Drawing.Point(1109, 580);
            this.Total_Before.Name = "Total_Before";
            this.Total_Before.ReadOnly = true;
            this.Total_Before.Size = new System.Drawing.Size(127, 26);
            this.Total_Before.TabIndex = 174;
            this.Total_Before.Text = "0";
            this.Total_Before.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Before.TextChanged += new System.EventHandler(this.Total_Before_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1242, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 175;
            this.label11.Text = "الإجمالي قبل الخصم";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة البيع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.Shown += new System.EventHandler(this.Invoice_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Invoice_KeyDown);
            this.Resize += new System.EventHandler(this.Invoice_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_INVOCE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_store;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.DateTimePicker date_invoice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_INVOCE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chk_percent;
        private System.Windows.Forms.TextBox txt_amount_of_product;
        private System.Windows.Forms.TextBox msg_invoice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chk_money;
        private System.Windows.Forms.Button btn_Save_Without_Print;
        private System.Windows.Forms.TextBox Discount_percent;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_new_invoice;
        private System.Windows.Forms.Button btn_close_invoice;
        private System.Windows.Forms.TextBox Discount_Money;
        private System.Windows.Forms.TextBox Total_;
        private System.Windows.Forms.TextBox The_rest;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.TextBox txt_Discount_value;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Total_Before;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CURRENCY;
        private System.Windows.Forms.TextBox UNIT;
        private System.Windows.Forms.CheckBox chk_fill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_parcode;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Total_Above;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PRODUCT_NAME;
        private System.Windows.Forms.TextBox PARCODE;
        private System.Windows.Forms.TextBox QTY;
        public System.Windows.Forms.TextBox PRICE;
        private System.Windows.Forms.Button btn_add_product;
        public System.Windows.Forms.Button btn_delete_row;
        private System.Windows.Forms.TextBox Order_Qty;
        private System.Windows.Forms.Button btn_show_invoice;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CURRENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Order_id;
    }
}