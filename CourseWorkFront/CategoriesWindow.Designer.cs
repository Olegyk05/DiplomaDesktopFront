namespace CourseWorkFront
{
    partial class CategoriesWindow
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
            this.PositionListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoriesListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EditCategoriesListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PositionListFlowPanel
            // 
            this.PositionListFlowPanel.AutoScroll = true;
            this.PositionListFlowPanel.Location = new System.Drawing.Point(29, 121);
            this.PositionListFlowPanel.Name = "PositionListFlowPanel";
            this.PositionListFlowPanel.Size = new System.Drawing.Size(613, 911);
            this.PositionListFlowPanel.TabIndex = 1;
            // 
            // CategoriesListFlowPanel
            // 
            this.CategoriesListFlowPanel.AutoScroll = true;
            this.CategoriesListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CategoriesListFlowPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesListFlowPanel.Location = new System.Drawing.Point(855, 121);
            this.CategoriesListFlowPanel.Name = "CategoriesListFlowPanel";
            this.CategoriesListFlowPanel.Size = new System.Drawing.Size(433, 911);
            this.CategoriesListFlowPanel.TabIndex = 2;
            this.CategoriesListFlowPanel.WrapContents = false;
            // 
            // EditCategoriesListButton
            // 
            this.EditCategoriesListButton.AutoSize = true;
            this.EditCategoriesListButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCategoriesListButton.Location = new System.Drawing.Point(855, 31);
            this.EditCategoriesListButton.Name = "EditCategoriesListButton";
            this.EditCategoriesListButton.Size = new System.Drawing.Size(372, 64);
            this.EditCategoriesListButton.TabIndex = 3;
            this.EditCategoriesListButton.Text = "Edit Categories List";
            this.EditCategoriesListButton.UseVisualStyleBackColor = true;
            this.EditCategoriesListButton.Click += new System.EventHandler(this.EditCategoriesListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(175, 36);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(467, 61);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CategoriesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditCategoriesListButton);
            this.Controls.Add(this.CategoriesListFlowPanel);
            this.Controls.Add(this.PositionListFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesWindow";
            this.Load += new System.EventHandler(this.CategoriesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PositionListFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel CategoriesListFlowPanel;
        private System.Windows.Forms.Button EditCategoriesListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}