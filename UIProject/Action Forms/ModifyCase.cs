using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace UIProject
{
    public partial class ModifyCase : DevExpress.XtraEditors.XtraForm
    {
        private int suspectEditMode, officerEditMode;
        public ModifyCase()
        {
            InitializeComponent();
            suspectEditMode = 0;
            officerEditMode = 0;
        }

        private void editSuspectButton_Click(object sender, EventArgs e)
        {
            switch (suspectEditMode)
            {
                case 0:
                    suspectEditMode = 1;
                    suspectPictureBox.Enabled = true;
                    suspectFirstNameTextBox.Enabled = true;
                    suspectLastNameTextBox.Enabled = true;
                    suspectIDTextBox.Enabled = true;
                    suspectGenderComboBox.Enabled = true;
                    suspectBirthdayDatePicker.Enabled = true;
                    suspectBuildTextBox.Enabled = true;
                    suspectHairTextBox.Enabled = true;
                    suspectHeightTextBox.Enabled = true;
                    suspectEyesTextBox.Enabled = true;
                    suspectStatusComboBox.Enabled = true;
                    editSuspectButton.Text = "Done";
                    break;
                case 1:
                    suspectEditMode = 0;
                    suspectPictureBox.Enabled = false;
                    suspectFirstNameTextBox.Enabled = false;
                    suspectLastNameTextBox.Enabled = false;
                    suspectIDTextBox.Enabled = false;
                    suspectGenderComboBox.Enabled = false;
                    suspectBirthdayDatePicker.Enabled = false;
                    suspectBuildTextBox.Enabled = false;
                    suspectHairTextBox.Enabled = false;
                    suspectHeightTextBox.Enabled = false;
                    suspectEyesTextBox.Enabled = false;
                    suspectStatusComboBox.Enabled = false;
                    editSuspectButton.Text = "Edit Suspect Detail";
                    break;
            }
        }

        private void suspectPictureBox_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    suspectPictureBox.Image = Image.FromFile(dlg.FileName);
                    suspectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(suspectPictureBox);
                }
            }
        }

        private void officerPictureBox_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    officerPictureBox.Image = Image.FromFile(dlg.FileName);
                    officerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            switch (officerEditMode)
            {
                case 0:
                    officerEditMode = 1;
                    officerPictureBox.Enabled = true;
                    officerFirstNameTextBox.Enabled = true;
                    officerLastNameTextBox.Enabled = true;
                    officerIDTextBox.Enabled = true;
                    officerDepartmentComboBox.Enabled = true;
                    editOfficerButton.Text = "Done";
                    break;
                case 1:
                    officerEditMode = 0;
                    officerPictureBox.Enabled = false;
                    officerFirstNameTextBox.Enabled = false;
                    officerLastNameTextBox.Enabled = false;
                    officerIDTextBox.Enabled = false;
                    officerDepartmentComboBox.Enabled = false;
                    editOfficerButton.Text = "Change Officer";
                    break;
            }
        }
    }
}
