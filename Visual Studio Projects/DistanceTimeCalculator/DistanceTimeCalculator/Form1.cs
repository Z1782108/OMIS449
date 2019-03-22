using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int hours = 0;
            int distance = 0;

            hoursTotalListBox.Items.Clear();

            if (int.TryParse(TravelSpeedTextBox.Text, out speed) && int.TryParse(hoursTraveledTextBox.Text, out hours))
            {
                for (int i = 1; i <= hours; i++)
                {
                    distance = i * speed;
                    hoursTotalListBox.Items.Add("After hour " + i + " the distance is " + distance + " miles.");
                }
            }

            else
                MessageBox.Show("Please Enter Valid Data in all Fields");
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}