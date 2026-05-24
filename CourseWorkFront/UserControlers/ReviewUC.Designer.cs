namespace CourseWorkFront.UserControlers
{
    partial class ReviewUC
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
            this.TasteRatingPanel = new System.Windows.Forms.Label();
            this.ServiceRatingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TasteRatingPanel
            // 
            this.TasteRatingPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasteRatingPanel.Location = new System.Drawing.Point(163, 12);
            this.TasteRatingPanel.Name = "TasteRatingPanel";
            this.TasteRatingPanel.Size = new System.Drawing.Size(103, 79);
            this.TasteRatingPanel.TabIndex = 8;
            this.TasteRatingPanel.Text = "Taste Rating";
            // 
            // ServiceRatingLabel
            // 
            this.ServiceRatingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceRatingLabel.Location = new System.Drawing.Point(12, 12);
            this.ServiceRatingLabel.Name = "ServiceRatingLabel";
            this.ServiceRatingLabel.Size = new System.Drawing.Size(113, 79);
            this.ServiceRatingLabel.TabIndex = 7;
            this.ServiceRatingLabel.Text = "Service Rating";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TasteRatingPanel);
            this.Controls.Add(this.ServiceRatingLabel);
            this.Name = "ReviewUC";
            this.Size = new System.Drawing.Size(596, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TasteRatingPanel;
        private System.Windows.Forms.Label ServiceRatingLabel;
        private System.Windows.Forms.Button button1;
    }
}
