using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Ribbon;
using UIProject.RibbonForm;
using UIProject.Action_Forms;
using System.Data.SqlClient;
using System.Data;

namespace UIProject
{
    public partial class UIProject : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string getId;
        public int getIndex;
        public UIProject()
        {
            InitializeComponent();
            var log = new LoginScreen();
            log.ShowMode = DevExpress.XtraSplashScreen.ShowMode.Form;
            log.ShowDialog();
            ribbonControl1.Minimized = true;
            InitializeRibbonControl();
        }
        private void InitializeRibbonControl()
        {
            var group1 = new RibbonPage("Test Group");
            ribbonControl1.Pages.Add(group1);
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            var form = new Dashboard();
            form.Dock = DockStyle.Fill;
            xtraTabPage1.Controls.Add(form);
            fillQueryIn();
            fillQuery();
            fillOfficer();
        }
        private void fillQueryIn() {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            string sql = "SELECT * FROM Commit_Crime  ";
            SqlCommand com = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            caseDataGridView.ReadOnly = false;
            caseDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void fillQuery()
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            string sql = "SELECT * FROM Committed_Target  ";
            SqlCommand com = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ExitButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void AddButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ac = new Crime();
            ac.FormClosed += new FormClosedEventHandler(acClose);
            ac.ShowDialog();
        }
        private void acClose(object sender, FormClosedEventArgs e)
        {
            fillQueryIn();
        }
 

        private void EditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mc = new ModifyCase();
            mc.ShowDialog();
        }

        private void DeleteButtonIteem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this case ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                caseDataGridView.Rows.RemoveAt(getIndex);
                caseDataGridView.Refresh();
                deleteCase(getId);
            }
        }
        public static void ShowLoading(Form ParentForm, String Caption)
        {
            SplashScreenManager.ShowForm(ParentForm, typeof(LoadingScreen), true, true, false, true);
            SplashScreenManager.Default.SetWaitFormCaption(Caption);
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            SplashScreenManager.Default.SetWaitFormCaption("Complete");
            System.Threading.Thread.Sleep(800);
            SplashScreenManager.CloseForm();
        }
        private void RefreshDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Reloading Database...");
        }

        private void DisconnectDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Disconnecting...");
        }

        private void LogoutButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Logging Out...");
            Hide();
            var lgs = new LoginScreen();
            lgs.ShowDialog();
            Application.DoEvents();
        }

        private void ChangeUserButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lgs = new LoginScreen();
            lgs.setLable("Change User");
            lgs.ShowDialog();
        }

        private void ChangePasswordButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cp = new ChangePassword();
            cp.ShowDialog();
        }

        private void ConnectDatabaseButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoading(this, "Connecting...");
        }

        private void HelpButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Contact your IT supporter for futher infomation.", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            var ribbon = sender as RibbonControl;
            for (var i = 0; i < ribbonControl1.Pages.Count; i++)
            {
                if (ribbon.SelectedPage == ribbonControl1.Pages[i])
                {
                    xtraTabControl1.SelectedTabPageIndex = i;
                }
            }
        }

        private void RibbonControl1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ribbonControl1_MinimizedChanged(object sender, EventArgs e)
        {
        }

        private void ribbonControl1_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {
            var ribbon = sender as RibbonControl;

            Console.Write(ribbon.SelectedPage.ToString());
            if (ribbon.SelectedPage == ribbonControl1.Pages[1])
            {
                Update();
                ribbon.Minimized = true;
                Application.DoEvents();
            }
            else
            {
                Update();
                ribbon.Minimized = false;
                Application.DoEvents();
            }
        }

        private void xtraTabPage1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void caseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getId = caseDataGridView.CurrentRow.Cells[0].Value.ToString();
            getIndex = caseDataGridView.CurrentRow.Index;
            Edit_Case ec = new Edit_Case(getId);
            ec.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string criminalID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CriminalDetail ec = new CriminalDetail(criminalID);
            ec.Show();
        }

        private void deleteCase(string id)
        {
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillOfficer()
        {
            var appPath = Application.StartupPath;
            Console.WriteLine(appPath + "Hello");
            var constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                appPath + "\\CriminalRecord.mdf;Integrated Security=True";
            var con = new SqlConnection(constring);

            string sql = "SELECT * FROM UserInformations  ";
            SqlCommand com = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = false;
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }

    }
}
