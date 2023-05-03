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
        public Form1()
        {
            InitializeComponent();
            gameover.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Jet_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Building(gamespeed);
            over();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void Building(int speed)
        {
            if (Building1.Top >= 500)
            {
                x = r.Next(0, 200);

                Building1.Location = new Point(x, 0);
            }
            else
            {
                Building1.Top += speed;
            }
            if (Building2.Top >= 500)
            {
                x = r.Next(0, 400);

                Building2.Location = new Point(x, 0);
            }
            else
            {
                Building2.Top += speed;
            }
            if (Building3.Top >= 500)
            {
                x = r.Next(200, 350);

                Building3.Location = new Point(x, 0);
            }
            else
            {
                Building3.Top += speed;
            }
        }



        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
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
        private void Jet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Jet.Left > 0)
                {
                    Jet.Left += -gamespeed;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Jet.Right > 380)
                {
                    Jet.Left += gamespeed;
                }
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
        }
    }
}