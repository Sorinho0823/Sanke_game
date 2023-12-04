using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_game
{
    public partial class Form1 : Form
    {

        int headX = 100;
        int headY = 100;
        int directionX = 1;
        int directionY = 0;
        int lenght = 5;
        //int steps?


        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headX += directionX * SnakeBody.BodySize;
            headY += directionY * SnakeBody.BodySize;

            foreach (SnakeBody item in PanelMap.Controls)
            {
                if (item.Left == headX && item.Top == headY)
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over :(");
                }

            }
            SnakeBody newHead = new SnakeBody();
            newHead.Left = headX;
            newHead.Top = headY;


            PanelMap.Controls.Add(newHead);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // 
        {
            if (e.KeyCode == Keys.W)
                if (directionX == 0 && directionY == 1) { }
                else
                {
                    { directionX = 0; directionY = -1; } // up
                }
            if (e.KeyCode == Keys.S)
                if (directionX == 0 && directionY == -1) { }


                else { directionX = 0; directionY = 1; } // down


            if (e.KeyCode == Keys.A)
                if (directionX == 1 && directionY == 0) { }
                else { directionX = -1; directionY = 0; } // left


            if (e.KeyCode == Keys.D)
                if (directionX == -1 && directionY == 0) { } // left)
                else { directionX = 1; directionY = 0; } // right
        }
    }
}






