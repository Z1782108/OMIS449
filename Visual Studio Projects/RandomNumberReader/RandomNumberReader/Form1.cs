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

namespace RandomNumberReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            //variables for the maths
            int number = 0;
            int sum = 0;
            int cnt = 0;

            //instaniates a new object of type OpenFileDialog
            OpenFileDialog openFile = new OpenFileDialog();
            //shows that there dialog
            openFile.ShowDialog();
            //creates a string and stores the openFile into it
            string filePath = openFile.FileName;

            //creates a StreamReader object
            StreamReader inputFile = new StreamReader(filePath);

            //makes sure the box is cleared from previous results
            lstBox.Items.Clear();

            //loop that writes lines from the file, sums them, and then counts them
            while (!inputFile.EndOfStream)
            {
                number = int.Parse(inputFile.ReadLine());
                lstBox.Items.Add(number);
                sum += number;
                cnt += 1;
            }

            //clears input boxes from previous run
            totalBox.Text = String.Empty;
            totalNumBox.Text = String.Empty;

            //outputs numbers to boxes from current run
            totalBox.Text = sum.ToString();
            totalNumBox.Text = cnt.ToString();
        }

        //exits
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        }
    }
}