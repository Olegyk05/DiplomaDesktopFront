namespace CourseWorkFront
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExpandButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.SideBarFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.DishesPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.DrinksPanel = new System.Windows.Forms.Panel();
            this.ReviewsButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SignOutPanel = new System.Windows.Forms.Panel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SideBarTransitionTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandButtonPictureBox)).BeginInit();
            this.SideBarFlowLayoutPanel.SuspendLayout();
            this.OrdersPanel.SuspendLayout();
            this.DishesPanel.SuspendLayout();
            this.StatisticsPanel.SuspendLayout();
            this.DrinksPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SignOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExpandButtonPictureBox);
            this.panel1.Controls.Add(this.HelloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 73);
            this.panel1.TabIndex = 4;
            // 
            // ExpandButtonPictureBox
            // 
            this.ExpandButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExpandButtonPictureBox.Image")));
            this.ExpandButtonPictureBox.Location = new System.Drawing.Point(3, 9);
            this.ExpandButtonPictureBox.Name = "ExpandButtonPictureBox";
            this.ExpandButtonPictureBox.Size = new System.Drawing.Size(68, 48);
            this.ExpandButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExpandButtonPictureBox.TabIndex = 5;
            this.ExpandButtonPictureBox.TabStop = false;
            this.ExpandButtonPictureBox.Click += new System.EventHandler(this.ExpandButtonPictureBox_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabel.Location = new System.Drawing.Point(86, 9);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(115, 48);
            this.HelloLabel.TabIndex = 5;
            this.HelloLabel.Text = "label1";
            // 
            // SideBarFlowLayoutPanel
            // 
            this.SideBarFlowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.SideBarFlowLayoutPanel.Controls.Add(this.OrdersPanel);
            this.SideBarFlowLayoutPanel.Controls.Add(this.DishesPanel);
            this.SideBarFlowLayoutPanel.Controls.Add(this.StatisticsPanel);
            this.SideBarFlowLayoutPanel.Controls.Add(this.DrinksPanel);
            this.SideBarFlowLayoutPanel.Controls.Add(this.SettingsPanel);
            this.SideBarFlowLayoutPanel.Controls.Add(this.SignOutPanel);
            this.SideBarFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBarFlowLayoutPanel.Location = new System.Drawing.Point(0, 73);
            this.SideBarFlowLayoutPanel.Name = "SideBarFlowLayoutPanel";
            this.SideBarFlowLayoutPanel.Size = new System.Drawing.Size(300, 705);
            this.SideBarFlowLayoutPanel.TabIndex = 5;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Controls.Add(this.OrdersButton);
            this.OrdersPanel.Location = new System.Drawing.Point(3, 3);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(297, 103);
            this.OrdersPanel.TabIndex = 6;
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.Silver;
            this.OrdersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.ForeColor = System.Drawing.Color.Black;
            this.OrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdersButton.Image")));
            this.OrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.Location = new System.Drawing.Point(0, 3);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(297, 100);
            this.OrdersButton.TabIndex = 7;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // DishesPanel
            // 
            this.DishesPanel.Controls.Add(this.MenuButton);
            this.DishesPanel.Location = new System.Drawing.Point(3, 112);
            this.DishesPanel.Name = "DishesPanel";
            this.DishesPanel.Size = new System.Drawing.Size(297, 103);
            this.DishesPanel.TabIndex = 7;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Silver;
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.ForeColor = System.Drawing.Color.Black;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(0, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(297, 100);
            this.MenuButton.TabIndex = 7;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.DishesButton_Click);
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.Controls.Add(this.CategoriesButton);
            this.StatisticsPanel.Location = new System.Drawing.Point(3, 221);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Size = new System.Drawing.Size(297, 103);
            this.StatisticsPanel.TabIndex = 9;
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.BackColor = System.Drawing.Color.Silver;
            this.CategoriesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesButton.ForeColor = System.Drawing.Color.Black;
            this.CategoriesButton.Image = ((System.Drawing.Image)(resources.GetObject("CategoriesButton.Image")));
            this.CategoriesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoriesButton.Location = new System.Drawing.Point(-3, 0);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Size = new System.Drawing.Size(297, 100);
            this.CategoriesButton.TabIndex = 7;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.UseVisualStyleBackColor = false;
            this.CategoriesButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // DrinksPanel
            // 
            this.DrinksPanel.Controls.Add(this.ReviewsButton);
            this.DrinksPanel.Location = new System.Drawing.Point(3, 330);
            this.DrinksPanel.Name = "DrinksPanel";
            this.DrinksPanel.Size = new System.Drawing.Size(297, 103);
            this.DrinksPanel.TabIndex = 8;
            // 
            // ReviewsButton
            // 
            this.ReviewsButton.BackColor = System.Drawing.Color.Silver;
            this.ReviewsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReviewsButton.ForeColor = System.Drawing.Color.Black;
            this.ReviewsButton.Image = ((System.Drawing.Image)(resources.GetObject("ReviewsButton.Image")));
            this.ReviewsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReviewsButton.Location = new System.Drawing.Point(-3, 3);
            this.ReviewsButton.Name = "ReviewsButton";
            this.ReviewsButton.Size = new System.Drawing.Size(297, 100);
            this.ReviewsButton.TabIndex = 7;
            this.ReviewsButton.Text = "Reviews";
            this.ReviewsButton.UseVisualStyleBackColor = false;
            this.ReviewsButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.SettingsButton);
            this.SettingsPanel.Location = new System.Drawing.Point(3, 439);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(297, 103);
            this.SettingsPanel.TabIndex = 10;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(-3, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(297, 100);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SignOutPanel
            // 
            this.SignOutPanel.Controls.Add(this.SignOutButton);
            this.SignOutPanel.Location = new System.Drawing.Point(3, 548);
            this.SignOutPanel.Name = "SignOutPanel";
            this.SignOutPanel.Size = new System.Drawing.Size(297, 103);
            this.SignOutPanel.TabIndex = 11;
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.Silver;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignOutButton.ForeColor = System.Drawing.Color.Black;
            this.SignOutButton.Image = ((System.Drawing.Image)(resources.GetObject("SignOutButton.Image")));
            this.SignOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutButton.Location = new System.Drawing.Point(0, 3);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(297, 100);
            this.SignOutButton.TabIndex = 7;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            // 
            // SideBarTransitionTimer
            // 
            this.SideBarTransitionTimer.Interval = 10;
            this.SideBarTransitionTimer.Tick += new System.EventHandler(this.SideBarTransitionTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1193, 778);
            this.Controls.Add(this.SideBarFlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpandButtonPictureBox)).EndInit();
            this.SideBarFlowLayoutPanel.ResumeLayout(false);
            this.OrdersPanel.ResumeLayout(false);
            this.DishesPanel.ResumeLayout(false);
            this.StatisticsPanel.ResumeLayout(false);
            this.DrinksPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SignOutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.PictureBox ExpandButtonPictureBox;
        private System.Windows.Forms.FlowLayoutPanel SideBarFlowLayoutPanel;
        private System.Windows.Forms.Panel OrdersPanel;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Panel DishesPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Panel DrinksPanel;
        private System.Windows.Forms.Button ReviewsButton;
        private System.Windows.Forms.Panel StatisticsPanel;
        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel SignOutPanel;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Timer SideBarTransitionTimer;
    }
}