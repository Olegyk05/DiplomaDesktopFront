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
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CourseWorkFront
{
    public partial class OrdersWindow : Form
    {


        public Func<Task> getAllOrdersAction;

        
        private Action AddOrderToPanelDependingOnRole;



        AddOrderWindow addOrderWindow = null;
        public OrdersWindow()
        {
            InitializeComponent();


            
        }

        private void OrdersWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            SetGuiDependingOnRole();
            AddOrderToPanelDependingOnRole();
            
            
        }

        private void SetGuiDependingOnRole()
        {
            if (DataComponent.RoleName != "Admin")
            {
                CashierModeCheckBox.Visible = false;

                AddOrderToPanelDependingOnRole = addOrdersToPanelAsCashier;
            }
            else
            {
                AddOrderToPanelDependingOnRole = addOrdersToPanelAsAdmin;
            }
        }

        public void addOrdersToPanelAsAdmin()
        {
            if (DataComponent.OrderList == null)
                return;

            OrderListFlowPanel.Controls.Clear();

            foreach (OrderModel order in DataComponent.OrderList) 
            {
                OrderUC orderUC = new OrderUC(order);

                OrderListFlowPanel.Controls.Add(orderUC);
            }
        }

        public void addOrdersToPanelAsCashier()
        {
            if (DataComponent.OrderList == null)
                return;

            OrderListFlowPanel.Controls.Clear();

            foreach (OrderModel order in DataComponent.OrderList.Where(x=>x.CreationTime.Date == DateTime.Today).ToList())
            {
                OrderUC orderUC = new OrderUC(order);

                OrderListFlowPanel.Controls.Add(orderUC);
            }
        }


        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            if(addOrderWindow == null)
            {
                addOrderWindow = new AddOrderWindow();
                addOrderWindow.updateOrdersListAction = AddOrderToPanelDependingOnRole;
            }
            addOrderWindow.Show();

        }

        private void SearchTextTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextTextBox.Text.Trim().ToLower();

            foreach (Control ctrl in OrderListFlowPanel.Controls)
            {
                if (ctrl is OrderUC uc)
                {
                    
                    bool matches = uc._orderId.ToString().ToLower().StartsWith(searchText);
                    uc.Visible = matches;
                }
            }
        }

        private void UpdateOrdersButton_Click(object sender, EventArgs e)
        {
            
            AddOrderToPanelDependingOnRole.Invoke();
        }

        private void CashierModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CashierModeCheckBox.Checked)
            {
                addOrdersToPanelAsCashier();
            }
            else
            {
                addOrdersToPanelAsAdmin();

                foreach(Control ctrl in OrderListFlowPanel.Controls)
                {
                    ctrl.Enabled = true;
                }
            }
        }
    }
}
