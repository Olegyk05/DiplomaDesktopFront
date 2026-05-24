namespace CourseWorkFront
{
    partial class PositionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionsWindow));
            this.DishesListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchDishByTextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateDishesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DishesListFlowPanel
            // 
            this.DishesListFlowPanel.AutoScroll = true;
            this.DishesListFlowPanel.Location = new System.Drawing.Point(21, 211);
            this.DishesListFlowPanel.Name = "DishesListFlowPanel";
            this.DishesListFlowPanel.Size = new System.Drawing.Size(1275, 907);
            this.DishesListFlowPanel.TabIndex = 0;
            // 
            // SearchDishByTextTextBox
            // 
            this.SearchDishByTextTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchDishByTextTextBox.Location = new System.Drawing.Point(415, 8);
            this.SearchDishByTextTextBox.Name = "SearchDishByTextTextBox";
            this.SearchDishByTextTextBox.Size = new System.Drawing.Size(287, 55);
            this.SearchDishByTextTextBox.TabIndex = 10;
            this.SearchDishByTextTextBox.TextChanged += new System.EventHandler(this.SearchDishByTextTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 54);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by dish name:";
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderByComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByComboBox.FormattingEnabled = true;
            this.OrderByComboBox.Items.AddRange(new object[] {
            "Order by Name",
            "Order by Price"});
            this.OrderByComboBox.Location = new System.Drawing.Point(1031, 12);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(265, 46);
            this.OrderByComboBox.TabIndex = 11;
            this.OrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(836, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order by:";
            // 
            // UpdateDishesButton
            // 
            this.UpdateDishesButton.AutoSize = true;
            this.UpdateDishesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDishesButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDishesButton.Image")));
            this.UpdateDishesButton.Location = new System.Drawing.Point(21, 132);
            this.UpdateDishesButton.Name = "UpdateDishesButton";
            this.UpdateDishesButton.Size = new System.Drawing.Size(46, 42);
            this.UpdateDishesButton.TabIndex = 13;
            this.UpdateDishesButton.UseVisualStyleBackColor = true;
            this.UpdateDishesButton.Click += new System.EventHandler(this.UpdateDishesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 54);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categories:";
            // 
            // categoriesFlowPanel
            // 
            this.categoriesFlowPanel.AutoScroll = true;
            this.categoriesFlowPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesFlowPanel.Location = new System.Drawing.Point(240, 75);
            this.categoriesFlowPanel.Name = "categoriesFlowPanel";
            this.categoriesFlowPanel.Size = new System.Drawing.Size(1056, 100);
            this.categoriesFlowPanel.TabIndex = 16;
            this.categoriesFlowPanel.WrapContents = false;
            // 
            // AddPositionButton
            // 
            this.AddPositionButton.AutoSize = true;
            this.AddPositionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPositionButton.Image = ((System.Drawing.Image)(resources.GetObject("AddPositionButton.Image")));
            this.AddPositionButton.Location = new System.Drawing.Point(170, 132);
            this.AddPositionButton.Name = "AddPositionButton";
            this.AddPositionButton.Size = new System.Drawing.Size(46, 42);
            this.AddPositionButton.TabIndex = 17;
            this.AddPositionButton.UseVisualStyleBackColor = true;
            this.AddPositionButton.Click += new System.EventHandler(this.AddPositionButton_Click);
            // 
            // PositionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 1156);
            this.Controls.Add(this.AddPositionButton);
            this.Controls.Add(this.categoriesFlowPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateDishesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderByComboBox);
            this.Controls.Add(this.SearchDishByTextTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DishesListFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PositionsWindow";
            this.Text = "DishesForm";
            this.Load += new System.EventHandler(this.DishesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel DishesListFlowPanel;
        private System.Windows.Forms.TextBox SearchDishByTextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OrderByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateDishesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel categoriesFlowPanel;
        private System.Windows.Forms.Button AddPositionButton;
    }
}