namespace CourseWorkFront
{
    partial class OrdersWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextTextBox = new System.Windows.Forms.TextBox();
            this.UpdateOrdersButton = new System.Windows.Forms.Button();
            this.CashierModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number:";
            // 
            // OrderListFlowPanel
            // 
            this.OrderListFlowPanel.AutoScroll = true;
            this.OrderListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderListFlowPanel.Location = new System.Drawing.Point(21, 176);
            this.OrderListFlowPanel.Name = "OrderListFlowPanel";
            this.OrderListFlowPanel.Size = new System.Drawing.Size(1311, 689);
            this.OrderListFlowPanel.TabIndex = 4;
            this.OrderListFlowPanel.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(513, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Amount:";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderButton.Location = new System.Drawing.Point(474, 884);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(361, 107);
            this.NewOrderButton.TabIndex = 6;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search by order №:";
            // 
            // SearchTextTextBox
            // 
            this.SearchTextTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextTextBox.Location = new System.Drawing.Point(375, 8);
            this.SearchTextTextBox.Name = "SearchTextTextBox";
            this.SearchTextTextBox.Size = new System.Drawing.Size(287, 55);
            this.SearchTextTextBox.TabIndex = 8;
            this.SearchTextTextBox.TextChanged += new System.EventHandler(this.SearchTextTextBox_TextChanged);
            // 
            // UpdateOrdersButton
            // 
            this.UpdateOrdersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateOrdersButton.Location = new System.Drawing.Point(1144, 22);
            this.UpdateOrdersButton.Name = "UpdateOrdersButton";
            this.UpdateOrdersButton.Size = new System.Drawing.Size(187, 40);
            this.UpdateOrdersButton.TabIndex = 9;
            this.UpdateOrdersButton.Text = "Update";
            this.UpdateOrdersButton.UseVisualStyleBackColor = true;
            this.UpdateOrdersButton.Click += new System.EventHandler(this.UpdateOrdersButton_Click);
            // 
            // CashierModeCheckBox
            // 
            this.CashierModeCheckBox.AutoSize = true;
            this.CashierModeCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashierModeCheckBox.Location = new System.Drawing.Point(21, 67);
            this.CashierModeCheckBox.Name = "CashierModeCheckBox";
            this.CashierModeCheckBox.Size = new System.Drawing.Size(206, 42);
            this.CashierModeCheckBox.TabIndex = 10;
            this.CashierModeCheckBox.Text = "CashierMode";
            this.CashierModeCheckBox.UseVisualStyleBackColor = true;
            this.CashierModeCheckBox.CheckedChanged += new System.EventHandler(this.CashierModeCheckBox_CheckedChanged);
            // 
            // OrdersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 1156);
            this.Controls.Add(this.CashierModeCheckBox);
            this.Controls.Add(this.UpdateOrdersButton);
            this.Controls.Add(this.SearchTextTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderListFlowPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersWindow";
            this.Text = "OrdersWindow";
            this.Load += new System.EventHandler(this.OrdersWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel OrderListFlowPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextTextBox;
        private System.Windows.Forms.Button UpdateOrdersButton;
        private System.Windows.Forms.CheckBox CashierModeCheckBox;
    }
}