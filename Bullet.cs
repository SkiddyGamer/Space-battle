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
        
        public Bullet()
        {
            InitializeBullet();
        }

        private void InitializeTimerBulletMove()
        {
            timerBulletMove = new Timer();
            timerBulletMove.Interval = 20;
            timerBulletMove.Start();
            timerBulletMove.Tick += new EventHandler(TimerBulletMove_Tick);
        }

        private void TimerBulletMove_Tick(object sender, EventArgs e)
        {

        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Blue;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
