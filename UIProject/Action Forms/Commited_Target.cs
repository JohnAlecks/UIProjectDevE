﻿using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UIProject.Action_Forms;
using UIProject.Tools;

namespace UIProject
{
    public partial class AddCase : DevExpress.XtraEditors.XtraForm
    {
        public Crime crime = new Crime();
        public Dictionary<string,string> a = new Dictionary<string, string>();
        
        public AddCase()
        {
            InitializeComponent();
            foo();
        }

        private static bool wasExecuted = false;
        public void foo()
        {
            Console.WriteLine(wasExecuted + "1");
            if (wasExecuted == false)
            {
                Console.WriteLine(wasExecuted + "2");
                wasExecuted = true;
                inittable();
                Console.WriteLine(wasExecuted);
            }
            else
            {
                Console.WriteLine("DAFUQ");
            }
        }

        private void inittable()
        {
            var appPath = Application.StartupPath;
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);
            con.Open();
            var DbCommand = new SqlCommand("CREATE TABLE dbo.##StoredDataID (Record_ID int, Crime_ID int);", con);
            DbCommand.ExecuteNonQuery();

            Console.WriteLine("Create Complete");
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
                    a.Add("Image",ImageTools.ImageToBase64(Image.FromFile(dlg.FileName), thisFormat));
                    SplashScreenManager.CloseForm();
                    suspectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(suspectPictureBox);
                }
            }
        }

        public bool YourReturnValue { get; private set; }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var textboxs = new object[] { firstNameTextBox, lastNameTextBox, idTextBox, genderComboBox, birthdayDatePicker, trialDayDatePicker, buildTextBox, heightTextBox, eyesTextBox, statusComboBox };
            //if (!SignUp.isFilled(textboxs))
            //{
            //    MessageBox.Show("Please fill out the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            {
                var appPath = Application.StartupPath;
                Console.WriteLine(appPath);
                var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
                var con = new SqlConnection(constring);
                con.Open();
                var sql = "INSERT INTO Committed_Target (Full_name, Dob, CMT_Address, Citizen_Verification, Committed_Style, Temp_Number, Temp_Jaildate, Note, Gender, Build, Height, Hair, Eyes, suspect_image ) "
                + "VALUES (@full_name, @dob, @address, @citizen_verification, @committed_style, @temp_number, @temp_jaildate, @note, @gender, @build, @height, @hair, @eyes, @suspect_image) ";

                var command = new SqlCommand(sql, con);

                command.Parameters.Add("@full_name", SqlDbType.VarChar).Value = "CykaBlyat";
                command.Parameters.Add("@dob", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = "Blah";
                command.Parameters.Add("@citizen_verification", SqlDbType.VarChar).Value = "1";
                command.Parameters.Add("@committed_style", SqlDbType.VarChar).Value = "123";
                command.Parameters.Add("@temp_number", SqlDbType.NVarChar).Value = "1";
                command.Parameters.Add("@temp_jaildate", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@note", SqlDbType.VarChar).Value = "123";
                command.Parameters.Add("@gender", SqlDbType.Char).Value = "GAY";
                command.Parameters.Add("@height", SqlDbType.VarChar).Value = "Black";
                command.Parameters.Add("@build", SqlDbType.VarChar).Value = "123";
                command.Parameters.Add("@hair", SqlDbType.Char).Value = "black";
                command.Parameters.Add("@eyes", SqlDbType.Char).Value = "blue";
                command.Parameters.Add("@suspect_image", SqlDbType.VarChar).Value = a["Image"];
                command.ExecuteNonQuery();
                con.Close();
                var parent = (Crime)Owner;
                a.Add("firstName", firstNameTextBox.Text);
                a.Add("lastName", lastNameTextBox.Text);
                a.Add("gender", genderComboBox.Text);
                a.Add("id", idTextBox.Text);
                a.Add("status", statusComboBox.Text);
                parent.NotifyMe(a);
                Close();
            }
        }

        public static List<string> getData()
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);
            con.Open();
            var sql = "SELECT * FROM ##StoredDataID, Committed_Target WHERE Record_ID = Committed_Target_ID";
            var com = new SqlCommand(sql, con);
            var read = com.ExecuteReader();
            var a = new List<string>();
            while (read.Read())
            {
                Console.WriteLine(read.GetValue(0).ToString());
                a.Add(read.GetValue(0).ToString());
            }
            con.Close();
            Console.WriteLine(a.ToArray());
            return a;
        }

        public static SqlConnection getc()
        {
            var appPath = Application.StartupPath;
            var sqlstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var conn = new SqlConnection(sqlstr);
            return conn;
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void AddCase_Load(object sender, EventArgs e)
        {
        }
    }
}
