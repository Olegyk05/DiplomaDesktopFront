namespace CourseWorkFront.UserControlers
{
    partial class FullOrderUC
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
            this.PositionTypeLabel = new System.Windows.Forms.Label();
            this.PositionNameLabel = new System.Windows.Forms.Label();
            this.PositionPriceLabel = new System.Windows.Forms.Label();
            this.PositionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionTypeLabel
            // 
            this.PositionTypeLabel.AutoSize = true;
            this.PositionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionTypeLabel.Location = new System.Drawing.Point(3, 15);
            this.PositionTypeLabel.Name = "PositionTypeLabel";
            this.PositionTypeLabel.Size = new System.Drawing.Size(228, 48);
            this.PositionTypeLabel.TabIndex = 1;
            this.PositionTypeLabel.Text = "PositionType:";
            // 
            // PositionNameLabel
            // 
            this.PositionNameLabel.AutoSize = true;
            this.PositionNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameLabel.Location = new System.Drawing.Point(286, 15);
            this.PositionNameLabel.Name = "PositionNameLabel";
            this.PositionNameLabel.Size = new System.Drawing.Size(249, 48);
            this.PositionNameLabel.TabIndex = 2;
            this.PositionNameLabel.Text = "PositionName:";
            // 
            // PositionPriceLabel
            // 
            this.PositionPriceLabel.AutoSize = true;
            this.PositionPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceLabel.Location = new System.Drawing.Point(1049, 15);
            this.PositionPriceLabel.Name = "PositionPriceLabel";
            this.PositionPriceLabel.Size = new System.Drawing.Size(232, 48);
            this.PositionPriceLabel.TabIndex = 3;
            this.PositionPriceLabel.Text = "PositionPrice:";
            // 
            // PositionCountLabel
            // 
            this.PositionCountLabel.AutoSize = true;
            this.PositionCountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionCountLabel.Location = new System.Drawing.Point(831, 15);
            this.PositionCountLabel.Name = "PositionCountLabel";
            this.PositionCountLabel.Size = new System.Drawing.Size(249, 48);
            this.PositionCountLabel.TabIndex = 4;
            this.PositionCountLabel.Text = "PositionCount:";
            // 
            // FullOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PositionCountLabel);
            this.Controls.Add(this.PositionPriceLabel);
            this.Controls.Add(this.PositionNameLabel);
            this.Controls.Add(this.PositionTypeLabel);
            this.Name = "FullOrderUC";
            this.Size = new System.Drawing.Size(1239, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionTypeLabel;
        private System.Windows.Forms.Label PositionNameLabel;
        private System.Windows.Forms.Label PositionPriceLabel;
        private System.Windows.Forms.Label PositionCountLabel;
    }
}
