namespace CourseWorkFront.UserControlers
{
    partial class PositionUC
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
            this.components = new System.ComponentModel.Container();
            this.PositionPictureBox = new System.Windows.Forms.PictureBox();
            this.PositionNameLabel = new System.Windows.Forms.Label();
            this.PositionPriceLabel = new System.Windows.Forms.Label();
            this.PositionUCContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPictureBox)).BeginInit();
            this.PositionUCContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PositionPictureBox
            // 
            this.PositionPictureBox.Location = new System.Drawing.Point(39, 6);
            this.PositionPictureBox.Name = "PositionPictureBox";
            this.PositionPictureBox.Size = new System.Drawing.Size(205, 199);
            this.PositionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PositionPictureBox.TabIndex = 0;
            this.PositionPictureBox.TabStop = false;
            // 
            // PositionNameLabel
            // 
            this.PositionNameLabel.AutoSize = true;
            this.PositionNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionNameLabel.Location = new System.Drawing.Point(3, 208);
            this.PositionNameLabel.Name = "PositionNameLabel";
            this.PositionNameLabel.Size = new System.Drawing.Size(254, 38);
            this.PositionNameLabel.TabIndex = 1;
            this.PositionNameLabel.Text = "PositionNameLabel";
            this.PositionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionPriceLabel
            // 
            this.PositionPriceLabel.AutoSize = true;
            this.PositionPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionPriceLabel.Location = new System.Drawing.Point(3, 246);
            this.PositionPriceLabel.Name = "PositionPriceLabel";
            this.PositionPriceLabel.Size = new System.Drawing.Size(241, 38);
            this.PositionPriceLabel.TabIndex = 2;
            this.PositionPriceLabel.Text = "PositionPriceLabel";
            this.PositionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionUCContextMenuStrip
            // 
            this.PositionUCContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PositionUCContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem1,
            this.ChangeToolStripMenu});
            this.PositionUCContextMenuStrip.Name = "PositionUCContextMenuStrip";
            this.PositionUCContextMenuStrip.ShowImageMargin = false;
            this.PositionUCContextMenuStrip.Size = new System.Drawing.Size(120, 68);
            // 
            // DeleteToolStripMenuItem1
            // 
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(119, 32);
            this.DeleteToolStripMenuItem1.Text = "Delete";
            // 
            // ChangeToolStripMenu
            // 
            this.ChangeToolStripMenu.Name = "ChangeToolStripMenu";
            this.ChangeToolStripMenu.Size = new System.Drawing.Size(119, 32);
            this.ChangeToolStripMenu.Text = "Change";
            this.ChangeToolStripMenu.Click += new System.EventHandler(this.ChangeToolStripMenu_Click);
            // 
            // PositionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PositionPriceLabel);
            this.Controls.Add(this.PositionNameLabel);
            this.Controls.Add(this.PositionPictureBox);
            this.Name = "PositionUC";
            this.Size = new System.Drawing.Size(286, 312);
            this.Load += new System.EventHandler(this.PositionUC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PositionUC_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PositionPictureBox)).EndInit();
            this.PositionUCContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PositionPictureBox;
        private System.Windows.Forms.Label PositionNameLabel;
        private System.Windows.Forms.Label PositionPriceLabel;
        private System.Windows.Forms.ContextMenuStrip PositionUCContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenu;
    }
}
