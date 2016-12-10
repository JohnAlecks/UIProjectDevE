using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIProject.Securities;
using static UIProject.Securities.Cookies;

namespace UIProject
{
    public partial class LoginScreen : SplashScreen
    {
        List<LoginInfo> LoginTable = new List<LoginInfo>();
        public LoginScreen()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {

            String appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);

            string sql = "SELECT User_Login_ID, Email, Password FROM LoginInformation";
            SqlCommand com = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                LoginInfo temp = new LoginInfo();
                temp.UserLogin = read.GetInt32(0);
                Console.WriteLine(temp.UserLogin);
                temp.Email = read.GetString(1).Trim();
                Console.WriteLine(temp.Email);
                temp.Password = read.GetString(2).Trim();
                LoginTable.Add(temp);
            }
            con.Close();
        }

        private bool checkRecord(string email, string box)
        {
            try
            {
                LoginInfo temp = LoginTable.Find(item => item.Email == email);
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
                };


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
                MessageBox.Show("Login Completed");
                Close();
            }
            else
            {
                MessageBox.Show("Incorect username or password!!!");
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void emailTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
