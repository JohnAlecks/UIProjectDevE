using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UIProject.RibbonForm
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            var appPath = Application.StartupPath;
            dashboardDesigner1.LoadDashboard(appPath + "\\Dashboard1.xml");

            var spliteControl = (SplitContainerControl)dashboardDesigner1.Controls[0];
            spliteControl.PanelVisibility = SplitPanelVisibility.Panel2;
            var childSpliteControl = (SplitContainerControl)spliteControl.Panel2.Controls[0];
            childSpliteControl.PanelVisibility = SplitPanelVisibility.Panel2;
        }
    }
}
