using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront
{
    public partial class QRCodeForMenuWindow : Form
    {
        public QRCodeForMenuWindow()
        {
            InitializeComponent();
        }

        public QRCodeForMenuWindow(Bitmap qrCodeImage)
        {
            InitializeComponent();

            qrCodePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            qrCodePictureBox.Image = qrCodeImage;
        }
    }
}
