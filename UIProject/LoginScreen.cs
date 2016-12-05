using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace UIProject
{
    public partial class LoginScreen : SplashScreen
    {
        public LoginScreen()
        {
            InitializeComponent();
        }



        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }



        public enum SplashScreenCommand
        {
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void marqueeProgressBarControl1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
