namespace ch2Orion
{
    partial class orionConstellation
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
            this.showStarNames = new System.Windows.Forms.Button();
            this.hideStarNames = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.orionPictureBox = new System.Windows.Forms.PictureBox();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showStarNames
            // 
            this.showStarNames.AutoSize = true;
            this.showStarNames.Location = new System.Drawing.Point(32, 459);
            this.showStarNames.Name = "showStarNames";
            this.showStarNames.Size = new System.Drawing.Size(119, 45);
            this.showStarNames.TabIndex = 0;
            this.showStarNames.Text = "Show Star Names";
            this.showStarNames.UseVisualStyleBackColor = true;
            this.showStarNames.Click += new System.EventHandler(this.showStarNames_Click);
            // 
            // hideStarNames
            // 
            this.hideStarNames.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.hideStarNames.Location = new System.Drawing.Point(157, 459);
            this.hideStarNames.Name = "hideStarNames";
            this.hideStarNames.Size = new System.Drawing.Size(119, 45);
            this.hideStarNames.TabIndex = 1;
            this.hideStarNames.Text = "Hide Star Names";
            this.hideStarNames.UseVisualStyleBackColor = true;
            this.hideStarNames.Click += new System.EventHandler(this.hideStarNames_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(282, 459);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(118, 45);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // orionPictureBox
            // 
            this.orionPictureBox.Image = global::ch2Orion.Properties.Resources.Orion;
            this.orionPictureBox.Location = new System.Drawing.Point(32, 23);
            this.orionPictureBox.Name = "orionPictureBox";
            this.orionPictureBox.Size = new System.Drawing.Size(368, 414);
            this.orionPictureBox.TabIndex = 3;
            this.orionPictureBox.TabStop = false;
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Location = new System.Drawing.Point(116, 252);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(39, 13);
            this.alnitakLabel.TabIndex = 4;
            this.alnitakLabel.Text = "Alnitak";
            this.alnitakLabel.Visible = false;
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Location = new System.Drawing.Point(74, 51);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(60, 13);
            this.betelgeuseLabel.TabIndex = 5;
            this.betelgeuseLabel.Text = "Betelgeuse";
            this.betelgeuseLabel.Visible = false;
            this.betelgeuseLabel.Click += new System.EventHandler(this.betelgeuseLabel_Click);
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Location = new System.Drawing.Point(74, 400);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(34, 13);
            this.saiphLabel.TabIndex = 6;
            this.saiphLabel.Text = "Saiph";
            this.saiphLabel.Visible = false;
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Location = new System.Drawing.Point(320, 101);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(40, 13);
            this.meissaLabel.TabIndex = 7;
            this.meissaLabel.Text = "Meissa";
            this.meissaLabel.Visible = false;
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Location = new System.Drawing.Point(320, 370);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(31, 13);
            this.rigelLabel.TabIndex = 8;
            this.rigelLabel.Text = "Rigel";
            this.rigelLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Location = new System.Drawing.Point(270, 219);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(45, 13);
            this.mintakaLabel.TabIndex = 9;
            this.mintakaLabel.Text = "Mintaka";
            this.mintakaLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Location = new System.Drawing.Point(184, 219);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(40, 13);
            this.alnilamLabel.TabIndex = 10;
            this.alnilamLabel.Text = "Alnilam";
            this.alnilamLabel.UseMnemonic = false;
            this.alnilamLabel.Visible = false;
            // 
            // orionConstellation
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.orionPictureBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.hideStarNames);
            this.Controls.Add(this.showStarNames);
            this.DoubleBuffered = true;
            this.Name = "orionConstellation";
            this.Text = "Orion Constllation";
            ((System.ComponentModel.ISupportInitialize)(this.orionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showStarNames;
        private System.Windows.Forms.Button hideStarNames;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox orionPictureBox;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label rigelLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label alnilamLabel;
    }
}

