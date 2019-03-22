using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        //Variables to handle logic within switch statements and math for output boxes
        decimal regFee = 0;
        decimal days = 0;
        //logFee is per day
        decimal logFee = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Calculate Button code
        private void calcCost_Click(object sender, EventArgs e)
        {
            //Index option based on option chosen by user in listbox, with error msg for no selection
            if (workshopList.SelectedIndex != -1)
            {
                switch (workshopList.SelectedIndex)
                {
                    case 0:
                        regFee = 1000;
                        days = 3;
                        break;

                    case 1:
                        regFee = 800;
                        days = 3;
                        break;

                    case 2:
                        regFee = 1500;
                        days = 3;
                        break;

                    case 3:
                        regFee = 1300;
                        days = 5;
                        break;

                    case 4:
                        regFee = 500;
                        days = 1;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Workshop selected ya dummy!");
            }

            //Index option based on option chosen by user in listbox, with error msg for no selection
            if (locationList.SelectedIndex != -1)
            {
                switch (locationList.SelectedIndex)
                {
                    case 0:
                        logFee = 150;
                        break;

                    case 1:
                        logFee = 225;
                        break;

                    case 2:
                        logFee = 175;
                        break;

                    case 3:
                        logFee = 300;
                        break;

                    case 4:
                        logFee = 175;
                        break;

                    case 5:
                        logFee = 150;
                        break;
                }
            }

            //Default error box
            else
            {
                MessageBox.Show("No Location selected ya dummy!");
            }

            //Outputs the Registration Fee and the Lodging(perday) fee
            registrationTextBox.Text = regFee.ToString("c");
            lodgingTextBox.Text = (logFee * days).ToString("c");

            //Calculates and displays the Total Cost
            var total = (logFee * days) + regFee;
            totalTextBox.Text = total.ToString("c");
        }

        //Exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears selection and output boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            workshopList.SelectedIndex = -1;
            locationList.SelectedIndex = -1;

            registrationTextBox.Text = String.Empty;
            lodgingTextBox.Text = String.Empty;
            totalTextBox.Text = String.Empty;
        }
    }
}