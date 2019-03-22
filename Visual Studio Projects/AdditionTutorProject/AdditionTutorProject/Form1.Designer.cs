namespace AdditionTutorProject
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
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.ansInput = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateProblems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(431, 104);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(249, 147);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAnswerButton.Location = new System.Drawing.Point(267, 104);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(148, 147);
            this.checkAnswerButton.TabIndex = 15;
            this.checkAnswerButton.Text = "Check Answer";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            this.checkAnswerButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "+";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(142, 36);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(77, 39);
            this.lblNum1.TabIndex = 13;
            this.lblNum1.Text = "???";
            // 
            // ansInput
            // 
            this.ansInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansInput.Location = new System.Drawing.Point(445, 31);
            this.ansInput.Name = "ansInput";
            this.ansInput.Size = new System.Drawing.Size(91, 44);
            this.ansInput.TabIndex = 12;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(295, 36);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(77, 39);
            this.lblNum2.TabIndex = 11;
            this.lblNum2.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // generateProblems
            // 
            this.generateProblems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateProblems.Location = new System.Drawing.Point(26, 104);
            this.generateProblems.Name = "generateProblems";
            this.generateProblems.Size = new System.Drawing.Size(224, 147);
            this.generateProblems.TabIndex = 17;
            this.generateProblems.Text = "Generate Problems";
            this.generateProblems.UseVisualStyleBackColor = true;
            this.generateProblems.Click += new System.EventHandler(this.generateProblems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 311);
            this.Controls.Add(this.generateProblems);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.ansInput);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox ansInput;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateProblems;
    }
}

