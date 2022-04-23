namespace Oryx
{
    partial class frm_crystal_pay
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystal_Viwer_Pay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.Crystal_Pay1 = new Oryx.Crystal_Pay();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1016, 486);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crystal_Viwer_Pay
            // 
            this.crystal_Viwer_Pay.ActiveViewIndex = 0;
            this.crystal_Viwer_Pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_Viwer_Pay.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_Viwer_Pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_Viwer_Pay.Location = new System.Drawing.Point(0, 0);
            this.crystal_Viwer_Pay.Name = "crystal_Viwer_Pay";
            //this.crystal_Viwer_Pay.ReportSource = this.Crystal_Pay1;
            this.crystal_Viwer_Pay.Size = new System.Drawing.Size(1016, 486);
            this.crystal_Viwer_Pay.TabIndex = 1;
            this.crystal_Viwer_Pay.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_crystal_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 486);
            this.Controls.Add(this.crystal_Viwer_Pay);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_crystal_pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_crystal_pay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private Oryx.Crystal_Pay Crystal_Pay1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_Viwer_Pay;
        //private Oryx.Crystal_Pay Crystal_Pay1;
        // private Oryx.Crystal_Pay Crystal_Pay1;
    }
}