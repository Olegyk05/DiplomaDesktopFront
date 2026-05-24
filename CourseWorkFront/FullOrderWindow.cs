using CourseWorkFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront.UserControlers
{

    public partial class FullOrderWindow : Form
    {
        public List<FullOrderModel> _fullOrderList = new List<FullOrderModel>();

        int _orderId = -1;

        private string _ownURL = "FullOder";
        public FullOrderWindow(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            OrderNumberLabel.Text += orderId.ToString();
        }

        private async void FullOrderWindow_Load(object sender, EventArgs e)
        {



            DisplayFullOrders();

        }

        private void DisplayFullOrders()
        {
            foreach( FullOrderModel model in DataComponent.GetFullOrder(_orderId))
            {
                FullOrderFlowPanel.Controls.Add(new FullOrderUC(model));
            }
        }
    }
}
