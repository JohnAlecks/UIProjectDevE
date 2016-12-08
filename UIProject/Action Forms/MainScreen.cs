using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

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
    }
}
