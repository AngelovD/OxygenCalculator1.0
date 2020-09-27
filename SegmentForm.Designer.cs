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
            this.StartBox = new System.Windows.Forms.TextBox();
            this.ObstaclesBox = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FloorB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(262, 91);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(289, 26);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // LenghtBox
            // 
            this.LenghtBox.Location = new System.Drawing.Point(262, 161);
            this.LenghtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LenghtBox.Name = "LenghtBox";
            this.LenghtBox.Size = new System.Drawing.Size(289, 26);
            this.LenghtBox.TabIndex = 2;
            // 
            // EntryBox
            // 
            this.EntryBox.Location = new System.Drawing.Point(262, 229);
            this.EntryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Size = new System.Drawing.Size(289, 26);
            this.EntryBox.TabIndex = 3;
            // 
            // ExitBox
            // 
            this.ExitBox.Location = new System.Drawing.Point(262, 300);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(289, 26);
            this.ExitBox.TabIndex = 4;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(743, 91);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(289, 26);
            this.HeightBox.TabIndex = 5;
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(743, 161);
            this.StartBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(289, 26);
            this.StartBox.TabIndex = 6;
            // 
            // ObstaclesBox
            // 
            this.ObstaclesBox.Location = new System.Drawing.Point(743, 229);
            this.ObstaclesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObstaclesBox.Name = "ObstaclesBox";
            this.ObstaclesBox.Size = new System.Drawing.Size(289, 26);
            this.ObstaclesBox.TabIndex = 7;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(533, 381);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(90, 31);
            this.SaveB.TabIndex = 15;
            this.SaveB.Text = "Запази";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Дължина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Коефициент при влизане";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Коефициент при излизане";
            // 
            // FloorB
            // 
            this.FloorB.AutoSize = true;
            this.FloorB.Location = new System.Drawing.Point(743, 302);
            this.FloorB.Name = "FloorB";
            this.FloorB.Size = new System.Drawing.Size(113, 24);
            this.FloorB.TabIndex = 20;
            this.FloorB.TabStop = true;
            this.FloorB.Text = "Мокър Под";
            this.FloorB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Височина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Начална точка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Препядстивя";
            // 
            // SegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 445);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FloorB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.ObstaclesBox);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.EntryBox);
            this.Controls.Add(this.LenghtBox);
            this.Controls.Add(this.NameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SegmentForm";
            this.Text = "SegmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LenghtBox;
        private System.Windows.Forms.TextBox EntryBox;
        private System.Windows.Forms.TextBox ExitBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox ObstaclesBox;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton FloorB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}