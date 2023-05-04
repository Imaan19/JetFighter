using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace JetFighter
{
    public partial class Form1 : Form
    {
        public const int NumberOfCoins = 4;
        public const int NumberOfBuildings = 3;

        public PictureBox[] Coins = new PictureBox[NumberOfCoins];
        public PictureBox[] Buildings = new PictureBox[NumberOfBuildings];
        public Form1()
        {
            InitializeComponent();
            gameover.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coins[0] = coin1;
            Coins[1] = coin2;
            Coins[2] = coin3;
            Coins[3] = coin4;

            Buildings[0] = Building1;
            Buildings[1] = Building2;
            Buildings[2] = Building3;
        }

        private void Jet_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        /// <summary>
        /// If the top of the building is greater than 500 then
        /// the building will be relocated to a random x position
        /// at the top of the form.
        /// </summary>
        /// <param name="speed"></param>
        void Building(int speed)
        {
            foreach (var building in Buildings)
            {
                if (building.Top >= Height)
                {
                    x = r.Next(0, 200);

                    building.Location = new Point(x, 0);
                }
                else
                {
                    building.Top += speed;
                }
            }
        }



        void MoveCoin(int speed)
        {
            foreach (var coin in Coins)
            {
                if (coin.Top >= Height)
                {
                    x = r.Next(0, 200);

                    coin.Location = new Point(x, 0);
                }
                else
                {
                    coin.Top += speed;
                }
            }
        }
        void over()
        {
            if (Jet.Bounds.IntersectsWith(Building1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            if (Jet.Bounds.IntersectsWith(Building2.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            if (Jet.Bounds.IntersectsWith(Building3.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
        }


        void coinscollection()
        {
            if (Jet.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                coin1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }
            if (Jet.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                coin1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            if (Jet.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                coin1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            if (Jet.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                coin1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Jet.Left > 0)
                    Jet.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Jet.Right < 380)
                    Jet.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
            coinscollection();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Building(gamespeed);
            over();
            MoveCoin(gamespeed);
            coinscollection();
        }
    }
}