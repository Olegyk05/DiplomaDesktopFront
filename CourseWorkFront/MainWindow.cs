using CourseWorkFront.Models;
using CourseWorkFront.UserControlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;

namespace CourseWorkFront
{


    public partial class MainWindow : Form
    {
        public static HttpClient httpClient = new HttpClient();

        private readonly string token;
        /*public static readonly string mainURL = "https://localhost:7248/api/";*/

        private OrdersWindow _ordersWindow;
        private PositionsWindow _dishesWindow;
        private ReviewsWindow _ReviewWindow;
        private SettingsWindow _settingsWindow;
        private CategoriesWindow _categoryWindow;

        public MainWindow(string token)
        {
            InitializeComponent();
            this.token = token;

            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue
                ("Bearer", token);
            mdiProp();
            
            HelloLabel.Text = "";
        }
        

        

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void OrdersButton_Click(object sender, EventArgs e)
        {
            if(_ordersWindow ==null)
            {
                
                _ordersWindow = new OrdersWindow();
                _ordersWindow.FormClosed += _ordersWindow_FormClosed;
                _ordersWindow.MdiParent = this;
                _ordersWindow.Dock = DockStyle.Fill;


                _ordersWindow.Show();
            }
            else
            {
                _ordersWindow.Activate();
            }
        }

        private void _ordersWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ordersWindow = null;
        }

        bool sideBarExpand = true;
        int ExpandingSpeed = 10;

        int minWidth = 71;
        int maxWidth = 300;
        private void SideBarTransitionTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                SideBarFlowLayoutPanel.Width -= ExpandingSpeed;
                if(SideBarFlowLayoutPanel.Width < minWidth)
                {
                    sideBarExpand = false;
                    SideBarTransitionTimer.Stop();

                   
                }
            }
            else
            {
                SideBarFlowLayoutPanel.Width += ExpandingSpeed;
                if( SideBarFlowLayoutPanel.Width > maxWidth)
                {
                    sideBarExpand = true;
                    SideBarTransitionTimer.Stop();

                }
            }
        }

        private void ExpandButtonPictureBox_Click(object sender, EventArgs e)
        {
            SideBarTransitionTimer.Start();
        }

        private void DishesButton_Click(object sender, EventArgs e)
        {
            if (_dishesWindow == null)
            {
                _dishesWindow = new PositionsWindow();
                _dishesWindow.FormClosed += _dishesWindow_FormClosed;
                _dishesWindow.MdiParent = this;
                _dishesWindow.Dock = DockStyle.Fill;
                _dishesWindow.Show();
            }
            else
            {
                _dishesWindow.Activate();
            }
        }

        private void _dishesWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dishesWindow = null;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {


            SetGuiDependingOnRole();
        }

        private void SetGuiDependingOnRole()
        {
            if(DataComponent.RoleName !="Admin")
            {
                CategoriesButton.Visible = false;
                ReviewsButton.Visible = false;
                SettingsButton.Visible = false;
            }
        }
        

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            if (_ReviewWindow == null)
            {
                _ReviewWindow = new ReviewsWindow();
                _ReviewWindow.FormClosed += _drinksWindow_FormClosed;
                _ReviewWindow.MdiParent = this;
                _ReviewWindow.Dock = DockStyle.Fill;
                _ReviewWindow.Show();
            }
            else
            {
                _ReviewWindow.Activate();
            }
        }

        private void _drinksWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ReviewWindow = null;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (_settingsWindow == null)
            {
                _settingsWindow = new SettingsWindow();
                _settingsWindow.FormClosed += _settingsWindow_FormClosed;
                _settingsWindow.MdiParent = this;
                _settingsWindow.Dock = DockStyle.Fill;
                _settingsWindow.Show();
            }
            else
            {
                _settingsWindow.Activate();
            }
        }

        private void _settingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _settingsWindow = null;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            
            

            if (_categoryWindow == null)
            {
                _categoryWindow = new CategoriesWindow();
                _categoryWindow.FormClosed += _categoriesWindow_FormClosed;
                _categoryWindow.MdiParent = this;
                _categoryWindow.Dock = DockStyle.Fill;
                _categoryWindow.Show();
            }
            else
            {
                _categoryWindow.Activate();
            }
        }

        private void _categoriesWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _categoryWindow = null;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
