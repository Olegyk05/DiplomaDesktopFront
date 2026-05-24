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
    public partial class OrderedPositionUC : UserControl
    {
        public string _positionName;
        public int _positionCount;
        public double _positionPrice;
        public OrderedPositionUC(string positionName,int positionCount,double PositionPrice)
        {
            InitializeComponent();

            _positionName = positionName;
            _positionCount = positionCount;
            _positionPrice = PositionPrice;

            PositionNameLabel.Text = positionName;
            PositionCountLabel.Text = positionCount.ToString();
            PositionPriceLabel.Text = PositionPrice.ToString();
        }

        public void SetAndUpdateCount( int positionCount)
        {
            _positionCount = positionCount;
            PositionCountLabel.Text = positionCount.ToString();
        }

    
    }
}
