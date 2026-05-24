namespace CourseWorkFront
{
    partial class FullReviewWindow
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
            this.ServiceRatingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TasteRatingPanel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServiceRatingLabel
            // 
            this.ServiceRatingLabel.AutoSize = true;
            this.ServiceRatingLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceRatingLabel.Location = new System.Drawing.Point(300, 9);
            this.ServiceRatingLabel.Name = "ServiceRatingLabel";
            this.ServiceRatingLabel.Size = new System.Drawing.Size(430, 54);
            this.ServiceRatingLabel.TabIndex = 8;
            this.ServiceRatingLabel.Text = "Service Rating Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Service Rating:";
            // 
            // TasteRatingPanel
            // 
            this.TasteRatingPanel.AutoSize = true;
            this.TasteRatingPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasteRatingPanel.Location = new System.Drawing.Point(319, 63);
            this.TasteRatingPanel.Name = "TasteRatingPanel";
            this.TasteRatingPanel.Size = new System.Drawing.Size(395, 54);
            this.TasteRatingPanel.TabIndex = 10;
            this.TasteRatingPanel.Text = "Taste Rating Number";
            this.TasteRatingPanel.Click += new System.EventHandler(this.TasteRatingPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taste Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(21, 175);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(709, 295);
            this.MessageTextBox.TabIndex = 13;
            // 
            // FullReviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 954);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TasteRatingPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceRatingLabel);
            this.Name = "FullReviewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullReviewWindow";
            this.Shown += new System.EventHandler(this.FullReviewWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceRatingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TasteRatingPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}