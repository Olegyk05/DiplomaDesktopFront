using CourseWorkFront.DTO;
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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;



namespace CourseWorkFront
{
    public partial class AddOrderWindow : Form
    {
        public Action updateOrdersListAction;


        public static List<OrderedPositionDTO> OrderedPositions = new List<OrderedPositionDTO>();

        private delegate void updateDataOnFlowDelegate() ;

        private double _orderAmount = 0;

        private class OrderPostRespons
        {
            public int oderId;
            public double oderAmount;
            public int oderStatisticsId;
        }


        public AddOrderWindow()
        {
            InitializeComponent();


            
        }

        

        private void UpadateOrderedPositionsOnFlowPanel()
        {
            
            OrderedPositionFlowPanel.SuspendLayout();

            foreach (OrderedPositionDTO el in OrderedPositions)
            {
                UpdateOrCreatePositionControl(el);
            }

            OrderedPositionFlowPanel.ResumeLayout();
            VisualizeOrderAmount(); 
        }

        private void UpdateOrCreatePositionControl(OrderedPositionDTO epm)
        {
            
            PositionModel selectedPosition = DataComponent.PositionList.FirstOrDefault(x => x.Id == epm.orderedPositionId);
            if (selectedPosition == null) return; 


            OrderedPositionUC existingControl = null;
            foreach (Control control in OrderedPositionFlowPanel.Controls)
            {
                if (control is OrderedPositionUC uc && uc._positionName == selectedPosition.Name)
                {
                    existingControl = uc;
                    break;
                }
            }


            if (existingControl != null)
            {

                if (epm.orderedPositionCount <= 0)
                {
                    OrderedPositionFlowPanel.Controls.Remove(existingControl);
                    existingControl.Dispose(); 
                }
                else
                {

                    existingControl.SetAndUpdateCount(epm.orderedPositionCount);
                }
            }
            else
            {

                if (epm.orderedPositionCount > 0)
                {
                    var newUc = new OrderedPositionUC(
                        selectedPosition.Name,
                        epm.orderedPositionCount,
                        selectedPosition.Price
                    );
                    OrderedPositionFlowPanel.Controls.Add(newUc);
                }
            }
        }


        private void VisualizeOrderAmount()
        {
            _orderAmount = GetPositionsOforderAmount();

            SummaryPriceLabel.Text = _orderAmount.ToString();
        }

        private double GetPositionsOforderAmount()
        {
            double amount = 0;

            foreach (OrderedPositionDTO omp in OrderedPositions)
            {
                PositionModel position = DataComponent.PositionList.FirstOrDefault(x => x.Id == omp.orderedPositionId);
                amount += position.Price * omp.orderedPositionCount;
            }

            return amount;
        }

        
        private void addAllPositionsOnFlow()
        {


            AddPositionUC.UpdatePositionDataOnFlow = UpadateOrderedPositionsOnFlowPanel;

            foreach (PositionModel positionModel in DataComponent.PositionList)
            {
                //dish.updateDishesDataOnFlow = UpadateOrderedDishesOnFlowPanel;
                PositionsFlowPanel.Controls.Add(new AddPositionUC(positionModel));
            }

        }

        

        private void AddOrderWindow_Load(object sender, EventArgs e)
        {
            PositionsFlowPanel.Controls.Clear();
            addAllPositionsOnFlow();

            DataComponent.UpdatePositionsOnUI += addAllPositionsOnFlow;

        }

        private void AddOrderWindow_VisibleChanged(object sender, EventArgs e)
        {
            OrderedPositionFlowPanel.Controls.Clear();
            SetAllPositionCountersToZero();

            OrderedPositions.Clear();
        }

        private void SetAllPositionCountersToZero()
        {
            foreach(Control control in PositionsFlowPanel.Controls)
            {
                if(control is AddPositionUC addPositionUC)
                {
                    addPositionUC.SetCounterToZero();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void AddOrderButton_Click(object sender, EventArgs e)
        {

            
            if(_orderAmount>0)
            {
                await DataComponent.CreateNewOrder(OrderedPositions);


                updateOrdersListAction?.Invoke();
            }


            Hide();

        }


        private void SearchPositionByTextTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchPositionByTextTextBox.Text.Trim().ToLower();

            foreach (Control ctrl in PositionsFlowPanel.Controls)
            {
                if (ctrl is AddPositionUC uc)
                {
                    bool matches = uc._positionName.ToLower().StartsWith(searchText);
                    uc.Visible = matches;
                }
            }
        }
    }
}
