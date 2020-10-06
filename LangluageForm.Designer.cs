namespace OxygenCalculator
{
    partial class LanguageForm
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
            this.BG = new System.Windows.Forms.Button();
            this.EN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BG
            // 
            this.BG.Location = new System.Drawing.Point(75, 85);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(132, 34);
            this.BG.TabIndex = 0;
            this.BG.Text = "Български";
            this.BG.UseVisualStyleBackColor = true;
            this.BG.Click += new System.EventHandler(this.BG_Click);
            // 
            // EN
            // 
            this.EN.Location = new System.Drawing.Point(322, 85);
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(132, 34);
            this.EN.TabIndex = 1;
            this.EN.Text = "English";
            this.EN.UseVisualStyleBackColor = true;
            this.EN.Click += new System.EventHandler(this.EN_Click);
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 192);
            this.Controls.Add(this.EN);
            this.Controls.Add(this.BG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LanguageForm";
            this.Text = "LangluageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BG;
        private System.Windows.Forms.Button EN;
    }
}