namespace Oryx
{
    partial class frm_Profits_Report
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
            this.crystalViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalViewer1
            // 
            this.crystalViewer1.ActiveViewIndex = -1;
            this.crystalViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalViewer1.Name = "crystalViewer1";
            this.crystalViewer1.Size = new System.Drawing.Size(1021, 488);
            this.crystalViewer1.TabIndex = 0;
            this.crystalViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Profits_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 488);
            this.Controls.Add(this.crystalViewer1);
            this.Name = "frm_Profits_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Profits_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewer1;
       // private Oryx.Crystal_Profits Crystal_Profits1;
    }
}