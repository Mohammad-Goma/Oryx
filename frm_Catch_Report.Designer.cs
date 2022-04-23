namespace Oryx
{
    partial class frm_Catch_Report
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
            this.crystalViewerCatch = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalViewerCatch
            // 
            this.crystalViewerCatch.ActiveViewIndex = -1;
            this.crystalViewerCatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewerCatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewerCatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalViewerCatch.Location = new System.Drawing.Point(0, 0);
            this.crystalViewerCatch.Name = "crystalViewerCatch";
            this.crystalViewerCatch.Size = new System.Drawing.Size(1020, 499);
            this.crystalViewerCatch.TabIndex = 0;
            this.crystalViewerCatch.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Catch_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 499);
            this.Controls.Add(this.crystalViewerCatch);
            this.Name = "frm_Catch_Report";
            this.Text = "frm_Catch_Report";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewerCatch;
    }
}