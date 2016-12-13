namespace UIProject
{
    partial class LoginScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.forgetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Lable = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // forgetPasswordLink
            // 
            this.forgetPasswordLink.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.forgetPasswordLink.AutoSize = true;
            this.forgetPasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.forgetPasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.forgetPasswordLink.Location = new System.Drawing.Point(290, 266);
            this.forgetPasswordLink.Name = "forgetPasswordLink";
            this.forgetPasswordLink.Size = new System.Drawing.Size(94, 13);
            this.forgetPasswordLink.TabIndex = 12;
            this.forgetPasswordLink.TabStop = true;
            this.forgetPasswordLink.Text = "Forget password ?";
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.rememberCheckBox.ForeColor = System.Drawing.Color.Black;
            this.rememberCheckBox.Location = new System.Drawing.Point(104, 303);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(103, 17);
            this.rememberCheckBox.TabIndex = 13;
            this.rememberCheckBox.Text = "Remember me ?";
            this.rememberCheckBox.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.loginButton.Location = new System.Drawing.Point(293, 293);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 36);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Turquoise;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 87);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.BackColor = System.Drawing.Color.Turquoise;
            this.Lable.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable.ForeColor = System.Drawing.Color.White;
            this.Lable.Location = new System.Drawing.Point(36, 31);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(145, 45);
            this.Lable.TabIndex = 16;
            this.Lable.Text = "Welcome";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(152, 105);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(149, 28);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Sign Up";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(212, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "or";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(104, 204);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.emailTextBox.Size = new System.Drawing.Size(280, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.ToolTipTitle = "Enter Your Email";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 243);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(280, 20);
            this.passwordTextBox.TabIndex = 20;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(421, 354);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.forgetPasswordLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "LoginScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emailTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel forgetPasswordLink;
        private System.Windows.Forms.CheckBox rememberCheckBox;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Lable;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}
