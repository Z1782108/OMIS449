using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSeriesProject
{
    public partial class WorldSeriesChampions : Form
    {
        public WorldSeriesChampions()
        {
            InitializeComponent();
        }

        List<string> WSWins = new List<string>();

        private List<string> ReadFile(List<string> s)
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Filter = "TXT|*.txt"
            };

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                s = System.IO.File.ReadAllLines(OpenFile.FileName).ToList();
            }

            else
                MessageBox.Show("Please try again");

            MessageBox.Show("File imported correctly.");

            return s;
        }

        private void Winners(string T, List<string> W)
        {
            int Wins = 0;

            foreach (string Line in W)
            {
                if (Line == T)
                    Wins++;
            }

            if (TeamListBox.SelectedIndex != -1)
            {
                NameLabel.Text = T.ToString();
            }

            WinsLabel.Text = Wins.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Teams = new List<string>();

            Teams = ReadFile(Teams);

            foreach (string s in Teams)
            {
                TeamListBox.Items.Add(s);
            }
        }


        private void loadSeries_Click(object sender, EventArgs e)
        {
            WSWins = ReadFile(WSWins);
        
        }

        private void calculateWins_Click(object sender, EventArgs e)
        {
            string Team = TeamListBox.SelectedItem.ToString();

            Winners(Team, WSWins);
        }

        private void exitButtpn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}