namespace UIProject.RibbonForm
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardDesigner1
            // 
            this.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner1.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.dashboardDesigner1.Name = "dashboardDesigner1";
            this.dashboardDesigner1.Size = new System.Drawing.Size(1236, 700);
            this.dashboardDesigner1.TabIndex = 0;
            this.dashboardDesigner1.Load += new System.EventHandler(this.dashboardDesigner1_Load);
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Location = new System.Drawing.Point(792, 0);
            this.dashboardViewer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(444, 700);
            this.dashboardViewer1.TabIndex = 1;
            this.dashboardViewer1.Load += new System.EventHandler(this.dashboardViewer1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardViewer1);
            this.Controls.Add(this.dashboardDesigner1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1236, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
    }
}
