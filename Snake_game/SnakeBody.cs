using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    class SnakeBody : Button
    {
        public static int BodySize = 25;
        public SnakeBody()
        {
            Width = BodySize;
            Height = BodySize;
            BackColor = Color.LightGreen;
            Enabled= false;


        }
    }
}
