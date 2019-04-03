namespace Name_Search_Project
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
            this.checkNames = new System.Windows.Forms.Button();
            this.boyResults = new System.Windows.Forms.TextBox();
            this.girlResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BInput = new System.Windows.Forms.TextBox();
            this.GInput = new System.Windows.Forms.TextBox();
            this.importBoyButton = new System.Windows.Forms.Button();
            this.importGirlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkNames
            // 
            this.checkNames.Location = new System.Drawing.Point(139, 107);
            this.checkNames.Name = "checkNames";
            this.checkNames.Size = new System.Drawing.Size(75, 35);
            this.checkNames.TabIndex = 19;
            this.checkNames.Text = "Check Names";
            this.checkNames.UseVisualStyleBackColor = true;
            this.checkNames.Click += new System.EventHandler(this.CheckNames_Click);
            // 
            // boyResults
            // 
            this.boyResults.Enabled = false;
            this.boyResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boyResults.Location = new System.Drawing.Point(53, 191);
            this.boyResults.Name = "boyResults";
            this.boyResults.Size = new System.Drawing.Size(249, 20);
            this.boyResults.TabIndex = 18;
            // 
            // girlResults
            // 
            this.girlResults.Enabled = false;
            this.girlResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girlResults.Location = new System.Drawing.Point(53, 165);
            this.girlResults.Name = "girlResults";
            this.girlResults.Size = new System.Drawing.Size(249, 20);
            this.girlResults.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search For a Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Boy Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Girl Name:";
            // 
            // BInput
            // 
            this.BInput.Location = new System.Drawing.Point(111, 81);
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(159, 20);
            this.BInput.TabIndex = 13;
            // 
            // GInput
            // 
            this.GInput.Location = new System.Drawing.Point(111, 52);
            this.GInput.Name = "GInput";
            this.GInput.Size = new System.Drawing.Size(159, 20);
            this.GInput.TabIndex = 12;
            // 
            // importBoyButton
            // 
            this.importBoyButton.Location = new System.Drawing.Point(235, 123);
            this.importBoyButton.Name = "importBoyButton";
            this.importBoyButton.Size = new System.Drawing.Size(102, 36);
            this.importBoyButton.TabIndex = 11;
            this.importBoyButton.Text = "Import: Boy Names";
            this.importBoyButton.UseVisualStyleBackColor = true;
            this.importBoyButton.Click += new System.EventHandler(this.importBoyButton_Click);
            // 
            // importGirlButton
            // 
            this.importGirlButton.Location = new System.Drawing.Point(11, 123);
            this.importGirlButton.Name = "importGirlButton";
            this.importGirlButton.Size = new System.Drawing.Size(102, 36);
            this.importGirlButton.TabIndex = 10;
            this.importGirlButton.Text = "Import: Girl Names";
            this.importGirlButton.UseVisualStyleBackColor = true;
            this.importGirlButton.Click += new System.EventHandler(this.importGirlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkNames);
            this.Controls.Add(this.boyResults);
            this.Controls.Add(this.girlResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.GInput);
            this.Controls.Add(this.importBoyButton);
            this.Controls.Add(this.importGirlButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkNames;
        private System.Windows.Forms.TextBox boyResults;
        private System.Windows.Forms.TextBox girlResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BInput;
        private System.Windows.Forms.TextBox GInput;
        private System.Windows.Forms.Button importBoyButton;
        private System.Windows.Forms.Button importGirlButton;
    }
}

