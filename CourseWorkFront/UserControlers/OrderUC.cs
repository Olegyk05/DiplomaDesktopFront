using CourseWorkFront.Models;
using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront.UserControlers
{
    public partial class OrderUC : UserControl
    {
        public int _orderId = -1;
        public int _orderStatus = -1;

        private string folderPath = @"..\..\ProgramData\Receipts\";
        public OrderUC(OrderModel order)
        {
            InitializeComponent();

            _orderId = order.Id;
            _orderStatus = order.Status;

            OrderNumberLabel.Text = "№" + order.Id.ToString();
            OrderAmountLabel.Text = order.Amount.ToString();
            OrderStatusLabel.Text = DataComponent.OrderStatusList.FirstOrDefault(x=>x.Id == order.Status).Name;
            SetOrderStatusColor();
            SetButtons();

        }

        private async void  DeleteButton_Click(object sender, EventArgs e)
        {
            if(await DataComponent.DeleteOrderFromDB(_orderId))
            {
                Visible = false;
            }
        }

        private void ViewDetailButton_Click(object sender, EventArgs e)
        {
            FullOrderWindow fullOrderWindow = new FullOrderWindow(_orderId);
            fullOrderWindow.ShowDialog();
        }

        private void SetOrderStatusColor()
        {
            if(OrderStatusLabel.Text == "Waiting for Payment")
            {
                OrderStatusLabel.ForeColor = Color.Purple;
            }
            else if(OrderStatusLabel.Text == "Paid")
            {
                OrderStatusLabel.ForeColor = Color.Cyan;
            }
            else if(OrderStatusLabel.Text == "Completed")
            {
                OrderStatusLabel.ForeColor = Color.Green;
            }
        }

        private void SetButtons()
        {
            if (OrderStatusLabel.Text == "Waiting for Payment")
            {
                ComplateButton.Enabled = false;
            }
        }

        private async void PaymentButton_Click(object sender, EventArgs e)
        {
            if(await DataComponent.UpdateOrderStatusInDB(_orderId, _orderStatus))
            {
                _orderStatus++;
                OrderStatusLabel.Text = "Paid";

                SetOrderStatusColor();

                ComplateButton.Enabled = true;
                PaymentButton.Enabled = false;

                GenerateReceipt();
            }
            
        }

        private async void ComplateButton_Click(object sender, EventArgs e)
        {
            await DataComponent.UpdateOrderStatusInDB(_orderId, _orderStatus);
            await DataComponent.UpdateOrderCompletionTimeInDB(_orderId);

            _orderStatus++;

            OrderStatusLabel.Text = "Completed";
            SetOrderStatusColor();

            



            Enabled = false;
        }

        private void GenerateReceipt()
        {
            
            var orderedItems = DataComponent.OrderedPositionsList
                                .Where(x => x.SelectedOrder == _orderId)
                                .ToList();

            
            int receiptWidth = 300;
            int receiptHeight = 380 + (orderedItems.Count * 20);

            
            using (Bitmap bitmap = new Bitmap(receiptWidth, receiptHeight))
            {
                
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    
                    g.Clear(Color.White);


                    Font fontTitle = new Font("Arial", 14, FontStyle.Bold);
                    Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
                    Font fontRegular = new Font("Arial", 10, FontStyle.Regular);

                    Brush brush = Brushes.Black;

                    int startX = 10;
                    int startY = 10;
                    int offset = 20;

                    
                    g.DrawString("RESTAURANT", fontTitle, brush, startX + 40, startY);
                    startY += offset + 5;
                    g.DrawString("\"DINECORE\"", fontTitle, brush, startX + 40, startY);
                    startY += offset + 5;
                    g.DrawString("Welcome!", fontRegular, brush, startX + 60, startY);
                    startY += offset;

                    g.DrawString("--------------------------------------------------", fontRegular, brush, startX, startY);
                    startY += offset;

                    g.DrawString($"Receipt №: {_orderId}", fontHeader, brush, startX, startY);
                    startY += offset;
                    g.DrawString($"Date: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}", fontRegular, brush, startX, startY);
                    startY += offset;
                    /*g.DrawString("Cashier: Administrator", fontRegular, brush, startX, startY);
                    startY += offset;*/

                    g.DrawString("--------------------------------------------------", fontRegular, brush, startX, startY);
                    startY += offset;


                    g.DrawString("Name", fontHeader, brush, startX, startY);
                    g.DrawString("count", fontHeader, brush, startX + 140, startY);
                    g.DrawString("Price", fontHeader, brush, startX + 220, startY);
                    startY += offset;

                    double totalSum = 0;


                    foreach (var orderedItem in orderedItems)
                    {
                        var positionDetails = DataComponent.PositionList
                                                .FirstOrDefault(p => p.Id == orderedItem.SelectedPosition);

                        if (positionDetails != null)
                        {
                            double itemTotalPrice = positionDetails.Price * orderedItem.Count;
                            totalSum += itemTotalPrice;

                            g.DrawString(positionDetails.Name, fontRegular, brush, startX, startY);
                            g.DrawString(orderedItem.Count.ToString(), fontRegular, brush, startX + 150, startY);
                            g.DrawString($"{itemTotalPrice:F2} ₴", fontRegular, brush, startX + 220, startY);

                            startY += offset;
                        }
                    }

                    g.DrawString("--------------------------------------------------", fontRegular, brush, startX, startY);
                    startY += offset;


                    g.DrawString("SUMMARY:", fontHeader, brush, startX, startY);
                    g.DrawString($"{totalSum:F2} ₴", fontHeader, brush, startX + 220, startY);
                    startY += offset + 15;


                    g.DrawString("Please, leave a review", fontHeader, brush, startX + 25, startY);
                    startY += offset - 5;
                    g.DrawString("about our service!", fontHeader, brush, startX + 30, startY);
                    startY += offset + 10;

                    
                    string reviewUrl = $"http://localhost:4200/review/{_orderId}";

                    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                    {
                        using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(reviewUrl, QRCodeGenerator.ECCLevel.M))
                        {
                            using (QRCode qrCode = new QRCode(qrCodeData))
                            {
                                using (Bitmap qrCodeImage = qrCode.GetGraphic(3, Color.Black, Color.White, true))
                                {
                                    int qrX = startX + 50;
                                    g.DrawImage(qrCodeImage, new Point(qrX, startY));
                                    startY += qrCodeImage.Height + 15;
                                }
                            }
                        }
                    }


                    g.DrawString("Thank you for visiting!", fontRegular, brush, startX + 65, startY);
                }


                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }


                string fileName = $"Receipt_{_orderId}.png";
                string fullPath = Path.Combine(folderPath, fileName);


                bitmap.Save(fullPath, ImageFormat.Png);

            }
        }

        private void OrderUC_Load(object sender, EventArgs e)
        {
            SetGuiDependingOnRole();

            if (DataComponent.OrderList.FirstOrDefault(x=>x.Id==_orderId).Status==4)
            {
                PaymentButton.Enabled = false;
                ComplateButton.Enabled = false;

                if (DataComponent.RoleName != "Admin")
                    Enabled = false;

            }
        }

        private void SetGuiDependingOnRole()
        {
            if (DataComponent.RoleName != "Admin")
            {
/*                DeleteButton.Enabled = false;
                DeleteButton.Visible = false;*/

            }
        }
    }
}
