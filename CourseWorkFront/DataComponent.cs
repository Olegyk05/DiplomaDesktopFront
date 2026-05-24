using CourseWorkFront.DTO;
using CourseWorkFront.Models;
using CourseWorkFront.UserControlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourseWorkFront
{
    static class DataComponent
    {
        public static HttpClient httpClient = new HttpClient();

        private static string token;
        public static string RoleName;
        public static readonly string mainURL = "https://localhost:7248/api/";

        public static readonly string OrderURL = "Orders";
        public static readonly string OrderStatusURL = "OrderStatus";
        public static readonly string PositionsURL = "Positions";
        public static readonly string OrderedPositionsURL = "OrderedPosition";
        public static readonly string ReviewsURL = "Review";
        public static readonly string CategoryLinksURL = "CategoryLinks";
        public static readonly string PositionCategoryURL = "PositionCategories";
        public static readonly string SignUpUserURL = "Auth/register";
        public static readonly string UserTypeURL = "UserType";


        public static List<OrderModel> OrderList = new List<OrderModel>();
        public static List<OrderStatusModel> OrderStatusList = new List<OrderStatusModel>();
        public static List<PositionModel> PositionList = new List<PositionModel>();
        public static List<OrderedPositionModel> OrderedPositionsList = new List<OrderedPositionModel>();
        public static List<ReviewModel> ReviewsList = new List<ReviewModel>();
        public static List<CategoryLinksModel> CategoryLinksList = new List<CategoryLinksModel>();
        public static List<PositionCategoryModel> PositionCategoryList = new List<PositionCategoryModel>();
        public static List<UserTypeModel> UserTypeList = new List<UserTypeModel>();





        public static void SetToken(string InputToken)
        {
            token = InputToken;

            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue
                ("Bearer", token);
        }
        public static void SetRole(string _RoleName)
        {
            RoleName = _RoleName;
        }
        public static async void GetAllDataFromDB()
        {
            await GetAllOrdersFromDB();
            await GetAllPositionsFromDB();
            await GetAllOrderedPositionFromDB();
            await GetAllOrderStatusFromDB();
            await GetAllReviewsFromDB();
            await GetAllCategoryLinksFromBD();
            await GeyAllPositionCategoriesFromBD();
            await GetAllUserTypesFromBD();

            await UpdateOrdersAmount();
        }

        public static async void GetAllDataFromDBAsUser()
        {
            await GetAllOrdersFromDB();
            await GetAllPositionsFromDB();
            await GetAllOrderedPositionFromDB();
            await GetAllOrderStatusFromDB();
            await GetAllCategoryLinksFromBD();
            await GeyAllPositionCategoriesFromBD();

            await UpdateOrdersAmount();

        }

        
        private static async Task GetAllOrdersFromDB()
        {
            string url = mainURL + OrderURL;

            PositionList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                OrderList = JsonConvert.DeserializeObject<List<OrderModel>>(result);

                OrderList = OrderList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Order Positions: " + ex.Message);
            }

            
        }
        private static async Task UpdateOrdersAmount()
        {
            foreach (var order in OrderList)
            {
                UpdateOrderAmount(order);
            }
            
        }

        public static void UpdateOrderAmount(OrderModel order)
        {
            double totalAmount = 0;

            foreach (var orderedPosition in OrderedPositionsList)
            {
                if (order.Id == orderedPosition.SelectedOrder)
                {
                    totalAmount += PositionList.FirstOrDefault(position => position.Id == orderedPosition.SelectedPosition).Price * orderedPosition.Count;
                }
            }

            order.Amount = totalAmount;
        }
        private static async Task GetAllPositionsFromDB()
        {
            string url = mainURL + PositionsURL;

            PositionList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                PositionList = JsonConvert.DeserializeObject<List<PositionModel>>(result);

                PositionList = PositionList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Positions: " + ex.Message);
            }
        }

        private static async Task GetAllOrderedPositionFromDB()
        {
            string url = mainURL + OrderedPositionsURL;

            OrderedPositionsList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                OrderedPositionsList = JsonConvert.DeserializeObject<List<OrderedPositionModel>>(result);

                OrderedPositionsList = OrderedPositionsList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Orders: " + ex.Message);
            }
        }

        private static async Task GetAllOrderStatusFromDB()
        {
            string url = mainURL + OrderStatusURL;

            OrderStatusList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                OrderStatusList = JsonConvert.DeserializeObject<List<OrderStatusModel>>(result);

                OrderStatusList = OrderStatusList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Orders: " + ex.Message);
            }
        }

        private static async Task GetAllReviewsFromDB()
        {
            string url = mainURL + ReviewsURL;

            ReviewsList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                ReviewsList = JsonConvert.DeserializeObject<List<ReviewModel>>(result);

                ReviewsList = ReviewsList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Reviews: " + ex.Message);
            }
        }

        private static async Task GetAllCategoryLinksFromBD()
        {
            string url = mainURL + CategoryLinksURL;

            CategoryLinksList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                CategoryLinksList = JsonConvert.DeserializeObject<List<CategoryLinksModel>>(result);

                CategoryLinksList = CategoryLinksList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Category Links: " + ex.Message);
            }
        }

        private static async Task GeyAllPositionCategoriesFromBD()
        {
            string url = mainURL + PositionCategoryURL;

            PositionCategoryList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                PositionCategoryList = JsonConvert.DeserializeObject<List<PositionCategoryModel>>(result);

                PositionCategoryList = PositionCategoryList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Position Category: " + ex.Message);
            }
        }

        private static async Task GetAllUserTypesFromBD()
        {
            string url = mainURL + UserTypeURL;

            UserTypeList.Clear();

            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string result = await response.Content.ReadAsStringAsync();

                UserTypeList = JsonConvert.DeserializeObject<List<UserTypeModel>>(result);

                UserTypeList = UserTypeList.OrderByDescending(x => x.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting Position Category: " + ex.Message);
            }
        }
        public static  List<FullOrderModel> GetFullOrder(int OrderId)
        {


            List<FullOrderModel> Result = (from op in OrderedPositionsList
                                           where op.SelectedOrder == OrderId
                                           join position in PositionList on op.SelectedPosition equals position.Id
                                           select new FullOrderModel
                                           {
                                               PositionName = position.Name,
                                               PositionPrice = position.Price,
                                               PositionCount = op.Count
                                           }).ToList();



            return Result;
        }

        public static async void AddNewPositionToDB(string _Name,double _Price)
        {
            PositionModel PositionData = new PositionModel
            {
                Id = 0,
                Name = _Name,
                Price = _Price
            };

            string URL = mainURL + PositionsURL;

            string jsonData = JsonConvert.SerializeObject(PositionData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    PositionModel createdPosition = JsonConvert.DeserializeObject<PositionModel>(responseContent);
                    if (createdPosition != null)
                    {
                        PositionList.Add(createdPosition);
                    }
                    MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static async Task CreateNewOrder(List<OrderedPositionDTO> _orderedPositions)
        {
            try
            {
                // 1. Спочатку створюємо саме замовлення і чекаємо на його ID від сервера
                int newOrderId = await CreateNewOrderInDb();

                if (newOrderId > 0)
                {
                    // 2. Якщо ID отримано, відправляємо всі позиції, прив'язані до цього ID
                    await AddAllOrderedPositions(_orderedPositions, newOrderId);
                    MessageBox.Show($"Замовлення №{newOrderId} успішно створено!");
                }
                else
                {
                    MessageBox.Show("Не вдалося створити замовлення на сервері.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні замовлення: {ex.Message}");
            }
        }

        private static async Task<int> CreateNewOrderInDb()
        {
            OrderDTO dataToSend = new OrderDTO
            {
                Id = 0,
                CreationTime = DateTime.Now,
                CompletionTime = DateTime.Now,
                Status = 2
            };

            string URL = mainURL + OrderURL;

            string json = JsonConvert.SerializeObject(dataToSend);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(URL, content);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                // Припускаємо, що сервер повертає просто ID (наприклад, 42) або об'єкт замовлення
                // Якщо сервер повертає JSON-об'єкт { "id": 42 }, то десеріалізуйте його.
                // Якщо сервер повертає просто цифру, то int.Parse:
                OrderModel createdOrder = JsonConvert.DeserializeObject<OrderModel>(responseContent);

                OrderList.Add(createdOrder);

                return createdOrder.Id;
            }

            return 0;


        }
        private static async Task AddAllOrderedPositions(List<OrderedPositionDTO> positions, int orderId)
        {

            List<OrderedPositionModel> modelsToSend = positions.Select(p => new OrderedPositionModel
            {
                SelectedPosition = p.orderedPositionId,
                Count = p.orderedPositionCount,
                SelectedOrder = orderId // Прив'язуємо до новоствореного замовлення
            }).ToList();

            string URL = mainURL + OrderedPositionsURL;

            foreach (OrderedPositionModel model in modelsToSend)
            {
                string json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Сервер повернув помилку при додаванні позицій: {response.StatusCode}");
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    
                    OrderedPositionModel createdOrderedPosition = JsonConvert.DeserializeObject<OrderedPositionModel>(responseContent);

                    OrderedPositionsList.Add(createdOrderedPosition);
                }

            }

            UpdateOrderAmount(OrderList.FirstOrDefault(el=>el.Id == orderId));
            OrderList = OrderList.OrderByDescending(x => x.Id).ToList();

        }

        public static async Task<bool> DeletePositionFromDB(int PositionId)
        {
            bool Result = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Position?", "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {

                string URL = mainURL + PositionsURL + "/" + PositionId.ToString();
                try
                {

                    HttpResponseMessage response = await httpClient.DeleteAsync(URL);
                    //response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        PositionList.Remove(PositionList.FirstOrDefault(x => x.Id == PositionId));
                        
                        MessageBox.Show("Your Position deleted");
                        Result = true;
                    }
                    else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {

                        string jsonResponse = await response.Content.ReadAsStringAsync();


                        var errorObj = JsonConvert.DeserializeAnonymousType(jsonResponse, new { message = "" });


                        //MessageBox.Show(errorObj.message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show(errorObj.message);
                    }
                    else
                    {
                        MessageBox.Show($"Error when deleting: {response.StatusCode}");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

            return Result;
        }
    
        public static async Task UpdatePositionDataInDB(PositionModel Position)
        {
            string URL = mainURL + PositionsURL + "/"+ Position.Id.ToString();

            string jsonData = JsonConvert.SerializeObject(Position);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {

                HttpResponseMessage response = await httpClient.PutAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    PositionModel OldElement = PositionList.FirstOrDefault(el => el.Id == Position.Id);

                    if (OldElement != null)
                    {
                        OldElement.Price = Position.Price;
                        OldElement.Name = Position.Name;
                    }
                    
                    MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        public static async Task<bool> DeleteOrderFromDB(int OrderId)
        {
            
            bool Result = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Order?", "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                foreach (OrderedPositionModel model in OrderedPositionsList.ToList())
                {
                    if (model.SelectedOrder == OrderId)
                        await DeleteOrderedPositionFromDB(model.Id);
                }


                string URL = mainURL + OrderURL + "/" + OrderId.ToString();
                try
                {

                    HttpResponseMessage response = await httpClient.DeleteAsync(URL);
                    //response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        OrderList.Remove(OrderList.FirstOrDefault(x => x.Id == OrderId));

                        MessageBox.Show("Your Order deleted");
                        Result = true;
                    }
                    else
                    {
                        MessageBox.Show($"Error when deleting Order: {response.StatusCode}");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

            return Result;
        }

        public static async Task AddNewCategoryLinkToDB(int selectedCategoryId,int selectedPositionId)
        {
            CategoryLinksModel CategoryLinkData = new CategoryLinksModel
            {
                Id = 0,
                LinkedCategory = selectedCategoryId,
                LinkedPosition = selectedPositionId
            };

            string URL = mainURL + CategoryLinksURL;

            string jsonData = JsonConvert.SerializeObject(CategoryLinkData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    CategoryLinksModel createdCategoryLink = JsonConvert.DeserializeObject<CategoryLinksModel>(responseContent);
                    if (createdCategoryLink != null)
                    {
                        CategoryLinksList.Add(createdCategoryLink);
                    }
                    //MessageBox.Show("Success added CategoryLink" + responseContent);
                }
                else
                {
                    MessageBox.Show("Error in response adding CategoryLink: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in addingCategoryLink: " + ex.Message);
            }
        }

        public static async Task<bool> DeleteCategoryLinkFromDB(int CategoryLinkId)
        {
            bool Result = false;

            //DialogResult dialogResult = MessageBox.Show("Are you sure to delete Order?", "Confirmation", MessageBoxButtons.OKCancel);

            string URL = mainURL + CategoryLinksURL + "/" + CategoryLinkId.ToString();
            try
            {

                HttpResponseMessage response = await httpClient.DeleteAsync(URL);
                //response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    CategoryLinksList.Remove(CategoryLinksList.FirstOrDefault(x => x.Id == CategoryLinkId));

                    //MessageBox.Show("Your Order deleted");
                    Result = true;
                }
                else
                {
                    MessageBox.Show($"Error when deleting CategoryLink: {response.StatusCode}");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when deleting CategoryLink: " + ex.Message);
            }

            return Result;
        }

        public static async Task AddNewPositionCategoryInDB(PositionCategoryModel positionCategoryModel)
        {
            string URL = mainURL + PositionCategoryURL;

            string jsonData = JsonConvert.SerializeObject(positionCategoryModel);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    PositionCategoryModel createdPosition = JsonConvert.DeserializeObject<PositionCategoryModel>(responseContent);
                    if (createdPosition != null)
                    {
                        PositionCategoryList.Add(createdPosition);
                    }
                   // MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static async Task UpdatePositionCategoryDataInDB(PositionCategoryModel positionCategoryModel)
        {
            string URL = mainURL + PositionCategoryURL + "/" + positionCategoryModel.Id.ToString();

            string jsonData = JsonConvert.SerializeObject(positionCategoryModel);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {

                HttpResponseMessage response = await httpClient.PutAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    PositionCategoryModel OldElement = PositionCategoryList.FirstOrDefault(el => el.Id == positionCategoryModel.Id);

                    if (OldElement != null)
                    {
                        OldElement.Name = positionCategoryModel.Name;
                    }

                    //MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static async Task<bool> DeletePositionCategoryInDB(int PositonCategoryId)
        {
            bool Result = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete Position Category?", "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                foreach (CategoryLinksModel model in CategoryLinksList.ToList())
                {
                    if (model.LinkedCategory == PositonCategoryId)
                        await DeleteCategoryLinkFromDB(model.Id);
                }

                string URL = mainURL + PositionCategoryURL + "/" + PositonCategoryId.ToString();
                try
                {

                    HttpResponseMessage response = await httpClient.DeleteAsync(URL);


                    if (response.IsSuccessStatusCode)
                    {
                        PositionCategoryList.Remove(PositionCategoryList.FirstOrDefault(x => x.Id == PositonCategoryId));

                        //MessageBox.Show("Your Order deleted");
                        Result = true;
                    }
                    else
                    {
                        MessageBox.Show($"Error when deleting Position Category: {response.StatusCode}");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting Position Category: " + ex.Message);
                }
            }

            

            return Result;
        }

        private static async Task<bool> DeleteOrderedPositionFromDB(int OrderedPositionId)
        {
            bool Result = false;

            //DialogResult dialogResult = MessageBox.Show("Are you sure to delete Order?", "Confirmation", MessageBoxButtons.OKCancel);

            string URL = mainURL + OrderedPositionsURL + "/" + OrderedPositionId.ToString();
            try
            {

                HttpResponseMessage response = await httpClient.DeleteAsync(URL);
                

                if (response.IsSuccessStatusCode)
                {
                    OrderedPositionsList.Remove(OrderedPositionsList.FirstOrDefault(x => x.Id == OrderedPositionId));

                    //MessageBox.Show("Your Order deleted");
                    Result = true;
                }
                else
                {
                    MessageBox.Show($"Error when deleting OrderedPosition: {response.StatusCode}");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when deleting CategoryLink: " + ex.Message);
            }

            return Result;
        }

        public static async Task UpdateOrderInDB(OrderModel orderModel)
        {
            string URL = mainURL + OrderURL + "/" + orderModel.Id.ToString();

            string jsonData = JsonConvert.SerializeObject(orderModel);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {

                HttpResponseMessage response = await httpClient.PutAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    OrderModel OldElement = OrderList.FirstOrDefault(el => el.Id == orderModel.Id);

                    if (OldElement != null)
                    {
                        OldElement.Status = orderModel.Status;
                        OldElement.CreationTime = orderModel.CreationTime;
                        OldElement.CompletionTime = orderModel.CompletionTime;
                        OldElement.Amount = orderModel.Amount;
                    }

                    //MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static async Task<bool> UpdateOrderStatusInDB(int orderId, int orderStatus)
        {
            bool Result = false;

            string URL = mainURL + OrderURL + "/" + orderId.ToString();

            OrderModel order = OrderList.FirstOrDefault(x=>x.Id == orderId);

            OrderModel newOrder = new OrderModel
            {
                Id = orderId,
                Status = orderStatus + 1,
                CreationTime = order.CreationTime,
                Amount = order.Amount,
                CompletionTime = order.CompletionTime
            };

            string jsonData = JsonConvert.SerializeObject(newOrder);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {

                HttpResponseMessage response = await httpClient.PutAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    OrderModel OldElement = OrderList.FirstOrDefault(el => el.Id == orderId);

                    if (OldElement != null)
                    {
                        OldElement.Status = newOrder.Status;
                        Result = true;
                    }

                    //MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return Result;
        }

        public static async Task UpdateOrderCompletionTimeInDB(int orderId)
        {
            string URL = mainURL + OrderURL + "/" + orderId.ToString();

            OrderModel order = OrderList.FirstOrDefault(x => x.Id == orderId);

            OrderModel newOrder = new OrderModel
            {
                Id = orderId,
                Status = order.Status,
                CreationTime = order.CreationTime,
                Amount = order.Amount,
                CompletionTime = DateTime.Now
            };

            string jsonData = JsonConvert.SerializeObject(newOrder);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            try
            {

                HttpResponseMessage response = await httpClient.PutAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    OrderModel OldElement = OrderList.FirstOrDefault(el => el.Id == orderId);

                    if (OldElement != null)
                    {
                        OldElement.CompletionTime = DateTime.Now;

                    }

                    //MessageBox.Show("Success " + responseContent);
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static async Task AddNewUserToDB(RegisterDTO registerDTO)
        {
            string URL = mainURL + SignUpUserURL;

            string jsonData = JsonConvert.SerializeObject(registerDTO);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);


                if (response.IsSuccessStatusCode)
                {
                    //string responseContent = await response.Content.ReadAsStringAsync();
                    
                    //MessageBox.Show("User Created " + responseContent);
                    MessageBox.Show("User Created ");
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
