namespace DistanceTimeCalculator
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
            this.TravelSpeedTextBox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.speedTraveledLabel = new System.Windows.Forms.Label();
            this.hoursTotalListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(199, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 47);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(26, 267);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(158, 47);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate Distances";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // hoursTraveledTextBox
            // 
            this.hoursTraveledTextBox.Location = new System.Drawing.Point(177, 86);
            this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
            this.hoursTraveledTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTraveledTextBox.TabIndex = 10;
            // 
            // TravelSpeedTextBox
            // 
            this.TravelSpeedTextBox.Location = new System.Drawing.Point(177, 37);
            this.TravelSpeedTextBox.Name = "TravelSpeedTextBox";
            this.TravelSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TravelSpeedTextBox.TabIndex = 9;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(88, 89);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(83, 13);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.Text = "Hours Traveled:";
            // 
            // speedTraveledLabel
            // 
            this.speedTraveledLabel.AutoSize = true;
            this.speedTraveledLabel.Location = new System.Drawing.Point(41, 40);
            this.speedTraveledLabel.Name = "speedTraveledLabel";
            this.speedTraveledLabel.Size = new System.Drawing.Size(130, 13);
            this.speedTraveledLabel.TabIndex = 7;
            this.speedTraveledLabel.Text = "Speed of Travel (in MPH):";
            // 
            // hoursTotalListBox
            // 
            this.hoursTotalListBox.FormattingEnabled = true;
            this.hoursTotalListBox.Location = new System.Drawing.Point(26, 151);
            this.hoursTotalListBox.Name = "hoursTotalListBox";
            this.hoursTotalListBox.Size = new System.Drawing.Size(312, 95);
            this.hoursTotalListBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.hoursTotalListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursTraveledTextBox);
            this.Controls.Add(this.TravelSpeedTextBox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.speedTraveledLabel);
            this.Name = "Form1";
            this.Text = "Distance Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox hoursTraveledTextBox;
        private System.Windows.Forms.TextBox TravelSpeedTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label speedTraveledLabel;
        private System.Windows.Forms.ListBox hoursTotalListBox;
    }
}

