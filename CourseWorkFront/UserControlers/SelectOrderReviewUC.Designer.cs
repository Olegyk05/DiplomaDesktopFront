namespace CourseWorkFront.UserControlers
{
    partial class SelectOrderReviewUC
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
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderCompletionTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberLabel.Location = new System.Drawing.Point(3, 21);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(68, 54);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "№";
            // 
            // OrderCompletionTimeLabel
            // 
            this.OrderCompletionTimeLabel.AutoSize = true;
            this.OrderCompletionTimeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCompletionTimeLabel.Location = new System.Drawing.Point(180, 21);
            this.OrderCompletionTimeLabel.Name = "OrderCompletionTimeLabel";
            this.OrderCompletionTimeLabel.Size = new System.Drawing.Size(106, 54);
            this.OrderCompletionTimeLabel.TabIndex = 1;
            this.OrderCompletionTimeLabel.Text = "Date";
            // 
            // SelectOrderReviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.OrderCompletionTimeLabel);
            this.Controls.Add(this.OrderNumberLabel);
            this.Name = "SelectOrderReviewUC";
            this.Size = new System.Drawing.Size(598, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label OrderNumberLabel;
        public System.Windows.Forms.Label OrderCompletionTimeLabel;
    }
}
