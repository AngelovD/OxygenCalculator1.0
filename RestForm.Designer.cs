namespace OxygenCalculator
{
    partial class RestForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RemoveB = new System.Windows.Forms.Button();
            this.SelectB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SegmentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(218, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(313, 26);
            this.TitleLabel.TabIndex = 44;
            this.TitleLabel.Text = "Изчисли Ресурси за Мисия";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveB
            // 
            this.RemoveB.Location = new System.Drawing.Point(499, 447);
            this.RemoveB.Name = "RemoveB";
            this.RemoveB.Size = new System.Drawing.Size(171, 29);
            this.RemoveB.TabIndex = 43;
            this.RemoveB.Text = "button1";
            this.RemoveB.UseVisualStyleBackColor = true;
            this.RemoveB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // SelectB
            // 
            this.SelectB.Location = new System.Drawing.Point(499, 92);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(171, 29);
            this.SelectB.TabIndex = 42;
            this.SelectB.Text = "button1";
            this.SelectB.UseVisualStyleBackColor = true;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(499, 273);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(171, 29);
            this.AddB.TabIndex = 41;
            this.AddB.Text = "button1";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "min";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(499, 201);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(171, 26);
            this.TimeBox.TabIndex = 39;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(383, 204);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(51, 20);
            this.TimeLabel.TabIndex = 38;
            this.TimeLabel.Text = "label1";
            // 
            // SegmentListBox
            // 
            this.SegmentListBox.FormattingEnabled = true;
            this.SegmentListBox.ItemHeight = 20;
            this.SegmentListBox.Location = new System.Drawing.Point(25, 92);
            this.SegmentListBox.Name = "SegmentListBox";
            this.SegmentListBox.Size = new System.Drawing.Size(249, 384);
            this.SegmentListBox.TabIndex = 37;
            // 
            // RestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 528);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RemoveB);
            this.Controls.Add(this.SelectB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SegmentListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RestForm";
            this.Text = "RestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button RemoveB;
        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ListBox SegmentListBox;
    }
}