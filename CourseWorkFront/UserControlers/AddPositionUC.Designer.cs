namespace CourseWorkFront.UserControlers
{
    partial class AddPositionUC
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
            this.PositionPriceLabel = new System.Windows.Forms.Label();
            this.PositionNameLabel = new System.Windows.Forms.Label();
            this.PositionPictureBox = new System.Windows.Forms.PictureBox();
            this.PositionCountLabel = new System.Windows.Forms.Label();
            this.AddCountButton = new System.Windows.Forms.Button();
            this.MinusCountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionPriceLabel
            // 
            this.PositionPriceLabel.AutoSize = true;
            this.PositionPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceLabel.Location = new System.Drawing.Point(6, 240);
            this.PositionPriceLabel.Name = "PositionPriceLabel";
            this.PositionPriceLabel.Size = new System.Drawing.Size(241, 38);
            this.PositionPriceLabel.TabIndex = 5;
            this.PositionPriceLabel.Text = "PositionPriceLabel";
            this.PositionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionNameLabel
            // 
            this.PositionNameLabel.AutoSize = true;
            this.PositionNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameLabel.Location = new System.Drawing.Point(6, 202);
            this.PositionNameLabel.Name = "PositionNameLabel";
            this.PositionNameLabel.Size = new System.Drawing.Size(254, 38);
            this.PositionNameLabel.TabIndex = 4;
            this.PositionNameLabel.Text = "PositionNameLabel";
            this.PositionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionPictureBox
            // 
            this.PositionPictureBox.Location = new System.Drawing.Point(42, 0);
            this.PositionPictureBox.Name = "PositionPictureBox";
            this.PositionPictureBox.Size = new System.Drawing.Size(205, 199);
            this.PositionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PositionPictureBox.TabIndex = 3;
            this.PositionPictureBox.TabStop = false;
            // 
            // PositionCountLabel
            // 
            this.PositionCountLabel.AutoSize = true;
            this.PositionCountLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionCountLabel.Location = new System.Drawing.Point(83, 284);
            this.PositionCountLabel.Name = "PositionCountLabel";
            this.PositionCountLabel.Size = new System.Drawing.Size(91, 38);
            this.PositionCountLabel.TabIndex = 6;
            this.PositionCountLabel.Text = "Count";
            this.PositionCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCountButton
            // 
            this.AddCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCountButton.Location = new System.Drawing.Point(180, 281);
            this.AddCountButton.Name = "AddCountButton";
            this.AddCountButton.Size = new System.Drawing.Size(53, 41);
            this.AddCountButton.TabIndex = 7;
            this.AddCountButton.Text = "+";
            this.AddCountButton.UseVisualStyleBackColor = true;
            this.AddCountButton.Click += new System.EventHandler(this.AddCountButton_Click);
            // 
            // MinusCountButton
            // 
            this.MinusCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusCountButton.Location = new System.Drawing.Point(33, 281);
            this.MinusCountButton.Name = "MinusCountButton";
            this.MinusCountButton.Size = new System.Drawing.Size(53, 41);
            this.MinusCountButton.TabIndex = 8;
            this.MinusCountButton.Text = "-";
            this.MinusCountButton.UseVisualStyleBackColor = true;
            this.MinusCountButton.Click += new System.EventHandler(this.MinusCountButton_Click);
            // 
            // AddPositionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MinusCountButton);
            this.Controls.Add(this.AddCountButton);
            this.Controls.Add(this.PositionCountLabel);
            this.Controls.Add(this.PositionPriceLabel);
            this.Controls.Add(this.PositionNameLabel);
            this.Controls.Add(this.PositionPictureBox);
            this.Name = "AddPositionUC";
            this.Size = new System.Drawing.Size(284, 346);
            ((System.ComponentModel.ISupportInitialize)(this.PositionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionPriceLabel;
        private System.Windows.Forms.Label PositionNameLabel;
        private System.Windows.Forms.PictureBox PositionPictureBox;
        private System.Windows.Forms.Label PositionCountLabel;
        private System.Windows.Forms.Button AddCountButton;
        private System.Windows.Forms.Button MinusCountButton;
    }
}
