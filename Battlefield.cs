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
        Spaceship spaceship;
        Bullet bullet;

        public Battlefield()
        {
            InitializeComponent();
            InitializeBattlefield();
        }

        private void InitializeBattlefield()
        {
            spaceship = new Spaceship();
            spaceship.Left = spaceship.Left = ClientRectangle.Width - (ClientRectangle.Width / 2 + spaceship.Width / 2);
            spaceship.Top = 300;
            this.Controls.Add(spaceship);
        }

        private void FireBullet()
        {
            bullet = new Bullet();
            bullet.Top = spaceship.Top;
            bullet.Left = spaceship.Left + (spaceship.Width / 2 - bullet.Width / 2;
        }
    }
}
