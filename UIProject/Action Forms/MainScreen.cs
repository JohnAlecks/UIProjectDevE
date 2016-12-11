﻿using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Ribbon;

using System.Drawing;
using UIProject.RibbonForm;

namespace UIProject
{
    public partial class UIProject : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int ctr = 1;
        DevExpress.XtraTab.XtraTabControl tabCtrl = new DevExpress.XtraTab.XtraTabControl();
        public UIProject()
        {
            InitializeComponent();
            var log = new LoginScreen();
            log.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Form;
            log.ShowDialog();
            //dashboardDesigner1.CreateRibbon();
            InitDatabaseDashboard();
            InitializeRibbonControl();
        }
        private void InitializeRibbonControl() {
            RibbonPage group1 = new RibbonPage("Test Group");
            ribbonControl1.Pages.Add(group1);
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            Dashboard form = new Dashboard();
            form.Dock = DockStyle.Fill;
            //form.TopLevel = false;
            xtraTabPage1.Controls.Add(form);
            //form.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void ExitButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void AddButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ac = new AddCase();
            ac.ShowDialog();
        }

        private void EditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mc = new ModifyCase();
            mc.ShowDialog();
        }

        private void DeleteButtonIteem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this case ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
            }
        }
        public static void ShowLoading(Form ParentForm, String Caption)
        {
            SplashScreenManager.ShowForm(ParentForm, typeof(LoadingScreen), true, true, false, true);
            SplashScreenManager.Default.SetWaitFormCaption(Caption);
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            SplashScreenManager.Default.SetWaitFormCaption("Complete");
            System.Threading.Thread.Sleep(800);
            SplashScreenManager.CloseForm();
        }
        private void RefreshDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Reloading Database...");
        }

        private void DisconnectDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Disconnecting...");
        }

        private void LogoutButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Logging Out...");
            Hide();
            var lgs = new LoginScreen();
            lgs.ShowDialog();
            Application.DoEvents();
        }

        private void ChangeUserButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lgs = new LoginScreen();
            lgs.setLable("Change User");
            lgs.ShowDialog();
        }

        private void ChangePasswordButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cp = new ChangePassword();
            cp.ShowDialog();
        }

        private void ConnectDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Connecting...");
        }

        private void HelpButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Contact your IT supporter for futher infomation.", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void caseListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitDatabaseDashboard() {
            
        }

        private void dashboardDesigner1_Load_1(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            //Ribbon.SelectedPage = ribbonControl1.Pages[0];
           
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            RibbonControl ribbon = sender as RibbonControl;
            for (int i = 0; i < ribbonControl1.Pages.Count; i++) {
                if (ribbon.SelectedPage == ribbonControl1.Pages[i])
                {
                    
                    xtraTabControl1.SelectedTabPageIndex = i;
                    
                }
            
            }
        }

        private void UIProject_MdiChildActivate(object sender, EventArgs e)
        {

        }

        
    }
}