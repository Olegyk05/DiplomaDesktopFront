using CourseWorkFront.Models;
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
    public partial class FullReviewWindow : Form
    {
        public FullReviewWindow()
        {
            InitializeComponent();
        }
        public FullReviewWindow(int ReviewId)
        {
            InitializeComponent();

            ReviewModel model = DataComponent.ReviewsList.FirstOrDefault(el=> el.Id == ReviewId);

            ServiceRatingLabel.Text = model.ServiceRating.ToString();
            TasteRatingPanel.Text = model.TasteRating.ToString();

            MessageTextBox.Text = model.Text;

        }

        private void TasteRatingPanel_Click(object sender, EventArgs e)
        {

        }

        private void FullReviewWindow_Shown(object sender, EventArgs e)
        {
            MessageTextBox.SelectionLength = 0;
        }
    }
}
