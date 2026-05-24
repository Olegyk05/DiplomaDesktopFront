namespace CourseWorkFront
{
    partial class AddOrderWindow
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
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewOrderDetailPanel = new System.Windows.Forms.Panel();
            this.SummaryPriceLabel = new System.Windows.Forms.Label();
            this.SummaryTextLabel = new System.Windows.Forms.Label();
            this.OrderedPositionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PositionsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchPositionByTextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewOrderDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(1067, 980);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(267, 112);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Add";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(1340, 980);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(267, 112);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewOrderDetailPanel
            // 
            this.NewOrderDetailPanel.Controls.Add(this.label4);
            this.NewOrderDetailPanel.Controls.Add(this.label2);
            this.NewOrderDetailPanel.Controls.Add(this.label1);
            this.NewOrderDetailPanel.Controls.Add(this.SummaryPriceLabel);
            this.NewOrderDetailPanel.Controls.Add(this.SummaryTextLabel);
            this.NewOrderDetailPanel.Controls.Add(this.OrderedPositionFlowPanel);
            this.NewOrderDetailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewOrderDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.NewOrderDetailPanel.Name = "NewOrderDetailPanel";
            this.NewOrderDetailPanel.Size = new System.Drawing.Size(654, 1104);
            this.NewOrderDetailPanel.TabIndex = 2;
            // 
            // SummaryPriceLabel
            // 
            this.SummaryPriceLabel.AutoSize = true;
            this.SummaryPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryPriceLabel.Location = new System.Drawing.Point(407, 980);
            this.SummaryPriceLabel.Name = "SummaryPriceLabel";
            this.SummaryPriceLabel.Size = new System.Drawing.Size(98, 48);
            this.SummaryPriceLabel.TabIndex = 5;
            this.SummaryPriceLabel.Text = "Price";
            // 
            // SummaryTextLabel
            // 
            this.SummaryTextLabel.AutoSize = true;
            this.SummaryTextLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryTextLabel.Location = new System.Drawing.Point(12, 980);
            this.SummaryTextLabel.Name = "SummaryTextLabel";
            this.SummaryTextLabel.Size = new System.Drawing.Size(177, 48);
            this.SummaryTextLabel.TabIndex = 4;
            this.SummaryTextLabel.Text = "Summary:";
            // 
            // OrderedPositionFlowPanel
            // 
            this.OrderedPositionFlowPanel.AutoScroll = true;
            this.OrderedPositionFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderedPositionFlowPanel.Location = new System.Drawing.Point(3, 91);
            this.OrderedPositionFlowPanel.Name = "OrderedPositionFlowPanel";
            this.OrderedPositionFlowPanel.Size = new System.Drawing.Size(637, 863);
            this.OrderedPositionFlowPanel.TabIndex = 3;
            this.OrderedPositionFlowPanel.WrapContents = false;
            // 
            // PositionsFlowPanel
            // 
            this.PositionsFlowPanel.AutoScroll = true;
            this.PositionsFlowPanel.Location = new System.Drawing.Point(660, 164);
            this.PositionsFlowPanel.Name = "PositionsFlowPanel";
            this.PositionsFlowPanel.Size = new System.Drawing.Size(947, 810);
            this.PositionsFlowPanel.TabIndex = 3;
            // 
            // SearchPositionByTextTextBox
            // 
            this.SearchPositionByTextTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchPositionByTextTextBox.Location = new System.Drawing.Point(978, 8);
            this.SearchPositionByTextTextBox.Name = "SearchPositionByTextTextBox";
            this.SearchPositionByTextTextBox.Size = new System.Drawing.Size(287, 55);
            this.SearchPositionByTextTextBox.TabIndex = 16;
            this.SearchPositionByTextTextBox.TextChanged += new System.EventHandler(this.SearchPositionByTextTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(660, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 54);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search by name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Position Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(212, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(437, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Position Price:";
            // 
            // AddOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1619, 1104);
            this.Controls.Add(this.SearchPositionByTextTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PositionsFlowPanel);
            this.Controls.Add(this.NewOrderDetailPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderWindow";
            this.Load += new System.EventHandler(this.AddOrderWindow_Load);
            this.VisibleChanged += new System.EventHandler(this.AddOrderWindow_VisibleChanged);
            this.NewOrderDetailPanel.ResumeLayout(false);
            this.NewOrderDetailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel NewOrderDetailPanel;
        private System.Windows.Forms.FlowLayoutPanel OrderedPositionFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel PositionsFlowPanel;
        private System.Windows.Forms.Label SummaryPriceLabel;
        private System.Windows.Forms.Label SummaryTextLabel;
        private System.Windows.Forms.TextBox SearchPositionByTextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}