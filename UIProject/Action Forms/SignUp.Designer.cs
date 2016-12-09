namespace UIProject
{
    partial class SignUp
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
            this.firstNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.departmentComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.retypeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.signUpButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retypeTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(70, 115);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 32);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.EditValueChanged += new System.EventHandler(this.firstNameTextBox_EditValueChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(282, 115);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(468, 32);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.EditValue = "";
            this.emailTextBox.Location = new System.Drawing.Point(70, 200);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(680, 32);
            this.emailTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Code";
            // 
            // empCodeTextBox
            // 
            this.empCodeTextBox.Location = new System.Drawing.Point(70, 285);
            this.empCodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.empCodeTextBox.Name = "empCodeTextBox";
            this.empCodeTextBox.Size = new System.Drawing.Size(200, 32);
            this.empCodeTextBox.TabIndex = 7;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Location = new System.Drawing.Point(282, 285);
            this.departmentComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.departmentComboBox.Size = new System.Drawing.Size(468, 34);
            this.departmentComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(70, 379);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(680, 32);
            this.passwordTextBox.TabIndex = 10;
            // 
            // retypeTextBox
            // 
            this.retypeTextBox.Location = new System.Drawing.Point(70, 469);
            this.retypeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.retypeTextBox.Name = "retypeTextBox";
            this.retypeTextBox.Size = new System.Drawing.Size(680, 32);
            this.retypeTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Re-enter Password";
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.AutoSize = true;
            this.agreeCheckBox.Location = new System.Drawing.Point(70, 538);
            this.agreeCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(541, 29);
            this.agreeCheckBox.TabIndex = 14;
            this.agreeCheckBox.Text = "I have read and agree with the terms and conditions";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.signUpButton.Location = new System.Drawing.Point(282, 583);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(6);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(190, 71);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 707);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.agreeCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.retypeTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.departmentComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retypeTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit firstNameTextBox;
        private DevExpress.XtraEditors.TextEdit lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit empCodeTextBox;
        private DevExpress.XtraEditors.ComboBoxEdit departmentComboBox;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit passwordTextBox;
        private DevExpress.XtraEditors.TextEdit retypeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private DevExpress.XtraEditors.SimpleButton signUpButton;
    }
}