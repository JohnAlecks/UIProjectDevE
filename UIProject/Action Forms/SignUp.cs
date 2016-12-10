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

namespace UIProject
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        public SignUp()
        {
            InitializeComponent();
            getData();
        }
        int id;
        private void getData()
        {

            String appPath = Application.StartupPath;
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "SELECT FROM Department ";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
                UserInfo temp = new UserInfo();
                temp.Fullname = read.GetString(1).Trim();
                temp.Address = read.GetString(2).Trim();
                //comboBox1.Items.Add(temp.Fullname);
                //id = temp.UserInfoID = read.GetInt32(0);

            }
            con.Close();

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            String appPath = Application.StartupPath;
            Console.WriteLine(appPath);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "INSERT INTO UserInformations (Fullname, Address, Phone) VALUES (@fullname, @address, @phone) SELECT @user_id = SCOPE_IDENTITY(); INSERT INTO LoginInformation(User_Login_ID, Email, Password) VALUES (@user_id, @email , @password)";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@fullname", SqlDbType.VarChar, 38).Value = firstNameTextBox.Text;
            command.Parameters.Add("@address", SqlDbType.VarChar, 38).Value = "528 Pham Van Hai";
            command.Parameters.Add("@phone", SqlDbType.VarChar, 38).Value = "";
            command.Parameters.Add("@email", SqlDbType.VarChar, 38).Value = emailTextBox.Text;
            string ePass = SaltPassword.ComputeHash(passwordTextBox.Text, "SHA512", null);
            //Console.WriteLine(ePass);
            command.Parameters.Add("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = ePass;
            command.ExecuteNonQuery();
            Console.WriteLine("COMPLETE");
        }

        private void firstNameTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
