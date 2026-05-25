using CourseWorkFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront.UserControlers
{
    public partial class ChangePositionData : Form
    {
        
/*        private DishModel dishData= null;
        private DrinkModel drinkData= null;*/

        //private string _ownUrl;
        private int _positionId;

        public ChangePositionData(int positionId,string PositionName,double PositionPrice)
        {
            InitializeComponent();

            PositionNameTextBox.Text = PositionName;
            PositionPriceTextBox.Text = PositionPrice.ToString();

            _positionId = positionId;
        }

        private void PositionNameTextBox_TextChanged(object sender, EventArgs e)
        {

            CheckCorrectDataInTextBoxes();


        }

        private void PositionPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCorrectDataInTextBoxes();
        }

        private void CheckCorrectDataInTextBoxes()
        {
            string name = PositionNameTextBox.Text.Trim();
            string priceText = PositionPriceTextBox.Text.Trim();


            bool isNameValid = !string.IsNullOrEmpty(name) &&
                                name.Length >= 2 &&
                                name.Length < 45 &&
                                name.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == '-');


            bool isPriceValid = double.TryParse(priceText, out double parsedPrice) && parsedPrice > 0;


            if (isNameValid && isPriceValid)
            {
                ErrorLabel.Visible = false;
                ChangeDataButton.Enabled = true;
            }
            else
            {
                ErrorLabel.Visible = true;
                ChangeDataButton.Enabled = false;


                if (!isNameValid)
                {
                    ErrorLabel.Text = "Error Name";
                }
                else if (!isPriceValid)
                {
                    ErrorLabel.Text = "Error Price";
                }
            }
        }

        private async void ChangeDataButton_Click(object sender, EventArgs e)
        {

            string _PriceText = PositionPriceTextBox.Text;
            string _Name = PositionNameTextBox.Text;

            int _Price = Convert.ToInt32(_PriceText);


            

            PositionModel NewPosition = new PositionModel
            {
                Id = _positionId,
                Name = _Name,
                Price = _Price,
            };

            await DataComponent.UpdatePositionDataInDB(NewPosition);

            Close();
        }
    }
}
