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
            //foo();
            

        }


        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }


        public void getData()
        {
            UserInfo temp = new UserInfo();
            //ListViewItem item1 = new ListViewItem("Criminal Name");
            Console.WriteLine("RUNNED");
            String appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Name";
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            ListViewItem item = new ListViewItem("1");
            listView1.Items.Add(item);
            listView1.View = View.Details;
            listView1.BeginUpdate();
            listView1.Items.Clear();
            
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);

            string sql = "SELECT Full_name FROM ##StoredDataID, Committed_Target WHERE Record_ID = Committed_Target_ID ";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            try
            {

                
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine("TRIGGER");
                    
                    temp.Email = read.GetString(0);
                    //istViewItem itemz = new ListViewItem(temp.Email);
                    this.listView1.Items.Add(read.GetString(0));
                    Console.WriteLine(temp.Email + "ALLAHU AKBAR");

                }
            }
            finally
            {
                listView1.EndUpdate();
            }
          
        }


        
      

        private void btn_submit_suspect_Click(object sender, EventArgs e)
        {
            AddCase cmt = new AddCase();
            cmt.Show();
            //this.FormClosed += new FormClosedEventHandler(AddCase);

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            String appPath = Application.StartupPath;
            Console.WriteLine(appPath);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);
            
                con.Open();

            string sql = "INSERT INTO Commit_Crime (Date_Commit, Content, Criminal, Note, Information_ID, Context, Result)"
                + "VALUES (@date_commit, @content, @criminal, @note, @id, @context, @result) ";                
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@date_commit", SqlDbType.VarChar).Value = DateTime.Now;
            command.Parameters.Add("@content", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@criminal", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@note", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@id", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@context", SqlDbType.VarChar).Value = "1";
            command.Parameters.Add("@result", SqlDbType.Int).Value = 1;
            command.ExecuteNonQuery();
            Console.WriteLine("COMPLETE");
            

        }
    }
}
