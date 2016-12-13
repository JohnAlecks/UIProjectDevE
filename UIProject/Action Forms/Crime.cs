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

            ListViewItem item1 = new ListViewItem("Criminal Name");
            Console.WriteLine("RUNNED");
            String appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath + "\\CriminalRecord.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(constring);

            string sql = "SELECT Full_name FROM ##StoredDataID, Committed_Target WHERE Record_ID = Committed_Target_ID ";
            SqlCommand com = new SqlCommand(sql, con);
            try
            {

                con.Open();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine(read.GetString(0));
                    //Console.WriteLine(read.GetInt32(1));
                    item1.SubItems.Add(read.GetString(0));
                    listView1.Items.Add(item1);
                }
                Task t = new Task(new Action(() =>
                {
                    RefreshLines();
                }));
                t.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void RefreshLines()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.RefreshLines));
            }
            for (int i = 1; i <= 10000; i++)
            {
                ListViewItem LVI = new ListViewItem("Track " + i);
                LVI.SubItems.Add("Updated");
                listView1.Items.Add(LVI);
                listView1.TopItem = LVI;
                listView1.EnsureVisible(listView1.Items.Count - 1);
                Application.DoEvents();
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
           
            string sql = "INSERT INTO UserInformations (First_name, Last_name, Address, Phone, Officer_Department_ID) VALUES (@first_name, @last_name, @address, @phone, @id) SELECT @user_id = SCOPE_IDENTITY(); INSERT INTO LoginInformation(User_Login_ID, Email, Password) VALUES (@user_id, @email , @password)";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@first_name", SqlDbType.VarChar, 38).Value = "";
            command.Parameters.Add("@last_name", SqlDbType.VarChar, 38).Value = "";
            command.Parameters.Add("@address", SqlDbType.VarChar, 38).Value = "528 Pham Van Hai";
            command.Parameters.Add("@phone", SqlDbType.VarChar, 38).Value = "123";
            command.Parameters.Add("@email", SqlDbType.VarChar, 38).Value = "";
            command.Parameters.Add("@id", SqlDbType.Int).Value = "1";
           
            command.ExecuteNonQuery();
            Console.WriteLine("COMPLETE");
            

        }
    }
}
