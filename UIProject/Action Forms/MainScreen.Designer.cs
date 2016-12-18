namespace UIProject
{
    partial class UIProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIProject));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fuck Police",
            "Fuck Police",
            "Fuck CS"}, -1);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.AddButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteButtonIteem = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DisconnectDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangeUserButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePasswordButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LogoutButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExitButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HelpButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Page1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.CasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DatabasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SystemPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.caseListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.caseDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.barAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.AddButtonItem,
            this.EditButtonItem,
            this.DeleteButtonIteem,
            this.ConnectDatabaseButtonItem,
            this.RefreshDatabaseButtonItem,
            this.DisconnectDatabaseButtonItem,
            this.ChangeUserButtonItem,
            this.ChangePasswordButtonItem,
            this.LogoutButtonItem,
            this.ExitButtonItem,
            this.HelpButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.Page1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(721, 130);
            this.ribbonControl1.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbonControl1_SelectedPageChanging);
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            this.ribbonControl1.MinimizedChanged += new System.EventHandler(this.ribbonControl1_MinimizedChanged);
            // 
            // AddButtonItem
            // 
            this.AddButtonItem.Caption = "Add";
            this.AddButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AddButtonItem.Id = 1;
            this.AddButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.add_ic;
            this.AddButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.add_ic;
            this.AddButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.add_ic;
            this.AddButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.add_ic;
            this.AddButtonItem.Name = "AddButtonItem";
            this.AddButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddButtonItem_ItemClick);
            // 
            // EditButtonItem
            // 
            this.EditButtonItem.Caption = "Edit";
            this.EditButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.EditButtonItem.Id = 2;
            this.EditButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.edit_ic;
            this.EditButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.edit_ic;
            this.EditButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.edit_ic;
            this.EditButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.edit_ic;
            this.EditButtonItem.Name = "EditButtonItem";
            this.EditButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditButtonItem_ItemClick);
            // 
            // DeleteButtonIteem
            // 
            this.DeleteButtonIteem.Caption = "Delete";
            this.DeleteButtonIteem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DeleteButtonIteem.Id = 3;
            this.DeleteButtonIteem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.delete_ic;
            this.DeleteButtonIteem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.delete_ic;
            this.DeleteButtonIteem.ImageOptions.Image = global::UIProject.Properties.Resources.delete_ic;
            this.DeleteButtonIteem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.delete_ic;
            this.DeleteButtonIteem.Name = "DeleteButtonIteem";
            this.DeleteButtonIteem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonIteem_ItemClick);
            // 
            // ConnectDatabaseButtonItem
            // 
            this.ConnectDatabaseButtonItem.Caption = "Connect Database";
            this.ConnectDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ConnectDatabaseButtonItem.Id = 4;
            this.ConnectDatabaseButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.adddb_ic;
            this.ConnectDatabaseButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.adddb_ic;
            this.ConnectDatabaseButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.adddb_ic;
            this.ConnectDatabaseButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.adddb_ic;
            this.ConnectDatabaseButtonItem.Name = "ConnectDatabaseButtonItem";
            this.ConnectDatabaseButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ConnectDatabaseButtonItem_ItemClick);
            // 
            // RefreshDatabaseButtonItem
            // 
            this.RefreshDatabaseButtonItem.Caption = "Refresh Database";
            this.RefreshDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.RefreshDatabaseButtonItem.Id = 5;
            this.RefreshDatabaseButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.refresh_ic;
            this.RefreshDatabaseButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.refresh_ic;
            this.RefreshDatabaseButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.refresh_ic;
            this.RefreshDatabaseButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.refresh_ic;
            this.RefreshDatabaseButtonItem.Name = "RefreshDatabaseButtonItem";
            this.RefreshDatabaseButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshDatabaseButtonItem_ItemClick);
            // 
            // DisconnectDatabaseButtonItem
            // 
            this.DisconnectDatabaseButtonItem.Caption = "Disconnect Database";
            this.DisconnectDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DisconnectDatabaseButtonItem.Id = 6;
            this.DisconnectDatabaseButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.removedb_ic;
            this.DisconnectDatabaseButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.removedb_ic;
            this.DisconnectDatabaseButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.removedb_ic;
            this.DisconnectDatabaseButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.removedb_ic;
            this.DisconnectDatabaseButtonItem.Name = "DisconnectDatabaseButtonItem";
            this.DisconnectDatabaseButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DisconnectDatabaseButtonItem_ItemClick);
            // 
            // ChangeUserButtonItem
            // 
            this.ChangeUserButtonItem.Caption = "Change User";
            this.ChangeUserButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ChangeUserButtonItem.Id = 7;
            this.ChangeUserButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.switchUser_ic;
            this.ChangeUserButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.switchUser_ic;
            this.ChangeUserButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.switchUser_ic;
            this.ChangeUserButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.switchUser_ic;
            this.ChangeUserButtonItem.Name = "ChangeUserButtonItem";
            this.ChangeUserButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangeUserButtonItem_ItemClick);
            // 
            // ChangePasswordButtonItem
            // 
            this.ChangePasswordButtonItem.Caption = "Change Password";
            this.ChangePasswordButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ChangePasswordButtonItem.Id = 8;
            this.ChangePasswordButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.changePassword_ic;
            this.ChangePasswordButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.changePassword_ic;
            this.ChangePasswordButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.changePassword_ic;
            this.ChangePasswordButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.changePassword_ic;
            this.ChangePasswordButtonItem.Name = "ChangePasswordButtonItem";
            this.ChangePasswordButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangePasswordButtonItem_ItemClick);
            // 
            // LogoutButtonItem
            // 
            this.LogoutButtonItem.Caption = "Log Out";
            this.LogoutButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.LogoutButtonItem.Id = 9;
            this.LogoutButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.logout_ic;
            this.LogoutButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.logout_ic;
            this.LogoutButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.logout_ic;
            this.LogoutButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.logout_ic;
            this.LogoutButtonItem.Name = "LogoutButtonItem";
            this.LogoutButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LogoutButtonItem_ItemClick);
            // 
            // ExitButtonItem
            // 
            this.ExitButtonItem.Caption = "Exit";
            this.ExitButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ExitButtonItem.Id = 10;
            this.ExitButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.exit_ic;
            this.ExitButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.exit_ic;
            this.ExitButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.exit_ic;
            this.ExitButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.exit_ic;
            this.ExitButtonItem.Name = "ExitButtonItem";
            this.ExitButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitButtonItem_ItemClick);
            // 
            // HelpButtonItem
            // 
            this.HelpButtonItem.Caption = "Help";
            this.HelpButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.HelpButtonItem.Id = 11;
            this.HelpButtonItem.ImageOptions.DisabledImage = global::UIProject.Properties.Resources.help_ic;
            this.HelpButtonItem.ImageOptions.DisabledLargeImage = global::UIProject.Properties.Resources.help_ic;
            this.HelpButtonItem.ImageOptions.Image = global::UIProject.Properties.Resources.help_ic;
            this.HelpButtonItem.ImageOptions.LargeImage = global::UIProject.Properties.Resources.help_ic;
            this.HelpButtonItem.Name = "HelpButtonItem";
            this.HelpButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HelpButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dashboard";
            // 
            // Page1
            // 
            this.Page1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.CasePageGroup,
            this.DatabasePageGroup,
            this.UserPageGroup,
            this.SystemPageGroup});
            this.Page1.Name = "Page1";
            this.Page1.Text = "Main Menu";
            // 
            // CasePageGroup
            // 
            this.CasePageGroup.ItemLinks.Add(this.AddButtonItem);
            this.CasePageGroup.ItemLinks.Add(this.EditButtonItem);
            this.CasePageGroup.ItemLinks.Add(this.DeleteButtonIteem);
            this.CasePageGroup.Name = "CasePageGroup";
            this.CasePageGroup.Text = "Case";
            // 
            // DatabasePageGroup
            // 
            this.DatabasePageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("DatabasePageGroup.Glyph")));
            this.DatabasePageGroup.ItemLinks.Add(this.ConnectDatabaseButtonItem);
            this.DatabasePageGroup.ItemLinks.Add(this.RefreshDatabaseButtonItem);
            this.DatabasePageGroup.ItemLinks.Add(this.DisconnectDatabaseButtonItem);
            this.DatabasePageGroup.Name = "DatabasePageGroup";
            this.DatabasePageGroup.Text = "Database";
            // 
            // UserPageGroup
            // 
            this.UserPageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("UserPageGroup.Glyph")));
            this.UserPageGroup.ItemLinks.Add(this.ChangeUserButtonItem);
            this.UserPageGroup.ItemLinks.Add(this.ChangePasswordButtonItem);
            this.UserPageGroup.ItemLinks.Add(this.LogoutButtonItem);
            this.UserPageGroup.Name = "UserPageGroup";
            this.UserPageGroup.Text = "User";
            // 
            // SystemPageGroup
            // 
            this.SystemPageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("SystemPageGroup.Glyph")));
            this.SystemPageGroup.ItemLinks.Add(this.HelpButtonItem);
            this.SystemPageGroup.ItemLinks.Add(this.ExitButtonItem);
            this.SystemPageGroup.Name = "SystemPageGroup";
            this.SystemPageGroup.Text = "System";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            this.ribbonPage2.Visible = false;
            // 
            // caseListView
            // 
            this.caseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.dateColumn,
            this.statusColumn});
            this.caseListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.caseListView.Location = new System.Drawing.Point(338, 151);
            this.caseListView.Name = "caseListView";
            this.caseListView.Size = new System.Drawing.Size(797, 356);
            this.caseListView.TabIndex = 1;
            this.caseListView.UseCompatibleStateImageBehavior = false;
            this.caseListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 142;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Date";
            this.dateColumn.Width = 89;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 104;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 130);
            this.xtraTabControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(721, 342);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(715, 314);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.caseDataGridView);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(715, 314);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.Controller = this.barAndDockingController1;
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // caseDataGridView
            // 
            this.caseDataGridView.AllowUserToAddRows = false;
            this.caseDataGridView.AllowUserToDeleteRows = false;
            this.caseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.caseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.caseDataGridView.Name = "caseDataGridView";
            this.caseDataGridView.ReadOnly = true;
            this.caseDataGridView.RowHeadersVisible = false;
            this.caseDataGridView.Size = new System.Drawing.Size(715, 314);
            this.caseDataGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Case ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UIProject
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 472);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.caseListView);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "UIProject";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI Project";
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Page1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CasePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DatabasePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserPageGroup;
        private DevExpress.XtraBars.BarButtonItem AddButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditButtonItem;
        private DevExpress.XtraBars.BarButtonItem DeleteButtonIteem;
        private DevExpress.XtraBars.BarButtonItem ConnectDatabaseButtonItem;
        private DevExpress.XtraBars.BarButtonItem RefreshDatabaseButtonItem;
        private DevExpress.XtraBars.BarButtonItem DisconnectDatabaseButtonItem;
        private DevExpress.XtraBars.BarButtonItem ChangeUserButtonItem;
        private DevExpress.XtraBars.BarButtonItem ChangePasswordButtonItem;
        private DevExpress.XtraBars.BarButtonItem LogoutButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExitButtonItem;
        private DevExpress.XtraBars.BarButtonItem HelpButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SystemPageGroup;
        private System.Windows.Forms.ListView caseListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private System.Windows.Forms.DataGridView caseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
