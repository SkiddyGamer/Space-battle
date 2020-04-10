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
        public Bullet()
        {
            InitializeBullet();
        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Coral;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
