namespace CourseWorkFront.UserControlers
{
    partial class OrderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUC));
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderAmountLabel = new System.Windows.Forms.Label();
            this.ViewDetailButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.ComplateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(3, 23);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(262, 48);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "Order Number:";
            // 
            // OrderAmountLabel
            // 
            this.OrderAmountLabel.AutoSize = true;
            this.OrderAmountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderAmountLabel.Location = new System.Drawing.Point(828, 18);
            this.OrderAmountLabel.Name = "OrderAmountLabel";
            this.OrderAmountLabel.Size = new System.Drawing.Size(258, 48);
            this.OrderAmountLabel.TabIndex = 1;
            this.OrderAmountLabel.Text = "Order Amount:";
            // 
            // ViewDetailButton
            // 
            this.ViewDetailButton.AutoSize = true;
            this.ViewDetailButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewDetailButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewDetailButton.Image")));
            this.ViewDetailButton.Location = new System.Drawing.Point(1101, 9);
            this.ViewDetailButton.Name = "ViewDetailButton";
            this.ViewDetailButton.Size = new System.Drawing.Size(70, 70);
            this.ViewDetailButton.TabIndex = 2;
            this.ViewDetailButton.UseVisualStyleBackColor = true;
            this.ViewDetailButton.Click += new System.EventHandler(this.ViewDetailButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(1177, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(70, 70);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderStatusLabel.Location = new System.Drawing.Point(386, 18);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(204, 45);
            this.OrderStatusLabel.TabIndex = 4;
            this.OrderStatusLabel.Text = "Order Status:";
            // 
            // PaymentButton
            // 
            this.PaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentButton.Image")));
            this.PaymentButton.Location = new System.Drawing.Point(714, 9);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(81, 70);
            this.PaymentButton.TabIndex = 5;
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // ComplateButton
            // 
            this.ComplateButton.Image = ((System.Drawing.Image)(resources.GetObject("ComplateButton.Image")));
            this.ComplateButton.Location = new System.Drawing.Point(306, 9);
            this.ComplateButton.Name = "ComplateButton";
            this.ComplateButton.Size = new System.Drawing.Size(74, 70);
            this.ComplateButton.TabIndex = 6;
            this.ComplateButton.UseVisualStyleBackColor = true;
            this.ComplateButton.Click += new System.EventHandler(this.ComplateButton_Click);
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ComplateButton);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewDetailButton);
            this.Controls.Add(this.OrderAmountLabel);
            this.Controls.Add(this.OrderNumberLabel);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(1271, 92);
            this.Load += new System.EventHandler(this.OrderUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label OrderAmountLabel;
        private System.Windows.Forms.Button ViewDetailButton;
        public System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button ComplateButton;
    }
}
