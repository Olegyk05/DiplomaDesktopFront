namespace CourseWorkFront
{
    partial class ReviewsWindow
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
            this.OrderListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderCompletionTime = new System.Windows.Forms.Label();
            this.ReviewFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceRatingLabel = new System.Windows.Forms.Label();
            this.TasteRatingPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderListFlowPanel
            // 
            this.OrderListFlowPanel.AutoScroll = true;
            this.OrderListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderListFlowPanel.Location = new System.Drawing.Point(12, 91);
            this.OrderListFlowPanel.Name = "OrderListFlowPanel";
            this.OrderListFlowPanel.Size = new System.Drawing.Size(606, 997);
            this.OrderListFlowPanel.TabIndex = 0;
            this.OrderListFlowPanel.WrapContents = false;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(68, 54);
            this.OrderNumberLabel.TabIndex = 1;
            this.OrderNumberLabel.Text = "№";
            // 
            // OrderCompletionTime
            // 
            this.OrderCompletionTime.AutoSize = true;
            this.OrderCompletionTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCompletionTime.Location = new System.Drawing.Point(342, 9);
            this.OrderCompletionTime.Name = "OrderCompletionTime";
            this.OrderCompletionTime.Size = new System.Drawing.Size(192, 54);
            this.OrderCompletionTime.TabIndex = 2;
            this.OrderCompletionTime.Text = "DateTime";
            // 
            // ReviewFlowPanel
            // 
            this.ReviewFlowPanel.AutoScroll = true;
            this.ReviewFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReviewFlowPanel.Location = new System.Drawing.Point(704, 91);
            this.ReviewFlowPanel.Name = "ReviewFlowPanel";
            this.ReviewFlowPanel.Size = new System.Drawing.Size(606, 997);
            this.ReviewFlowPanel.TabIndex = 3;
            this.ReviewFlowPanel.WrapContents = false;
            // 
            // ServiceRatingLabel
            // 
            this.ServiceRatingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceRatingLabel.Location = new System.Drawing.Point(697, 9);
            this.ServiceRatingLabel.Name = "ServiceRatingLabel";
            this.ServiceRatingLabel.Size = new System.Drawing.Size(113, 79);
            this.ServiceRatingLabel.TabIndex = 4;
            this.ServiceRatingLabel.Text = "Service Rating";
            // 
            // TasteRatingPanel
            // 
            this.TasteRatingPanel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasteRatingPanel.Location = new System.Drawing.Point(850, 9);
            this.TasteRatingPanel.Name = "TasteRatingPanel";
            this.TasteRatingPanel.Size = new System.Drawing.Size(103, 79);
            this.TasteRatingPanel.TabIndex = 5;
            this.TasteRatingPanel.Text = "Taste Rating";
            // 
            // ReviewsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 1100);
            this.Controls.Add(this.TasteRatingPanel);
            this.Controls.Add(this.ServiceRatingLabel);
            this.Controls.Add(this.ReviewFlowPanel);
            this.Controls.Add(this.OrderCompletionTime);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.OrderListFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewsWindow";
            this.Text = "ReviewsForm";
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrderListFlowPanel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label OrderCompletionTime;
        private System.Windows.Forms.FlowLayoutPanel ReviewFlowPanel;
        private System.Windows.Forms.Label ServiceRatingLabel;
        private System.Windows.Forms.Label TasteRatingPanel;
    }
}