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
    public partial class EditCategoriesListWindow : Form
    {
        public static Action UpdateCategoriestListInAnotherWindows;

        public EditCategoriesListWindow()
        {
            InitializeComponent();

            UpdateCategoriesList();


        }

        private void UpdateCategoriesList()
        {
            CategoriesListBox.DataSource = null;
            CategoriesListBox.DataSource = DataComponent.PositionCategoryList;
            CategoriesListBox.DisplayMember = "Name";
            CategoriesListBox.ValueMember = "Id";

            UpdateCategoriestListInAnotherWindows?.Invoke();
        }

        

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesListBox.SelectedItem is PositionCategoryModel selectedCategory)
            {
                
                CategoryNameTextBox.Text = selectedCategory.Name;
            }
        }
        private async void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            string newName = CategoryNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Enter Category Name!!!");
                return;
            }

            
            var newCategory = new PositionCategoryModel {
                Id = 0,
                Name = newName 
            };

            await DataComponent.AddNewPositionCategoryInDB(newCategory);




            UpdateCategoriesList();
            CategoryNameTextBox.Clear();

        }

        private async void ChangeCategoryNameButton_Click(object sender, EventArgs e)
        {
            if (CategoriesListBox.SelectedItem is PositionCategoryModel selectedCategory)
            {
                string updatedName = CategoryNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(updatedName)) return;

                
                selectedCategory.Name = updatedName;



                await DataComponent.UpdatePositionCategoryDataInDB(selectedCategory);


                UpdateCategoriesList();

            }
        }

        private async void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (CategoriesListBox.SelectedItem is PositionCategoryModel selectedCategory)
            {
                

                await DataComponent.DeletePositionCategoryInDB(selectedCategory.Id);




                UpdateCategoriesList();
                CategoryNameTextBox.Clear();
            }
        }
    }
}
