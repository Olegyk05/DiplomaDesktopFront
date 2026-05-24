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
    public partial class FullOrderUC : UserControl
    {
        public FullOrderUC(FullOrderModel fullOrderModel)
        {
            InitializeComponent();

            //PositionTypeLabel.Text = fullOrderModel.itemType;
            PositionNameLabel.Text = fullOrderModel.PositionName;
            PositionCountLabel.Text = fullOrderModel.PositionCount.ToString();
            PositionPriceLabel.Text = fullOrderModel.PositionPrice.ToString();
        }
    }
}
