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

namespace RandomNumberWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(InputBox.Text, out int amt))
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter outputFile = File.CreateText(saveFileDialog.FileName + ".txt");

                        Random rnd = new Random();

                        int randNum = 0;

                        for (int i = 0; i < amt; i++)
                        {
                            randNum = rnd.Next(100) + 1;

                            outputFile.WriteLine(randNum.ToString());
                        }

                        outputFile.Close();

                        saveFileDialog.FileName = String.Empty;

                        MessageBox.Show("You done created that there file.");
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}