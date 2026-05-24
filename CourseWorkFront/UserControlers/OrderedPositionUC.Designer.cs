namespace CourseWorkFront.UserControlers
{
    partial class OrderedPositionUC
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
            this.PositionNameLabel = new System.Windows.Forms.Label();
            this.PositionCountLabel = new System.Windows.Forms.Label();
            this.PositionPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionNameLabel
            // 
            this.PositionNameLabel.AutoSize = true;
            this.PositionNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameLabel.Location = new System.Drawing.Point(3, 17);
            this.PositionNameLabel.Name = "PositionNameLabel";
            this.PositionNameLabel.Size = new System.Drawing.Size(219, 45);
            this.PositionNameLabel.TabIndex = 0;
            this.PositionNameLabel.Text = "PositionName";
            // 
            // PositionCountLabel
            // 
            this.PositionCountLabel.AutoSize = true;
            this.PositionCountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionCountLabel.Location = new System.Drawing.Point(297, 17);
            this.PositionCountLabel.Name = "PositionCountLabel";
            this.PositionCountLabel.Size = new System.Drawing.Size(220, 45);
            this.PositionCountLabel.TabIndex = 1;
            this.PositionCountLabel.Text = "PositionCount";
            // 
            // PositionPriceLabel
            // 
            this.PositionPriceLabel.AutoSize = true;
            this.PositionPriceLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceLabel.Location = new System.Drawing.Point(434, 17);
            this.PositionPriceLabel.Name = "PositionPriceLabel";
            this.PositionPriceLabel.Size = new System.Drawing.Size(203, 45);
            this.PositionPriceLabel.TabIndex = 2;
            this.PositionPriceLabel.Text = "PositionPrice";
            // 
            // OrderedPositionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PositionPriceLabel);
            this.Controls.Add(this.PositionCountLabel);
            this.Controls.Add(this.PositionNameLabel);
            this.Name = "OrderedPositionUC";
            this.Size = new System.Drawing.Size(625, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionNameLabel;
        private System.Windows.Forms.Label PositionCountLabel;
        private System.Windows.Forms.Label PositionPriceLabel;
    }
}
