using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; 

namespace Space_battle
{
    class Spaceship : PictureBox
    {
        public Spaceship()
        {
            InitializeSpaceship();  
        }

        private void InitializeSpaceship()
        {
            this.BackColor = Color.Salmon;
            this.Height = 40;
            this.Width = 100;
        }
    }
}
