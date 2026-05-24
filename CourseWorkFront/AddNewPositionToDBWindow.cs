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

namespace CourseWorkFront
{
    public partial class AddNewPositionToDBWindow : Form
    {
        public AddNewPositionToDBWindow()
        {
            InitializeComponent();
        }

        private void PositionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string Name = PositionNameTextBox.Text;
            string price = PositionPriceTextBox.Text;


            bool onlyLetters = Name.All(char.IsLetter);
            //bool isEmpty = string.IsNullOrEmpty(Name);

            bool isEmptyPrice = string.IsNullOrEmpty(price);
            bool isEmptyName = string.IsNullOrEmpty(Name);

            if (onlyLetters && Name.Length<45&& !isEmptyPrice && !isEmptyName)
            {
                ErrorLabel.Visible = false;


                AddDrinkButton.Enabled = true;
            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Error Name";

                AddDrinkButton.Enabled = false;
            }
        }

        private void PositionPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            string price = PositionPriceTextBox.Text;
            string Name = PositionNameTextBox.Text;

            bool isEmptyPrice = string.IsNullOrEmpty(price);
            bool isEmptyName = string.IsNullOrEmpty(Name);


            bool onlyDigit = price.All(char.IsDigit);

            if (onlyDigit && price.Length > 0 && !isEmptyPrice&& !isEmptyName)
            {

                ErrorLabel.Visible = false;


                AddDrinkButton.Enabled = true;
            }
            else
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Error Price";

                AddDrinkButton.Enabled = false;
            }
        }

        private async void AddDishButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewPositionToDBWindow_Load(object sender, EventArgs e)
        {

            AddDrinkButton.Enabled = false;
        }

        private async void AddDrinkButton_Click(object sender, EventArgs e)
        {
            string Name = PositionNameTextBox.Text;

            int price = Convert.ToInt32(PositionPriceTextBox.Text);

            if (price < 0)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Error price";
                return;
            }

            DataComponent.AddNewPositionToDB(Name, price);
            
            Close();
        }
    }
}
