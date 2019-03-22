namespace RandomNumberReader
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
            this.totalNumBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(41, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 39);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // totalNumBox
            // 
            this.totalNumBox.Enabled = false;
            this.totalNumBox.Location = new System.Drawing.Point(100, 245);
            this.totalNumBox.Name = "totalNumBox";
            this.totalNumBox.Size = new System.Drawing.Size(48, 20);
            this.totalNumBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Numbers:";
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(82, 268);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(66, 20);
            this.totalBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(18, 30);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(154, 186);
            this.lstBox.TabIndex = 10;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(41, 315);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(107, 39);
            this.ReadButton.TabIndex = 9;
            this.ReadButton.Text = "Read Numbers";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 421);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalNumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.ReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox totalNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button ReadButton;
    }
}

