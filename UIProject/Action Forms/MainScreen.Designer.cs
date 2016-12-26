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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIProject));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fuck Police",
            "Fuck Police",
            "Fuck CS"}, -1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Page1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SystemPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DatabasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caseListView = new System.Windows.Forms.ListView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.officerDataGridView = new System.Windows.Forms.DataGridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.criminalGridView = new System.Windows.Forms.DataGridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.caseDataGridView = new System.Windows.Forms.DataGridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officerDataGridView)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGridView)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
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
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.Controller = this.barAndDockingController1;
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
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
            // SystemPageGroup
            // 
            this.SystemPageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("SystemPageGroup.Glyph")));
            this.SystemPageGroup.ItemLinks.Add(this.HelpButtonItem);
            this.SystemPageGroup.ItemLinks.Add(this.ExitButtonItem);
            this.SystemPageGroup.Name = "SystemPageGroup";
            this.SystemPageGroup.Text = "System";
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
            // DatabasePageGroup
            // 
            this.DatabasePageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("DatabasePageGroup.Glyph")));
            this.DatabasePageGroup.ItemLinks.Add(this.ConnectDatabaseButtonItem);
            this.DatabasePageGroup.ItemLinks.Add(this.RefreshDatabaseButtonItem);
            this.DatabasePageGroup.ItemLinks.Add(this.DisconnectDatabaseButtonItem);
            this.DatabasePageGroup.Name = "DatabasePageGroup";
            this.DatabasePageGroup.Text = "Database";
            // 
            // CasePageGroup
            // 
            this.CasePageGroup.ItemLinks.Add(this.AddButtonItem);
            this.CasePageGroup.ItemLinks.Add(this.EditButtonItem);
            this.CasePageGroup.ItemLinks.Add(this.DeleteButtonIteem);
            this.CasePageGroup.Name = "CasePageGroup";
            this.CasePageGroup.Text = "Case";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dashboard";
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.Page1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1442, 253);
            this.ribbonControl1.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbonControl1_SelectedPageChanging);
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            this.ribbonControl1.MinimizedChanged += new System.EventHandler(this.ribbonControl1_MinimizedChanged);
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
            // caseListView
            // 
            this.caseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.dateColumn,
            this.statusColumn});
            this.caseListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.caseListView.Location = new System.Drawing.Point(676, 290);
            this.caseListView.Margin = new System.Windows.Forms.Padding(6);
            this.caseListView.Name = "caseListView";
            this.caseListView.Size = new System.Drawing.Size(1590, 681);
            this.caseListView.TabIndex = 1;
            this.caseListView.UseCompatibleStateImageBehavior = false;
            this.caseListView.View = System.Windows.Forms.View.Details;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.officerDataGridView);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1430, 602);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // officerDataGridView
            // 
            this.officerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.officerDataGridView.Name = "officerDataGridView";
            this.officerDataGridView.RowTemplate.Height = 33;
            this.officerDataGridView.Size = new System.Drawing.Size(1430, 602);
            this.officerDataGridView.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.criminalGridView);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1430, 602);
            this.xtraTabPage3.Text = "xtraTabPage3";
            // 
            // criminalGridView
            // 
            this.criminalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criminalGridView.Location = new System.Drawing.Point(0, 0);
            this.criminalGridView.Name = "criminalGridView";
            this.criminalGridView.RowTemplate.Height = 33;
            this.criminalGridView.Size = new System.Drawing.Size(1430, 602);
            this.criminalGridView.TabIndex = 0;
            this.criminalGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.criminalGridView_CellContentClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.caseDataGridView);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1430, 602);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // caseDataGridView
            // 
            this.caseDataGridView.AllowUserToOrderColumns = true;
            this.caseDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.caseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.caseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.caseDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.caseDataGridView.Name = "caseDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.875F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.caseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.caseDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.caseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.caseDataGridView.Size = new System.Drawing.Size(1430, 602);
            this.caseDataGridView.TabIndex = 2;
            this.caseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caseDataGridView_CellDoubleClick);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1430, 602);
            this.xtraTabPage1.Text = "xtraTabPage1";
            this.xtraTabPage1.DoubleClick += new System.EventHandler(this.xtraTabPage1_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 253);
            this.xtraTabControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1442, 655);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // UIProject
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 908);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.caseListView);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "UIProject";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI Project";
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officerDataGridView)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.criminalGridView)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.DataGridView caseDataGridView;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.DataGridView criminalGridView;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.DataGridView officerDataGridView;
        private System.Windows.Forms.ListView caseListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Page1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CasePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DatabasePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SystemPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
    }
}
