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
            string Name = PositionNameTextBox.Text;
            string price = PositionPriceTextBox.Text;


            bool onlyLetters = Name.All(char.IsLetter);
            //bool isEmpty = string.IsNullOrEmpty(Name);

            bool isEmptyPrice = string.IsNullOrEmpty(price);
            bool isEmptyName = string.IsNullOrEmpty(Name);

            if (onlyLetters && Name.Length < 45 && !isEmptyPrice && !isEmptyName)
            {
                ErrorLabel.Visible = false;

                ChangeDataButton.Enabled = true;

            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Error Name";
                ChangeDataButton.Enabled = false;

            }
        }

        private void PositionPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            string price = PositionPriceTextBox.Text;
            string Name = PositionNameTextBox.Text;

            bool isEmptyPrice = string.IsNullOrEmpty(price);
            bool isEmptyName = string.IsNullOrEmpty(Name);


            bool onlyDigit = price.All(char.IsDigit);

            if (onlyDigit && price.Length > 0 && !isEmptyPrice && !isEmptyName)
            {
                //double digit = Convert.ToInt32(text); 
                //if(digit)
                ErrorLabel.Visible = false;

                ChangeDataButton.Enabled = true;

            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Error Price";
                ChangeDataButton.Enabled = false;

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
