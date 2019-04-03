namespace WorldSeriesProject
{
    partial class WorldSeriesChampions
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
            this.calculateWinsButton = new System.Windows.Forms.Button();
            this.WinsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadWinsButton = new System.Windows.Forms.Button();
            this.TeamListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtpn_Click);
            // 
            // calculateWinsButton
            // 
            this.calculateWinsButton.Location = new System.Drawing.Point(12, 164);
            this.calculateWinsButton.Name = "calculateWinsButton";
            this.calculateWinsButton.Size = new System.Drawing.Size(75, 39);
            this.calculateWinsButton.TabIndex = 15;
            this.calculateWinsButton.Text = "Calculate!";
            this.calculateWinsButton.UseVisualStyleBackColor = true;
            this.calculateWinsButton.Click += new System.EventHandler(this.calculateWins_Click);
            // 
            // WinsLabel
            // 
            this.WinsLabel.AutoSize = true;
            this.WinsLabel.Location = new System.Drawing.Point(555, 190);
            this.WinsLabel.Name = "WinsLabel";
            this.WinsLabel.Size = new System.Drawing.Size(0, 13);
            this.WinsLabel.TabIndex = 14;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(149, 111);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of WIns: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team Name: ";
            // 
            // loadWinsButton
            // 
            this.loadWinsButton.Location = new System.Drawing.Point(12, 85);
            this.loadWinsButton.Name = "loadWinsButton";
            this.loadWinsButton.Size = new System.Drawing.Size(107, 39);
            this.loadWinsButton.TabIndex = 10;
            this.loadWinsButton.Text = "Load Series Wins";
            this.loadWinsButton.UseVisualStyleBackColor = true;
            this.loadWinsButton.Click += new System.EventHandler(this.loadSeries_Click);
            // 
            // TeamListBox
            // 
            this.TeamListBox.FormattingEnabled = true;
            this.TeamListBox.Location = new System.Drawing.Point(125, 12);
            this.TeamListBox.Name = "TeamListBox";
            this.TeamListBox.Size = new System.Drawing.Size(210, 264);
            this.TeamListBox.TabIndex = 9;
            this.TeamListBox.SelectedIndexChanged += new System.EventHandler(this.TeamListBox_SelectedIndexChanged);
            // 
            // WorldSeriesChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateWinsButton);
            this.Controls.Add(this.WinsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadWinsButton);
            this.Controls.Add(this.TeamListBox);
            this.Name = "WorldSeriesChampions";
            this.Text = "WorldSeriesChampions";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateWinsButton;
        private System.Windows.Forms.Label WinsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadWinsButton;
        private System.Windows.Forms.ListBox TeamListBox;
    }
}

