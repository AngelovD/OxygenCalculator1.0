namespace OxygenCalculator
{
    partial class WorkerForm
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
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.SpeedBox = new System.Windows.Forms.TextBox();
            this.TireBox = new System.Windows.Forms.TextBox();
            this.OxygenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApparatusBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveB = new System.Windows.Forms.Button();
            this.UpdateWorkerB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(202, 86);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(289, 26);
            this.NameBox.TabIndex = 0;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(202, 151);
            this.HeightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(289, 26);
            this.HeightBox.TabIndex = 1;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(202, 225);
            this.WeightBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(289, 26);
            this.WeightBox.TabIndex = 2;
            // 
            // SpeedBox
            // 
            this.SpeedBox.Location = new System.Drawing.Point(746, 151);
            this.SpeedBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(286, 26);
            this.SpeedBox.TabIndex = 3;
            // 
            // TireBox
            // 
            this.TireBox.Location = new System.Drawing.Point(746, 225);
            this.TireBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TireBox.Name = "TireBox";
            this.TireBox.Size = new System.Drawing.Size(286, 26);
            this.TireBox.TabIndex = 4;
            // 
            // OxygenBox
            // 
            this.OxygenBox.Location = new System.Drawing.Point(746, 86);
            this.OxygenBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OxygenBox.Name = "OxygenBox";
            this.OxygenBox.Size = new System.Drawing.Size(286, 26);
            this.OxygenBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ръст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тегло";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Консумация на кислород";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Скорост";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Умора за 100 метра";
            // 
            // ApparatusBox
            // 
            this.ApparatusBox.FormattingEnabled = true;
            this.ApparatusBox.ItemHeight = 20;
            this.ApparatusBox.Location = new System.Drawing.Point(202, 315);
            this.ApparatusBox.Name = "ApparatusBox";
            this.ApparatusBox.Size = new System.Drawing.Size(436, 264);
            this.ApparatusBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Изберете апарат";
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(859, 330);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(90, 31);
            this.SaveB.TabIndex = 14;
            this.SaveB.Text = "Запази";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // UpdateWorkerB
            // 
            this.UpdateWorkerB.Location = new System.Drawing.Point(859, 522);
            this.UpdateWorkerB.Name = "UpdateWorkerB";
            this.UpdateWorkerB.Size = new System.Drawing.Size(90, 31);
            this.UpdateWorkerB.TabIndex = 15;
            this.UpdateWorkerB.Text = "Обнови";
            this.UpdateWorkerB.UseVisualStyleBackColor = true;
            this.UpdateWorkerB.Click += new System.EventHandler(this.UpdateWorkerB_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 626);
            this.Controls.Add(this.UpdateWorkerB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ApparatusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OxygenBox);
            this.Controls.Add(this.TireBox);
            this.Controls.Add(this.SpeedBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.NameBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox SpeedBox;
        private System.Windows.Forms.TextBox TireBox;
        private System.Windows.Forms.TextBox OxygenBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ApparatusBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button UpdateWorkerB;
    }
}