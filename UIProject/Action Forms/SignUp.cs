﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using UIProject.Securities;

namespace UIProject
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {

        List<UserInfo> UserTable = new List<UserInfo>();

        public SignUp()
        {
            InitializeComponent();

            getData();

        }
        private void getData()
        {

            String appPath = Application.StartupPath;
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string sql = "SELECT A.Email FROM LoginInformation as A";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                UserInfo temp = new UserInfo();
                temp.Email = read.GetString(0).Trim();
                UserTable.Add(temp);
            }
            con.Close();
        }

        private bool checkEmail(string data)
        {
        
          UserInfo temp = UserTable.Find(item => item.Email == data);
            try
            {
                if (temp.Email != null)
                {
                    if (temp.Email == data)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException ex)
            {
                return false;
            }
            return false;
        }
        private bool isFilled(Object[] textboxs)
        {
            foreach (Object textbox in textboxs)
            {

                try
                {
                    DevExpress.XtraEditors.TextEdit tb = (DevExpress.XtraEditors.TextEdit)textbox;
                    if (tb.Text == "")
                    {
                        return false;
                    }
                }
                catch
                {
                    try
                    {

                        DevExpress.XtraEditors.ComboBoxEdit cb = (DevExpress.XtraEditors.ComboBoxEdit)textbox;
                        if (cb.Text == "")
                {
                            return false;
                        }
                    }
                    catch
                    {

                        TextBox tb = (TextBox)textbox;
                        if (tb.Text == "")

                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void signUpButton_Click_1(object sender, EventArgs e)
        {

            var textboxs = new Object[] { firstNameTextBox, lastNameTextBox, emailTextBox, departmentComboBox, passwordTextBox, retypePasswordTextBox, empCodeTextBox, addressTextBox };

            if (!isFilled(textboxs))
            {
                MessageBox.Show("Please fill out the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var appPath = Application.StartupPath;
                Console.WriteLine(appPath);
                var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
                var con = new SqlConnection(constring);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string sql = "INSERT INTO UserInformations (First_name, Last_name, Address, Phone, Officer_Department_ID) " +
                        "VALUES (@first_name, @last_name, @address, @phone, @officer)" +
                        " SELECT @user_id = SCOPE_IDENTITY(); " +
                        "INSERT INTO LoginInformation(User_Login_ID, Email, Password) " +
                        "VALUES (@user_id, @email , @password)";
                var command = new SqlCommand(sql, con);
                if (checkEmail(emailTextBox.Text) == true)
                {
                    MessageBox.Show("Email taken");
                }
                else
                {
                    if (!passwordTextBox.Text.Equals(retypePasswordTextBox.Text))
                    {
                        MessageBox.Show("Retype password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        command.Parameters.Add("@first_name", SqlDbType.VarChar, 38).Value = firstNameTextBox.Text;
                        command.Parameters.Add("@last_name", SqlDbType.VarChar, 38).Value = lastNameTextBox.Text;
                        command.Parameters.Add("@address", SqlDbType.VarChar, 38).Value = addressTextBox.Text;
                        command.Parameters.Add("@phone", SqlDbType.VarChar, 38).Value = "";
                        command.Parameters.Add("@officer", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@email", SqlDbType.VarChar, 38).Value = emailTextBox.Text;
                        string ePass = SaltPassword.ComputeHash(passwordTextBox.Text, "SHA512", null);
                        command.Parameters.Add("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@password", SqlDbType.VarChar).Value = ePass;
                        command.ExecuteNonQuery();
                        Console.WriteLine("COMPLETE");
                        this.Close();
                    }
                }
            }
        }
    }
}
