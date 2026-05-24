namespace CourseWorkFront.UserControlers
{
    partial class ChangePositionData
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PositionPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(546, 88);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(106, 48);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "Error:";
            this.ErrorLabel.Visible = false;
            // 
            // PositionPriceTextBox
            // 
            this.PositionPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceTextBox.Location = new System.Drawing.Point(534, 276);
            this.PositionPriceTextBox.Name = "PositionPriceTextBox";
            this.PositionPriceTextBox.Size = new System.Drawing.Size(300, 55);
            this.PositionPriceTextBox.TabIndex = 8;
            this.PositionPriceTextBox.TextChanged += new System.EventHandler(this.PositionPriceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(281, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position Price:";
            // 
            // PositionNameTextBox
            // 
            this.PositionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameTextBox.Location = new System.Drawing.Point(534, 214);
            this.PositionNameTextBox.Name = "PositionNameTextBox";
            this.PositionNameTextBox.Size = new System.Drawing.Size(300, 55);
            this.PositionNameTextBox.TabIndex = 6;
            this.PositionNameTextBox.TextChanged += new System.EventHandler(this.PositionNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position Name:";
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDataButton.Location = new System.Drawing.Point(534, 453);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(244, 87);
            this.ChangeDataButton.TabIndex = 10;
            this.ChangeDataButton.Text = "Change Data";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // ChangePositionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 735);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PositionPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangePositionData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePositionData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox PositionPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PositionNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeDataButton;
    }
}