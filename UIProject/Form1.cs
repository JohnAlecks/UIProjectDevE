using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace UIProject
{
    public partial class UIProject : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UIProject()
        {
            InitializeComponent();
            LoginScreen log = new LoginScreen();
            log.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Form;
            log.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
