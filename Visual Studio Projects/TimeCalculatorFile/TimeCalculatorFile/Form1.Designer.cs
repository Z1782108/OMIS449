namespace TimeCalculatorFile
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
            this.hoursTravele = new System.Windows.Forms.TextBox();
            this.speedTraveledTextBox = new System.Windows.Forms.TextBox();
            this.hoursTraveledLabel = new System.Windows.Forms.Label();
            this.speedTaveledLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 146);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 60);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hoursTravele
            // 
            this.hoursTravele.Location = new System.Drawing.Point(160, 90);
            this.hoursTravele.Name = "hoursTravele";
            this.hoursTravele.Size = new System.Drawing.Size(100, 20);
            this.hoursTravele.TabIndex = 9;
            // 
            // speedTraveledTextBox
            // 
            this.speedTraveledTextBox.Location = new System.Drawing.Point(160, 52);
            this.speedTraveledTextBox.Name = "speedTraveledTextBox";
            this.speedTraveledTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTraveledTextBox.TabIndex = 8;
            // 
            // hoursTraveledLabel
            // 
            this.hoursTraveledLabel.AutoSize = true;
            this.hoursTraveledLabel.Location = new System.Drawing.Point(27, 93);
            this.hoursTraveledLabel.Name = "hoursTraveledLabel";
            this.hoursTraveledLabel.Size = new System.Drawing.Size(83, 13);
            this.hoursTraveledLabel.TabIndex = 7;
            this.hoursTraveledLabel.Text = "Hours Traveled:";
            // 
            // speedTaveledLabel
            // 
            this.speedTaveledLabel.AutoSize = true;
            this.speedTaveledLabel.Location = new System.Drawing.Point(27, 55);
            this.speedTaveledLabel.Name = "speedTaveledLabel";
            this.speedTaveledLabel.Size = new System.Drawing.Size(115, 13);
            this.speedTaveledLabel.TabIndex = 6;
            this.speedTaveledLabel.Text = "Vehicle speed in MPH:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(30, 146);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 60);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Calculate Distance";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hoursTravele);
            this.Controls.Add(this.speedTraveledTextBox);
            this.Controls.Add(this.hoursTraveledLabel);
            this.Controls.Add(this.speedTaveledLabel);
            this.Name = "Form1";
            this.Text = "Time Calculator To File";
            this.Click += new System.EventHandler(this.exitButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox hoursTravele;
        private System.Windows.Forms.TextBox speedTraveledTextBox;
        private System.Windows.Forms.Label hoursTraveledLabel;
        private System.Windows.Forms.Label speedTaveledLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

