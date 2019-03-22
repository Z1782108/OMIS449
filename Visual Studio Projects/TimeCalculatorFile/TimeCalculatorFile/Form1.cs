using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeCalculatorFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int hours = 0;
            int distance = 0;

            if (int.TryParse(speedTraveledTextBox.Text, out speed) && int.TryParse(hoursTravele.Text, out hours))
            {

                try
                {
                    
                    StreamWriter outputFile;
                    outputFile = File.CreateText(@"DistanceToFile.txt");
                    for (int i = 1; i <= hours; i++)
                    {
                        distance = i * speed;
                        outputFile.WriteLine("After hour " + i + " the distance is " + distance + " miles.");
                    }

                   
                    outputFile.Close();
                    MessageBox.Show("File has been created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Please try again." + ex.Message);
                }

            }

            else
                MessageBox.Show("Please enter valid data");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
