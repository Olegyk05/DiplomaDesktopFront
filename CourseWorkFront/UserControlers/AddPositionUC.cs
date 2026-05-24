using CourseWorkFront.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CourseWorkFront.UserControlers
{
    public partial class AddPositionUC : UserControl
    {
        public string _positionName = null;



        public static Action UpdatePositionDataOnFlow;

        private int positionId = -1;


        private string _imageSource = @"..\..\ProgramData\Images\Positions\";



        private int _counter = 0;

        

        public AddPositionUC(PositionModel positionModel)
        {
            InitializeComponent();
            positionId = positionModel.Id;
            _positionName = positionModel.Name;

            PositionNameLabel.Text = _positionName;
            PositionPriceLabel.Text = positionModel.Price.ToString();

            SetPictrueForPosition();
        }

        public void SetPictrueForPosition()
        {
            if (File.Exists(_imageSource + _positionName + ".jpg"))
            {
                PositionPictureBox.Image = Image.FromFile(_imageSource + _positionName + ".jpg");
            }
            else
                PositionPictureBox.Image = Image.FromFile(_imageSource + "Default" + ".jpg");
        }

        public void SetCounterToZero()
        {
            _counter = 0;
            PositionCountLabel.Text = _counter.ToString();
        }
        private void AddCountButton_Click(object sender, EventArgs e)
        {
            _counter++;
            PositionCountLabel.Text = _counter.ToString();
            AddOrChangeOrderedPositionList();
        }

        private void MinusCountButton_Click(object sender, EventArgs e)
        {
            _counter--;

            if( _counter < 0 )
            {
                _counter++;
            }

            PositionCountLabel.Text = _counter.ToString();
            AddOrChangeOrderedPositionList();
        }

        private void AddOrChangeOrderedPositionList()
        {
            

            OrderedPositionDTO el = AddOrderWindow.OrderedPositions.FirstOrDefault(
                orderedPosition => orderedPosition.orderedPositionId == positionId);

            if (el != null)
            {
                el.orderedPositionCount = _counter;
            }
            else
            {
                AddOrderWindow.OrderedPositions.Add(new OrderedPositionDTO(positionId, _counter));
            }

            UpdatePositionDataOnFlow?.Invoke();

        }


        
    }
}
