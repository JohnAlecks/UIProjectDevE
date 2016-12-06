namespace UIProject
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.newPasswordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.retypePasswordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.doneButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.currentPasswordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retypePasswordTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Location = new System.Drawing.Point(133, 31);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(227, 20);
            this.currentPasswordTextBox.TabIndex = 1;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(133, 57);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(227, 20);
            this.newPasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // retypePasswordTextBox
            // 
            this.retypePasswordTextBox.Location = new System.Drawing.Point(133, 83);
            this.retypePasswordTextBox.Name = "retypePasswordTextBox";
            this.retypePasswordTextBox.Size = new System.Drawing.Size(227, 20);
            this.retypePasswordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retype New Password";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(133, 113);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(79, 26);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(281, 113);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 26);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 151);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.retypePasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.currentPasswordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retypePasswordTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit currentPasswordTextBox;
        private DevExpress.XtraEditors.TextEdit newPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit retypePasswordTextBox;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton doneButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
    }
}