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

    
    public partial class CategoriesWindow : Form
    {
        private PositionUC _selectedPanelItem = null;

        private int _selectedPositionId = 0;

        public CategoriesWindow()
        {
            InitializeComponent();
        }

        private void CategoriesWindow_Load(object sender, EventArgs e)
        {
            ControlBox = false;

            addPositionsToPanel();
            addCategoriesToPanel();
        }

        public void addPositionsToPanel()
        {
            if (DataComponent.OrderList == null)
                return;

            PositionListFlowPanel.Controls.Clear();

            foreach (PositionModel position in DataComponent.PositionList)
            {
                PositionUC positionUC = new PositionUC(position);
                positionUC.Click += OnPanelItem_Click;
                
                PositionListFlowPanel.Controls.Add(positionUC);
            }
        }

        private void OnPanelItem_Click(object sender, EventArgs e)
        {


            PositionUC clickedControl = sender as PositionUC;
            if (clickedControl == null) return;



            if (clickedControl == null) return; 


            if (_selectedPanelItem is PositionUC oldSelected)
            {
                oldSelected.SetSelected(false);
            }

            _selectedPanelItem = clickedControl;
            if (_selectedPanelItem is PositionUC newSelected)
            {
                newSelected.SetSelected(true);
            }


            OnPositionSelected(_selectedPanelItem._positionId);
        }

        public void addCategoriesToPanel()
        {
            CategoriesListFlowPanel.Controls.Clear();

            foreach (var category in DataComponent.PositionCategoryList)
            {
                CheckBox cb = new CheckBox();
                cb.Text = category.Name;
                cb.Tag = category.Id; // Зберігаємо ID категорії в Tag
                cb.AutoSize = true;
                cb.Margin = new Padding(10, 10, 20, 10);

                // 🔥 Підписуємося на подію кліку по чекбоксу, щоб одразу зберігати зміни в базу/API
                cb.CheckedChanged += CategoryCheckBox_CheckedChanged;

                CategoriesListFlowPanel.Controls.Add(cb);
            }
        }
        private void OnPositionSelected(int positionId)
        {
            _selectedPositionId = positionId;


            ResetCheckBoxEvents(false);

           
            var linkedCategoryIds = DataComponent.CategoryLinksList
                .Where(link => link.LinkedPosition == positionId)
                .Select(link => link.LinkedCategory)
                .ToList();

            
            foreach (Control ctrl in CategoriesListFlowPanel.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    int categoryId = (int)cb.Tag;


                    cb.Checked = linkedCategoryIds.Contains(categoryId);
                }
            }


            ResetCheckBoxEvents(true);
        }


        private void ResetCheckBoxEvents(bool enable)
        {
            foreach (Control ctrl in CategoriesListFlowPanel.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    if (enable) cb.CheckedChanged += CategoryCheckBox_CheckedChanged;
                    else cb.CheckedChanged -= CategoryCheckBox_CheckedChanged;
                }
            }
        }

        private async void CategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedPositionId == -1) return; 

            CheckBox cb = sender as CheckBox;
            int categoryId = (int)cb.Tag;

            if (cb.Checked)
            {

                if (!DataComponent.CategoryLinksList.Any(l => l.LinkedPosition == _selectedPositionId && l.LinkedCategory == categoryId))
                {
                    await DataComponent.AddNewCategoryLinkToDB(categoryId, _selectedPositionId);


                }
            }
            else
            {


                var linkToRemove = DataComponent.CategoryLinksList.FirstOrDefault(l => l.LinkedPosition == _selectedPositionId && l.LinkedCategory == categoryId);

                if (linkToRemove != null)
                {

                    await DataComponent.DeleteCategoryLinkFromDB(linkToRemove.Id);

                    //DataComponent.CategoryLinksList.Remove(linkToRemove);
                }
            }
        }

        private void EditCategoriesListButton_Click(object sender, EventArgs e)
        {
            EditCategoriesListWindow editCategoriesListWindow = new EditCategoriesListWindow();
            EditCategoriesListWindow.UpdateCategoriestListInAnotherWindows += addCategoriesToPanel;
            editCategoriesListWindow.ShowDialog();
        }
    }
}
