using System;
using System.Collections.Generic;
using DevExpress.XtraSplashScreen;

namespace UIProject
{
    public partial class LoginScreen : SplashScreen
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public void setLable(String lable)
        {
            Lable.Text = lable;
        }


        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }
        public enum SplashScreenCommand
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
