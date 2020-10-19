namespace OxygenCalculator
{
    partial class DeleteApparatus
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
            this.ApparatusBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApparatusBox
            // 
            this.ApparatusBox.FormattingEnabled = true;
            this.ApparatusBox.ItemHeight = 20;
            this.ApparatusBox.Location = new System.Drawing.Point(79, 71);
            this.ApparatusBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApparatusBox.Name = "ApparatusBox";
            this.ApparatusBox.Size = new System.Drawing.Size(408, 424);
            this.ApparatusBox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(235, 24);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(25, 26);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "1";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(153, 530);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(256, 43);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteApparatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 598);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ApparatusBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteApparatus";
            this.Text = "DeleteApparatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ApparatusBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button Delete;
    }
}