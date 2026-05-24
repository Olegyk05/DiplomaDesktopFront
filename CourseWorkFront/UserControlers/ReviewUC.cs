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

namespace CourseWorkFront.UserControlers
{
    public partial class ReviewUC : UserControl
    {
        ReviewModel _reviewModel;
        public ReviewUC()
        {
            InitializeComponent();
        }
        public ReviewUC(ReviewModel model)
        {
            InitializeComponent();

            _reviewModel = model;

            ServiceRatingLabel.Text = model.ServiceRating.ToString();
            TasteRatingPanel.Text = model.TasteRating.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullReviewWindow fullOrderWindow = new FullReviewWindow(_reviewModel.Id);
            fullOrderWindow.ShowDialog();
        }
    }
}
