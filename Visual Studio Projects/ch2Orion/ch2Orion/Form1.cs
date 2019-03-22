using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch2Orion
{
    public partial class orionConstellation : Form
    {
        public orionConstellation()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showStarNames_Click(object sender, EventArgs e)
        {
            meissaLabel.Visible = true;
            betelgeuseLabel.Visible = true;
            alnitakLabel.Visible = true;
            alnilamLabel.Visible = true;
            mintakaLabel.Visible = true;
            saiphLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void betelgeuseLabel_Click(object sender, EventArgs e)
        {

        }

        private void hideStarNames_Click(object sender, EventArgs e)
        {
            meissaLabel.Visible = false;
            betelgeuseLabel.Visible = false;
            alnitakLabel.Visible = false;
            alnilamLabel.Visible = false;
            mintakaLabel.Visible = false;
            saiphLabel.Visible = false;
            rigelLabel.Visible = false;
        }
    }
}
