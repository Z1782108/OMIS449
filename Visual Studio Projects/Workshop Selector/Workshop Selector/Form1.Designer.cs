namespace Workshop_Selector
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
            this.components = new System.ComponentModel.Container();
            this.locationList = new System.Windows.Forms.ListBox();
            this.workshopList = new System.Windows.Forms.ListBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.lodgingTextBox = new System.Windows.Forms.TextBox();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calcCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationList
            // 
            this.locationList.FormattingEnabled = true;
            this.locationList.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationList.Location = new System.Drawing.Point(179, 64);
            this.locationList.Name = "locationList";
            this.locationList.Size = new System.Drawing.Size(120, 121);
            this.locationList.TabIndex = 2;
            // 
            // workshopList
            // 
            this.workshopList.FormattingEnabled = true;
            this.workshopList.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotitation",
            "How to Interview"});
            this.workshopList.Location = new System.Drawing.Point(28, 64);
            this.workshopList.Name = "workshopList";
            this.workshopList.Size = new System.Drawing.Size(120, 121);
            this.workshopList.TabIndex = 3;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(221, 46);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location";
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(48, 46);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(69, 13);
            this.workshopLabel.TabIndex = 5;
            this.workshopLabel.Text = "Workstations";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(325, 51);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(63, 13);
            this.registrationLabel.TabIndex = 6;
            this.registrationLabel.Text = "Registration";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Location = new System.Drawing.Point(343, 102);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(45, 13);
            this.lodgingLabel.TabIndex = 7;
            this.lodgingLabel.Text = "Lodging";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(353, 152);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(27, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "total";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(394, 152);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 10;
            // 
            // lodgingTextBox
            // 
            this.lodgingTextBox.Enabled = false;
            this.lodgingTextBox.Location = new System.Drawing.Point(394, 99);
            this.lodgingTextBox.Name = "lodgingTextBox";
            this.lodgingTextBox.Size = new System.Drawing.Size(100, 20);
            this.lodgingTextBox.TabIndex = 11;
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.Enabled = false;
            this.registrationTextBox.Location = new System.Drawing.Point(394, 48);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationTextBox.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(397, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 40);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(135, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(245, 40);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calcCost
            // 
            this.calcCost.Location = new System.Drawing.Point(28, 211);
            this.calcCost.Name = "calcCost";
            this.calcCost.Size = new System.Drawing.Size(89, 40);
            this.calcCost.TabIndex = 15;
            this.calcCost.Text = "Calcukate Cost";
            this.calcCost.UseVisualStyleBackColor = true;
            this.calcCost.Click += new System.EventHandler(this.calcCost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.calcCost);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(this.lodgingTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopList);
            this.Controls.Add(this.locationList);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.ListBox workshopList;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox lodgingTextBox;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calcCost;
    }
}

