using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Ribbon;
using UIProject.RibbonForm;
using UIProject.Action_Forms;

namespace UIProject
{
    public partial class UIProject : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public UIProject()
        {
            InitializeComponent();
            var log = new LoginScreen();
            log.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Form;
            log.ShowDialog();
            ribbonControl1.Minimized = true;
            InitializeRibbonControl();
        }
        private void InitializeRibbonControl()
        {
            var group1 = new RibbonPage("Test Group");
            ribbonControl1.Pages.Add(group1);
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            var form = new Dashboard();
            form.Dock = DockStyle.Fill;
            xtraTabPage1.Controls.Add(form);
        }

        private void ExitButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void AddButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ac = new Crime();
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



        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            var ribbon = sender as RibbonControl;           
            for (var i = 0; i < ribbonControl1.Pages.Count; i++)
            {
               
                if (ribbon.SelectedPage == ribbonControl1.Pages[i])
                {
                    xtraTabControl1.SelectedTabPageIndex = i;
                   
                }
            }
        }

<<<<<<< HEAD


        private void UIProject_MdiChildActivate(object sender, EventArgs e)
=======
        private void RibbonControl1_MouseClick(object sender, MouseEventArgs e)
>>>>>>> 0ede2be48dfde9f4e702c42cb3013855d9ac008b
        {
            throw new NotImplementedException();
        }

        private void ribbonControl1_MinimizedChanged(object sender, EventArgs e)
        {
            
        }

        private void ribbonControl1_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {
            
            var ribbon = sender as RibbonControl;
            
            Console.Write(ribbon.SelectedPage.ToString());
            if (ribbon.SelectedPage == ribbonControl1.Pages[1])
            {
                this.Update();
                ribbon.Minimized = true;
                Application.DoEvents();
            }
            else
            {
                this.Update();
                ribbon.Minimized = false;
                Application.DoEvents();
            }
        }
    }
}
