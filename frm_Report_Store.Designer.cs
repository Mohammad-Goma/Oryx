namespace Oryx
{
    partial class frm_Report_Store
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
            this.crystalViewerStore = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalViewerStore
            // 
            this.crystalViewerStore.ActiveViewIndex = -1;
            this.crystalViewerStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewerStore.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewerStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalViewerStore.Location = new System.Drawing.Point(0, 0);
            this.crystalViewerStore.Name = "crystalViewerStore";
            this.crystalViewerStore.Size = new System.Drawing.Size(1016, 525);
            this.crystalViewerStore.TabIndex = 0;
            this.crystalViewerStore.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Report_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 525);
            this.Controls.Add(this.crystalViewerStore);
            this.Name = "frm_Report_Store";
            this.Text = "frm_Report_Store";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewerStore;
    }
}