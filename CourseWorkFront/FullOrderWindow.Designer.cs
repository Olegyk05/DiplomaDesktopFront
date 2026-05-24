namespace CourseWorkFront.UserControlers
{
    partial class FullOrderWindow
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
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.FullOrderFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(21, 23);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(262, 48);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "Order Number:";
            // 
            // FullOrderFlowPanel
            // 
            this.FullOrderFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FullOrderFlowPanel.Location = new System.Drawing.Point(18, 210);
            this.FullOrderFlowPanel.Name = "FullOrderFlowPanel";
            this.FullOrderFlowPanel.Size = new System.Drawing.Size(1307, 732);
            this.FullOrderFlowPanel.TabIndex = 1;
            this.FullOrderFlowPanel.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "PositionType:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(275, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(740, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1073, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position Price:";
            // 
            // FullOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 954);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullOrderFlowPanel);
            this.Controls.Add(this.OrderNumberLabel);
            this.Name = "FullOrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullOrderWindow";
            this.Load += new System.EventHandler(this.FullOrderWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel FullOrderFlowPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}