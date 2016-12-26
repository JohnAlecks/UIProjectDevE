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
using UIProject.Securities;

namespace UIProject.Action_Forms
{
    public partial class Crime : Form
    {
        public Crime()
        {
            InitializeComponent();
            getLoginData();
        }

        public static DataGridView dgv = new DataGridView();
        public static int index;
        public string getId = "";
        public int officerID;
        public int current = 0;
        public Dictionary<int, Dictionary<string, string>> suspects = new Dictionary<int, Dictionary<string, string>>(); 
        public static SqlConnection getc()
        {
            var appPath = Application.StartupPath;
            var sqlstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var conn = new SqlConnection(sqlstr);
            return conn;
        }
        private void getLoginData() {
            officerFirstNameTextBox.Text = Cookies.SessionInfo.UserName;
            officerLastNameTextBox.Text = Cookies.SessionInfo.UserName;
            officerIDTextBox.Text = Cookies.SessionInfo.UserID.ToString();
            officerDepartmentComboBox.Text = Cookies.SessionInfo.Department;
            
        }


        private void btn_submit_suspect_Click(object sender, EventArgs e)
        {
            using (var formOptions = new AddCase())
            {
                formOptions.ShowDialog(this);
            }
        }

        public void NotifyMeEdit(int index,Dictionary<string, string> suspectDetail)
        {
            dataGridView1.Rows[index].Cells[1].Value = suspectDetail["firstname"];
            dataGridView1.Rows[index].Cells[0].Value = suspectDetail["id"];
            dataGridView1.Rows[index].Cells[2].Value = suspectDetail["lastname"];
            dataGridView1.Rows[index].Cells[3].Value = suspectDetail["gender"];
            suspects[index] = suspectDetail;
            dataGridView1.Refresh();
            
        }
        public void NotifyMe(Dictionary<string, string> suspectDetail)
        {
            var temp = AddCase.getData();
            dataGridView1.Rows.Add(temp[temp.Count - 1], suspectDetail["firstName"], suspectDetail["lastName"], suspectDetail["gender"], suspectDetail["status"]);
            suspects.Add(dataGridView1.Rows.Count - 1, suspectDetail);
            current = dataGridView1.Rows.Count - 1;
            //officerPictureBox.Image = ImageTools.Base64ToImage(suspectDetail["Image"]);

        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath);
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            con.Open();

            var sql = "INSERT INTO Commit_Crime (Date_Commit, Content, Criminal, Note, Information_ID, Context, Result, Officer_ID)"
                + "VALUES (@date_commit, @content, @criminal, @note, @id, @context, @result, @officer_id) ";
            var command = new SqlCommand(sql, con);
            command.Parameters.Add("@date_commit", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@content", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@criminal", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@note", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@context", SqlDbType.VarChar).Value = "1";
            command.Parameters.Add("@result", SqlDbType.Int).Value = 1;
            if (officerID == null || officerID == Cookies.SessionInfo.UserID)
            {
                command.Parameters.Add("@officer_ID", SqlDbType.Int).Value = Cookies.SessionInfo.UserID;
            }
            else {
                command.Parameters.Add("@officer_ID", SqlDbType.Int).Value = officerID;
            }
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
                    officerID = officer.UserInfoID;
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
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Refresh();
            deleteCriminal(getId);
        }

        private void deleteCriminal(string id) {
            var appPath = Application.StartupPath;
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True;";
            var con = new SqlConnection(constring);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            var sql = "DELETE FROM Committed_Target WHERE Committed_Target_ID = " + id;
            var command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            Console.Write("Delete COmplete");
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            Console.WriteLine(index);
            getId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.Write(getId);
        }

        private void modifySuspectButton_Click(object sender, EventArgs e)
        {
            using (var formOptions = new Edit_CommittedTarget(getId, index, suspects[index]))
            {
                formOptions.ShowDialog(this);
            }
        }

        private void officerLastNameTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
