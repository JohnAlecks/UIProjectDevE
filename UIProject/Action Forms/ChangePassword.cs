using System;

namespace UIProject
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
