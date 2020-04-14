﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_battle
{
    public partial class Battlefield : Form
    {
        private Spaceship spaceship = null;
        private Bullet bullet = null;
        private Timer mainTimer = null;
        private bool moveLeft = false;
        private bool moveRight = false;
        private bool bulletFired = false;

        public Battlefield()
        {
            InitializeComponent();
            InitializeBattlefield();
            InitializeMainTimer();
        }

        private void InitializeBattlefield()
        {
            spaceship = new Spaceship();
            spaceship.Left = spaceship.Left = ClientRectangle.Width - (ClientRectangle.Width / 2 + spaceship.Width / 2);
            spaceship.Top = 300;
            this.Controls.Add(spaceship);
        }

        private void InitializeMainTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Interval = 20;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft)
            {
                spaceship.Left -= 10;
            }
            if (moveRight)
            {
                spaceship.Left += 10;
            }
        }

        private void FireBullet()
        {
            bullet = new Bullet();
            bullet.Top = spaceship.Top;
            bullet.Left = spaceship.Left + (spaceship.Width / 2 - bullet.Width / 2);
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void Battlefield_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !bulletFired)
            {
                FireBullet();
                bulletFired = true;
            }
            else if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            else if (e.KeyCode == Keys.E)
            {
                if (spaceship.EngineState == "off")
                {
                    spaceship.EngineOn();
                }
                else if (spaceship.EngineState == "on")
                {
                    spaceship.EngineOff();
                }
            }


        }

        private void Battlefield_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                bulletFired = false;
            }
            else if(e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            else if(e.KeyCode == Keys.D)
            {
                moveRight = false; 
            }
        }
    }
}
