using CourseWorkFront.Models;
using CourseWorkFront.UserControlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront
{
    public partial class PositionsWindow : Form
    {
        


        public PositionsWindow()
        {
            InitializeComponent();

            


        }


        private void DishesWindow_Load(object sender, EventArgs e)
        {
            SetGuiDependingOnRole();
            addDishesToPanel();
            AddCategories();


            EditCategoriesListWindow.UpdateCategoriestListInAnotherWindows += AddCategories;
        }

        private void SetGuiDependingOnRole()
        {
            if (DataComponent.RoleName != "Admin")
            {
                AddPositionButton.Visible = false;


            }


        }
        private void addDishesToPanel()
        {
            if (DataComponent.PositionList == null || DataComponent.PositionList.Count==0)
                return;

            foreach (PositionUC ctrl in DishesListFlowPanel.Controls.OfType<PositionUC>())
            {
                ctrl.Dispose();
            }

            DishesListFlowPanel.Controls.Clear();

            foreach (PositionModel dish in DataComponent.PositionList)
            {
                PositionUC newPositionUC = new PositionUC(dish);
                newPositionUC.AfterUpdateAction = addDishesToPanel;

                DishesListFlowPanel.Controls.Add(newPositionUC);
            }
        }

        private void AddCategories()
        {
            foreach (CheckBox cb in categoriesFlowPanel.Controls.OfType<CheckBox>())
            {
                cb.Dispose();
            }

            categoriesFlowPanel.Controls.Clear();


            foreach (PositionCategoryModel positionCategoryModel in DataComponent.PositionCategoryList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = positionCategoryModel.Name;
                cb.Tag = positionCategoryModel.Id; 
                cb.AutoSize = true;


                cb.CheckedChanged += CategoryFilter_CheckedChanged;

                categoriesFlowPanel.Controls.Add(cb);


            }


        }
        private void SearchDishByTextTextBox_TextChanged(object sender, EventArgs e)
        {



            ApplyCombinedFilter();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = OrderByComboBox.SelectedIndex;

            switch(selectedIndex)
            {
                case 0:
                    SortListByABC();
                    break;
                case 1:
                    SordListByPrice();
                    break;

            }
            
            ApplySortingToPanel();
        }

        private void ApplySortingToPanel()
        {
            DishesListFlowPanel.SuspendLayout();

            
            var sortedOrder = DataComponent.PositionList
                .Select((pos, index) => new { pos.Id, index })
                .ToDictionary(x => x.Id, x => x.index);

            
            foreach (Control ctrl in DishesListFlowPanel.Controls)
            {
                if (ctrl is PositionUC uc)
                {

                    if (sortedOrder.ContainsKey(uc._positionId))
                    {
                        int newIndex = sortedOrder[uc._positionId];

                        
                        DishesListFlowPanel.Controls.SetChildIndex(uc, newIndex);
                    }
                }
            }

            DishesListFlowPanel.ResumeLayout();
        }

        private void SortListByABC()
        {
            
            DataComponent.PositionList = DataComponent.PositionList.OrderBy(x=>x.Name).ToList();
            
        }
        private void SordListByPrice()
        {
            
            DataComponent.PositionList = DataComponent.PositionList.OrderBy(x => x.Price).ToList();
            
        }

        private void UpdateDishesButton_Click(object sender, EventArgs e)
        {


            foreach (Control ctrl in DishesListFlowPanel.Controls)
            {
                ctrl.Dispose();
            }

            DishesListFlowPanel.Controls.Clear();

            foreach (PositionModel position in DataComponent.PositionList)
            {
                DishesListFlowPanel.Controls.Add(new PositionUC(position));
            }
        }

        private void CategoryFilter_CheckedChanged(object sender, EventArgs e)
        {
            


            ApplyCombinedFilter();
        }

        private void ApplyCombinedFilter()
        {
            
            string searchText = SearchDishByTextTextBox.Text.Trim().ToLower();

            
            List<int> selectedCategoryIds = new List<int>();
            foreach (Control ctrl in categoriesFlowPanel.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    selectedCategoryIds.Add((int)cb.Tag);
                }
            }

            

            DishesListFlowPanel.SuspendLayout();

            foreach (Control ctrl in DishesListFlowPanel.Controls)
            {
                if (ctrl is PositionUC uc)
                {
                    
                    bool matchesSearch = string.IsNullOrEmpty(searchText) ||
                                         uc._positionName.ToLower().StartsWith(searchText);

                    
                    bool matchesCategory = selectedCategoryIds.Count == 0 ||
                                           DataComponent.CategoryLinksList.Any(link =>
                                               link.LinkedPosition == uc._positionId &&
                                               selectedCategoryIds.Contains(link.LinkedCategory)
                                           );

                    
                    uc.Visible = matchesSearch && matchesCategory;
                }
            }

            ApplySortingToPanel();

            DishesListFlowPanel.ResumeLayout();
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            AddNewPositionToDBWindow addNewPositionToDBWindow = new AddNewPositionToDBWindow();
            addNewPositionToDBWindow.ShowDialog();
        }
    }
}
