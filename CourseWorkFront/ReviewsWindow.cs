using CourseWorkFront.Models;
using CourseWorkFront.UserControlers;
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
    public partial class ReviewsWindow : Form
    {

        private SelectOrderReviewUC _selectedPanelItem = null;

        public ReviewsWindow()
        {
            InitializeComponent();
        }

        private void OnPanelItem_Click(object sender, EventArgs e)
        {

            
            SelectOrderReviewUC clickedControl = sender as SelectOrderReviewUC;
            if (clickedControl == null) return;

           

            if (clickedControl == null) return; 

 
            if (_selectedPanelItem is SelectOrderReviewUC oldSelected)
            {
                oldSelected.SetSelected(false);
            }


            _selectedPanelItem = clickedControl;
            if (_selectedPanelItem is SelectOrderReviewUC newSelected)
            {
                newSelected.SetSelected(true);
            }

            
            MyCustomFunction(clickedControl);
        }

       
        private void MyCustomFunction(Control selectedControl)
        {


            if (selectedControl is SelectOrderReviewUC uc)
            {
                foreach(Control control in ReviewFlowPanel.Controls)
                {
                    control.Dispose();
                }

                ReviewFlowPanel.Controls.Clear();

                foreach(ReviewModel review in DataComponent.ReviewsList)
                {
                    if(review.LinkedOrder == _selectedPanelItem._OrderId)
                    {
                        

                        ReviewFlowPanel.Controls.Add(new ReviewUC(review));
                    }
                }


            }

        }


        public void addOrdersToPanel()
        {
            if (DataComponent.OrderList == null)
                return;

            OrderListFlowPanel.Controls.Clear();

            foreach (OrderModel order in DataComponent.OrderList)
            {
                SelectOrderReviewUC orderUC = new SelectOrderReviewUC(order);
                orderUC.Click += OnPanelItem_Click;
                
                OrderListFlowPanel.Controls.Add(orderUC);
            }
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            addOrdersToPanel();
        }
    }
}
