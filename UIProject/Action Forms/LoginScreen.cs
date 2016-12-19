using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UIProject.Securities;
using static UIProject.Securities.Cookies;

namespace UIProject
{
    public partial class LoginScreen : SplashScreen
    {
        private List<LoginInfo> LoginTable = new List<LoginInfo>();
        public LoginScreen()
        {
            InitializeComponent();
            InitForm();
        }
        public void InitForm()
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            var sql = "SELECT User_Login_ID, Email, Password FROM LoginInformation";
            var com = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            var read = com.ExecuteReader();
            while (read.Read())
            {
                var temp = new LoginInfo();
                temp.UserLogin = read.GetInt32(0);

                temp.Email = read.GetString(1).Trim();

                temp.Password = read.GetString(2).Trim();
                LoginTable.Add(temp);
            }
            con.Close();
        }

        private bool checkRecord(string email, string box)
        {
            try
            {
                var temp = LoginTable.Find(item => item.Email == email);
                Console.Write(temp.Password);
                if (SaltPassword.VerifyHash(passwordTextBox.Text, "SHA512", temp.Password) == true)
                {
                    SessionInfo.UserID = temp.UserLogin;
                    Console.WriteLine(SessionInfo.UserID);
                    return true;
                }
                else
                {
                    return false;
                }
                ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
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
            if (checkRecord(emailTextBox.Text, passwordTextBox.Text) == true)
            {
                Close();
            }
            else
            {
                Close();
                MessageBox.Show("Incorect username or password!!!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var signUp = new SignUp();
            signUp.FormClosed += new FormClosedEventHandler(signUpFormClosed);
            signUp.ShowDialog();
        }
        private void signUpFormClosed(object sender, FormClosedEventArgs e)
        {
            InitForm();
        }
    }
}
