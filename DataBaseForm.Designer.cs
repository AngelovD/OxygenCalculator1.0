namespace OxygenCalculator
{
    partial class DataBaseForm
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
            this.LanguageB = new System.Windows.Forms.Button();
            this.DatabaseNotFoundLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RunLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LanguageB
            // 
            this.LanguageB.Location = new System.Drawing.Point(1009, 46);
            this.LanguageB.Name = "LanguageB";
            this.LanguageB.Size = new System.Drawing.Size(121, 37);
            this.LanguageB.TabIndex = 0;
            this.LanguageB.Text = "button1";
            this.LanguageB.UseVisualStyleBackColor = true;
            this.LanguageB.Click += new System.EventHandler(this.LanguageB_Click);
            // 
            // DatabaseNotFoundLabel
            // 
            this.DatabaseNotFoundLabel.AutoSize = true;
            this.DatabaseNotFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNotFoundLabel.Location = new System.Drawing.Point(171, 54);
            this.DatabaseNotFoundLabel.Name = "DatabaseNotFoundLabel";
            this.DatabaseNotFoundLabel.Size = new System.Drawing.Size(66, 24);
            this.DatabaseNotFoundLabel.TabIndex = 1;
            this.DatabaseNotFoundLabel.Text = "label1";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(171, 143);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(51, 20);
            this.LinkLabel.TabIndex = 2;
            this.LinkLabel.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1005, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // RunLabel
            // 
            this.RunLabel.AutoSize = true;
            this.RunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunLabel.Location = new System.Drawing.Point(171, 263);
            this.RunLabel.Name = "RunLabel";
            this.RunLabel.Size = new System.Drawing.Size(51, 20);
            this.RunLabel.TabIndex = 4;
            this.RunLabel.Text = "label1";
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 320);
            this.Controls.Add(this.RunLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.DatabaseNotFoundLabel);
            this.Controls.Add(this.LanguageB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LanguageB;
        private System.Windows.Forms.Label DatabaseNotFoundLabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label RunLabel;
    }
}