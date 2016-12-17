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
            String appPath = Application.StartupPath;
            string sqlstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlstr);
            return conn;
        }


        private void btn_submit_suspect_Click(object sender, EventArgs e)
        {
            using (AddCase formOptions = new AddCase())
            {
                
                formOptions.ShowDialog(this);
            }
           
            //this.FormClosed += new FormClosedEventHandler(AddCase);

            
        }
        public void NotifyMe(Dictionary<string,string> suspectDetail)
        {
            
            List<string> temp = AddCase.getData();
            dataGridView1.Rows.Add(temp[temp.Count - 1],suspectDetail["firstName"],suspectDetail["lastName"],suspectDetail["gender"],suspectDetail["status"]);
        }
        void cmtFormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> temp = AddCase.getData();
            dataGridView1.Rows.Add(temp[temp.Count - 1]);
           
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            String appPath = Application.StartupPath;
            Console.WriteLine(appPath);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" 
            + appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            
                con.Open();

            string sql = "INSERT INTO Commit_Crime (Date_Commit, Content, Criminal, Note, Information_ID, Context, Result)"
                + "VALUES (@date_commit, @content, @criminal, @note, @id, @context, @result) ";                
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@date_commit", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@content", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@criminal", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@note", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@context", SqlDbType.VarChar).Value = "1";
            command.Parameters.Add("@result", SqlDbType.Int).Value = 1;
            command.ExecuteNonQuery();
            Console.WriteLine("COMPLETE");
            
            this.Close();
            

        }
        
        private void editOfficerButton_Click(object sender, EventArgs e)
        {
            if (officerIDTextBox.Text != "")
            {

            }
            else {
                MessageBox.Show("Please enter officer ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void removeSuspectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
