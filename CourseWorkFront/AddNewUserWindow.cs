using CourseWorkFront.DTO;
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
    public partial class AddNewUserWindow : Form
    {
        public AddNewUserWindow()
        {
            InitializeComponent();
        }

        private async void AddUserButton_Click(object sender, EventArgs e)
        {
            RegisterDTO registerDTO = new RegisterDTO
            {
                login = LoginTextBox.Text,
                password = PasswordTextBox.Text,
                userName = FullNameTextBox.Text,
                roleId = (int)UserRoleComboBox.SelectedValue
            };

            await DataComponent.AddNewUserToDB(registerDTO);
        }

        private void AddNewUserWindow_Load(object sender, EventArgs e)
        {
            UserRoleComboBox.Items.Clear();

            UserRoleComboBox.DataSource = DataComponent.UserTypeList;

            UserRoleComboBox.DisplayMember = "TypeName";

            UserRoleComboBox.ValueMember = "Id";


            
        }
    }
}
