using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int min = 0;
            int hours = 0;
            int days = 0;

            if (int.TryParse(secondsTextBox.Text, out int sec))
            {
                min = sec / 60;
                hours = sec / 3600;
                days = sec / 86400;

                minutesTextBox.Text = min.ToString();
                hoursTextBox.Text = hours.ToString();
                daysTextBox.Text = days.ToString();
            }

            else
                MessageBox.Show("Enter a valid Number");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void secInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
