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
using UIProject.Database.Database_Controller;
using UIProject.Tools;

namespace UIProject.Action_Forms
{
    public partial class Edit_Case : DevExpress.XtraEditors.XtraForm
    {
        public string cellID;
        public Edit_Case(string id)
        {
            InitializeComponent();
            cellID = id;
            fillInData(id);

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
            var sql = "SELECT * FROM Commit_Crime WHERE Committed_Crime_ID =" + id;
            var command = new SqlCommand(sql, con);
            var read = command.ExecuteReader();
            while (read.Read())
            {
                textEdit1.Text = read.GetDateTime(1).ToString();
                textEdit3.Text = read.GetString(2);
                textEdit4.Text = read.GetString(4);
                ///comboBoxEdit1.Text = read.GetDateTime(5).ToString();
                //comboBoxEdit2.Text = read.GetString(5);
                textEdit2.Text = read.GetString(6);
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
            SqlCommand updcommand = new SqlCommand("update commit_crime set date_commit = @date, content = @content, criminal = @criminal, note = @note, information_id = @id, context = @context, result = @result where commit_crime =" + cellID, con);
            updcommand.Parameters.AddWithValue("@date", textEdit1.Text);
            updcommand.Parameters.AddWithValue("@content", groupBox1.Text);
            updcommand.Parameters.AddWithValue("@criminal", "1");
            updcommand.Parameters.AddWithValue("@note", textEdit4.Text);
            updcommand.Parameters.AddWithValue("@id", "1");
            updcommand.Parameters.AddWithValue("@context", "Blah");
            updcommand.Parameters.AddWithValue("@result", "1");
            updcommand.ExecuteNonQuery();
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editOfficerButton_Click(object sender, EventArgs e)
        {
            if (officerIDTextBox.Text != string.Empty)
            {
                List<UserInfo> temp = DataQuery.runQuery(officerIDTextBox.Text);
                try
                {
                    UserInfo officer = temp.First();
                    officerFirstNameTextBox.Text = officer.First_name;
                    officerLastNameTextBox.Text = officer.Last_name;
                    officerPictureBox.Image = ImageTools.Base64ToImage(officer.Link);
                    officerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    var appPath = Application.StartupPath;
                    Console.WriteLine(appPath + "Hello");
                    var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                        appPath + "\\CriminalRecord.mdf;Integrated Security=True";
                    var con = new SqlConnection(constring);
                    string sql = "SELECT Department_Name FROM Department WHERE Department_ID=" + officer.Officer_Department;
                    var com = new SqlCommand(sql, con);
                    con.Open();
                    var read = com.ExecuteReader();
                    while (read.Read())
                    {
                        officerDepartmentComboBox.Text = read.GetString(0);

                    }
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("No Officer found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void information_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void content_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifySuspectButton_Click(object sender, EventArgs e)
        {

        }
    }
}