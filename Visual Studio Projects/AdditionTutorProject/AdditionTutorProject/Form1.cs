using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionTutorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //closes the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(lblNum1.Text);
                int num2 = int.Parse(lblNum2.Text);
                if (int.TryParse(ansInput.Text, out int ans))
                {
                    
                    if (ans == num1 + num2)
                    {
                        MessageBox.Show("Congrats! This is correct.");
                    }
                    
                    else
                        MessageBox.Show("Please try again.");
                }
                else
                    MessageBox.Show("Please enter a valid number (no decimals or negatives)");
            }

            catch
            {
                MessageBox.Show("Click Generate first!");
            }
        }

        private void generateProblems_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            Random rnd = new Random();
            number1 = rnd.Next(100, 500);
            number2 = rnd.Next(100, 500);
            lblNum1.Text = number1.ToString();
            lblNum2.Text = number2.ToString();
            ansInput.Text = String.Empty;

        }
    }
}
