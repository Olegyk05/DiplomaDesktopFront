namespace CourseWorkFront
{
    partial class AddNewPositionToDBWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.PositionNameTextBox = new System.Windows.Forms.TextBox();
            this.PositionPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AddDrinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Name:";
            // 
            // PositionNameTextBox
            // 
            this.PositionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameTextBox.Location = new System.Drawing.Point(412, 161);
            this.PositionNameTextBox.Name = "PositionNameTextBox";
            this.PositionNameTextBox.Size = new System.Drawing.Size(300, 55);
            this.PositionNameTextBox.TabIndex = 1;
            this.PositionNameTextBox.TextChanged += new System.EventHandler(this.PositionNameTextBox_TextChanged);
            // 
            // PositionPriceTextBox
            // 
            this.PositionPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceTextBox.Location = new System.Drawing.Point(412, 223);
            this.PositionPriceTextBox.Name = "PositionPriceTextBox";
            this.PositionPriceTextBox.Size = new System.Drawing.Size(300, 55);
            this.PositionPriceTextBox.TabIndex = 3;
            this.PositionPriceTextBox.TextChanged += new System.EventHandler(this.PositionPriceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(159, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position Price:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(424, 35);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(106, 48);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Error:";
            this.ErrorLabel.Visible = false;
            // 
            // AddDrinkButton
            // 
            this.AddDrinkButton.AutoSize = true;
            this.AddDrinkButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDrinkButton.Location = new System.Drawing.Point(412, 520);
            this.AddDrinkButton.Name = "AddDrinkButton";
            this.AddDrinkButton.Size = new System.Drawing.Size(231, 87);
            this.AddDrinkButton.TabIndex = 7;
            this.AddDrinkButton.Text = "Add Position";
            this.AddDrinkButton.UseVisualStyleBackColor = true;
            this.AddDrinkButton.Click += new System.EventHandler(this.AddDrinkButton_Click);
            // 
            // AddNewPositionToDBWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 708);
            this.Controls.Add(this.AddDrinkButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PositionPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewPositionToDBWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewPositionToDBWindow";
            this.Load += new System.EventHandler(this.AddNewPositionToDBWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PositionNameTextBox;
        private System.Windows.Forms.TextBox PositionPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button AddDrinkButton;
    }
}