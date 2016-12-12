using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Sql;

namespace UIProject.RibbonForm
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
           // dashboardDesigner1.CreateRibbon();
            String appPath = Application.StartupPath;
            dashboardDesigner1.LoadDashboard(appPath + "\\Dashboard1.xml");
            //DashboardItem gridTicker = dashboardViewer.Dashboard.Items.FindFirst(c => c.Name == "By Ticker")
            SplitContainerControl spliteControl = (SplitContainerControl)dashboardDesigner1.Controls[0];
            spliteControl.PanelVisibility = SplitPanelVisibility.Panel2;
            SplitContainerControl childSpliteControl = (SplitContainerControl)spliteControl.Panel2.Controls[0];
            childSpliteControl.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pivotGridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
