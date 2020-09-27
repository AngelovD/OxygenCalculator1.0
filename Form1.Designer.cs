﻿namespace OxygenCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateWorkerB = new System.Windows.Forms.Button();
            this.ChooseWorkerB = new System.Windows.Forms.Button();
            this.UpdateWorkerB = new System.Windows.Forms.Button();
            this.DeleteWorkerB = new System.Windows.Forms.Button();
            this.CreateApparatusB = new System.Windows.Forms.Button();
            this.UpdateApparatusB = new System.Windows.Forms.Button();
            this.DeleteApparatusB = new System.Windows.Forms.Button();
            this.DeleteBreakB = new System.Windows.Forms.Button();
            this.AddBreakB = new System.Windows.Forms.Button();
            this.RemoveLuggageB = new System.Windows.Forms.Button();
            this.AddLuggageB = new System.Windows.Forms.Button();
            this.DeleteSegmentB = new System.Windows.Forms.Button();
            this.UpdateSegmentB = new System.Windows.Forms.Button();
            this.CreateSegmentB = new System.Windows.Forms.Button();
            this.WorkerListBox = new System.Windows.Forms.ListBox();
            this.SegmentListBox = new System.Windows.Forms.ListBox();
            this.CalculateB = new System.Windows.Forms.Button();
            this.OxygenForExitB = new System.Windows.Forms.Button();
            this.OxygenForEntryB = new System.Windows.Forms.Button();
            this.OxygenOnExitB = new System.Windows.Forms.Button();
            this.OxygenOnEntryB = new System.Windows.Forms.Button();
            this.AlternativePathsB = new System.Windows.Forms.Button();
            this.RemainingTimeB = new System.Windows.Forms.Button();
            this.TimeForPathB = new System.Windows.Forms.Button();
            this.TimeForExitB = new System.Windows.Forms.Button();
            this.TimeForEntryB = new System.Windows.Forms.Button();
            this.PathLengthB = new System.Windows.Forms.Button();
            this.SaveResultsB = new System.Windows.Forms.Button();
            this.ChangeValuesB = new System.Windows.Forms.Button();
            this.ChoosePathB = new System.Windows.Forms.Button();
            this.ChooseWorkerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спасител";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Спасители:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сегмент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сегменти:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CreateWorkerB
            // 
            this.CreateWorkerB.Location = new System.Drawing.Point(34, 80);
            this.CreateWorkerB.Name = "CreateWorkerB";
            this.CreateWorkerB.Size = new System.Drawing.Size(171, 28);
            this.CreateWorkerB.TabIndex = 4;
            this.CreateWorkerB.Text = "Създай Спасител";
            this.CreateWorkerB.UseVisualStyleBackColor = true;
            this.CreateWorkerB.Click += new System.EventHandler(this.CreateWorkerB_Click);
            // 
            // ChooseWorkerB
            // 
            this.ChooseWorkerB.Location = new System.Drawing.Point(34, 131);
            this.ChooseWorkerB.Name = "ChooseWorkerB";
            this.ChooseWorkerB.Size = new System.Drawing.Size(171, 28);
            this.ChooseWorkerB.TabIndex = 5;
            this.ChooseWorkerB.Text = "Избери Спасител";
            this.ChooseWorkerB.UseVisualStyleBackColor = true;
            this.ChooseWorkerB.Click += new System.EventHandler(this.ChooseWorkerB_Click);
            // 
            // UpdateWorkerB
            // 
            this.UpdateWorkerB.Location = new System.Drawing.Point(34, 188);
            this.UpdateWorkerB.Name = "UpdateWorkerB";
            this.UpdateWorkerB.Size = new System.Drawing.Size(171, 28);
            this.UpdateWorkerB.TabIndex = 6;
            this.UpdateWorkerB.Text = "Обнови Спасител";
            this.UpdateWorkerB.UseVisualStyleBackColor = true;
            this.UpdateWorkerB.Click += new System.EventHandler(this.UpdateWorkerB_Click);
            // 
            // DeleteWorkerB
            // 
            this.DeleteWorkerB.Location = new System.Drawing.Point(34, 244);
            this.DeleteWorkerB.Name = "DeleteWorkerB";
            this.DeleteWorkerB.Size = new System.Drawing.Size(171, 28);
            this.DeleteWorkerB.TabIndex = 7;
            this.DeleteWorkerB.Text = "Изтрий Спасител";
            this.DeleteWorkerB.UseVisualStyleBackColor = true;
            this.DeleteWorkerB.Click += new System.EventHandler(this.DeleteWorkerB_Click);
            // 
            // CreateApparatusB
            // 
            this.CreateApparatusB.Location = new System.Drawing.Point(34, 304);
            this.CreateApparatusB.Name = "CreateApparatusB";
            this.CreateApparatusB.Size = new System.Drawing.Size(171, 28);
            this.CreateApparatusB.TabIndex = 8;
            this.CreateApparatusB.Text = "Създай Апарат";
            this.CreateApparatusB.UseVisualStyleBackColor = true;
            this.CreateApparatusB.Click += new System.EventHandler(this.CreateApparatusB_Click);
            // 
            // UpdateApparatusB
            // 
            this.UpdateApparatusB.Location = new System.Drawing.Point(34, 365);
            this.UpdateApparatusB.Name = "UpdateApparatusB";
            this.UpdateApparatusB.Size = new System.Drawing.Size(171, 28);
            this.UpdateApparatusB.TabIndex = 9;
            this.UpdateApparatusB.Text = "Обнови Апарат";
            this.UpdateApparatusB.UseVisualStyleBackColor = true;
            this.UpdateApparatusB.Click += new System.EventHandler(this.UpdateApparatusB_Click);
            // 
            // DeleteApparatusB
            // 
            this.DeleteApparatusB.Location = new System.Drawing.Point(34, 430);
            this.DeleteApparatusB.Name = "DeleteApparatusB";
            this.DeleteApparatusB.Size = new System.Drawing.Size(171, 28);
            this.DeleteApparatusB.TabIndex = 10;
            this.DeleteApparatusB.Text = "Изтрий Апарат";
            this.DeleteApparatusB.UseVisualStyleBackColor = true;
            this.DeleteApparatusB.Click += new System.EventHandler(this.DeleteApparatusB_Click);
            // 
            // DeleteBreakB
            // 
            this.DeleteBreakB.Location = new System.Drawing.Point(650, 430);
            this.DeleteBreakB.Name = "DeleteBreakB";
            this.DeleteBreakB.Size = new System.Drawing.Size(168, 28);
            this.DeleteBreakB.TabIndex = 17;
            this.DeleteBreakB.Text = "Изтрий Почивка";
            this.DeleteBreakB.UseVisualStyleBackColor = true;
            this.DeleteBreakB.Click += new System.EventHandler(this.DeleteBreakB_Click);
            // 
            // AddBreakB
            // 
            this.AddBreakB.Location = new System.Drawing.Point(650, 365);
            this.AddBreakB.Name = "AddBreakB";
            this.AddBreakB.Size = new System.Drawing.Size(168, 28);
            this.AddBreakB.TabIndex = 16;
            this.AddBreakB.Text = "Добави Почивка";
            this.AddBreakB.UseVisualStyleBackColor = true;
            this.AddBreakB.Click += new System.EventHandler(this.AddBreakB_Click);
            // 
            // RemoveLuggageB
            // 
            this.RemoveLuggageB.Location = new System.Drawing.Point(650, 304);
            this.RemoveLuggageB.Name = "RemoveLuggageB";
            this.RemoveLuggageB.Size = new System.Drawing.Size(168, 28);
            this.RemoveLuggageB.TabIndex = 15;
            this.RemoveLuggageB.Text = "Премахни Товар";
            this.RemoveLuggageB.UseVisualStyleBackColor = true;
            this.RemoveLuggageB.Click += new System.EventHandler(this.RemoveLuggageB_Click);
            // 
            // AddLuggageB
            // 
            this.AddLuggageB.Location = new System.Drawing.Point(650, 244);
            this.AddLuggageB.Name = "AddLuggageB";
            this.AddLuggageB.Size = new System.Drawing.Size(168, 28);
            this.AddLuggageB.TabIndex = 14;
            this.AddLuggageB.Text = "Добави Товар";
            this.AddLuggageB.UseVisualStyleBackColor = true;
            this.AddLuggageB.Click += new System.EventHandler(this.AddLuggageB_Click);
            // 
            // DeleteSegmentB
            // 
            this.DeleteSegmentB.Location = new System.Drawing.Point(650, 188);
            this.DeleteSegmentB.Name = "DeleteSegmentB";
            this.DeleteSegmentB.Size = new System.Drawing.Size(168, 28);
            this.DeleteSegmentB.TabIndex = 13;
            this.DeleteSegmentB.Text = "Изтрий Участък";
            this.DeleteSegmentB.UseVisualStyleBackColor = true;
            this.DeleteSegmentB.Click += new System.EventHandler(this.DeleteSegmentB_Click);
            // 
            // UpdateSegmentB
            // 
            this.UpdateSegmentB.Location = new System.Drawing.Point(650, 131);
            this.UpdateSegmentB.Name = "UpdateSegmentB";
            this.UpdateSegmentB.Size = new System.Drawing.Size(168, 28);
            this.UpdateSegmentB.TabIndex = 12;
            this.UpdateSegmentB.Text = "Обнови Участък";
            this.UpdateSegmentB.UseVisualStyleBackColor = true;
            this.UpdateSegmentB.Click += new System.EventHandler(this.UpdateSegmentB_Click);
            // 
            // CreateSegmentB
            // 
            this.CreateSegmentB.Location = new System.Drawing.Point(650, 80);
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
            this.WorkerListBox.Location = new System.Drawing.Point(307, 80);
            this.WorkerListBox.Name = "WorkerListBox";
            this.WorkerListBox.Size = new System.Drawing.Size(249, 384);
            this.WorkerListBox.TabIndex = 18;
            // 
            // SegmentListBox
            // 
            this.SegmentListBox.FormattingEnabled = true;
            this.SegmentListBox.ItemHeight = 20;
            this.SegmentListBox.Location = new System.Drawing.Point(915, 80);
            this.SegmentListBox.Name = "SegmentListBox";
            this.SegmentListBox.Size = new System.Drawing.Size(249, 384);
            this.SegmentListBox.TabIndex = 19;
            // 
            // CalculateB
            // 
            this.CalculateB.Location = new System.Drawing.Point(636, 519);
            this.CalculateB.Name = "CalculateB";
            this.CalculateB.Size = new System.Drawing.Size(142, 28);
            this.CalculateB.TabIndex = 20;
            this.CalculateB.Text = "Изчисли";
            this.CalculateB.UseVisualStyleBackColor = true;
            this.CalculateB.Click += new System.EventHandler(this.CalculateB_Click);
            // 
            // OxygenForExitB
            // 
            this.OxygenForExitB.Location = new System.Drawing.Point(53, 838);
            this.OxygenForExitB.Name = "OxygenForExitB";
            this.OxygenForExitB.Size = new System.Drawing.Size(364, 28);
            this.OxygenForExitB.TabIndex = 25;
            this.OxygenForExitB.Text = "Кислород за излизане:";
            this.OxygenForExitB.UseVisualStyleBackColor = true;
            this.OxygenForExitB.Click += new System.EventHandler(this.OxygenForExitB_Click);
            // 
            // OxygenForEntryB
            // 
            this.OxygenForEntryB.Location = new System.Drawing.Point(53, 773);
            this.OxygenForEntryB.Name = "OxygenForEntryB";
            this.OxygenForEntryB.Size = new System.Drawing.Size(364, 28);
            this.OxygenForEntryB.TabIndex = 24;
            this.OxygenForEntryB.Text = "Кислород за влизане:";
            this.OxygenForEntryB.UseVisualStyleBackColor = true;
            this.OxygenForEntryB.Click += new System.EventHandler(this.OxygenForEntryB_Click);
            // 
            // OxygenOnExitB
            // 
            this.OxygenOnExitB.Location = new System.Drawing.Point(53, 712);
            this.OxygenOnExitB.Name = "OxygenOnExitB";
            this.OxygenOnExitB.Size = new System.Drawing.Size(364, 28);
            this.OxygenOnExitB.TabIndex = 23;
            this.OxygenOnExitB.Text = "Наличен кислород при излизане:";
            this.OxygenOnExitB.UseVisualStyleBackColor = true;
            this.OxygenOnExitB.Click += new System.EventHandler(this.OxygenOnExitB_Click);
            // 
            // OxygenOnEntryB
            // 
            this.OxygenOnEntryB.Location = new System.Drawing.Point(53, 652);
            this.OxygenOnEntryB.Name = "OxygenOnEntryB";
            this.OxygenOnEntryB.Size = new System.Drawing.Size(364, 28);
            this.OxygenOnEntryB.TabIndex = 22;
            this.OxygenOnEntryB.Text = "Наличен кислород при влизане:";
            this.OxygenOnEntryB.UseVisualStyleBackColor = true;
            this.OxygenOnEntryB.Click += new System.EventHandler(this.OxygenOnEntryB_Click);
            // 
            // AlternativePathsB
            // 
            this.AlternativePathsB.Location = new System.Drawing.Point(53, 596);
            this.AlternativePathsB.Name = "AlternativePathsB";
            this.AlternativePathsB.Size = new System.Drawing.Size(364, 28);
            this.AlternativePathsB.TabIndex = 21;
            this.AlternativePathsB.Text = "Алтернативни трасета";
            this.AlternativePathsB.UseVisualStyleBackColor = true;
            this.AlternativePathsB.Click += new System.EventHandler(this.AlternativePathsB_Click);
            // 
            // RemainingTimeB
            // 
            this.RemainingTimeB.Location = new System.Drawing.Point(537, 838);
            this.RemainingTimeB.Name = "RemainingTimeB";
            this.RemainingTimeB.Size = new System.Drawing.Size(396, 28);
            this.RemainingTimeB.TabIndex = 30;
            this.RemainingTimeB.Text = "Оставащо време при умерена работа:";
            this.RemainingTimeB.UseVisualStyleBackColor = true;
            this.RemainingTimeB.Click += new System.EventHandler(this.RemainingTimeB_Click);
            // 
            // TimeForPathB
            // 
            this.TimeForPathB.Location = new System.Drawing.Point(537, 773);
            this.TimeForPathB.Name = "TimeForPathB";
            this.TimeForPathB.Size = new System.Drawing.Size(396, 28);
            this.TimeForPathB.TabIndex = 29;
            this.TimeForPathB.Text = "Време за изминаване на пътя:";
            this.TimeForPathB.UseVisualStyleBackColor = true;
            this.TimeForPathB.Click += new System.EventHandler(this.TimeForPathB_Click);
            // 
            // TimeForExitB
            // 
            this.TimeForExitB.Location = new System.Drawing.Point(537, 712);
            this.TimeForExitB.Name = "TimeForExitB";
            this.TimeForExitB.Size = new System.Drawing.Size(396, 28);
            this.TimeForExitB.TabIndex = 28;
            this.TimeForExitB.Text = "Време за излизане:";
            this.TimeForExitB.UseVisualStyleBackColor = true;
            this.TimeForExitB.Click += new System.EventHandler(this.TimeForExitB_Click);
            // 
            // TimeForEntryB
            // 
            this.TimeForEntryB.Location = new System.Drawing.Point(537, 652);
            this.TimeForEntryB.Name = "TimeForEntryB";
            this.TimeForEntryB.Size = new System.Drawing.Size(396, 28);
            this.TimeForEntryB.TabIndex = 27;
            this.TimeForEntryB.Text = "Време за влизане:";
            this.TimeForEntryB.UseVisualStyleBackColor = true;
            this.TimeForEntryB.Click += new System.EventHandler(this.TimeForEntryB_Click);
            // 
            // PathLengthB
            // 
            this.PathLengthB.Location = new System.Drawing.Point(537, 596);
            this.PathLengthB.Name = "PathLengthB";
            this.PathLengthB.Size = new System.Drawing.Size(396, 28);
            this.PathLengthB.TabIndex = 26;
            this.PathLengthB.Text = "Дължина на трасето:";
            this.PathLengthB.UseVisualStyleBackColor = true;
            this.PathLengthB.Click += new System.EventHandler(this.PathLengthB_Click);
            // 
            // SaveResultsB
            // 
            this.SaveResultsB.Location = new System.Drawing.Point(1022, 625);
            this.SaveResultsB.Name = "SaveResultsB";
            this.SaveResultsB.Size = new System.Drawing.Size(159, 28);
            this.SaveResultsB.TabIndex = 31;
            this.SaveResultsB.Text = "Запази Резултат";
            this.SaveResultsB.UseVisualStyleBackColor = true;
            this.SaveResultsB.Click += new System.EventHandler(this.SaveResultsB_Click);
            // 
            // ChangeValuesB
            // 
            this.ChangeValuesB.Location = new System.Drawing.Point(1022, 712);
            this.ChangeValuesB.Name = "ChangeValuesB";
            this.ChangeValuesB.Size = new System.Drawing.Size(159, 53);
            this.ChangeValuesB.TabIndex = 32;
            this.ChangeValuesB.Text = "Промени коефициенти";
            this.ChangeValuesB.UseVisualStyleBackColor = true;
            this.ChangeValuesB.Click += new System.EventHandler(this.ChangeValuesB_Click);
            // 
            // ChoosePathB
            // 
            this.ChoosePathB.Location = new System.Drawing.Point(275, 519);
            this.ChoosePathB.Name = "ChoosePathB";
            this.ChoosePathB.Size = new System.Drawing.Size(142, 28);
            this.ChoosePathB.TabIndex = 33;
            this.ChoosePathB.Text = "Избери трасе";
            this.ChoosePathB.UseVisualStyleBackColor = true;
            this.ChoosePathB.Click += new System.EventHandler(this.ChoosePathB_Click);
            // 
            // ChooseWorkerLabel
            // 
            this.ChooseWorkerLabel.AutoSize = true;
            this.ChooseWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseWorkerLabel.Location = new System.Drawing.Point(932, 523);
            this.ChooseWorkerLabel.Name = "ChooseWorkerLabel";
            this.ChooseWorkerLabel.Size = new System.Drawing.Size(222, 20);
            this.ChooseWorkerLabel.TabIndex = 34;
            this.ChooseWorkerLabel.Text = "Моля изберете спасител";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 891);
            this.Controls.Add(this.ChooseWorkerLabel);
            this.Controls.Add(this.ChoosePathB);
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
            this.Controls.Add(this.AlternativePathsB);
            this.Controls.Add(this.CalculateB);
            this.Controls.Add(this.SegmentListBox);
            this.Controls.Add(this.WorkerListBox);
            this.Controls.Add(this.DeleteBreakB);
            this.Controls.Add(this.AddBreakB);
            this.Controls.Add(this.RemoveLuggageB);
            this.Controls.Add(this.AddLuggageB);
            this.Controls.Add(this.DeleteSegmentB);
            this.Controls.Add(this.UpdateSegmentB);
            this.Controls.Add(this.CreateSegmentB);
            this.Controls.Add(this.DeleteApparatusB);
            this.Controls.Add(this.UpdateApparatusB);
            this.Controls.Add(this.CreateApparatusB);
            this.Controls.Add(this.DeleteWorkerB);
            this.Controls.Add(this.UpdateWorkerB);
            this.Controls.Add(this.ChooseWorkerB);
            this.Controls.Add(this.CreateWorkerB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateWorkerB;
        private System.Windows.Forms.Button ChooseWorkerB;
        private System.Windows.Forms.Button UpdateWorkerB;
        private System.Windows.Forms.Button DeleteWorkerB;
        private System.Windows.Forms.Button CreateApparatusB;
        private System.Windows.Forms.Button UpdateApparatusB;
        private System.Windows.Forms.Button DeleteApparatusB;
        private System.Windows.Forms.Button DeleteBreakB;
        private System.Windows.Forms.Button AddBreakB;
        private System.Windows.Forms.Button RemoveLuggageB;
        private System.Windows.Forms.Button AddLuggageB;
        private System.Windows.Forms.Button DeleteSegmentB;
        private System.Windows.Forms.Button UpdateSegmentB;
        private System.Windows.Forms.Button CreateSegmentB;
        private System.Windows.Forms.ListBox WorkerListBox;
        private System.Windows.Forms.ListBox SegmentListBox;
        private System.Windows.Forms.Button CalculateB;
        private System.Windows.Forms.Button OxygenForExitB;
        private System.Windows.Forms.Button OxygenForEntryB;
        private System.Windows.Forms.Button OxygenOnExitB;
        private System.Windows.Forms.Button OxygenOnEntryB;
        private System.Windows.Forms.Button AlternativePathsB;
        private System.Windows.Forms.Button RemainingTimeB;
        private System.Windows.Forms.Button TimeForPathB;
        private System.Windows.Forms.Button TimeForExitB;
        private System.Windows.Forms.Button TimeForEntryB;
        private System.Windows.Forms.Button PathLengthB;
        private System.Windows.Forms.Button SaveResultsB;
        private System.Windows.Forms.Button ChangeValuesB;
        private System.Windows.Forms.Button ChoosePathB;
        private System.Windows.Forms.Label ChooseWorkerLabel;
    }
}
