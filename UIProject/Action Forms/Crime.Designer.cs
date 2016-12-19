namespace UIProject.Action_Forms
{
    partial class Crime
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
            this.components = new System.ComponentModel.Container();
            this.caseInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.editOfficerButton = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.officerPictureBox = new System.Windows.Forms.PictureBox();
            this.officerLastNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.officerFirstNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.officerIDTextBox = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.officerDepartmentComboBox = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.addSuspectButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifySuspectButton = new DevExpress.XtraEditors.SimpleButton();
            this.removeSuspectButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.caseInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerLastNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerFirstNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerIDTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDepartmentComboBox.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // caseInformationBindingSource
            // 
            this.caseInformationBindingSource.DataMember = "Case_Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.gender,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(234, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 290);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxEdit2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxEdit1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1378, 419);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Case Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Date Take";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(704, 365);
            this.comboBoxEdit2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "2",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "3",
            "30",
            "31",
            "32",
            "33",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxEdit2.Properties.Sorted = true;
            this.comboBoxEdit2.Size = new System.Drawing.Size(298, 34);
            this.comboBoxEdit2.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1044, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Process";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(1050, 371);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "2",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "3",
            "30",
            "31",
            "32",
            "33",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxEdit1.Properties.Sorted = true;
            this.comboBoxEdit1.Size = new System.Drawing.Size(298, 34);
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.editOfficerButton);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.officerPictureBox);
            this.groupBox4.Controls.Add(this.officerLastNameTextBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.officerFirstNameTextBox);
            this.groupBox4.Controls.Add(this.officerIDTextBox);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.officerDepartmentComboBox);
            this.groupBox4.Location = new System.Drawing.Point(0, 37);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(690, 373);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Officer Info";
            // 
            // editOfficerButton
            // 
            this.editOfficerButton.Location = new System.Drawing.Point(12, 273);
            this.editOfficerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editOfficerButton.Name = "editOfficerButton";
            this.editOfficerButton.Size = new System.Drawing.Size(224, 56);
            this.editOfficerButton.TabIndex = 42;
            this.editOfficerButton.Text = "Change Officer";
            this.editOfficerButton.Click += new System.EventHandler(this.editOfficerButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 252);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 25);
            this.label17.TabIndex = 49;
            this.label17.Text = "Deparment";
            // 
            // officerPictureBox
            // 
            this.officerPictureBox.BackColor = System.Drawing.Color.White;
            this.officerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.officerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.officerPictureBox.Location = new System.Drawing.Point(12, 33);
            this.officerPictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.officerPictureBox.Name = "officerPictureBox";
            this.officerPictureBox.Size = new System.Drawing.Size(222, 221);
            this.officerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.officerPictureBox.TabIndex = 42;
            this.officerPictureBox.TabStop = false;
            // 
            // officerLastNameTextBox
            // 
            this.officerLastNameTextBox.Enabled = false;
            this.officerLastNameTextBox.Location = new System.Drawing.Point(260, 133);
            this.officerLastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.officerLastNameTextBox.Name = "officerLastNameTextBox";
            this.officerLastNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.officerLastNameTextBox.Size = new System.Drawing.Size(280, 34);
            this.officerLastNameTextBox.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "First Name";
            // 
            // officerFirstNameTextBox
            // 
            this.officerFirstNameTextBox.Enabled = false;
            this.officerFirstNameTextBox.Location = new System.Drawing.Point(258, 58);
            this.officerFirstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.officerFirstNameTextBox.Name = "officerFirstNameTextBox";
            this.officerFirstNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.officerFirstNameTextBox.Size = new System.Drawing.Size(282, 34);
            this.officerFirstNameTextBox.TabIndex = 19;
            // 
            // officerIDTextBox
            // 
            this.officerIDTextBox.Location = new System.Drawing.Point(258, 208);
            this.officerIDTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.officerIDTextBox.Name = "officerIDTextBox";
            this.officerIDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.officerIDTextBox.Size = new System.Drawing.Size(218, 34);
            this.officerIDTextBox.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 177);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "ID Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 102);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Last Name";
            // 
            // officerDepartmentComboBox
            // 
            this.officerDepartmentComboBox.Enabled = false;
            this.officerDepartmentComboBox.Location = new System.Drawing.Point(260, 283);
            this.officerDepartmentComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.officerDepartmentComboBox.Name = "officerDepartmentComboBox";
            this.officerDepartmentComboBox.Size = new System.Drawing.Size(374, 34);
            this.officerDepartmentComboBox.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Controls.Add(this.textEdit2);
            this.groupBox2.Controls.Add(this.textEdit4);
            this.groupBox2.Controls.Add(this.textEdit3);
            this.groupBox2.Location = new System.Drawing.Point(704, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(662, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "District";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(54, 67);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(590, 34);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(54, 142);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.Items.AddRange(new object[] {
            "Bac Lieu",
            "Ben Thuy",
            "Ben Tre",
            "Bien Hoa",
            "Buon Me Thuot",
            "Cam Ranh",
            "Can Tho",
            "Cao Lanh",
            "Cho Lon",
            "Con Son",
            "Da Lat",
            "Da Nang",
            "Ha Long",
            "Hai Duong",
            "Haiphong",
            "Hanoi",
            "Ho Chi Minh City",
            "Hoa Binh",
            "Hue",
            "Kon Tum",
            "Lao Cai",
            "Long Xuyen",
            "My Tho",
            "Nam Dinh",
            "Nha Trang",
            "Phan Thiet",
            "Pleiku",
            "Quang Ngai",
            "Qui Nhon",
            "Rach Gia",
            "Sa Dec",
            "Tay Ninh",
            "Thai Binh",
            "Thai Nguyen",
            "Thanh Hoa",
            "Thu Dau Mot",
            "Tuy Hoa",
            "Vinh",
            "Vinh Long",
            "Vung Tau"});
            this.textEdit2.Properties.Sorted = true;
            this.textEdit2.Size = new System.Drawing.Size(590, 34);
            this.textEdit2.TabIndex = 2;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(54, 217);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit4.Properties.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "2",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "3",
            "30",
            "31",
            "32",
            "33",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.textEdit4.Properties.Sorted = true;
            this.textEdit4.Size = new System.Drawing.Size(274, 34);
            this.textEdit4.TabIndex = 6;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(346, 217);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit3.Properties.Items.AddRange(new object[] {
            "Huyện Cần Giờ",
            "Huyện Củ Chi",
            "Huyện Hóc Môn",
            "Huyện Nhà Bè",
            "Quận 1",
            "Quận 10",
            "Quận 11",
            "Quận 12",
            "Quận 2",
            "Quận 3",
            "Quận 4",
            "Quận 5",
            "Quận 6",
            "Quận 7",
            "Quận 8",
            "Quận 9",
            "Quận Bình Tân",
            "Quận Bình Thạnh",
            "Quận Gò Vấp",
            "Quận Phú Nhuận",
            "Quận Tân Bình",
            "Quận Tân Phú",
            "Quận Thủ Đức"});
            this.textEdit3.Properties.Sorted = true;
            this.textEdit3.Size = new System.Drawing.Size(298, 34);
            this.textEdit3.TabIndex = 4;
            // 
            // addSuspectButton
            // 
            this.addSuspectButton.Location = new System.Drawing.Point(32, 37);
            this.addSuspectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addSuspectButton.Name = "addSuspectButton";
            this.addSuspectButton.Size = new System.Drawing.Size(192, 44);
            this.addSuspectButton.TabIndex = 14;
            this.addSuspectButton.Text = "Add Suspect";
            this.addSuspectButton.Click += new System.EventHandler(this.btn_submit_suspect_Click);
            // 
            // modifySuspectButton
            // 
            this.modifySuspectButton.Location = new System.Drawing.Point(32, 92);
            this.modifySuspectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modifySuspectButton.Name = "modifySuspectButton";
            this.modifySuspectButton.Size = new System.Drawing.Size(192, 44);
            this.modifySuspectButton.TabIndex = 15;
            this.modifySuspectButton.Text = "Modify Suspect";
            this.modifySuspectButton.Click += new System.EventHandler(this.modifySuspectButton_Click);
            // 
            // removeSuspectButton
            // 
            this.removeSuspectButton.Location = new System.Drawing.Point(32, 148);
            this.removeSuspectButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.removeSuspectButton.Name = "removeSuspectButton";
            this.removeSuspectButton.Size = new System.Drawing.Size(192, 44);
            this.removeSuspectButton.TabIndex = 16;
            this.removeSuspectButton.Text = "Remove Suspect";
            this.removeSuspectButton.Click += new System.EventHandler(this.removeSuspectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeSuspectButton);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.modifySuspectButton);
            this.groupBox3.Controls.Add(this.addSuspectButton);
            this.groupBox3.Location = new System.Drawing.Point(24, 444);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1378, 342);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suspect Info";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(1206, 798);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(196, 62);
            this.simpleButton3.TabIndex = 17;
            this.simpleButton3.Text = "Done";
            this.simpleButton3.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Crime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 879);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Crime";
            this.Text = "Crime";
            ((System.ComponentModel.ISupportInitialize)(this.caseInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerLastNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerFirstNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerIDTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDepartmentComboBox.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource caseInformationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit3;
        private DevExpress.XtraEditors.SimpleButton addSuspectButton;
        private DevExpress.XtraEditors.SimpleButton modifySuspectButton;
        private DevExpress.XtraEditors.SimpleButton removeSuspectButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton editOfficerButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox officerPictureBox;
        private DevExpress.XtraEditors.TextEdit officerLastNameTextBox;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit officerFirstNameTextBox;
        private DevExpress.XtraEditors.TextEdit officerIDTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private DevExpress.XtraEditors.TextEdit officerDepartmentComboBox;
    }
}