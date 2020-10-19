namespace OxygenCalculator
{
    partial class Form1
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
            this.WorkerLabel = new System.Windows.Forms.Label();
            this.WorkersLabel = new System.Windows.Forms.Label();
            this.SegmentLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.CreateWorkerB = new System.Windows.Forms.Button();
            this.ChooseWorkerB = new System.Windows.Forms.Button();
            this.DeleteWorkerB = new System.Windows.Forms.Button();
            this.CreateApparatusB = new System.Windows.Forms.Button();
            this.DeleteApparatusB = new System.Windows.Forms.Button();
            this.DeleteBreakB = new System.Windows.Forms.Button();
            this.AddBreakB = new System.Windows.Forms.Button();
            this.RemoveLuggageB = new System.Windows.Forms.Button();
            this.AddLuggageB = new System.Windows.Forms.Button();
            this.DeleteSegmentB = new System.Windows.Forms.Button();
            this.CreateSegmentB = new System.Windows.Forms.Button();
            this.WorkerListBox = new System.Windows.Forms.ListBox();
            this.SegmentListBox = new System.Windows.Forms.ListBox();
            this.CalculateB = new System.Windows.Forms.Button();
            this.OxygenForExitB = new System.Windows.Forms.Button();
            this.OxygenForEntryB = new System.Windows.Forms.Button();
            this.OxygenOnExitB = new System.Windows.Forms.Button();
            this.OxygenOnEntryB = new System.Windows.Forms.Button();
            this.RemainingTimeB = new System.Windows.Forms.Button();
            this.TimeForPathB = new System.Windows.Forms.Button();
            this.TimeForExitB = new System.Windows.Forms.Button();
            this.TimeForEntryB = new System.Windows.Forms.Button();
            this.PathLengthB = new System.Windows.Forms.Button();
            this.SaveResultsB = new System.Windows.Forms.Button();
            this.ChangeValuesB = new System.Windows.Forms.Button();
            this.ChooseWorkerLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkerLabel
            // 
            this.WorkerLabel.AutoSize = true;
            this.WorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerLabel.Location = new System.Drawing.Point(68, 123);
            this.WorkerLabel.Name = "WorkerLabel";
            this.WorkerLabel.Size = new System.Drawing.Size(91, 20);
            this.WorkerLabel.TabIndex = 0;
            this.WorkerLabel.Text = "Спасител";
            this.WorkerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WorkersLabel
            // 
            this.WorkersLabel.AutoSize = true;
            this.WorkersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkersLabel.Location = new System.Drawing.Point(358, 123);
            this.WorkersLabel.Name = "WorkersLabel";
            this.WorkersLabel.Size = new System.Drawing.Size(106, 20);
            this.WorkersLabel.TabIndex = 1;
            this.WorkersLabel.Text = "Спасители:";
            this.WorkersLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SegmentLabel
            // 
            this.SegmentLabel.AutoSize = true;
            this.SegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentLabel.Location = new System.Drawing.Point(694, 123);
            this.SegmentLabel.Name = "SegmentLabel";
            this.SegmentLabel.Size = new System.Drawing.Size(81, 20);
            this.SegmentLabel.TabIndex = 2;
            this.SegmentLabel.Text = "Сегмент";
            this.SegmentLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.Location = new System.Drawing.Point(983, 123);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(96, 20);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Сегменти:";
            this.PathLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreateWorkerB
            // 
            this.CreateWorkerB.Location = new System.Drawing.Point(31, 170);
            this.CreateWorkerB.Name = "CreateWorkerB";
            this.CreateWorkerB.Size = new System.Drawing.Size(171, 28);
            this.CreateWorkerB.TabIndex = 4;
            this.CreateWorkerB.Text = "Създай Спасител";
            this.CreateWorkerB.UseVisualStyleBackColor = true;
            this.CreateWorkerB.Click += new System.EventHandler(this.CreateWorkerB_Click);
            // 
            // ChooseWorkerB
            // 
            this.ChooseWorkerB.Location = new System.Drawing.Point(31, 221);
            this.ChooseWorkerB.Name = "ChooseWorkerB";
            this.ChooseWorkerB.Size = new System.Drawing.Size(171, 28);
            this.ChooseWorkerB.TabIndex = 5;
            this.ChooseWorkerB.Text = "Избери Спасител";
            this.ChooseWorkerB.UseVisualStyleBackColor = true;
            this.ChooseWorkerB.Click += new System.EventHandler(this.ChooseWorkerB_Click);
            // 
            // DeleteWorkerB
            // 
            this.DeleteWorkerB.Location = new System.Drawing.Point(31, 278);
            this.DeleteWorkerB.Name = "DeleteWorkerB";
            this.DeleteWorkerB.Size = new System.Drawing.Size(171, 28);
            this.DeleteWorkerB.TabIndex = 7;
            this.DeleteWorkerB.Text = "Изтрий Спасител";
            this.DeleteWorkerB.UseVisualStyleBackColor = true;
            this.DeleteWorkerB.Click += new System.EventHandler(this.DeleteWorkerB_Click);
            // 
            // CreateApparatusB
            // 
            this.CreateApparatusB.Location = new System.Drawing.Point(31, 338);
            this.CreateApparatusB.Name = "CreateApparatusB";
            this.CreateApparatusB.Size = new System.Drawing.Size(171, 28);
            this.CreateApparatusB.TabIndex = 8;
            this.CreateApparatusB.Text = "Създай Апарат";
            this.CreateApparatusB.UseVisualStyleBackColor = true;
            this.CreateApparatusB.Click += new System.EventHandler(this.CreateApparatusB_Click);
            // 
            // DeleteApparatusB
            // 
            this.DeleteApparatusB.Location = new System.Drawing.Point(31, 398);
            this.DeleteApparatusB.Name = "DeleteApparatusB";
            this.DeleteApparatusB.Size = new System.Drawing.Size(171, 28);
            this.DeleteApparatusB.TabIndex = 10;
            this.DeleteApparatusB.Text = "Изтрий Апарат";
            this.DeleteApparatusB.UseVisualStyleBackColor = true;
            this.DeleteApparatusB.Click += new System.EventHandler(this.DeleteApparatusB_Click);
            // 
            // DeleteBreakB
            // 
            this.DeleteBreakB.Location = new System.Drawing.Point(647, 463);
            this.DeleteBreakB.Name = "DeleteBreakB";
            this.DeleteBreakB.Size = new System.Drawing.Size(168, 28);
            this.DeleteBreakB.TabIndex = 17;
            this.DeleteBreakB.Text = "Изтрий Почивка";
            this.DeleteBreakB.UseVisualStyleBackColor = true;
            this.DeleteBreakB.Click += new System.EventHandler(this.DeleteBreakB_Click);
            // 
            // AddBreakB
            // 
            this.AddBreakB.Location = new System.Drawing.Point(647, 398);
            this.AddBreakB.Name = "AddBreakB";
            this.AddBreakB.Size = new System.Drawing.Size(168, 28);
            this.AddBreakB.TabIndex = 16;
            this.AddBreakB.Text = "Добави Почивка";
            this.AddBreakB.UseVisualStyleBackColor = true;
            this.AddBreakB.Click += new System.EventHandler(this.AddBreakB_Click);
            // 
            // RemoveLuggageB
            // 
            this.RemoveLuggageB.Location = new System.Drawing.Point(647, 337);
            this.RemoveLuggageB.Name = "RemoveLuggageB";
            this.RemoveLuggageB.Size = new System.Drawing.Size(168, 28);
            this.RemoveLuggageB.TabIndex = 15;
            this.RemoveLuggageB.Text = "Премахни Товар";
            this.RemoveLuggageB.UseVisualStyleBackColor = true;
            this.RemoveLuggageB.Click += new System.EventHandler(this.RemoveLuggageB_Click);
            // 
            // AddLuggageB
            // 
            this.AddLuggageB.Location = new System.Drawing.Point(647, 277);
            this.AddLuggageB.Name = "AddLuggageB";
            this.AddLuggageB.Size = new System.Drawing.Size(168, 28);
            this.AddLuggageB.TabIndex = 14;
            this.AddLuggageB.Text = "Добави Товар";
            this.AddLuggageB.UseVisualStyleBackColor = true;
            this.AddLuggageB.Click += new System.EventHandler(this.AddLuggageB_Click);
            // 
            // DeleteSegmentB
            // 
            this.DeleteSegmentB.Location = new System.Drawing.Point(647, 221);
            this.DeleteSegmentB.Name = "DeleteSegmentB";
            this.DeleteSegmentB.Size = new System.Drawing.Size(168, 28);
            this.DeleteSegmentB.TabIndex = 13;
            this.DeleteSegmentB.Text = "Изтрий Участък";
            this.DeleteSegmentB.UseVisualStyleBackColor = true;
            this.DeleteSegmentB.Click += new System.EventHandler(this.DeleteSegmentB_Click);
            // 
            // CreateSegmentB
            // 
            this.CreateSegmentB.Location = new System.Drawing.Point(647, 170);
            this.CreateSegmentB.Name = "CreateSegmentB";
            this.CreateSegmentB.Size = new System.Drawing.Size(168, 28);
            this.CreateSegmentB.TabIndex = 11;
            this.CreateSegmentB.Text = "Създай Участък";
            this.CreateSegmentB.UseVisualStyleBackColor = true;
            this.CreateSegmentB.Click += new System.EventHandler(this.CreateSegmentB_Click);
            // 
            // WorkerListBox
            // 
            this.WorkerListBox.FormattingEnabled = true;
            this.WorkerListBox.ItemHeight = 20;
            this.WorkerListBox.Location = new System.Drawing.Point(272, 170);
            this.WorkerListBox.Name = "WorkerListBox";
            this.WorkerListBox.Size = new System.Drawing.Size(309, 384);
            this.WorkerListBox.TabIndex = 18;
            this.WorkerListBox.SelectedIndexChanged += new System.EventHandler(this.WorkerListBox_SelectedIndexChanged);
            // 
            // SegmentListBox
            // 
            this.SegmentListBox.FormattingEnabled = true;
            this.SegmentListBox.ItemHeight = 20;
            this.SegmentListBox.Location = new System.Drawing.Point(912, 170);
            this.SegmentListBox.Name = "SegmentListBox";
            this.SegmentListBox.Size = new System.Drawing.Size(249, 384);
            this.SegmentListBox.TabIndex = 19;
            this.SegmentListBox.SelectedIndexChanged += new System.EventHandler(this.SegmentListBox_SelectedIndexChanged);
            // 
            // CalculateB
            // 
            this.CalculateB.Location = new System.Drawing.Point(562, 609);
            this.CalculateB.Name = "CalculateB";
            this.CalculateB.Size = new System.Drawing.Size(142, 28);
            this.CalculateB.TabIndex = 20;
            this.CalculateB.Text = "Изчисли";
            this.CalculateB.UseVisualStyleBackColor = true;
            this.CalculateB.Click += new System.EventHandler(this.CalculateB_Click);
            // 
            // OxygenForExitB
            // 
            this.OxygenForExitB.Location = new System.Drawing.Point(89, 863);
            this.OxygenForExitB.Name = "OxygenForExitB";
            this.OxygenForExitB.Size = new System.Drawing.Size(364, 28);
            this.OxygenForExitB.TabIndex = 25;
            this.OxygenForExitB.Text = "Кислород за излизане:";
            this.OxygenForExitB.UseVisualStyleBackColor = true;
            this.OxygenForExitB.Click += new System.EventHandler(this.OxygenForExitB_Click);
            // 
            // OxygenForEntryB
            // 
            this.OxygenForEntryB.Location = new System.Drawing.Point(89, 802);
            this.OxygenForEntryB.Name = "OxygenForEntryB";
            this.OxygenForEntryB.Size = new System.Drawing.Size(364, 28);
            this.OxygenForEntryB.TabIndex = 24;
            this.OxygenForEntryB.Text = "Кислород за влизане:";
            this.OxygenForEntryB.UseVisualStyleBackColor = true;
            this.OxygenForEntryB.Click += new System.EventHandler(this.OxygenForEntryB_Click);
            // 
            // OxygenOnExitB
            // 
            this.OxygenOnExitB.Location = new System.Drawing.Point(89, 742);
            this.OxygenOnExitB.Name = "OxygenOnExitB";
            this.OxygenOnExitB.Size = new System.Drawing.Size(364, 28);
            this.OxygenOnExitB.TabIndex = 23;
            this.OxygenOnExitB.Text = "Наличен кислород при излизане:";
            this.OxygenOnExitB.UseVisualStyleBackColor = true;
            this.OxygenOnExitB.Click += new System.EventHandler(this.OxygenOnExitB_Click);
            // 
            // OxygenOnEntryB
            // 
            this.OxygenOnEntryB.Location = new System.Drawing.Point(89, 686);
            this.OxygenOnEntryB.Name = "OxygenOnEntryB";
            this.OxygenOnEntryB.Size = new System.Drawing.Size(364, 28);
            this.OxygenOnEntryB.TabIndex = 22;
            this.OxygenOnEntryB.Text = "Наличен кислород при влизане:";
            this.OxygenOnEntryB.UseVisualStyleBackColor = true;
            this.OxygenOnEntryB.Click += new System.EventHandler(this.OxygenOnEntryB_Click);
            // 
            // RemainingTimeB
            // 
            this.RemainingTimeB.Location = new System.Drawing.Point(89, 919);
            this.RemainingTimeB.Name = "RemainingTimeB";
            this.RemainingTimeB.Size = new System.Drawing.Size(364, 28);
            this.RemainingTimeB.TabIndex = 30;
            this.RemainingTimeB.Text = "Оставащо време при умерена работа:";
            this.RemainingTimeB.UseVisualStyleBackColor = true;
            this.RemainingTimeB.Click += new System.EventHandler(this.RemainingTimeB_Click);
            // 
            // TimeForPathB
            // 
            this.TimeForPathB.Location = new System.Drawing.Point(534, 863);
            this.TimeForPathB.Name = "TimeForPathB";
            this.TimeForPathB.Size = new System.Drawing.Size(396, 28);
            this.TimeForPathB.TabIndex = 29;
            this.TimeForPathB.Text = "Време за изминаване на пътя:";
            this.TimeForPathB.UseVisualStyleBackColor = true;
            this.TimeForPathB.Click += new System.EventHandler(this.TimeForPathB_Click);
            // 
            // TimeForExitB
            // 
            this.TimeForExitB.Location = new System.Drawing.Point(534, 802);
            this.TimeForExitB.Name = "TimeForExitB";
            this.TimeForExitB.Size = new System.Drawing.Size(396, 28);
            this.TimeForExitB.TabIndex = 28;
            this.TimeForExitB.Text = "Време за излизане:";
            this.TimeForExitB.UseVisualStyleBackColor = true;
            this.TimeForExitB.Click += new System.EventHandler(this.TimeForExitB_Click);
            // 
            // TimeForEntryB
            // 
            this.TimeForEntryB.Location = new System.Drawing.Point(534, 742);
            this.TimeForEntryB.Name = "TimeForEntryB";
            this.TimeForEntryB.Size = new System.Drawing.Size(396, 28);
            this.TimeForEntryB.TabIndex = 27;
            this.TimeForEntryB.Text = "Време за влизане:";
            this.TimeForEntryB.UseVisualStyleBackColor = true;
            this.TimeForEntryB.Click += new System.EventHandler(this.TimeForEntryB_Click);
            // 
            // PathLengthB
            // 
            this.PathLengthB.Location = new System.Drawing.Point(534, 686);
            this.PathLengthB.Name = "PathLengthB";
            this.PathLengthB.Size = new System.Drawing.Size(396, 28);
            this.PathLengthB.TabIndex = 26;
            this.PathLengthB.Text = "Дължина на трасето:";
            this.PathLengthB.UseVisualStyleBackColor = true;
            this.PathLengthB.Click += new System.EventHandler(this.PathLengthB_Click);
            // 
            // SaveResultsB
            // 
            this.SaveResultsB.Location = new System.Drawing.Point(534, 919);
            this.SaveResultsB.Name = "SaveResultsB";
            this.SaveResultsB.Size = new System.Drawing.Size(396, 28);
            this.SaveResultsB.TabIndex = 31;
            this.SaveResultsB.Text = "Запази Резултат";
            this.SaveResultsB.UseVisualStyleBackColor = true;
            this.SaveResultsB.Click += new System.EventHandler(this.SaveResultsB_Click);
            // 
            // ChangeValuesB
            // 
            this.ChangeValuesB.Location = new System.Drawing.Point(1019, 894);
            this.ChangeValuesB.Name = "ChangeValuesB";
            this.ChangeValuesB.Size = new System.Drawing.Size(159, 53);
            this.ChangeValuesB.TabIndex = 32;
            this.ChangeValuesB.Text = "Промени коефициенти";
            this.ChangeValuesB.UseVisualStyleBackColor = true;
            this.ChangeValuesB.Click += new System.EventHandler(this.ChangeValuesB_Click);
            // 
            // ChooseWorkerLabel
            // 
            this.ChooseWorkerLabel.AutoSize = true;
            this.ChooseWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseWorkerLabel.Location = new System.Drawing.Point(929, 613);
            this.ChooseWorkerLabel.Name = "ChooseWorkerLabel";
            this.ChooseWorkerLabel.Size = new System.Drawing.Size(222, 20);
            this.ChooseWorkerLabel.TabIndex = 34;
            this.ChooseWorkerLabel.Text = "Моля изберете спасител";
            this.ChooseWorkerLabel.Click += new System.EventHandler(this.ChooseWorkerLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(462, 41);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(313, 26);
            this.TitleLabel.TabIndex = 35;
            this.TitleLabel.Text = "Изчисли Ресурси за Мисия";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 980);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ChooseWorkerLabel);
            this.Controls.Add(this.ChangeValuesB);
            this.Controls.Add(this.SaveResultsB);
            this.Controls.Add(this.RemainingTimeB);
            this.Controls.Add(this.TimeForPathB);
            this.Controls.Add(this.TimeForExitB);
            this.Controls.Add(this.TimeForEntryB);
            this.Controls.Add(this.PathLengthB);
            this.Controls.Add(this.OxygenForExitB);
            this.Controls.Add(this.OxygenForEntryB);
            this.Controls.Add(this.OxygenOnExitB);
            this.Controls.Add(this.OxygenOnEntryB);
            this.Controls.Add(this.CalculateB);
            this.Controls.Add(this.SegmentListBox);
            this.Controls.Add(this.WorkerListBox);
            this.Controls.Add(this.DeleteBreakB);
            this.Controls.Add(this.AddBreakB);
            this.Controls.Add(this.RemoveLuggageB);
            this.Controls.Add(this.AddLuggageB);
            this.Controls.Add(this.DeleteSegmentB);
            this.Controls.Add(this.CreateSegmentB);
            this.Controls.Add(this.DeleteApparatusB);
            this.Controls.Add(this.CreateApparatusB);
            this.Controls.Add(this.DeleteWorkerB);
            this.Controls.Add(this.ChooseWorkerB);
            this.Controls.Add(this.CreateWorkerB);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.SegmentLabel);
            this.Controls.Add(this.WorkersLabel);
            this.Controls.Add(this.WorkerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkerLabel;
        private System.Windows.Forms.Label WorkersLabel;
        private System.Windows.Forms.Label SegmentLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button CreateWorkerB;
        private System.Windows.Forms.Button ChooseWorkerB;
        private System.Windows.Forms.Button DeleteWorkerB;
        private System.Windows.Forms.Button CreateApparatusB;
        private System.Windows.Forms.Button DeleteApparatusB;
        private System.Windows.Forms.Button DeleteBreakB;
        private System.Windows.Forms.Button AddBreakB;
        private System.Windows.Forms.Button RemoveLuggageB;
        private System.Windows.Forms.Button AddLuggageB;
        private System.Windows.Forms.Button DeleteSegmentB;
        private System.Windows.Forms.Button CreateSegmentB;
        private System.Windows.Forms.ListBox WorkerListBox;
        private System.Windows.Forms.ListBox SegmentListBox;
        private System.Windows.Forms.Button CalculateB;
        private System.Windows.Forms.Button OxygenForExitB;
        private System.Windows.Forms.Button OxygenForEntryB;
        private System.Windows.Forms.Button OxygenOnExitB;
        private System.Windows.Forms.Button OxygenOnEntryB;
        private System.Windows.Forms.Button RemainingTimeB;
        private System.Windows.Forms.Button TimeForPathB;
        private System.Windows.Forms.Button TimeForExitB;
        private System.Windows.Forms.Button TimeForEntryB;
        private System.Windows.Forms.Button PathLengthB;
        private System.Windows.Forms.Button SaveResultsB;
        private System.Windows.Forms.Button ChangeValuesB;
        private System.Windows.Forms.Label ChooseWorkerLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

