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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Page1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.CasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DatabasePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AddButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteButtonIteem = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.RefreshDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DisconnectDatabaseButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangeUserButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePasswordButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LogoutButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SystemPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ExitButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HelpButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
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
            this.Page1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(795, 130);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
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
            // AddButtonItem
            // 
            this.AddButtonItem.Caption = "Add";
            this.AddButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.AddButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("AddButtonItem.Glyph")));
            this.AddButtonItem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("AddButtonItem.GlyphDisabled")));
            this.AddButtonItem.Id = 1;
            this.AddButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("AddButtonItem.LargeGlyph")));
            this.AddButtonItem.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("AddButtonItem.LargeGlyphDisabled")));
            this.AddButtonItem.Name = "AddButtonItem";
            // 
            // EditButtonItem
            // 
            this.EditButtonItem.Caption = "Edit";
            this.EditButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.EditButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.Glyph")));
            this.EditButtonItem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.GlyphDisabled")));
            this.EditButtonItem.Id = 2;
            this.EditButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.LargeGlyph")));
            this.EditButtonItem.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("EditButtonItem.LargeGlyphDisabled")));
            this.EditButtonItem.Name = "EditButtonItem";
            // 
            // DeleteButtonIteem
            // 
            this.DeleteButtonIteem.Caption = "Delete";
            this.DeleteButtonIteem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DeleteButtonIteem.Glyph = ((System.Drawing.Image)(resources.GetObject("DeleteButtonIteem.Glyph")));
            this.DeleteButtonIteem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("DeleteButtonIteem.GlyphDisabled")));
            this.DeleteButtonIteem.Id = 3;
            this.DeleteButtonIteem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DeleteButtonIteem.LargeGlyph")));
            this.DeleteButtonIteem.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("DeleteButtonIteem.LargeGlyphDisabled")));
            this.DeleteButtonIteem.Name = "DeleteButtonIteem";
            // 
            // ConnectDatabaseButtonItem
            // 
            this.ConnectDatabaseButtonItem.Caption = "Connect Database";
            this.ConnectDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ConnectDatabaseButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ConnectDatabaseButtonItem.Glyph")));
            this.ConnectDatabaseButtonItem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("ConnectDatabaseButtonItem.GlyphDisabled")));
            this.ConnectDatabaseButtonItem.Id = 4;
            this.ConnectDatabaseButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ConnectDatabaseButtonItem.LargeGlyph")));
            this.ConnectDatabaseButtonItem.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("ConnectDatabaseButtonItem.LargeGlyphDisabled")));
            this.ConnectDatabaseButtonItem.Name = "ConnectDatabaseButtonItem";
            // 
            // RefreshDatabaseButtonItem
            // 
            this.RefreshDatabaseButtonItem.Caption = "Refresh Database";
            this.RefreshDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.RefreshDatabaseButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("RefreshDatabaseButtonItem.Glyph")));
            this.RefreshDatabaseButtonItem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("RefreshDatabaseButtonItem.GlyphDisabled")));
            this.RefreshDatabaseButtonItem.Id = 5;
            this.RefreshDatabaseButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("RefreshDatabaseButtonItem.LargeGlyph")));
            this.RefreshDatabaseButtonItem.Name = "RefreshDatabaseButtonItem";
            // 
            // DisconnectDatabaseButtonItem
            // 
            this.DisconnectDatabaseButtonItem.Caption = "Disconnect Database";
            this.DisconnectDatabaseButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.DisconnectDatabaseButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("DisconnectDatabaseButtonItem.Glyph")));
            this.DisconnectDatabaseButtonItem.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("DisconnectDatabaseButtonItem.GlyphDisabled")));
            this.DisconnectDatabaseButtonItem.Id = 6;
            this.DisconnectDatabaseButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("DisconnectDatabaseButtonItem.LargeGlyph")));
            this.DisconnectDatabaseButtonItem.LargeGlyphDisabled = ((System.Drawing.Image)(resources.GetObject("DisconnectDatabaseButtonItem.LargeGlyphDisabled")));
            this.DisconnectDatabaseButtonItem.Name = "DisconnectDatabaseButtonItem";
            // 
            // ChangeUserButtonItem
            // 
            this.ChangeUserButtonItem.Caption = "Change User";
            this.ChangeUserButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ChangeUserButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ChangeUserButtonItem.Glyph")));
            this.ChangeUserButtonItem.Id = 7;
            this.ChangeUserButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ChangeUserButtonItem.LargeGlyph")));
            this.ChangeUserButtonItem.Name = "ChangeUserButtonItem";
            // 
            // ChangePasswordButtonItem
            // 
            this.ChangePasswordButtonItem.Caption = "Change Password";
            this.ChangePasswordButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ChangePasswordButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButtonItem.Glyph")));
            this.ChangePasswordButtonItem.Id = 8;
            this.ChangePasswordButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButtonItem.LargeGlyph")));
            this.ChangePasswordButtonItem.Name = "ChangePasswordButtonItem";
            // 
            // LogoutButtonItem
            // 
            this.LogoutButtonItem.Caption = "Log Out";
            this.LogoutButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.LogoutButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("LogoutButtonItem.Glyph")));
            this.LogoutButtonItem.Id = 9;
            this.LogoutButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("LogoutButtonItem.LargeGlyph")));
            this.LogoutButtonItem.Name = "LogoutButtonItem";
            // 
            // SystemPageGroup
            // 
            this.SystemPageGroup.Glyph = ((System.Drawing.Image)(resources.GetObject("SystemPageGroup.Glyph")));
            this.SystemPageGroup.ItemLinks.Add(this.HelpButtonItem);
            this.SystemPageGroup.ItemLinks.Add(this.ExitButtonItem);
            this.SystemPageGroup.Name = "SystemPageGroup";
            this.SystemPageGroup.Text = "System";
            // 
            // ExitButtonItem
            // 
            this.ExitButtonItem.Caption = "Exit";
            this.ExitButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.ExitButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ExitButtonItem.Glyph")));
            this.ExitButtonItem.Id = 10;
            this.ExitButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ExitButtonItem.LargeGlyph")));
            this.ExitButtonItem.Name = "ExitButtonItem";
            this.ExitButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitButtonItem_ItemClick);
            // 
            // HelpButtonItem
            // 
            this.HelpButtonItem.Caption = "Help";
            this.HelpButtonItem.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.HelpButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("HelpButtonItem.Glyph")));
            this.HelpButtonItem.Id = 11;
            this.HelpButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("HelpButtonItem.LargeGlyph")));
            this.HelpButtonItem.Name = "HelpButtonItem";
            // 
            // UIProject
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UIProject";
            this.Ribbon = this.ribbonControl1;
            this.Text = "UI Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
    }
}

