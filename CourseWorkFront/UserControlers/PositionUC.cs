using CourseWorkFront.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CourseWorkFront.UserControlers
{
    public partial class PositionUC : UserControl
    {
        public string _positionName = null;
        public double _positionPrice = 0;
        public int _positionId = -1;

        private string _imageSource = @"..\..\ProgramData\Images\Positions\";




        public Action AfterUpdateAction;

        public PositionUC(PositionModel Position)
        {
            InitializeComponent();

            _positionId = Position.Id;
            _positionName = Position.Name;
            _positionPrice = Position.Price;

            SetPictrueForPosition();

            PositionNameLabel.Text = _positionName;
            PositionPriceLabel.Text = Position.Price.ToString();



            DeleteToolStripMenuItem1.Click += DeleteToolStripMenuItem1_Click;
        }

        private void PositionUC_Load(object sender, EventArgs e)
        {
            SetGuiDependingOnRole();
        }
        private void SetGuiDependingOnRole()
        {
            if (DataComponent.RoleName != "Admin")
            {
                PositionUCContextMenuStrip.Enabled = false;
                PositionUCContextMenuStrip.Visible = false;
            }
        }

        private async void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(await DataComponent.DeletePositionFromDB(_positionId))
            {
                //AfterDeleteUpdateAction?.Invoke();
                Visible = false;
                //Dispose();
            }

        }
        public void SetPictrueForPosition()
        {
            if (File.Exists(_imageSource + _positionName + ".jpg"))
            {
                PositionPictureBox.Image = Image.FromFile(_imageSource + _positionName + ".jpg");
            }
            else
                PositionPictureBox.Image = Image.FromFile(_imageSource + "Default" + ".jpg");
        }

        private void PositionUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //PositionUCContextMenuStrip.Show(panel1, e.Location);
                PositionUCContextMenuStrip.Show(this,e.Location);
            }
        }

        private void ChangeToolStripMenu_Click(object sender, EventArgs e)
        {
            

            ChangePositionData changePositionData = new ChangePositionData(_positionId,_positionName, _positionPrice);
            changePositionData.ShowDialog();

            AfterUpdateAction?.Invoke();
        }

        public void SetSelected(bool isSelected)
        {
            if (isSelected)
            {
                BackColor = Color.LightBlue; // Колір виділеного елемента
                                             // Або можна змінити BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BackColor = SystemColors.Control; // Повертаємо стандартний колір
                                                  // BorderStyle = BorderStyle.None;
            }
        }

        
    }
}
