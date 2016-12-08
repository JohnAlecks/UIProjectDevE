using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UIProject
{
    public partial class AddCase : DevExpress.XtraEditors.XtraForm
    {
        public AddCase()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
