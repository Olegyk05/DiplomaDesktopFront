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
    public partial class SelectOrderReviewUC : UserControl
    {
        public int _OrderId;
        public DateTime _CompletionTime;

        public SelectOrderReviewUC()
        {
            InitializeComponent();
        }

        public SelectOrderReviewUC(OrderModel orderModel)
        {
            InitializeComponent();

            _OrderId = orderModel.Id;
            _CompletionTime = orderModel.CompletionTime;

            OrderNumberLabel.Text = _OrderId.ToString();
            OrderCompletionTimeLabel.Text = _CompletionTime.ToString();



        }


        public void SetSelected(bool isSelected)
        {
            if (isSelected)
            {
                BackColor = Color.LightBlue; // Колір виділеного елемента
                                                  // Або можна змінити BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BackColor = SystemColors.Control; // Повертаємо стандартний колір
                                                       // BorderStyle = BorderStyle.None;
            }
        }
    }
}
