using System;
using DevExpress.XtraWaitForm;

namespace UIProject
{
    public partial class LoadingScreen : WaitForm
    {
        public LoadingScreen()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }



        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }



        public enum WaitFormCommand
        {
        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {
        }
    }
}
