using System;
using System.Collections.Generic;
using System.Linq;

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
            // save 
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
