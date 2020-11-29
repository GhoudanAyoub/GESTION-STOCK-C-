using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECTOMAR
{
    public partial class firstCustomControl1 : UserControl
    {
        public firstCustomControl1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;
        private void loadNextImage()
        {
            if (imageNumber == 15)
            {
                imageNumber = 1;
            }
            SlidePic.ImageLocation = String.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }
    }
}

