using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Space_battle
{
    class Bullet : PictureBox
    {
        private Timer timerBulletMove;
        int verVelocity = 0;
        int horVelocity = 0;
        int bulletstep = 5;
        
        public Bullet()
        {
            InitializeBullet();
            InitializeTimerBulletMove(); 
        }

        private void InitializeTimerBulletMove()
        {
            timerBulletMove = new Timer();
            timerBulletMove.Interval = 20;
            timerBulletMove.Tick += new EventHandler(TimerBulletMove_Tick);
            verVelocity = -bulletstep;
            timerBulletMove.Start();
        }

        private void TimerBulletMove_Tick(object sender, EventArgs e)
        {
            this.Top += verVelocity;
            this.Left += horVelocity;
            if(this.Top < 0)
            {
                this.Dispose();
            }
        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Blue;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
