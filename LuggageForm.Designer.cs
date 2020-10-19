namespace OxygenCalculator
{
    partial class LuggageForm
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
            this.SegmentListBox = new System.Windows.Forms.ListBox();
            this.LuggageLabel = new System.Windows.Forms.Label();
            this.LuggageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddB = new System.Windows.Forms.Button();
            this.SelectB = new System.Windows.Forms.Button();
            this.RemoveB = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SegmentListBox
            // 
            this.SegmentListBox.FormattingEnabled = true;
            this.SegmentListBox.ItemHeight = 20;
            this.SegmentListBox.Location = new System.Drawing.Point(32, 86);
            this.SegmentListBox.Name = "SegmentListBox";
            this.SegmentListBox.Size = new System.Drawing.Size(249, 384);
            this.SegmentListBox.TabIndex = 20;
            // 
            // LuggageLabel
            // 
            this.LuggageLabel.AutoSize = true;
            this.LuggageLabel.Location = new System.Drawing.Point(390, 198);
            this.LuggageLabel.Name = "LuggageLabel";
            this.LuggageLabel.Size = new System.Drawing.Size(51, 20);
            this.LuggageLabel.TabIndex = 21;
            this.LuggageLabel.Text = "label1";
            // 
            // LuggageBox
            // 
            this.LuggageBox.Location = new System.Drawing.Point(506, 195);
            this.LuggageBox.Name = "LuggageBox";
            this.LuggageBox.Size = new System.Drawing.Size(171, 26);
            this.LuggageBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "kg";
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(506, 267);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(171, 29);
            this.AddB.TabIndex = 24;
            this.AddB.Text = "button1";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SelectB
            // 
            this.SelectB.Location = new System.Drawing.Point(506, 86);
            this.SelectB.Name = "SelectB";
            this.SelectB.Size = new System.Drawing.Size(171, 29);
            this.SelectB.TabIndex = 25;
            this.SelectB.Text = "button1";
            this.SelectB.UseVisualStyleBackColor = true;
            this.SelectB.Click += new System.EventHandler(this.SelectB_Click);
            // 
            // RemoveB
            // 
            this.RemoveB.Location = new System.Drawing.Point(506, 441);
            this.RemoveB.Name = "RemoveB";
            this.RemoveB.Size = new System.Drawing.Size(171, 29);
            this.RemoveB.TabIndex = 26;
            this.RemoveB.Text = "button1";
            this.RemoveB.UseVisualStyleBackColor = true;
            this.RemoveB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(225, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(313, 26);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "Изчисли Ресурси за Мисия";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LuggageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RemoveB);
            this.Controls.Add(this.SelectB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LuggageBox);
            this.Controls.Add(this.LuggageLabel);
            this.Controls.Add(this.SegmentListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LuggageForm";
            this.Text = "LuggageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SegmentListBox;
        private System.Windows.Forms.Label LuggageLabel;
        private System.Windows.Forms.TextBox LuggageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button SelectB;
        private System.Windows.Forms.Button RemoveB;
        private System.Windows.Forms.Label TitleLabel;
    }
}