namespace Oryx
{
    partial class Profits
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
            this.dt_1 = new System.Windows.Forms.DateTimePicker();
            this.dt_2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.ID_ORDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT_ITEMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV3 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_TIME_NOW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY_FIRST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THE_REST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.ID_ORDER_AUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_NOW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Invoice = new System.Windows.Forms.TextBox();
            this.Recipt = new System.Windows.Forms.TextBox();
            this.Billing = new System.Windows.Forms.TextBox();
            this.Total_Profits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Qty_Coast = new System.Windows.Forms.TextBox();
            this.txt_last_Coast = new System.Windows.Forms.TextBox();
            this.DGV4 = new System.Windows.Forms.DataGridView();
            this.Parcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV4)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_1
            // 
            this.dt_1.CustomFormat = "yyyy-MM-dd";
            this.dt_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_1.Location = new System.Drawing.Point(1073, 11);
            this.dt_1.Name = "dt_1";
            this.dt_1.RightToLeftLayout = true;
            this.dt_1.Size = new System.Drawing.Size(207, 26);
            this.dt_1.TabIndex = 0;
            this.dt_1.Value = new System.DateTime(2020, 7, 3, 0, 0, 0, 0);
            // 
            // dt_2
            // 
            this.dt_2.CustomFormat = "yyyy-MM-dd";
            this.dt_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_2.Location = new System.Drawing.Point(716, 11);
            this.dt_2.Name = "dt_2";
            this.dt_2.RightToLeftLayout = true;
            this.dt_2.Size = new System.Drawing.Size(218, 26);
            this.dt_2.TabIndex = 1;
            this.dt_2.Value = new System.DateTime(2020, 7, 3, 0, 0, 0, 0);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Blue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(404, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(158, 33);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ORDER,
            this.DATE,
            this.AMOUNT_ITEMS,
            this.TOTAL});
            this.DGV1.Location = new System.Drawing.Point(13, 79);
            this.DGV1.Name = "DGV1";
            this.DGV1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV1.Size = new System.Drawing.Size(697, 298);
            this.DGV1.TabIndex = 3;
            // 
            // ID_ORDER
            // 
            this.ID_ORDER.DataPropertyName = "ID_ORDER";
            this.ID_ORDER.HeaderText = "الرقم الآلي";
            this.ID_ORDER.Name = "ID_ORDER";
            this.ID_ORDER.ReadOnly = true;
            this.ID_ORDER.Width = 110;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "التاريخ";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 170;
            // 
            // AMOUNT_ITEMS
            // 
            this.AMOUNT_ITEMS.DataPropertyName = "AMOUNT_ITEMS";
            this.AMOUNT_ITEMS.HeaderText = "كمية الأصناف";
            this.AMOUNT_ITEMS.Name = "AMOUNT_ITEMS";
            this.AMOUNT_ITEMS.ReadOnly = true;
            this.AMOUNT_ITEMS.Width = 200;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "المجموع";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 130;
            // 
            // DGV3
            // 
            this.DGV3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DGV3.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATE_TIME_NOW,
            this.CURENCY,
            this.TOTAL_AMOUNT,
            this.TOTAL_DISCOUNT,
            this.PAY_FIRST,
            this.THE_REST});
            this.DGV3.Location = new System.Drawing.Point(536, 435);
            this.DGV3.Name = "DGV3";
            this.DGV3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV3.Size = new System.Drawing.Size(824, 259);
            this.DGV3.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "الرقم المرجعي";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DATE_TIME_NOW
            // 
            this.DATE_TIME_NOW.DataPropertyName = "DATE_TIME_NOW";
            this.DATE_TIME_NOW.HeaderText = "تاريخ البيع";
            this.DATE_TIME_NOW.Name = "DATE_TIME_NOW";
            this.DATE_TIME_NOW.ReadOnly = true;
            this.DATE_TIME_NOW.Width = 170;
            // 
            // CURENCY
            // 
            this.CURENCY.DataPropertyName = "CURENCY";
            this.CURENCY.HeaderText = "العملة";
            this.CURENCY.Name = "CURENCY";
            this.CURENCY.ReadOnly = true;
            // 
            // TOTAL_AMOUNT
            // 
            this.TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.HeaderText = "الكمية المباعة";
            this.TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.ReadOnly = true;
            // 
            // TOTAL_DISCOUNT
            // 
            this.TOTAL_DISCOUNT.DataPropertyName = "TOTAL_DISCOUNT";
            this.TOTAL_DISCOUNT.HeaderText = "إجمالي الخصم";
            this.TOTAL_DISCOUNT.Name = "TOTAL_DISCOUNT";
            this.TOTAL_DISCOUNT.ReadOnly = true;
            // 
            // PAY_FIRST
            // 
            this.PAY_FIRST.DataPropertyName = "PAY_FIRST";
            this.PAY_FIRST.HeaderText = "المدفوع";
            this.PAY_FIRST.Name = "PAY_FIRST";
            this.PAY_FIRST.ReadOnly = true;
            // 
            // THE_REST
            // 
            this.THE_REST.DataPropertyName = "THE_REST";
            this.THE_REST.HeaderText = "الباقي";
            this.THE_REST.Name = "THE_REST";
            this.THE_REST.ReadOnly = true;
            // 
            // DGV2
            // 
            this.DGV2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV2.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ORDER_AUTO,
            this.CUSTOMER_NAME,
            this.DATE_NOW,
            this.Cash});
            this.DGV2.Location = new System.Drawing.Point(716, 79);
            this.DGV2.Name = "DGV2";
            this.DGV2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV2.Size = new System.Drawing.Size(642, 298);
            this.DGV2.TabIndex = 5;
            // 
            // ID_ORDER_AUTO
            // 
            this.ID_ORDER_AUTO.DataPropertyName = "ID_ORDER_AUTO";
            this.ID_ORDER_AUTO.HeaderText = "الرقم الآلي للفاتورة ";
            this.ID_ORDER_AUTO.Name = "ID_ORDER_AUTO";
            this.ID_ORDER_AUTO.ReadOnly = true;
            this.ID_ORDER_AUTO.Width = 150;
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.HeaderText = "أسم العميل";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.ReadOnly = true;
            this.CUSTOMER_NAME.Width = 130;
            // 
            // DATE_NOW
            // 
            this.DATE_NOW.DataPropertyName = "DATE_NOW";
            this.DATE_NOW.HeaderText = "التاريخ";
            this.DATE_NOW.Name = "DATE_NOW";
            this.DATE_NOW.ReadOnly = true;
            this.DATE_NOW.Width = 130;
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "المدفوع";
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "إجمالي الفواتير المباعة ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "إجمالي المصروفات";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "إجمالي المشتريات";
            // 
            // Invoice
            // 
            this.Invoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice.Location = new System.Drawing.Point(16, 469);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(212, 26);
            this.Invoice.TabIndex = 9;
            this.Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Invoice.TextChanged += new System.EventHandler(this.Invoice_TextChanged);
            // 
            // Recipt
            // 
            this.Recipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recipt.Location = new System.Drawing.Point(317, 469);
            this.Recipt.Name = "Recipt";
            this.Recipt.Size = new System.Drawing.Size(206, 26);
            this.Recipt.TabIndex = 10;
            this.Recipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recipt.TextChanged += new System.EventHandler(this.Invoice_TextChanged);
            // 
            // Billing
            // 
            this.Billing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Billing.Location = new System.Drawing.Point(317, 534);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(206, 26);
            this.Billing.TabIndex = 11;
            this.Billing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Billing.TextChanged += new System.EventHandler(this.Invoice_TextChanged);
            // 
            // Total_Profits
            // 
            this.Total_Profits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Total_Profits.Location = new System.Drawing.Point(423, 604);
            this.Total_Profits.Name = "Total_Profits";
            this.Total_Profits.Size = new System.Drawing.Size(100, 26);
            this.Total_Profits.TabIndex = 12;
            this.Total_Profits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Profits.Visible = false;
            this.Total_Profits.TextChanged += new System.EventHandler(this.Invoice_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "إجمالي الأرباح";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Blue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(13, 16);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(141, 33);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "طباعة التقرير";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "المبيعات";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1279, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "المصروفات";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1287, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "المشتريات";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1290, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "من تاريخ ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(946, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "إلى تاريخ ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "تكلفة الكمية المباعة";
            // 
            // Qty_Coast
            // 
            this.Qty_Coast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Qty_Coast.Location = new System.Drawing.Point(16, 534);
            this.Qty_Coast.Name = "Qty_Coast";
            this.Qty_Coast.Size = new System.Drawing.Size(212, 26);
            this.Qty_Coast.TabIndex = 21;
            this.Qty_Coast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty_Coast.TextChanged += new System.EventHandler(this.Invoice_TextChanged);
            // 
            // txt_last_Coast
            // 
            this.txt_last_Coast.Location = new System.Drawing.Point(150, 649);
            this.txt_last_Coast.Name = "txt_last_Coast";
            this.txt_last_Coast.Size = new System.Drawing.Size(210, 26);
            this.txt_last_Coast.TabIndex = 22;
            this.txt_last_Coast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV4
            // 
            this.DGV4.AllowUserToAddRows = false;
            this.DGV4.AllowUserToDeleteRows = false;
            this.DGV4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcode});
            this.DGV4.Location = new System.Drawing.Point(12, 604);
            this.DGV4.Name = "DGV4";
            this.DGV4.ReadOnly = true;
            this.DGV4.Size = new System.Drawing.Size(116, 111);
            this.DGV4.TabIndex = 23;
            this.DGV4.Visible = false;
            // 
            // Parcode
            // 
            this.Parcode.DataPropertyName = "Parcode";
            this.Parcode.HeaderText = "Parcode";
            this.Parcode.Name = "Parcode";
            this.Parcode.ReadOnly = true;
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.DGV4);
            this.Controls.Add(this.txt_last_Coast);
            this.Controls.Add(this.Qty_Coast);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total_Profits);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.Recipt);
            this.Controls.Add(this.Invoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.DGV3);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dt_2);
            this.Controls.Add(this.dt_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Profits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_1;
        private System.Windows.Forms.DateTimePicker dt_2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridView DGV3;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Invoice;
        private System.Windows.Forms.TextBox Recipt;
        private System.Windows.Forms.TextBox Billing;
        private System.Windows.Forms.TextBox Total_Profits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT_ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_TIME_NOW;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAY_FIRST;
        private System.Windows.Forms.DataGridViewTextBoxColumn THE_REST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER_AUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_NOW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Qty_Coast;
        private System.Windows.Forms.TextBox txt_last_Coast;
        private System.Windows.Forms.DataGridView DGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcode;
    }
}