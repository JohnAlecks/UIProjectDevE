using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using UIProject.Tools;
using DevExpress.XtraSplashScreen;

namespace UIProject.Action_Forms
{
    public partial class Edit_CommittedTarget : DevExpress.XtraEditors.XtraForm
    {
        string image = "";
        string suspectID = "";
        int id = -1;
        public Dictionary<string, string> supect = new Dictionary<string, string>();
        public Dictionary<string, string> a = new Dictionary<string, string>();
        public Edit_CommittedTarget(string cellID, int index,Dictionary<string,string> suspectDetail)
        {

            InitializeComponent();
            fillInData(cellID);
            id = index;
            suspectID = cellID;
            supect = suspectDetail;
            
        }

        private void fillInData(string id)
        {
            var appPath = Application.StartupPath;
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True;";
            var con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            var sql = "SELECT * FROM Committed_Target WHERE Committed_Target_ID =" + id;
            var command = new SqlCommand(sql, con);
            var read = command.ExecuteReader();
            while (read.Read())
            {
                idTextBox.Text = read.GetInt32(0).ToString();
                firstNameTextBox.Text = read.GetString(1);
                lastNameTextBox.Text = read.GetString(1);
                birthdayDatePicker.DateTime = read.GetDateTime(2);
                genderComboBox.Text = read.GetString(9);
                trialDayDatePicker.DateTime = read.GetDateTime(7);
                jailNumberTextBox.Text = read.GetString(6);
                buildTextBox.Text = read.GetString(10);
                crimesTextBox.Text = read.GetString(8);
                heightTextBox.Text = read.GetString(11);
                eyesTextBox.Text = read.GetString(12);
                hairTextBox.Text = read.GetString(13);
                image = read.GetString(14);
                suspectPictureBox.Image = ImageTools.Base64ToImage(read.GetString(14));
            }
            con.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var apppath = Application.StartupPath;
            var constring = @"data source=(localdb)\mssqllocaldb;attachdbfilename=" +
                apppath + "\\criminalrecord.mdf;integrated security=true;connect timeout=30";
            var con = new SqlConnection(constring);
            con.Open();
            SqlCommand updcommand = new SqlCommand("update committed_target set full_name = @full_name, dob = @dob, cmt_address = @cmt_address, citizen_verification = @citizen_verification, committed_style = @committed_style, temp_number = @temp_number, temp_jaildate = @temp_jaildate, note = @note, gender = @gender, build = @build, height = @height, hair = @hair, eyes = @eyes, suspect_image = @suspect_image where committed_target_id =" + suspectID, con);
            updcommand.Parameters.AddWithValue("@full_name", firstNameTextBox.Text);
            updcommand.Parameters.AddWithValue("@dob", birthdayDatePicker.DateTime);
            updcommand.Parameters.AddWithValue("@cmt_address", "cyka blyat street");
            updcommand.Parameters.AddWithValue("@citizen_verification", "1");
            updcommand.Parameters.AddWithValue("@committed_style", "1");
            updcommand.Parameters.AddWithValue("@temp_number", jailNumberTextBox.Text);
            updcommand.Parameters.AddWithValue("@temp_jaildate", trialDayDatePicker.DateTime);
            updcommand.Parameters.AddWithValue("@note", "1");
            updcommand.Parameters.AddWithValue("@gender", genderComboBox.Text);
            updcommand.Parameters.AddWithValue("@build", buildTextBox.Text);
            updcommand.Parameters.AddWithValue("@hair", hairTextBox.Text);
            updcommand.Parameters.AddWithValue("@eyes", eyesTextBox.Text);
            updcommand.Parameters.AddWithValue("@height", heightTextBox.Text);
            updcommand.Parameters.AddWithValue("@suspect_image", image);
            updcommand.ExecuteNonQuery();
            supect["firstname"] = firstNameTextBox.Text;
            supect["lastname"] = lastNameTextBox.Text;
            supect["id"] = idTextBox.Text;
            supect["gender"] = genderComboBox.Text;

            var parent = (Crime)Owner;
            parent.NotifyMeEdit(id,supect);
            con.Close();
        }

        private void suspectPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    suspectPictureBox.Image = Image.FromFile(dlg.FileName);
                    Image imgInput = Image.FromFile(dlg.FileName);
                    Graphics gInput = Graphics.FromImage(imgInput);
                    System.Drawing.Imaging.ImageFormat thisFormat = imgInput.RawFormat;
                    SplashScreenManager.ShowForm(this, typeof(LoadingScreen), true, true, false, true);
                    SplashScreenManager.Default.SetWaitFormCaption("Loading image...");
                    image = ImageTools.ImageToBase64(Image.FromFile(dlg.FileName), thisFormat);
                    SplashScreenManager.CloseForm();
                    suspectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(suspectPictureBox);
                }
            }
        }
    }
}