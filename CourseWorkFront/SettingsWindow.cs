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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void AddnewPositionButton_Click(object sender, EventArgs e)
        {
            AddNewUserWindow addNewUserToDBWindow = new AddNewUserWindow();
            addNewUserToDBWindow.ShowDialog();
        }
    }
}
