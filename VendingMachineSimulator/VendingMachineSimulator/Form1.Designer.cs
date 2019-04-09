namespace VendingMachineSimulator
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colaLabel = new System.Windows.Forms.Label();
            this.lemonLimeLabel = new System.Windows.Forms.Label();
            this.creamLabel = new System.Windows.Forms.Label();
            this.rootBeerLabel = new System.Windows.Forms.Label();
            this.grapeLabel = new System.Windows.Forms.Label();
            this.colaPrice = new System.Windows.Forms.Label();
            this.lemonLimePrice = new System.Windows.Forms.Label();
            this.creamPrice = new System.Windows.Forms.Label();
            this.rootBeerPrice = new System.Windows.Forms.Label();
            this.grapePrice = new System.Windows.Forms.Label();
            this.salesTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(75, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VendingMachineSimulator.Properties.Resources.GrapeSoda;
            this.pictureBox4.Location = new System.Drawing.Point(142, 146);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendingMachineSimulator.Properties.Resources.RootBeer;
            this.pictureBox2.Location = new System.Drawing.Point(140, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VendingMachineSimulator.Properties.Resources.CreamSoda;
            this.pictureBox5.Location = new System.Drawing.Point(21, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VendingMachineSimulator.Properties.Resources.LemonLime;
            this.pictureBox3.Location = new System.Drawing.Point(22, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendingMachineSimulator.Properties.Resources.Cola;
            this.pictureBox1.Location = new System.Drawing.Point(20, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colaLabel
            // 
            this.colaLabel.AutoSize = true;
            this.colaLabel.Location = new System.Drawing.Point(30, 29);
            this.colaLabel.Name = "colaLabel";
            this.colaLabel.Size = new System.Drawing.Size(28, 13);
            this.colaLabel.TabIndex = 6;
            this.colaLabel.Text = "Cola";
            // 
            // lemonLimeLabel
            // 
            this.lemonLimeLabel.AutoSize = true;
            this.lemonLimeLabel.Location = new System.Drawing.Point(20, 130);
            this.lemonLimeLabel.Name = "lemonLimeLabel";
            this.lemonLimeLabel.Size = new System.Drawing.Size(64, 13);
            this.lemonLimeLabel.TabIndex = 7;
            this.lemonLimeLabel.Text = "Lemon Lime";
            // 
            // creamLabel
            // 
            this.creamLabel.AutoSize = true;
            this.creamLabel.Location = new System.Drawing.Point(18, 226);
            this.creamLabel.Name = "creamLabel";
            this.creamLabel.Size = new System.Drawing.Size(65, 13);
            this.creamLabel.TabIndex = 8;
            this.creamLabel.Text = "Cream Soda";
            // 
            // rootBeerLabel
            // 
            this.rootBeerLabel.AutoSize = true;
            this.rootBeerLabel.Location = new System.Drawing.Point(146, 29);
            this.rootBeerLabel.Name = "rootBeerLabel";
            this.rootBeerLabel.Size = new System.Drawing.Size(55, 13);
            this.rootBeerLabel.TabIndex = 9;
            this.rootBeerLabel.Text = "Root Beer";
            // 
            // grapeLabel
            // 
            this.grapeLabel.AutoSize = true;
            this.grapeLabel.Location = new System.Drawing.Point(140, 130);
            this.grapeLabel.Name = "grapeLabel";
            this.grapeLabel.Size = new System.Drawing.Size(64, 13);
            this.grapeLabel.TabIndex = 10;
            this.grapeLabel.Text = "Grape Soda";
            // 
            // colaPrice
            // 
            this.colaPrice.AutoSize = true;
            this.colaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPrice.Location = new System.Drawing.Point(30, 16);
            this.colaPrice.Name = "colaPrice";
            this.colaPrice.Size = new System.Drawing.Size(39, 13);
            this.colaPrice.TabIndex = 11;
            this.colaPrice.Text = "$1.00";
            // 
            // lemonLimePrice
            // 
            this.lemonLimePrice.AutoSize = true;
            this.lemonLimePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonLimePrice.Location = new System.Drawing.Point(30, 117);
            this.lemonLimePrice.Name = "lemonLimePrice";
            this.lemonLimePrice.Size = new System.Drawing.Size(39, 13);
            this.lemonLimePrice.TabIndex = 12;
            this.lemonLimePrice.Text = "$1.00";
            // 
            // creamPrice
            // 
            this.creamPrice.AutoSize = true;
            this.creamPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamPrice.Location = new System.Drawing.Point(30, 213);
            this.creamPrice.Name = "creamPrice";
            this.creamPrice.Size = new System.Drawing.Size(39, 13);
            this.creamPrice.TabIndex = 13;
            this.creamPrice.Text = "$1.50";
            // 
            // rootBeerPrice
            // 
            this.rootBeerPrice.AutoSize = true;
            this.rootBeerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerPrice.Location = new System.Drawing.Point(155, 16);
            this.rootBeerPrice.Name = "rootBeerPrice";
            this.rootBeerPrice.Size = new System.Drawing.Size(39, 13);
            this.rootBeerPrice.TabIndex = 14;
            this.rootBeerPrice.Text = "$1.00";
            // 
            // grapePrice
            // 
            this.grapePrice.AutoSize = true;
            this.grapePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapePrice.Location = new System.Drawing.Point(155, 117);
            this.grapePrice.Name = "grapePrice";
            this.grapePrice.Size = new System.Drawing.Size(39, 13);
            this.grapePrice.TabIndex = 15;
            this.grapePrice.Text = "$1.50";
            // 
            // salesTotalLabel
            // 
            this.salesTotalLabel.AutoSize = true;
            this.salesTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotalLabel.Location = new System.Drawing.Point(183, 259);
            this.salesTotalLabel.Name = "salesTotalLabel";
            this.salesTotalLabel.Size = new System.Drawing.Size(28, 13);
            this.salesTotalLabel.TabIndex = 16;
            this.salesTotalLabel.Text = "$$$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Sales:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesTotalLabel);
            this.Controls.Add(this.grapePrice);
            this.Controls.Add(this.rootBeerPrice);
            this.Controls.Add(this.creamPrice);
            this.Controls.Add(this.lemonLimePrice);
            this.Controls.Add(this.colaPrice);
            this.Controls.Add(this.grapeLabel);
            this.Controls.Add(this.rootBeerLabel);
            this.Controls.Add(this.creamLabel);
            this.Controls.Add(this.lemonLimeLabel);
            this.Controls.Add(this.colaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label colaLabel;
        private System.Windows.Forms.Label lemonLimeLabel;
        private System.Windows.Forms.Label creamLabel;
        private System.Windows.Forms.Label rootBeerLabel;
        private System.Windows.Forms.Label grapeLabel;
        private System.Windows.Forms.Label colaPrice;
        private System.Windows.Forms.Label lemonLimePrice;
        private System.Windows.Forms.Label creamPrice;
        private System.Windows.Forms.Label rootBeerPrice;
        private System.Windows.Forms.Label grapePrice;
        private System.Windows.Forms.Label salesTotalLabel;
        private System.Windows.Forms.Label label1;
    }
}

