using CourseWorkFront.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkFront
{
    public partial class AccountLoginWindow : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private string URL = "https://localhost:7248/api/Auth/login";

        private string token;


        private MainWindow mainForm;

        private class LoginResponse
        {
            public  string token;
        }


        public AccountLoginWindow()
        {
            InitializeComponent();
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            /*string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;*/


            var data = new
            {
                login = LoginTextBox.Text,
                password = PasswordTextBox.Text,
            };

            var jsonData = JsonConvert.SerializeObject(data);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");



            try
            {

                HttpResponseMessage response = await httpClient.PostAsync(URL, content);
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();


                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(result);

                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(loginResponse.token);

                
                var roleClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "role" ||
                                c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role");

                if (roleClaim != null)
                {
                    string userRole = roleClaim.Value; 


                    DataComponent.SetRole(userRole);

                    
                }
                else
                {
                    MessageBox.Show("Role not found");
                }

                DataComponent.SetToken(loginResponse.token);
                DataComponent.GetAllDataFromDB();




                mainForm = new MainWindow(loginResponse.token);

                mainForm.Show();

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

                
        }
    }
}
