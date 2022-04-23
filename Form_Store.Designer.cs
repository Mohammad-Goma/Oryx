namespace Oryx
{
    partial class Form_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Store));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INITIAL_COAST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LESS_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIPPING_COAST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINISH_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_STORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETAILS_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETAILS_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETAILS_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.First_price = new System.Windows.Forms.TextBox();
            this.Secound_price = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARCODE,
            this.PRODUCT_NAME,
            this.UNIT,
            this.CURRENCY,
            this.INITIAL_COAST,
            this.LESS_PRICE,
            this.PRICE,
            this.SHIPPING_COAST,
            this.CUSTOMS,
            this.FINISH_PRICE,
            this.QTY,
            this.ID_STORE,
            this.DETAILS_1,
            this.DETAILS_2,
            this.DETAILS_3,
            this.ID});
            this.DGV.Location = new System.Drawing.Point(3, 91);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1225, 532);
            this.DGV.TabIndex = 0;
            // 
            // PARCODE
            // 
            this.PARCODE.DataPropertyName = "PARCODE";
            this.PARCODE.HeaderText = "الباركود";
            this.PARCODE.Name = "PARCODE";
            this.PARCODE.ReadOnly = true;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "أسم الصنف";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Width = 150;
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "الوحدة";
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            // 
            // CURRENCY
            // 
            this.CURRENCY.DataPropertyName = "CURRENCY";
            this.CURRENCY.HeaderText = "العملة";
            this.CURRENCY.Name = "CURRENCY";
            this.CURRENCY.ReadOnly = true;
            // 
            // INITIAL_COAST
            // 
            this.INITIAL_COAST.DataPropertyName = "INITIAL_COAST";
            this.INITIAL_COAST.HeaderText = "التكلفة الأولية";
            this.INITIAL_COAST.Name = "INITIAL_COAST";
            this.INITIAL_COAST.ReadOnly = true;
            this.INITIAL_COAST.Width = 120;
            // 
            // LESS_PRICE
            // 
            this.LESS_PRICE.DataPropertyName = "LESS_PRICE";
            this.LESS_PRICE.HeaderText = "أقل سعر";
            this.LESS_PRICE.Name = "LESS_PRICE";
            this.LESS_PRICE.ReadOnly = true;
            this.LESS_PRICE.Width = 80;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "سعر البيع";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 80;
            // 
            // SHIPPING_COAST
            // 
            this.SHIPPING_COAST.DataPropertyName = "SHIPPING_COAST";
            this.SHIPPING_COAST.HeaderText = "تكلفة الشحن";
            this.SHIPPING_COAST.Name = "SHIPPING_COAST";
            this.SHIPPING_COAST.ReadOnly = true;
            this.SHIPPING_COAST.Width = 90;
            // 
            // CUSTOMS
            // 
            this.CUSTOMS.DataPropertyName = "CUSTOMS";
            this.CUSTOMS.HeaderText = "الجمارك";
            this.CUSTOMS.Name = "CUSTOMS";
            this.CUSTOMS.ReadOnly = true;
            this.CUSTOMS.Width = 80;
            // 
            // FINISH_PRICE
            // 
            this.FINISH_PRICE.DataPropertyName = "FINISH_PRICE";
            this.FINISH_PRICE.HeaderText = "التكلفة النهائية";
            this.FINISH_PRICE.Name = "FINISH_PRICE";
            this.FINISH_PRICE.ReadOnly = true;
            this.FINISH_PRICE.Width = 110;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "الكمية";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 70;
            // 
            // ID_STORE
            // 
            this.ID_STORE.HeaderText = "ID_STORE";
            this.ID_STORE.Name = "ID_STORE";
            this.ID_STORE.ReadOnly = true;
            this.ID_STORE.Visible = false;
            // 
            // DETAILS_1
            // 
            this.DETAILS_1.DataPropertyName = "DETAILS_1";
            this.DETAILS_1.HeaderText = "نثريات";
            this.DETAILS_1.Name = "DETAILS_1";
            this.DETAILS_1.ReadOnly = true;
            // 
            // DETAILS_2
            // 
            this.DETAILS_2.HeaderText = "DETAILS_2";
            this.DETAILS_2.Name = "DETAILS_2";
            this.DETAILS_2.ReadOnly = true;
            this.DETAILS_2.Visible = false;
            // 
            // DETAILS_3
            // 
            this.DETAILS_3.HeaderText = "DETAILS_3";
            this.DETAILS_3.Name = "DETAILS_3";
            this.DETAILS_3.ReadOnly = true;
            this.DETAILS_3.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.First_price);
            this.groupBox1.Controls.Add(this.Secound_price);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 743);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Location = new System.Drawing.Point(9, 28);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(115, 39);
            this.btn_print.TabIndex = 10;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "مجموع سعر البيع ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "التكلفة النهائية للمنتجات";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1019, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "عدد المنتجات المتبقية";
            // 
            // First_price
            // 
            this.First_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.First_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_price.Location = new System.Drawing.Point(527, 675);
            this.First_price.Name = "First_price";
            this.First_price.Size = new System.Drawing.Size(239, 26);
            this.First_price.TabIndex = 6;
            // 
            // Secound_price
            // 
            this.Secound_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Secound_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secound_price.Location = new System.Drawing.Point(87, 675);
            this.Secound_price.Name = "Secound_price";
            this.Secound_price.Size = new System.Drawing.Size(235, 26);
            this.Secound_price.TabIndex = 5;
            // 
            // Amount
            // 
            this.Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(971, 675);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(235, 26);
            this.Amount.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(159, 28);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(105, 39);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "تنشيط";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(935, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_search.Size = new System.Drawing.Size(285, 26);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Blue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(752, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 39);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1235, 749);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Store";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخزن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox First_price;
        private System.Windows.Forms.TextBox Secound_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn INITIAL_COAST;
        private System.Windows.Forms.DataGridViewTextBoxColumn LESS_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPPING_COAST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINISH_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_STORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETAILS_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETAILS_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETAILS_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}