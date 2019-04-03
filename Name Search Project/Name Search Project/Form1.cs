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

namespace Name_Search_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> GirlNames = new List<string>();
        List<string> BoyNames = new List<string>();

        private List<string> LoadFiles(List<string> s)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "TXT|*.txt";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                s = File.ReadAllLines(OpenFile.FileName).ToList();
            }

            return s;
        }

        private void CheckNames_Click(object sender, EventArgs e)
        {
            foreach (string Name in GirlNames)
            {
                try
                {
                    if (GirlNames.Contains(GInput.Text))
                    {
                        girlResults.Text = GInput.Text + " is a popular name";
                    }

                    else if (GInput.Text == String.Empty)
                        girlResults.Text = String.Empty;

                    else
                        girlResults.Text = GInput.Text + " is not a popular name";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("There was a error: " + ex);
                }
            }

            foreach (string Name in BoyNames)
            {
                try
                {
                    if (BoyNames.Contains(BInput.Text))
                    {
                        boyResults.Text = BInput.Text + " is a popular name";
                    }

                    else if (BInput.Text == String.Empty)
                        boyResults.Text = String.Empty;

                    else
                        boyResults.Text = BInput.Text + " is not a popular name";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please try again" + ex);
                }
            }
        }

        private void importGirlButton_Click(object sender, EventArgs e)
        {
            GirlNames = LoadFiles(GirlNames);
        
        }

        private void importBoyButton_Click(object sender, EventArgs e)
        {
            BoyNames = LoadFiles(BoyNames);
        }
    }
}
