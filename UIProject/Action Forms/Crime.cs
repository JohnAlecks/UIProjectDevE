using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UIProject.Tools;
using UIProject.Database;
using UIProject.Database.Database_Controller;

namespace UIProject.Action_Forms
{
    public partial class Crime : Form
    {
        public Crime()
        {
            InitializeComponent();
        }

        public static DataGridView dgv = new DataGridView();

        public static SqlConnection getc()
        {
            var appPath = Application.StartupPath;
            var sqlstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var conn = new SqlConnection(sqlstr);
            return conn;
        }


        private void btn_submit_suspect_Click(object sender, EventArgs e)
        {
            using (var formOptions = new AddCase())
            {
                formOptions.ShowDialog(this);
            }
        }

        public void NotifyMe(Dictionary<string, string> suspectDetail)
        {
            var temp = AddCase.getData();
            dataGridView1.Rows.Add(temp[temp.Count - 1], suspectDetail["firstName"], suspectDetail["lastName"], suspectDetail["gender"], suspectDetail["status"]);

            //officerPictureBox.Image = ImageTools.Base64ToImage(suspectDetail["Image"]);
            
        }
        private void cmtFormClosed(object sender, FormClosedEventArgs e)
        {
            var temp = AddCase.getData();
            dataGridView1.Rows.Add(temp[temp.Count - 1]);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath);
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            con.Open();

            var sql = "INSERT INTO Commit_Crime (Date_Commit, Content, Criminal, Note, Information_ID, Context, Result)"
                + "VALUES (@date_commit, @content, @criminal, @note, @id, @context, @result) ";
            var command = new SqlCommand(sql, con);
            command.Parameters.Add("@date_commit", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@content", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@criminal", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@note", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@context", SqlDbType.VarChar).Value = "1";
            command.Parameters.Add("@result", SqlDbType.Int).Value = 1;
            command.ExecuteNonQuery();
            Console.WriteLine("COMPLETE");

            Close();
        }

        private void editOfficerButton_Click(object sender, EventArgs e)
        {
            if (officerIDTextBox.Text != string.Empty)
            {
                List<UserInfo> temp = DataQuery.runQuery(officerIDTextBox.Text);
                try {
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
                    while (read.Read()) {
                        officerDepartmentComboBox.Text = read.GetString(0);
                        
                    }
                    con.Close();
                } catch {
                    MessageBox.Show("No Officer found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please enter officer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeSuspectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
