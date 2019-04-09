using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSimulator
{
    struct Drinks
    {
        public string Name;
        public double Price;
        public int Amount;
        public double RunningTotal;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SodaTotal()
        {
            double t;
            t = Soda[Cola].RunningTotal + Soda[RootBeer].RunningTotal + Soda[LemonLime].RunningTotal +
                Soda[Grape].RunningTotal + Soda[CreamSoda].RunningTotal;
            salesTotalLabel.Text = t.ToString("c");
        }

        private double PurchaseSodaFunction(double a, double p)
        {
            a = (20 - a) * p;

            return a;
        }

        private int PurchaseSodaFunction(int a)
        {
            if (a <= 0)
            {
                MessageBox.Show("Try another selection, that one has been depleted!");
                return a;
            }

            else
            {
                a -= 1;
                return a;
            }
        }

        Drinks[] Soda = new Drinks[5];
        int Cola = 0;
        int RootBeer = 1;
        int LemonLime = 2;
        int Grape = 3;
        int CreamSoda = 4;
        double Total = 0.00;

        private void Form1_Load(object sender, EventArgs e)
        {
            Soda[Cola].Name = "Cola";
            Soda[Cola].Price = 1.00;
            Soda[Cola].Amount = 20;
            Soda[Cola].RunningTotal = 0.00;
            Soda[RootBeer].Name = "Root Beer";
            Soda[RootBeer].Price = 1.00;
            Soda[RootBeer].Amount = 20;
            Soda[RootBeer].RunningTotal = 0.00;
            Soda[LemonLime].Name = "Lemon Lime Soda";
            Soda[LemonLime].Price = 1.00;
            Soda[LemonLime].Amount = 20;
            Soda[LemonLime].RunningTotal = 0.00;
            Soda[Grape].Name = "Grape Soda";
            Soda[Grape].Price = 1.50;
            Soda[Grape].Amount = 20;
            Soda[Grape].RunningTotal = 0.00;
            Soda[CreamSoda].Name = "Cream Soda";
            Soda[CreamSoda].Price = 1.50;
            Soda[CreamSoda].Amount = 20;
            Soda[CreamSoda].RunningTotal = 0.00;

            colaLabel.Text = Soda[Cola].Amount.ToString();
            colaPrice.Text = Soda[Cola].Price.ToString("c");

            rootBeerLabel.Text = Soda[RootBeer].Amount.ToString();
            rootBeerPrice.Text = Soda[RootBeer].Price.ToString("c");

            lemonLimeLabel.Text = Soda[LemonLime].Amount.ToString();
            lemonLimePrice.Text = Soda[LemonLime].Price.ToString("c");

            grapeLabel.Text = Soda[Grape].Amount.ToString();
            grapePrice.Text = Soda[Grape].Price.ToString("c");

            creamLabel.Text = Soda[CreamSoda].Amount.ToString();
            creamPrice.Text = Soda[CreamSoda].Price.ToString("c");

            salesTotalLabel.Text = Total.ToString("c");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Soda[Cola].Amount = PurchaseSodaFunction(Soda[Cola].Amount);
            colaLabel.Text = Soda[Cola].Amount.ToString();

            Soda[Cola].RunningTotal = PurchaseSodaFunction(Soda[Cola].Amount, Soda[Cola].Price);

            SodaTotal();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Soda[RootBeer].Amount = PurchaseSodaFunction(Soda[RootBeer].Amount);
            rootBeerLabel.Text = Soda[RootBeer].Amount.ToString();

            Soda[RootBeer].RunningTotal = PurchaseSodaFunction(Soda[RootBeer].Amount, Soda[RootBeer].Price);

            SodaTotal();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Soda[LemonLime].Amount = PurchaseSodaFunction(Soda[LemonLime].Amount);
            lemonLimeLabel.Text = Soda[LemonLime].Amount.ToString();

            Soda[LemonLime].RunningTotal = PurchaseSodaFunction(Soda[LemonLime].Amount, Soda[LemonLime].Price);

            SodaTotal();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Soda[Grape].Amount = PurchaseSodaFunction(Soda[Grape].Amount);
            grapeLabel.Text = Soda[Grape].Amount.ToString();

            Soda[Grape].RunningTotal = PurchaseSodaFunction(Soda[Grape].Amount, Soda[Grape].Price);

            SodaTotal();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Soda[CreamSoda].Amount = PurchaseSodaFunction(Soda[CreamSoda].Amount);
            creamLabel.Text = Soda[CreamSoda].Amount.ToString();

            Soda[CreamSoda].RunningTotal = PurchaseSodaFunction(Soda[CreamSoda].Amount, Soda[CreamSoda].Price);

            SodaTotal();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}