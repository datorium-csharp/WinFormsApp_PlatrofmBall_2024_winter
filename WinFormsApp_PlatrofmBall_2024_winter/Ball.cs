using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PlatrofmBall_2024_winter
{
    internal class Ball : PictureBox
    {
        public int horVelocity = 2;
        public int verVelocity = 2;

        public Ball()
        {
            this.Width = 10;
            this.Height = 10;
            this.BackColor = Color.White;
        }
    }
}
