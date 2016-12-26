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
using UIProject.Tools;
using System.Data.SqlClient;

namespace UIProject.Action_Forms
{
    public partial class CriminalDetail : DevExpress.XtraEditors.XtraForm
    {
        public CriminalDetail(string id)
        {
            InitializeComponent();
            fillInData(id);
        }
        private String image;
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
                foreach (DateTime crimes in fillinTextBox(id)) {
                    crimesTextBox.Text = crimes.ToString();
                }
                heightTextBox.Text = read.GetString(11);
                eyesTextBox.Text = read.GetString(12);
                hairTextBox.Text = read.GetString(13);
                image = read.GetString(14);
                suspectPictureBox.Image = ImageTools.Base64ToImage(read.GetString(14));
            }
            con.Close();
        }

        private Array fillinTextBox(string crminalID)
        {
            List<DateTime> dataArray = new List<DateTime>();
            var appPath = Application.StartupPath;
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True;";
            var con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            var sql = " SELECT Date_Commit FROM Committed_Target, Committed_Crime_Target, Commit_Crime WHERE Committed_Target_ID = " + crminalID +" AND Committed_Target_ID = CommittedTarget_ID AND CommittedCrime_ID = Committed_Crime_ID" ;
            var command = new SqlCommand(sql, con);
            var read = command.ExecuteReader();
            while (read.Read())
            {
                dataArray.Add(read.GetDateTime(0));
            }
            con.Close();
            return dataArray.ToArray();
        }
    }
}