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
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    suspectPictureBox.Image = Image.FromFile(dlg.FileName);
                    suspectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //PictureBox PictureBox1 = new PictureBox();
                    //PictureBox1.Image = new Bitmap(dlg.FileName);

                    // Add the new control to its parent's controls collection
                    this.Controls.Add(suspectPictureBox);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddCase_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // save here 

            this.Close();
        }
    }
}
