namespace CourseWorkFront
{
    partial class EditCategoriesListWindow
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
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.AddNewCategoryButton = new System.Windows.Forms.Button();
            this.ChangeCategoryNameButton = new System.Windows.Forms.Button();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.ItemHeight = 54;
            this.CategoriesListBox.Location = new System.Drawing.Point(23, 33);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(343, 652);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(843, 139);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(292, 61);
            this.CategoryNameTextBox.TabIndex = 1;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryNameLabel.Location = new System.Drawing.Point(834, 82);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(301, 54);
            this.CategoryNameLabel.TabIndex = 2;
            this.CategoryNameLabel.Text = "Category name:";
            // 
            // AddNewCategoryButton
            // 
            this.AddNewCategoryButton.AutoSize = true;
            this.AddNewCategoryButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewCategoryButton.Location = new System.Drawing.Point(788, 281);
            this.AddNewCategoryButton.Name = "AddNewCategoryButton";
            this.AddNewCategoryButton.Size = new System.Drawing.Size(347, 64);
            this.AddNewCategoryButton.TabIndex = 3;
            this.AddNewCategoryButton.Text = "AddNewCategory";
            this.AddNewCategoryButton.UseVisualStyleBackColor = true;
            this.AddNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // ChangeCategoryNameButton
            // 
            this.ChangeCategoryNameButton.AutoSize = true;
            this.ChangeCategoryNameButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCategoryNameButton.Location = new System.Drawing.Point(788, 369);
            this.ChangeCategoryNameButton.Name = "ChangeCategoryNameButton";
            this.ChangeCategoryNameButton.Size = new System.Drawing.Size(434, 64);
            this.ChangeCategoryNameButton.TabIndex = 4;
            this.ChangeCategoryNameButton.Text = "ChangeCategoryName";
            this.ChangeCategoryNameButton.UseVisualStyleBackColor = true;
            this.ChangeCategoryNameButton.Click += new System.EventHandler(this.ChangeCategoryNameButton_Click);
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.AutoSize = true;
            this.DeleteCategoryButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCategoryButton.Location = new System.Drawing.Point(788, 451);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(340, 64);
            this.DeleteCategoryButton.TabIndex = 5;
            this.DeleteCategoryButton.Text = "DeleteCategory";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // EditCategoriesListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 735);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.ChangeCategoryNameButton);
            this.Controls.Add(this.AddNewCategoryButton);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoriesListBox);
            this.Name = "EditCategoriesListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCategoriesListWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Button AddNewCategoryButton;
        private System.Windows.Forms.Button ChangeCategoryNameButton;
        private System.Windows.Forms.Button DeleteCategoryButton;
    }
}