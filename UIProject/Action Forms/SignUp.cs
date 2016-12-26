using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using UIProject.Securities;
using UIProject.Tools;

namespace UIProject
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        private List<UserInfo> UserTable = new List<UserInfo>();
        string image = "";
        public SignUp()
        {
            InitializeComponent();

            getData();
        }
        private void getData()
        {
            var appPath = Application.StartupPath;
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            var con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            var sql = "SELECT A.Email FROM LoginInformation as A";
            var command = new SqlCommand(sql, con);
            var read = command.ExecuteReader();
            while (read.Read())
            {
                var temp = new UserInfo();
                temp.Email = read.GetString(0).Trim();
                UserTable.Add(temp);
            }
            con.Close();
        }

        private bool checkEmail(string data)
        {
            var temp = UserTable.Find(item => item.Email == data);
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
            catch
            {
                return false;
            }
        }
        public static bool isFilled(Object[] textboxs)
        {
            foreach (Object textbox in textboxs)
            {
                try
                {
                    var tb = (DevExpress.XtraEditors.TextEdit)textbox;
                    if (tb.Text == string.Empty)
                    {
                        return false;
                    }
                }
                catch
                {
                    try
                    {
                        var cb = (DevExpress.XtraEditors.ComboBoxEdit)textbox;
                        if (cb.Text == string.Empty)
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        try
                        {
                            var de = (DevExpress.XtraEditors.DateEdit)textbox;
                            if (de.Text == string.Empty)
                            {
                                return false;
                            }
                        }
                        catch
                        {
                            var tb = (TextBox)textbox;
                            if (tb.Text == string.Empty)
                            {
                                return false;
                            }
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
                if (!agreeCheckBox.Checked)
                {
                    MessageBox.Show("You must agree with conditions and terms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var appPath = Application.StartupPath;
                Console.WriteLine(appPath);
                var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
                var con = new SqlConnection(constring);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                var sql = "INSERT INTO UserInformations (First_name, Last_name, Address, Phone, Officer_Department_ID, profile_image) " +
                        "VALUES (@first_name, @last_name, @address, @phone, @officer, @profile_image)" +
                        " SELECT @user_id = SCOPE_IDENTITY(); " +
                        "INSERT INTO LoginInformation(User_Login_ID, Email, Password) " +
                        "VALUES (@user_id, @email , @password)";
                var command = new SqlCommand(sql, con);
                if (checkEmail(emailTextBox.Text) == true)
                {
                    MessageBox.Show("Email's already existed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        command.Parameters.Add("@phone", SqlDbType.VarChar, 38).Value = string.Empty;
                        command.Parameters.Add("@officer", SqlDbType.Int).Value = 1;
                        command.Parameters.Add("@email", SqlDbType.VarChar, 38).Value = emailTextBox.Text;
                        var ePass = SaltPassword.ComputeHash(passwordTextBox.Text, "SHA512", null);
                        command.Parameters.Add("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@password", SqlDbType.VarChar).Value = ePass;
                        command.Parameters.Add("@profile_image", SqlDbType.VarChar).Value = image;
                        command.ExecuteNonQuery();
                        Console.WriteLine("COMPLETE");
                        Close();
                    }
                }
            }
        }

        private void editOfficerButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    officerPictureBox.Image = Image.FromFile(dlg.FileName);
                    Image imgInput = Image.FromFile(dlg.FileName);
                    Graphics gInput = Graphics.FromImage(imgInput);
                    System.Drawing.Imaging.ImageFormat thisFormat = imgInput.RawFormat;
                    SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false, true);
                    SplashScreenManager.Default.SetWaitFormCaption("Loading image...");
                    image = ImageTools.ImageToBase64(Image.FromFile(dlg.FileName), thisFormat);
                    SplashScreenManager.CloseForm();
                    officerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(officerPictureBox);
                }
            }
        }
    }
}
