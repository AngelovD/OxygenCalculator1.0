namespace OxygenCalculator
{
    partial class SegmentForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LenghtBox = new System.Windows.Forms.TextBox();
            this.EntryBox = new System.Windows.Forms.TextBox();
            this.ExitBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.ObstaclesBox = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.EntrySpeedLabel = new System.Windows.Forms.Label();
            this.ExitSpeedLabel = new System.Windows.Forms.Label();
            this.FloorB = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ObstaclesLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EntryConsumeLabel = new System.Windows.Forms.Label();
            this.EntryOxygenBox = new System.Windows.Forms.TextBox();
            this.ExitConsumeLabel = new System.Windows.Forms.Label();
            this.ExitOxygenBox = new System.Windows.Forms.TextBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(358, 89);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(289, 26);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // LenghtBox
            // 
            this.LenghtBox.Location = new System.Drawing.Point(358, 147);
            this.LenghtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LenghtBox.Name = "LenghtBox";
            this.LenghtBox.Size = new System.Drawing.Size(289, 26);
            this.LenghtBox.TabIndex = 2;
            // 
            // EntryBox
            // 
            this.EntryBox.Location = new System.Drawing.Point(358, 204);
            this.EntryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Size = new System.Drawing.Size(289, 26);
            this.EntryBox.TabIndex = 3;
            // 
            // ExitBox
            // 
            this.ExitBox.Location = new System.Drawing.Point(1036, 204);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(289, 26);
            this.ExitBox.TabIndex = 4;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(1036, 89);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(289, 26);
            this.HeightBox.TabIndex = 5;
            // 
            // ObstaclesBox
            // 
            this.ObstaclesBox.Location = new System.Drawing.Point(358, 314);
            this.ObstaclesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObstaclesBox.Name = "ObstaclesBox";
            this.ObstaclesBox.Size = new System.Drawing.Size(289, 26);
            this.ObstaclesBox.TabIndex = 7;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(651, 379);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(90, 31);
            this.SaveB.TabIndex = 15;
            this.SaveB.Text = "Запази";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(21, 86);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 20);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Име";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(21, 147);
            this.LenghtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(80, 20);
            this.LenghtLabel.TabIndex = 17;
            this.LenghtLabel.Text = "Дължина";
            // 
            // EntrySpeedLabel
            // 
            this.EntrySpeedLabel.AutoSize = true;
            this.EntrySpeedLabel.Location = new System.Drawing.Point(21, 204);
            this.EntrySpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntrySpeedLabel.Name = "EntrySpeedLabel";
            this.EntrySpeedLabel.Size = new System.Drawing.Size(290, 20);
            this.EntrySpeedLabel.TabIndex = 18;
            this.EntrySpeedLabel.Text = "Коефициент на скорост при влизане";
            this.EntrySpeedLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ExitSpeedLabel
            // 
            this.ExitSpeedLabel.AutoSize = true;
            this.ExitSpeedLabel.Location = new System.Drawing.Point(698, 204);
            this.ExitSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitSpeedLabel.Name = "ExitSpeedLabel";
            this.ExitSpeedLabel.Size = new System.Drawing.Size(298, 20);
            this.ExitSpeedLabel.TabIndex = 19;
            this.ExitSpeedLabel.Text = "Коефициент на скорост при излизане";
            // 
            // FloorB
            // 
            this.FloorB.AutoSize = true;
            this.FloorB.Location = new System.Drawing.Point(1036, 315);
            this.FloorB.Name = "FloorB";
            this.FloorB.Size = new System.Drawing.Size(113, 24);
            this.FloorB.TabIndex = 20;
            this.FloorB.TabStop = true;
            this.FloorB.Text = "Мокър Под";
            this.FloorB.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(845, 89);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(82, 20);
            this.HeightLabel.TabIndex = 21;
            this.HeightLabel.Text = "Височина";
            // 
            // ObstaclesLabel
            // 
            this.ObstaclesLabel.AutoSize = true;
            this.ObstaclesLabel.Location = new System.Drawing.Point(21, 314);
            this.ObstaclesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ObstaclesLabel.Name = "ObstaclesLabel";
            this.ObstaclesLabel.Size = new System.Drawing.Size(112, 20);
            this.ObstaclesLabel.TabIndex = 23;
            this.ObstaclesLabel.Text = "Препядстивя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1333, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(655, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "min";
            // 
            // EntryConsumeLabel
            // 
            this.EntryConsumeLabel.AutoSize = true;
            this.EntryConsumeLabel.Location = new System.Drawing.Point(21, 268);
            this.EntryConsumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntryConsumeLabel.Name = "EntryConsumeLabel";
            this.EntryConsumeLabel.Size = new System.Drawing.Size(318, 20);
            this.EntryConsumeLabel.TabIndex = 28;
            this.EntryConsumeLabel.Text = "Коефициент на консумация при влизане";
            // 
            // EntryOxygenBox
            // 
            this.EntryOxygenBox.Location = new System.Drawing.Point(358, 265);
            this.EntryOxygenBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntryOxygenBox.Name = "EntryOxygenBox";
            this.EntryOxygenBox.Size = new System.Drawing.Size(289, 26);
            this.EntryOxygenBox.TabIndex = 27;
            // 
            // ExitConsumeLabel
            // 
            this.ExitConsumeLabel.AutoSize = true;
            this.ExitConsumeLabel.Location = new System.Drawing.Point(698, 265);
            this.ExitConsumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitConsumeLabel.Name = "ExitConsumeLabel";
            this.ExitConsumeLabel.Size = new System.Drawing.Size(326, 20);
            this.ExitConsumeLabel.TabIndex = 30;
            this.ExitConsumeLabel.Text = "Коефициент на консумация при излизане";
            // 
            // ExitOxygenBox
            // 
            this.ExitOxygenBox.Location = new System.Drawing.Point(1036, 262);
            this.ExitOxygenBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitOxygenBox.Name = "ExitOxygenBox";
            this.ExitOxygenBox.Size = new System.Drawing.Size(289, 26);
            this.ExitOxygenBox.TabIndex = 29;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Location = new System.Drawing.Point(845, 147);
            this.TempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(112, 20);
            this.TempLabel.TabIndex = 32;
            this.TempLabel.Text = "Температура ";
            // 
            // TempBox
            // 
            this.TempBox.Location = new System.Drawing.Point(1036, 144);
            this.TempBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(289, 26);
            this.TempBox.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1333, 147);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "°C";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(560, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(313, 26);
            this.TitleLabel.TabIndex = 36;
            this.TitleLabel.Text = "Изчисли Ресурси за Мисия";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1398, 445);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.TempBox);
            this.Controls.Add(this.ExitConsumeLabel);
            this.Controls.Add(this.ExitOxygenBox);
            this.Controls.Add(this.EntryConsumeLabel);
            this.Controls.Add(this.EntryOxygenBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ObstaclesLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.FloorB);
            this.Controls.Add(this.ExitSpeedLabel);
            this.Controls.Add(this.EntrySpeedLabel);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.ObstaclesBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.EntryBox);
            this.Controls.Add(this.LenghtBox);
            this.Controls.Add(this.NameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SegmentForm";
            this.Text = "SegmentForm";
            this.Load += new System.EventHandler(this.SegmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LenghtBox;
        private System.Windows.Forms.TextBox EntryBox;
        private System.Windows.Forms.TextBox ExitBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox ObstaclesBox;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.Label EntrySpeedLabel;
        private System.Windows.Forms.Label ExitSpeedLabel;
        private System.Windows.Forms.RadioButton FloorB;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label ObstaclesLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EntryConsumeLabel;
        private System.Windows.Forms.TextBox EntryOxygenBox;
        private System.Windows.Forms.Label ExitConsumeLabel;
        private System.Windows.Forms.TextBox ExitOxygenBox;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TitleLabel;
    }
}